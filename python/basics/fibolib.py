
def fibo1(n):
    #iterative version
    a = 1
    b = 1
    lista = [1,1]
    
    for i in range(3,n):
        temp = a + b
        a = b  
        b = temp
        lista.append(temp)
   
    return lista 


def fibor(n):
    #recursive version
    if n == 1:
        return 1
    elif n == 2:
        return 1
    else:
        return(fibor(n-1) + fibor(n-2))



def fibo2(n):
    flist = []
    
    for i in range(1, n):
        flist.append(fibor(i))
    return flist
    





