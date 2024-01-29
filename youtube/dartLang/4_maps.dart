void main() {
  //Maps!   Key/Value pairs
  var toppings = {"Abdullah": "Sahin", "Nuri": "Acar"};
  print(toppings);
  print(toppings["Nuri"]);

  //Show Values
  print(toppings.values);

  //Show keys
  print(toppings.keys);

  //Show length
  print(toppings.length);

  //Add something
  toppings["Tim"] = "Jhon";
  print(toppings);

  //Add manything
  toppings.addAll({"Tina": "Nina", "Steve": "Jobs"});
  print(toppings);

  //Remove something
  toppings.remove("Steve");
  print(toppings);

  //Remove everything
  toppings.clear();
  print(toppings);
}
