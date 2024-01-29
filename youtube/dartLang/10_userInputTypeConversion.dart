import 'dart:io';

void main() {
  //User input type conversion
  print("Enter A number");

  //Get user input
  var nummy = stdin.readLineSync();
  var nummy2 = int.parse(nummy ?? '0') + 10;
  print("$nummy + 10 = $nummy2");
}
