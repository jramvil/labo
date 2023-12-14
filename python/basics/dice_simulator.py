#Simulation dices
#JAVIER RAMIREZ VILLALBA


import random

times = 1000000
outcome = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0] # lista que usaremos para contar cuantas veces sale cada numero




for i in range(1, times):
    dice1 = random.randint(1, 6)
    dice2 = random.randint(1, 6)
    result = dice1 + dice2
    outcome[result - 2] += 1
    
    
for i in range(11):
    #print(i+2, "-->", outcome[i])
    print("%2d %10d %10.2f" % (i+2, outcome[i], 100*outcome[i] / times))










