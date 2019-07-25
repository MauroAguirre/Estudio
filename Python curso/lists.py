demo_list = [1,"hello",1.32,True,[1,2,3]]
colors = ["red","green","blue"]

numbers_list = list((1,2,3,4))
print(numbers_list)

r = list(range(1,101))
print(r)

print(type(colors))
print(dir(colors))

print(len(colors))
print(len(demo_list))

print(colors[2])
print(colors[-2])

print("green" in colors)
print("black" in colors)

print(colors)
colors[1] = "yellow"
print(colors)

colors.append("violet")
print(colors)

colors.extend(["black","white"])
print(colors)

colors.extend(("pink","brown"))
print(colors)

colors.insert(1,"skyblue")
print(colors)

colors.insert(len(colors),"orange")
print(colors)

colors.pop()
print(colors)

colors.remove("yellow")
print(colors)

colors.pop(1)
print(colors)

# para borrarlos colors.clear()

colors.sort()
print(colors)

colors.sort(reverse=True)
print(colors)

print(colors.index("red"))

print(colors.count("red"))