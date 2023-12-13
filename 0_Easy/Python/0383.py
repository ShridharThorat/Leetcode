# 0383 - Ransom Note
from collections import Counter


# Runtime: 40ms     (Beats 71.41% of users with Python)
# Memory : 13.6MB   (Beats 34.53% of users with Python)
class Solution(object):
    def canConstruct(self, ransomNote, magazine):
        """
        :type ransomNote: str
        :type magazine: str
        :rtype: bool
        """
        available = dict()
        # available = Counter(magazine)
        # Count the number of each character
        for char in magazine:
            available[char] = available.get(char, 0) + 1

        for char in ransomNote:
            if available.get(char, 0) == 0:
                return False
            available[char] -= 1
        if min(available.values()) < 0:
            return False
        return True


ransomNote = "abb"
magazine = "bbb"

sol = Solution()
print(sol.canConstruct(ransomNote, magazine))
