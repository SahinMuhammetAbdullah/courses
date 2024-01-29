void main() {
  //Convert  string, integer adn doubles

  //String to int
  var a, b, c;
  a = 21;
  b = "1";
  c = a + int.parse(b);
  print("$a + $b + $c");

  //String to double
  var d, e, f;
  d = 40;
  e = "0.1";
  f = d + double.parse(e);
  print("$d + $e = $f");

  //Integer to String
  var g, h, i;
  g = 40;
  h = '1';
  i = g.toString() + h;
  print("$g + $h = $i");
  
}
