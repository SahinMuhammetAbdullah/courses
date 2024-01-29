# JavaScript
## Anahtar Kelimeler (Keywords):
1. var:
   * Değişken tanımlamak için kullanılır.
   ```JS
   var x = 5;
   ```
2. let:
   * Blok kapsamında değişken tanımlamak için kullanılır.
    ```JS
    let y = 10;
    ```
3. const:
   * Sabit bir değer tanımlamak için kullanılır.
   ```JS
   const PI = 3.14;
   ```
4. if:
   * Bir koşulu kontrol etmek için kullanılır.
   ```JS
   if (x > 0) {
    console.log("x pozitif");
   }
   ```
5. else:
   * Bir "if" koşulu sağlanmadığında çalışacak olan bloğu belirtmek için kullanılır.
   ```JS
   if (x > 0) {
    console.log("x pozitif");
   } else {
    console.log("x negatif veya sıfır");
   }
   ```
6. for:
   * Bir döngü oluşturmak için kullanılır.
   ```JS
   for (let i = 0; i < 5; i++) {
     console.log(i);
   }
   ```
7. while:
   * Belirli bir koşul sağlandığı sürece bir döngüyü çalıştırmak için kullanılır.
   ```JS
   let i = 0;
   while (i < 5) {
    console.log(i);
     i++;
   }
   ```
## Operatörler:
1. Aritmetik Operatörler:
   * +, -, *, /, %, **
   * Temel matematiksel işlemleri gerçekleştirmek için kullanılır.
   ```JS
   let a = 5;
   let b = 2;
   console.log(a + b); // 7
   ```
2. Karşılaştırma Operatörleri:
   * ==, ===, !=, !==, >, <, >=, <=
   * Değerleri karşılaştırmak için kullanılır.
   ```JS
   let x = 5;
   let y = "5";
   console.log(x == y); // true
   console.log(x === y); // false
   ```
3. Mantıksal Operatörler:
   * && (ve), || (veya), ! (değil)
   * Sabit bir değer tanımlamak için kullanılır.
   ```JS
   let p = true;
   let q = false;
   console.log(p && q); // false
   console.log(p || q); // true
   ```