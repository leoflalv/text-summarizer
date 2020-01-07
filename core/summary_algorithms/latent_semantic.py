from sklearn.feature_extraction.text import TfidfVectorizer
from numpy.linalg import svd
import numpy as np
from summary_algorithms.algorithm import SummaryAlgorithm


class LatentSemanticAlgorithm(SummaryAlgorithm):
    def __init__(self, manager):
        self.__manager = manager

    def __words_amount(self, sentence):
        return len(sentence.split())

    def summary(self, text, max_length):
        self.__manager.preprocess(text)
        vectorizer = TfidfVectorizer()
        tfxidf_matrix = vectorizer.fit_transform(
            self.__manager.processed_sentences).todense()

        _, s, vh = svd(tfxidf_matrix, full_matrices=False)

        d = np.power(np.diag(s).dot(vh), 2)

        weights = [np.sqrt(np.sum(d[i, :])) for i in range(d.shape[0])]

        sorted_sentences = list(zip(weights, self.__manager.raw_sentences))
        sorted_sentences.sort(reverse=True)

        sentence_with_position = [
            (self.__manager.get_sentence_position(x[1]), x[1]) for x in sorted_sentences]

        sentence_with_position.sort()

        current_length = 0
        summary = ''

        for (_, sentence) in sentence_with_position:
            if self.__words_amount(sentence) + current_length > max_length:
                break
            summary += sentence + '.'

        return summary
