using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Web.Script.Serialization;
using System.Diagnostics;


namespace Text_Summarizer
{
    public partial class Form1 : Form
    {
        #region Globals
        string core_path = "core";

        string mainpy_name = "__main__.py";
        string inputJson_file_name = "input.json";
        string outputJson_file_name = "output.json";
        string lock_file_name = "core.lock";

        string mainpy_path;
        string inputJson_file;
        string outputJson_file;
        string lock_file;

        string summarized_text = "";
        #endregion

        enum JAction
        {
            summarize
        }

        class JsonParamSummTextTech
        {
            public string technique { get; set; }

            public int word_count { get; set; }

            public string text { get; set; }

            public JsonParamSummTextTech(string technique, int word_count, string text)
            {
                this.technique = technique;
                this.word_count = word_count;
                this.text = text;
            }

            public JsonParamSummTextTech() { }
        }

        class JsonAction
        {
            public string action { get; set; }

            public JsonParamSummTextTech parameters { get; set; }

            public JsonAction() { }

            public JsonAction(string action, JsonParamSummTextTech parameters)
            {
                this.action = action;
                this.parameters = parameters;
            }
        }


        public Form1()
        {
            InitializeComponent();
            comboBox_tech.SelectedIndex = 0;
            lock_file = core_path + "/" + lock_file_name;
            inputJson_file = core_path + "/" + inputJson_file_name;
            outputJson_file = core_path + "/" + outputJson_file_name;
            mainpy_path = core_path + "/" + mainpy_name;
        }

        #region Methods
        private void SerializeJsonRunMainPy(JsonAction jsonAction)
        {
            var j = new JavaScriptSerializer().Serialize(jsonAction);
            StreamWriter sw = new StreamWriter(inputJson_file);

            sw.WriteLine(j);
            sw.Close();

            FileStream fs = new FileStream(lock_file, FileMode.OpenOrCreate);
            fs.Close();

            Process process = new Process();

            ProcessStartInfo psi = new ProcessStartInfo();

            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = "cmd.exe";
            psi.Arguments = "/C python " + mainpy_path;
            process.StartInfo = psi;

            process.Start();

            while (File.Exists(lock_file)) ;
        }

        private string ReadFromOutputJson()
        {
            StreamReader sr = new StreamReader(outputJson_file);
            string js = sr.ReadToEnd();
            sr.Close();
            return js;
        }

        private void GetMainPyResponse()
        {
            JavaScriptSerializer JSSerializer = new JavaScriptSerializer();
            string jsonText = ReadFromOutputJson();
            JsonAction jrr = (JsonAction)JSSerializer.Deserialize(jsonText, new JsonAction().GetType());
            summarized_text = jrr.parameters.text;
            textBox_summ.Text = summarized_text;
        }

        private void Summarize()
        {
            string textToSummarize = textBox_to_summ.Text;
            int word_count = (int)numericUpDown_word_count.Value;
            string tech = comboBox_tech.Text;
            JsonParamSummTextTech jp = new JsonParamSummTextTech(technique: tech, word_count: word_count, text: textToSummarize);
            JsonAction ja = new JsonAction(action: JAction.summarize.ToString(), parameters: jp);
            SerializeJsonRunMainPy(ja);
            GetMainPyResponse();
        }

        private void ProcessFile(string selected_file)
        {
            StreamReader sr = new StreamReader(selected_file);
            textBox_to_summ.Text = sr.ReadToEnd();
            sr.Close();
        }
        #endregion

        #region Events
        private void Button_browse_file_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selected_file = openFileDialog1.FileName;
                ProcessFile(selected_file);
            }
        }

        private void Button_summarize_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        private void Button_save_summ_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string save_path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(save_path);
                sw.Write(textBox_summ.Text);
                sw.Close();
            }
        }
        #endregion
    }
}
