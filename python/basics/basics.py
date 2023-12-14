# JAVIER RAMIREZ VILLALBA 
# Basics of Python 26-10-2023

#-------------------------------------------------------------------------

# importacion de librerias 
import random


#-------------------------------------------------------------------------

# Declaracion de variables
a = 1
b = 10
c = 1 + 10
d = 1 - 10
e = 1 // 10 # la division con dos barras coge unicamente la parte entera

num = random.randint(2, 100)

#-------------------------------------------------------------------------

# No hace falta usar parantesis en los if, ni llaves. Las llaves se cambian por :
if num % 2 == 0:
    print (f"{num} is an even number")
else:
    print (f"{num} is an odd number")

#-------------------------------------------------------------------------

#listas

a = [1, 2, 3, 100, 'Python', [10,20,30]]

print (a[5][1]) 
print (a[0:4]) # Muestra los elementos de la lista entre los puestos 0 y 4 excluyendo el 4 
print (a[-1]) # Para mostrar el ultimo de la lista

#-------------------------------------------------------------------------


#-------------------------------------------------------------------------




#-------------------------------------------------------------------------


# Imprimir texto por pantalla --> comillas simples
#print ('This is "the best programing language"')
    
#print (a, b, c, d, e)

#print ("six divided by ten is:", 6/10) 
#print (f"six divided by ten is {6/10}") # la f significa formato
#print (num)

















