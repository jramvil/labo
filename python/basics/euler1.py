#Euler 1
#JAVIER RAMIREZ VILLALBA

result = 0

for i in range(3, 1000, 3):
    result += i
    
for i in range(5, 1000, 5):
    if i % 3 != 0:
        result += i
        

print ("The sum of result is:", result)









