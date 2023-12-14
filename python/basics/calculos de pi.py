#CALCULO DE PI CON EL METODO DE WALLIS

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

    return Y[len(Y)-1]

    
# CALCULO DE PI CON EL METODO DE Leibitz Y BUCLE FOR
def calculate_pi2(n):
    X = []
    Y = []
    Z = []
    pi = 0

    for i in range (1, n+1):
        
        pi = pi + 1.0*(-1)**(i+1)*4/(2*i-1)
        X.append(i)
        Y.append(pi)
        Z.append(3.14)

    return Y[len(Y)-1]



N = 1000
real_pi = 3.14159265359

leibnitz = calculate_pi2(N)
wallis = calculate_pi(N)

diff_leib = real_pi - calculate_pi2(N)
diff_wallis = real_pi - calculate_pi(N)

print(f"Leibnitz: {leibnitz}   Wallis: {wallis}")
print(f"Diff Leib: {diff_leib}   Diff Wallis: {diff_wallis}")


