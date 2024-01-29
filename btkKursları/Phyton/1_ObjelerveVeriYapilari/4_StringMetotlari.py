message = ' Hello There. My name is Sadik Turan'

message = message.upper() #! Tumu buyuk
message = message.lower() #! Tumu kucuk
message = message.title() #! Ilk harfler buyuk
message = message.capitalize() #! Ilk karakter buyuk
message = message.strip() #! Bastaki bosluklari sil
message = message.split() #! Tum bosluklardan ayirir
message = message.split('.') #! Tum noktalardan(.) ayirir
message = message.split() #! Tum bosluklardan ayirir
message = ' '.join(message) #! ' ' ile birlestirir ('--' ise her kelemime arasina "--" ekler)
index = message.find('Sadik') #! Cumlede kelime varsa o kelimenin ilk harfinin index numarasini dondurur. -1 ise cumlede yok demek
isFount = message.startswith('H') #! 'H' ile basliyorsa true doner (bool deger doner)
isFount = message.endwith('n') #! 'n' ile bitiyorsa true doner (bool deger doner)

message = message.replace('Sadik', 'Cinar') #! Sadik'i bul Cinar ile degistir
message = message.center(50,'*') #! n karakterlik alan ayirir ve ortalar ve bosluklar yerine * (n den sonra deger yazilmayabilir)

#? String metotlari <<=>> https://www.w3schools.com/python/python_ref_string.asp



print(message)
