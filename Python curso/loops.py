foods = ["apples","bread","cheese","milk"]
print(foods)

for food in foods:
    print(food)
    if food == "cheese":
        print("you have to buy this")
        break # break termina el bucle
        # continue sirve para continuar el bucle

for number in range(1,8):
    print(number)
for letter in "Hello":
    print(letter)

count = 4

while count <= 10:
    print(count)
    count = count + 1
    