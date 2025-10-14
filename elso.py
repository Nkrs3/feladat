a = float(input("Add meg az első oldal hosszát: "))
b = float(input("Add meg a második oldal hosszát: "))
c = float(input("Add meg a harmadik oldal hosszát: "))

if (a < b + c) and (b < a + c) and (c < a + b):
    print("A megadott szakaszok alkothatnak háromszöget.")
else:
    print("A megadott szakaszok nem alkothatnak háromszöget.")