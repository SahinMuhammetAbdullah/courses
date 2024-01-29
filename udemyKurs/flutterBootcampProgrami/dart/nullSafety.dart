void main(List<String> args) {
  String str = "merhaba";

  String? str2 = null;

  print("Yontem 1: ${str2?.toUpperCase()}");

  //print("Yontem 2: ${str2!.toUpperCase()}");

  if (str2 != null)
    print(str);
  else
    print("str null");

  //late String v;
}
