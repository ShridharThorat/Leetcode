# 0412 - Fizz Buzz
 
class Solution(object):
    def fizzBuzz(self, n):
        """
        :type n: int
        :rtype: List[str]
        """
        fizzbuzz = []
        for i in range(1, n+1):
            if (i % 3 == 0) and (i % 5 == 0):
                fizzbuzz.append("FizzBuzz")
            elif (i % 3 == 0):
                fizzbuzz.append("Fizz")
            elif (i % 5 == 0):
                fizzbuzz.append("Buzz")
            else:
                fizzbuzz.append(str(i))

        return fizzbuzz


sol = Solution()

print(sol.fizzBuzz(3))
print(sol.fizzBuzz(5))
print(sol.fizzBuzz(15))
