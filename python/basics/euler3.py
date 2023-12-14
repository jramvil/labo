# JAVIER RAMIREZ VILALBA
# EULER 3

def prime(n):
    if n < 2:
        return False
    for i in range(2,n-1):
        if n % i == 0:
            return False
    return True


num = 600851475143


for i in range(1, int(num** .5) +1):

    if num % i == 0 and prime(i):
       sol = i
       
print(sol)
      





