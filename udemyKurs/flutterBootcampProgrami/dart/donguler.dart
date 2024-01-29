void main(List<String> args) {
  for (var i = 0; i < 3; i++) {
    print(i + 1);
  }
  var i = 0;
  while (i < 3) {
    print(i + 1);
    i++;
  }
  for (var i = 0; i < 5; i++) {
    if (i == 2) {
      break; // durdurmak
    }
    print(i + 1);
  }
  for (var i = 0; i < 5; i++) {
    if (i == 2) {
      continue; // pass gecmek
    }
    print(i + 1);
  }
}
