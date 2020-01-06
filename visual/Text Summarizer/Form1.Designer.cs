namespace Text_Summarizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_to_summ = new System.Windows.Forms.TextBox();
            this.button_summarize = new System.Windows.Forms.Button();
            this.comboBox_tech = new System.Windows.Forms.ComboBox();
            this.label_tech = new System.Windows.Forms.Label();
            this.groupBox_to_summ = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_word_count = new System.Windows.Forms.NumericUpDown();
            this.button_buscar_directorio = new System.Windows.Forms.Button();
            this.groupBox_summ = new System.Windows.Forms.GroupBox();
            this.button_save_summ = new System.Windows.Forms.Button();
            this.textBox_summ = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_to_summ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_word_count)).BeginInit();
            this.groupBox_summ.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_to_summ
            // 
            this.textBox_to_summ.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_to_summ.Location = new System.Drawing.Point(6, 21);
            this.textBox_to_summ.Multiline = true;
            this.textBox_to_summ.Name = "textBox_to_summ";
            this.textBox_to_summ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_to_summ.Size = new System.Drawing.Size(384, 446);
            this.textBox_to_summ.TabIndex = 0;
            // 
            // button_summarize
            // 
            this.button_summarize.BackColor = System.Drawing.Color.White;
            this.button_summarize.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_summarize.Location = new System.Drawing.Point(279, 473);
            this.button_summarize.Name = "button_summarize";
            this.button_summarize.Size = new System.Drawing.Size(111, 37);
            this.button_summarize.TabIndex = 1;
            this.button_summarize.Text = "- Summarize -";
            this.button_summarize.UseVisualStyleBackColor = false;
            this.button_summarize.Click += new System.EventHandler(this.Button_summarize_Click);
            // 
            // comboBox_tech
            // 
            this.comboBox_tech.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tech.FormattingEnabled = true;
            this.comboBox_tech.Items.AddRange(new object[] {
            "gensim",
            "frequency-driven",
            "LSA"});
            this.comboBox_tech.Location = new System.Drawing.Point(9, 487);
            this.comboBox_tech.Name = "comboBox_tech";
            this.comboBox_tech.Size = new System.Drawing.Size(127, 25);
            this.comboBox_tech.TabIndex = 4;
            // 
            // label_tech
            // 
            this.label_tech.AutoSize = true;
            this.label_tech.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tech.Location = new System.Drawing.Point(9, 468);
            this.label_tech.Name = "label_tech";
            this.label_tech.Size = new System.Drawing.Size(78, 17);
            this.label_tech.TabIndex = 5;
            this.label_tech.Text = "Technique:";
            // 
            // groupBox_to_summ
            // 
            this.groupBox_to_summ.Controls.Add(this.label1);
            this.groupBox_to_summ.Controls.Add(this.numericUpDown_word_count);
            this.groupBox_to_summ.Controls.Add(this.button_buscar_directorio);
            this.groupBox_to_summ.Controls.Add(this.textBox_to_summ);
            this.groupBox_to_summ.Controls.Add(this.label_tech);
            this.groupBox_to_summ.Controls.Add(this.button_summarize);
            this.groupBox_to_summ.Controls.Add(this.comboBox_tech);
            this.groupBox_to_summ.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_to_summ.Location = new System.Drawing.Point(3, 2);
            this.groupBox_to_summ.Name = "groupBox_to_summ";
            this.groupBox_to_summ.Size = new System.Drawing.Size(396, 517);
            this.groupBox_to_summ.TabIndex = 6;
            this.groupBox_to_summ.TabStop = false;
            this.groupBox_to_summ.Text = "Text to summarize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Word count:";
            // 
            // numericUpDown_word_count
            // 
            this.numericUpDown_word_count.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_word_count.Location = new System.Drawing.Point(166, 488);
            this.numericUpDown_word_count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_word_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_word_count.Name = "numericUpDown_word_count";
            this.numericUpDown_word_count.Size = new System.Drawing.Size(74, 22);
            this.numericUpDown_word_count.TabIndex = 7;
            this.numericUpDown_word_count.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // button_buscar_directorio
            // 
            this.button_buscar_directorio.BackColor = System.Drawing.SystemColors.Control;
            this.button_buscar_directorio.FlatAppearance.BorderSize = 0;
            this.button_buscar_directorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar_directorio.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar_directorio.Image = ((System.Drawing.Image)(resources.GetObject("button_buscar_directorio.Image")));
            this.button_buscar_directorio.Location = new System.Drawing.Point(370, 0);
            this.button_buscar_directorio.Name = "button_buscar_directorio";
            this.button_buscar_directorio.Size = new System.Drawing.Size(20, 20);
            this.button_buscar_directorio.TabIndex = 6;
            this.button_buscar_directorio.UseVisualStyleBackColor = false;
            this.button_buscar_directorio.Click += new System.EventHandler(this.Button_browse_file_Click);
            // 
            // groupBox_summ
            // 
            this.groupBox_summ.Controls.Add(this.button_save_summ);
            this.groupBox_summ.Controls.Add(this.textBox_summ);
            this.groupBox_summ.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_summ.Location = new System.Drawing.Point(405, 2);
            this.groupBox_summ.Name = "groupBox_summ";
            this.groupBox_summ.Size = new System.Drawing.Size(454, 517);
            this.groupBox_summ.TabIndex = 7;
            this.groupBox_summ.TabStop = false;
            this.groupBox_summ.Text = "Summarized text";
            // 
            // button_save_summ
            // 
            this.button_save_summ.BackColor = System.Drawing.SystemColors.Control;
            this.button_save_summ.FlatAppearance.BorderSize = 0;
            this.button_save_summ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_summ.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_summ.Image = ((System.Drawing.Image)(resources.GetObject("button_save_summ.Image")));
            this.button_save_summ.Location = new System.Drawing.Point(427, 0);
            this.button_save_summ.Name = "button_save_summ";
            this.button_save_summ.Size = new System.Drawing.Size(20, 20);
            this.button_save_summ.TabIndex = 7;
            this.button_save_summ.UseVisualStyleBackColor = false;
            this.button_save_summ.Click += new System.EventHandler(this.Button_save_summ_Click);
            // 
            // textBox_summ
            // 
            this.textBox_summ.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_summ.Location = new System.Drawing.Point(6, 21);
            this.textBox_summ.Multiline = true;
            this.textBox_summ.Name = "textBox_summ";
            this.textBox_summ.ReadOnly = true;
            this.textBox_summ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_summ.Size = new System.Drawing.Size(441, 488);
            this.textBox_summ.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text File|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.groupBox_summ);
            this.Controls.Add(this.groupBox_to_summ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Text Summarizer";
            this.groupBox_to_summ.ResumeLayout(false);
            this.groupBox_to_summ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_word_count)).EndInit();
            this.groupBox_summ.ResumeLayout(false);
            this.groupBox_summ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_to_summ;
        private System.Windows.Forms.Button button_summarize;
        private System.Windows.Forms.ComboBox comboBox_tech;
        private System.Windows.Forms.Label label_tech;
        private System.Windows.Forms.GroupBox groupBox_to_summ;
        private System.Windows.Forms.GroupBox groupBox_summ;
        private System.Windows.Forms.TextBox textBox_summ;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_buscar_directorio;
        private System.Windows.Forms.Button button_save_summ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown_word_count;
        private System.Windows.Forms.Label label1;
    }
}

