class Araba {
  //late String renk;
  //late int hiz;
  //late bool calisiyorMu;
  String renk;
  int hiz;
  bool calisiyorMu;

  Araba({required this.renk, required this.hiz, required this.calisiyorMu});

  void calistir() {
    this.hiz = 5;
    this.calisiyorMu = true;
  }

  void durudr() {
    this.hiz = 0;
    this.calisiyorMu = false;
  }

  void bilgiAl() {
    print("---------");
    print("renk   : ${this.renk}");
    print("renk   : ${this.hiz}");
    print("renk   : ${this.calisiyorMu}");
  }
}
