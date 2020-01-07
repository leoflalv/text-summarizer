import re
import spacy


class SummaryManager:

    def __init__(self):
        self.__nlp = spacy.load('es_core_news_sm')
        self.raw_sentences = []
        self.processed_sentences = []
        self.words_set = None
        self.words = None
        self.__raw_sentence_with_position = None
        self.__raw_sentence_by_processed_sentence = None

    def preprocess(self, text):
        doc = re.sub(r'(\n|\r)', '', text)
        doc = re.sub(r'(¿|¡)(\w|\s)*(\?|!)', '', doc)
        self.raw_sentences = [x for x in doc.split('.') if len(x) > 2]

        doc = re.sub(r'("|-|:|,)', '', doc)
        sentences = [x for x in doc.split('.') if len(x) > 2]

        for sentence in sentences:
            new_sentence = ''
            for word in sentence.split():
                if not self.__nlp.vocab[word].is_stop:
                    new_sentence += word + " "
            self.processed_sentences.append(new_sentence)

        self.__raw_sentence_with_position = dict(
            zip(self.raw_sentences, range(len(self.raw_sentences))))

        self.__raw_sentence_by_processed_sentence = dict(
            zip(self.processed_sentences, self.raw_sentences))

        words = doc.split()
        for i in range(len(words)):
            words[i] = words[i].lower()
            if words[i][-1] == '.':
                words[i] = words[i][:-1]

        self.words = words
        self.words_set = set(words)

    def get_raw_sentence(self, processed_sentence):
        return self.__raw_sentence_by_processed_sentence[processed_sentence]

    def get_sentence_position(self, sentence):
        return self.__raw_sentence_with_position[sentence]
