void main() {
  //Functions
  myFunc(String name, {name2 = "Friends"}
      /*{name2} /*Belirtme gerekli ayrica opsiyonel*/*/ /*[name2] /*opsional*/*/
      ) {
    return ("Hello $name and $name2");
  }

  //print(myFunc());

  var thing = myFunc("Abdullah", name2: "Bill");
  print(thing);
}
