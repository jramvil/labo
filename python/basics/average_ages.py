def prime(n):
   
    nums = []
    i = 2

    while len(nums) < n:
        is_prime = all(i % p != 0 for p in nums)
        if is_prime:
            nums.append(i)
        i += 1

    return nums


prime_numbers = prime(100)


print(prime_numbers)

