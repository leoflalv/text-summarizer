import gensim
from summary_algorithms.algorithm import SummaryAlgorithm

class GensimSummarizer(SummaryAlgorithm):
    def summarize(self, text, max_length):
        return gensim.summarization.summarize(text, word_count=max_length)
