#   1 2 3 4 5 6 7 8 9
# 1 0 0 0 0 0 0 0 0 0 1
#   x   x   x   x   x  ->  zeroes_between//2
#     x   x   x   x    ->  placeable_areas//2
#       x   x   x      -> (placeable_areas-1)//2+1

# Status: Accepted
# Runtime: 117ms    (Beats 65.12% of users with Python)
# Memory : 13.79MB  (Beats 71.25% of users with Python)
def canPlaceFlowers(flowerbed, n):
    """
    :type flowerbed: List[int]
    :type n: int
    :rtype: bool
    """
    # Gets the indexes of all ones
    all_ones = [i for i, x in enumerate(flowerbed) if x == 1]
    # mathematically works out
    if len(all_ones) == 0:
        all_ones = [-1, len(flowerbed)]
    else:
        if all_ones[0] != 0:
            all_ones = [-1] + all_ones
        if all_ones[-1] != len(flowerbed) - 1:
            all_ones = all_ones + [len(flowerbed)]

    maximum = 0
    for i in range(len(all_ones)-1):
        zeroes_between = all_ones[i+1] - all_ones[i] - 1
        # If there is no '1's (...)
        if all_ones[i] == -1 and all_ones[i+1] == len(flowerbed):
            placeable_areas = zeroes_between
        # If there is only one '1' acting as a boundary (1,...) or (...,1)
        # Technically should be XOR but elif does this for us
        elif all_ones[i] == -1 or all_ones[i+1] == len(flowerbed):
            placeable_areas = zeroes_between - 1
        else:  # There are two '1's acting as a boundary (1,...,1)
            placeable_areas = zeroes_between - 2

        if placeable_areas <= 0:  # i.e if zeroes_between == 1
            continue
        # flowers cannot be right next to the 1's -> i.e take the smallest number
        prev_max = maximum
        possible_flowers = max((placeable_areas//2), (placeable_areas-1)//2+1)
        maximum += possible_flowers

        if (n <= maximum) and (n >= prev_max):
            return True

    # return False
    return False


print(canPlaceFlowers([0, 0, 0, 0, 0], 3))
