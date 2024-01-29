//import 'ev.dart';
import 'saray.dart';
import 'villa.dart';

void main(List<String> args) {
  var topkapiSarayi = Saray(kule_sayisi: 10, pencere_sayisi: 50);
  print(topkapiSarayi.kule_sayisi);
  print(topkapiSarayi.pencere_sayisi);

  var bogazVilla = Villa(garaj_var_mi: true, pencere_sayisi: 30);
  print(bogazVilla.garaj_var_mi);
  print(bogazVilla.pencere_sayisi);

  //?tip kontrolu
  // ignore: unnecessary_type_check
  if (topkapiSarayi is Saray) {
    print("saraydir");
  } else {
    print("saraydegil");
  }

  if (bogazVilla is Saray) {
    print("saraydir");
  } else {
    print("saraydegil");
  }

  // //? Downcasting
  // var ev = Ev(pencere_sayisi: 10);
  // var saray = ev as Saray;

  // //? Upcasting
  // var s = Saray(kule_sayisi: 3, pencere_sayisi: 100);
  // Ev e = s;
}
