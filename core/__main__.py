import json
import os
from summary_algorithms.gensim_tech import GensimSummarizer
from summary_algorithms.frequency_driven import FrequencyDrivenAlgorithm
from utils.manager import SummaryManager


def main():
    dic = {'gensim': GensimSummarizer(), 'frequency-driven': FrequencyDrivenAlgorithm(SummaryManager())}

    input_data = read_input()
    technique = input_data['parameters']['technique']
    word_count = input_data['parameters']['word_count']
    text = input_data['parameters']['text']
    output_data = {'action': 'summarize', 'parameters':{'technique': technique, 'word_count': word_count, 'text': ''}}
    
    if not technique in dic:
        print('Error: technique: {0} not found'.format(technique))
    else:
        summ_text = dic[technique].summary(text, word_count)
        output_data['parameters']['text'] = summ_text
        
    write_output(output_data)

    try:
        os.remove('core/core.lock')
    except:
        pass
        
def read_input():
    input_file = open('core/input.json')
    input_data = json.load(input_file)
    input_file.close()
    return input_data

def write_output(data):
    output_file = open('core/output.json', 'w')
    json.dump(data, output_file)
    output_file.close()

if __name__ == '__main__':
    main()