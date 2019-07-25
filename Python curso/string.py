myStr = "hello world"

# dir sirve para ver funciones de los tipos de datos
#print(dir(myStr))

print(myStr.upper())
print(myStr.lower())
print(myStr.swapcase())
print(myStr.capitalize())
print(myStr.replace("hello","bye").upper())
print(myStr.count("l"))
print(myStr.count(" "))
print(myStr.count('o'))

print(myStr.startswith("hello"))
print(myStr.startswith("bye"))
print(myStr.endswith("world"))

# por defecto separa por un espacio
print(myStr.split())
print(myStr.split("o"))

# devuelve la posicion de el caracter
print(myStr.find("o"))

# imprime longitud
print(len(myStr))

print(myStr.index("e"))

print(myStr.isnumeric())
print(myStr.isalpha())

print(myStr[6])
print(myStr[0])
print(myStr[3])
print(myStr[-2])
print(myStr[-3])

print(myStr + " - " + "Mauro")
print(f"My name is {myStr}")
print("My name is {}".format(myStr))
