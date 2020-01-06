from summary_algorithms.algorithm import SummaryAlgorithm


class FrequencyDrivenAlgorithm(SummaryAlgorithm):
    def __init__(self, manager):
        self.__manager = manager
        self.__weight_by_word = None

    def __get_weight(self, sentence):
        weight = 0
        for word in sentence:
            weight += self.__weight_by_word[word.lower()]
        return weight/len(sentence)

    def __next_sentence(self):
        best_sentence = None
        best_score = 0
        for sentence in self.__manager.processed_sentences:
            weight = self.__get_weight(sentence.split())
            if weight > best_score:
                best_sentence = sentence
                best_score = weight
        if best_sentence is not None:
            self.__manager.processed_sentences.remove(best_sentence)
        return best_sentence

    def __update_words_weight(self, selected_sentence):
        for word in selected_sentence.split():
            self.__weight_by_word[word.lower(
            )] *= self.__weight_by_word[word.lower()]

    def __words_amount(self, sentence):
        return len(sentence.split())

    def summary(self, text, max_length):
        self.__manager.preprocess(text)
        weights = [self.__manager.words.count(
            x)/len(self.__manager.words) for x in self.__manager.words_set]
        self.__weight_by_word = dict(zip(self.__manager.words_set, weights))

        current_length = 0

        summary_sentences = []

        sentence_to_summary = self.__next_sentence()

        while sentence_to_summary is not None and self.__words_amount(sentence_to_summary) + current_length <= max_length:
            current_length += self.__words_amount(sentence_to_summary)
            self.__update_words_weight(sentence_to_summary)
            raw_sentence = self.__manager.get_raw_sentence(sentence_to_summary)
            summary_sentences.append(
                (self.__manager.get_sentence_position(raw_sentence), raw_sentence + '.'))
            sentence_to_summary = self.__next_sentence()

        summary_sentences.sort()

        summary = ''

        for sentence in summary_sentences:
            summary += sentence[1]

        return summary
