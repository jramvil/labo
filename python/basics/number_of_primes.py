

def is_prime(num):
    if num < 2:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True

def count_primes(a, b):
    count = 0
    for num in range(a, b + 1):
        if is_prime(num):
            count += 1
    return count


def interval(num, inter_len):
    results = []

    for i in range(num):
        beg = i * inter_len + 1
        end = (i + 1) * inter_len

        count = count_primes(beg, end)
        results.append(count)

    return results


num_intervals = 10
lengh_inter = 100000
final_result = interval(num_intervals, lengh_inter)

for i, count in enumerate(final_result):
    inter_begin = i * lengh_inter + 1
    intern_end = (i + 1) * lengh_inter
    print(f'There are {count} prime numbers in the interval [{inter_begin}, {intern_end}].')








'''
a = 1
b = 20
result = count_primes(a, b)
print(f'The number of prime numbers between {a} and {b} is: {result}')
'''