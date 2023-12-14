
    
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










