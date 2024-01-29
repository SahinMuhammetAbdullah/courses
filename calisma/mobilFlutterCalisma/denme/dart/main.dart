void main() {
  outerloop:
  for (var i = 0; i < 5; i++) {
    print('innerLoop ${i}');
    innerloop:
    for (var j = 0; j < 5; j++) {
      if (j > 3) break;
      if (i == 2) break innerloop;
      if (i == 4) break outerloop;
      print('innerLoop ${j}');
    }
  }
  // print(null ?? 5);
  // var i = play();
  // print(i);
}

String play() {
  var caunting = 0;
  for (var i = 0; i < 10000000000; i++) {
    caunting += i;
  }
  return 'çalıstı';
}
