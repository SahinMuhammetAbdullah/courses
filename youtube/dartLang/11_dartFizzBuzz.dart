void main() {
  var count = 100;
  for (var i = 1; i <= count; i++) {
    if (i % 5 == 0 && i % 3 == 0) {
      print("$i fizzbuzz");
    } else if (i % 5 == 0) {
      print("$i fizz");
    } else if (i % 3 == 0) {
      print("$i buzz");
    } else
      print("$i");
  }
}
