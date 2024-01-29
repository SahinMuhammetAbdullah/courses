void main(List<String> args) {
  //saidan sayiya
  int i = 5;
  double d = 7.5;
  int s1 = d.toInt();
  double s2 = i.toDouble();

  print(s1);
  print(s2);

  //sayidan metne
  String s3 = i.toString(); //"5"
  String s4 = d.toString(); //"7.5"
  print(s3);
  print(s4);

  //metinden sayiya
  String y1 = "25";
  String y2 = "12.43";

  int s5 = int.parse(y1);
  double s6 = double.parse(y2);
  //!int s7 = int.parse(y2);

  print(s5);
  print(s6);
}
