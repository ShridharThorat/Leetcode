# 2591 - Distribute Money to Maximum Children

# You are given an integer money denoting the amount of money (in dollars)
# that you have and another integer children denoting the number of children
# that you must distribute the money to.

# You have to distribute the money according to the following rules:
#   1. All money must be distributed.
#   2. Everyone must receive at least 1 dollar.
#   3. Nobody receives 4 dollars.

# Return the maximum number of children who may receive exactly 8 dollars
#  if you distribute the money according to the aforementioned rules.
#  If there is no way to distribute the money, return -1.

# Constraints
# 1 <= money <= 200
# 2 <= children <= 30

class Solution(object):
    def distMoney(self, money, children):
        """
        :type money: int
        :type children: int
        :rtype: int
        """
        # Condition 2 fails
        if money < children:
            return -1

        # index+1 is the child and the value is the money distributed
        # child_to_money = [8 for _ in range(children)]
        # extra = (children*8) - money

        # # Subtract from each child        
        # while extra > 0:
        #     for i in range(children):
        #         subtract = extra % 4
        #         if subtract == 0:                    
        #             child_to_money[i] -= 1
        #             extra -= 1
        #         else:
        #             child_to_money[i] -= subtract
        #             extra -= subtract
                    
        #         if extra == 0:
        #             break
        distribution = []
        
        
        return distribution
        




sol = Solution()
print(sol.distMoney(20, 3))
