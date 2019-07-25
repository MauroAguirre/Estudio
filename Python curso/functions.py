# algunas funciones ya usadas
# print, dir, type, input

# vamos a crear una funcion

def hello(name):
    print("hello "+ name)

#para agregar un valor por defecto a el parametro de la funcion
def Hola(nombre = "Pablo"):
    print("Hola "+nombre)

hello("Mauro")
Hola("Raul")
Hola()

def suma(a,b):
    return a + b

print(suma(2,5))

# funcion lambda
add = lambda number1, number2: number1+number2

print(add(30,10))