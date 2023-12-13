# 1672 - Richest Customer Wealth

# You are given an m x n integer grid accounts where accounts[i][j]
# is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
# Return the wealth that the richest customer has.

# A customer's wealth is the amount of money they have in all their bank accounts.
# The richest customer is the customer that has the maximum wealth.

class Solution(object):
    def maximumWealth(self, accounts):
        """
        :type accounts: List[List[int]]
        :rtype: int
        """

        max_wealth = sum(accounts[0])
        for account in accounts:
            wealth = sum(account)
            if wealth > max_wealth:
                max_wealth = wealth

        return max_wealth


accounts = [[1, 2, 3], [3, 2, 1]]
accounts = [[1, 5], [7, 3], [3, 5]]
accounts = [[2, 8, 7], [7, 1, 3], [1, 9, 5]]
sol = Solution()
print(sol.maximumWealth(accounts))
