#JAVIER RAMIREZ VILLALBA


import random
import math

class triangle:
    
    def triangle(self):
        pass

    def sides(self):
        random_sides = [random.randint(1, 13) for i in range(3)]
        random_sides.sort()
        return random_sides

    def is_triangle(self, num):
        if sum(num[:2]) > num[2]:
            return True
        else:
            return False
            
            
    def area(self, num):
        
        p = sum(num[:3])/2
        area = math.sqrt(p*(p-num[0])*(p-num[1])*(p-num[2]))
            
        return area   
            
    def rectangle(self, num):
        
        a, b, c = num
        
        if a**2 + b**2 == c**2 or a**2 + c**2 == b**2 or b**2 + c**2 == a**2:
            return True
        
        else:
            return False
        
        
        
            

lados = triangle()
result = lados.sides()

print("Numeros aleatorios:", result)

if lados.is_triangle(result):
    print("We can build a triangle, and its area is:", round(lados.area(result),2), lados.rectangle(result))
    
else:
    print("We can not build a triangle")
