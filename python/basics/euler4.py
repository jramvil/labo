#JAVIER RAMIREZ VILLALBA
#EULER 4


def isPalindrome(n):
    for i in range(int(len(n) /2)):
        if(n[i] == n[-i -1]):
            pass
        else:
            return False
    return True

for i in range(100, 1000):
    for j in range(100, 1000):
        if isPalindrome(str(i*j)):
            temp = i*j
        else:
            pass

print(temp)