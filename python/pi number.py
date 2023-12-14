
# CALCULO DE PI CON EL METODO DE Leibitz Y BUCLE WHILE
'''
def number_pi(accuracy):
    pi = 0
    i = 0
    acurate_value = 3.141592653589 / 4

    while abs(pi - acurate_value) > accuracy:
        pi = pi + (((-1)**i)/(2*i + 1))
        i += 1
        
        
    return 4*pi, i

pi_value = number_pi(0.001)[0]
iterations = number_pi(0.001)[1]
print(pi_value, iterations)
'''


#CALCULO DE PI CON EL METODO DE WALLIS
'''
def calculate_pi(n):
    X = []
    Y = []
    Z = []
    pi = 1

    for i in range (1, n+1):
        
        pi = pi*(((2*i)/(2*i-1))*((2*i)/(2*i+1)))
        X.append(i)
        Y.append(2*pi)
        Z.append(3.14)

    return X, Y, Z
'''
    
# CALCULO DE PI CON EL METODO DE Leibitz Y BUCLE FOR
def calculate_pi(n):
    X = []
    Y = []
    Z = []
    pi = 0

    for i in range (1, n+1):
        
        pi = pi + 1.0*(-1)**(i+1)*4/(2*i-1)
        X.append(i)
        Y.append(round(pi,2))
        Z.append(3.14)

    return X, Y, Z



X, Y, Z = calculate_pi(10)

import matplotlib.pyplot as plt

plt.style.use('dark_background')

fig, ax = plt.subplots()
ax.plot(Y, c = 'red')
ax.plot(Z, c = 'blue')

ax.set_title("Aproaching to number PI", fontsize = 12)
ax.set_xlabel("Number of iterations", fontsize = 12)
ax.set_ylabel("Calculated value of PI", fontsize = 12)
#ax.tick_params(axis = 'both', wich = 'major', labelsize = 12)

plt.show()










