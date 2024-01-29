'''
name = "Sadik"
surnaem = 'Turan'
age = 36

greeting = 'My name is '+name+' '+surnaem+" and\nI am "+str(age) +' years old'
print(greeting[0])
print(greeting[1])
print(greeting[2])
print(greeting[3])
print(len(greeting))
print(greeting[len(greeting)-1])
print(greeting[-1])
print(greeting[3:7])
print(greeting[3:])
print(greeting[:16])
print(greeting[2:40:2])
'''

name = 'cinar'
surname = 'turan'

print(surname[::-1])
age = 35
print('My name is {} {}'.format(name , surname))
print('My name is {1} {0}'.format(name , surname))
print("My name is {n} {s} and i'm {a}".format(n=name , s=surname,a=age))
print(f"My name is {name} {surname} and i'm {age}")

result = 200 / 700

print('The result is {k:1.4}'.format(k=result))