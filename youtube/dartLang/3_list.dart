void main() {
  //List
  var myList = [1, 2, 3];
  print(myList);
  print(myList[0]);

  //Change an item
  myList[0] = 21;
  print(myList);

  //Creat an empty list
  var emptyList = [];
  print(emptyList);

  //Add to ampy list
  emptyList.add(21);
  print(emptyList);

  //Add multiple to empty list
  emptyList.addAll([1, 2, 3]);
  print(emptyList);

  //Insert at specific position (position, item)
  myList.insert(3, 900);
  print(myList);

  //Insertmany
  myList.insertAll(1, [99, 98, 97]);
  print(myList);

  //Mixed list
  var mixedList = [1, 2, 3, "Abdullah", "Bob"];
  print(mixedList);

  //Remove from list
  mixedList.remove("Bob");
  print(mixedList);

  //Remove frome specific location
  mixedList.removeAt(1);
  print(mixedList);
}
