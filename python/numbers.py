"""list numbers"""

start = int(input("from: "))
end = int(input("to: "))
steps = int(input("steps: "))
for number in range(start, end + 1, steps):
    print(number)
