'''
x = input('1.sayi: ')
y = input('2.sayi: ')

print(type(x))
print(type(y))

toplam = int(x) + int(y)

print(toplam)

'''
'''
x = 1               #? int
y = 1.2             #? float
name = "abdullah"   #? string
isStudent = True    #? bool

print(type(x))
print(type(y))
print(type(name))
print(type(isStudent))

x = float(x)
'''

r = input("Yari cap giriniz: ")

pi = 3.14
r = int(r)
daireAlan = pi * (r**2)
daireCevre = pi * r * 2

print("Daire Alani : " + str(daireAlan))
print("Daire Cevresi : ",daireCevre)