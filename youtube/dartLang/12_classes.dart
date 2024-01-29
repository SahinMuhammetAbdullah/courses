void main() {
  //Creat personal Class
  Person p1 = Person();
  p1.showData();
  //Add data
  p1.addData("Abdullah", "Male", 21);
  p1.showData();
  //print(p1.name);

  //Person p2 = Person("Mary", "Female", 21);
  //p2.showData();
}

class Person {
  String? name, sex;
  int? age;
  //!Constructors
  //Person(String name, sex, int age) {
  //  this.name = name;
  //  this.sex = sex;
  //  this.age = age;
  //}
  //!Method
  void addData(String name, sex, int age) {
    this.name = name;
    this.sex = sex;
    this.age = age;
  }

  //Method
  void showData() {
    print('Name = $name');
    print('Sex = $sex');
    print('Age = $age');

    print("The peson ${name}, they are ${sex} and ${age} years old...");
  }
}
