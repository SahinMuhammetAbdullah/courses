import 'oop.dart';

void main(List<String> args) {
  var bmw = Araba(renk: "mavi", hiz: 100, calisiyorMu: true);
  bmw.bilgiAl();
  bmw.renk = "Kirmizi";
  bmw.bilgiAl();
  var sahin = Araba(renk: "beyaz", hiz: 0, calisiyorMu: false);
  sahin.bilgiAl();
  sahin.hiz = 10;
  sahin.calisiyorMu = true;
  sahin.bilgiAl();
  sahin.durudr();
  sahin.bilgiAl();
}
