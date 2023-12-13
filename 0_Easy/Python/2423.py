# 2423. Remove Letter To Equalize Frequency
import typing
from collections import Counter
# You are given a 0-indexed string word, consisting of lowercase English letters.
# You need to select one index and remove the letter at that index
# from word so that the frequency of every letter present in word is equal.

# Return true if it is possible to remove one letter
# so that the frequency of all letters in word are equal,
# and false otherwise.

# Note:
#   The frequency of a letter x is the number of times it occurs in the string.
#   You must remove exactly one letter and cannot choose to do nothing.


# Runtime:    11ms    (Beats 78.85%of users with Python)
# Memory : 13.22MB    (Beats 75.00%of users with Python)
class Solution(object):
    def equalFrequency(self, word: str):
        """
        :type word: str
        :rtype: bool
        """
        counter = {}
        # Determine how many times each character is repeated in the word
        for char in word:
            counter[char] = counter.get(char, 0) + 1

        frequency = {}  # count: num chars
        for char, count in counter.items():
            if frequency.get(count, -1) == -1:
                frequency[count] = 1
            else:
                frequency[count] += 1

        frequencies = list(frequency.keys())

        # Case 1: Each character is repeated the same number of times
        if len(frequencies) == 1:
            # If there are more than 1 characters that
            # are seen more than once, i.e. a word such as `aabb`
            if (frequencies[0] > 1) and (frequency[frequencies[0]] > 1):
                return False
            return True
        # Case 2: Two distinct frequencies
        if len(frequencies) == 2:
            min_freq = min(frequencies)
            max_freq = max(frequencies)

            min_count = frequency[min_freq]
            max_count = frequency[max_freq]

            difference_is_1 = bool(max_freq - min_freq == 1)
            if (min_freq == 1 and min_count == 1) or (difference_is_1 and max_count == 1):
                return True

        # Case 3: There are more than 2 distinct frequencies
        elif len(frequencies) > 2:
            return False

        return False


sol = Solution()
word = "word"
print(word, sol.equalFrequency(word))
word = "aabbbccc"
print(word, sol.equalFrequency(word))


# Simpler solution by someone else
class Solution(object):
    def equalFrequency(self, word):
        d = Counter(word)

        for c in word:
            d[c] -= 1
            new = []
            for j in d.values():
                if j:
                    new.append(j)
            if len(set(new)) == 1:
                return True
            d[c] += 1
        return False


class Solution(object):
    def equalFrequency(self, word):
        """
        :type word: str
        :rtype: bool
        """
        values = sorted([word.count(k) for k in set(word)])
        clean_values = sorted(list(set(values)))
        nb_values = len(clean_values)

        if len(values) == 1:
            return True

        if nb_values > 2:
            return False

        if nb_values == 1:
            if clean_values[0] == 1:
                return True
            else:
                return False

        if values.count(1) == 1 and nb_values == 2:
            return True

        values[-1] -= 1
        return len(set(values)) == 1
