# Javier Ramirez Villalba
# Euler 2 Fibonacci

a = 1
b = 1
temp = 0
even = [1]
total = 0

for i in range (3,100):
    temp = a + b
    a = b
    b = temp
  
    if b % 2 == 0 and b < 4000000:
    #   even.append(temp)
        total += temp

print(f"Total result is:  {total}")