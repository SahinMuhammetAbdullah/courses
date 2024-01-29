import 'katogoriler.dart';
import 'yonetmenler.dart';

class Filmler {
  int? film_id;
  String? film_ad;
  int? film_yil;
  Katogoriler? katogori_id;
  Yonetmenler? yonetmen_id;

  Filmler(
      {required this.film_id,
      required this.film_ad,
      required this.film_yil,
      required this.katogori_id,
      required this.yonetmen_id});
}
