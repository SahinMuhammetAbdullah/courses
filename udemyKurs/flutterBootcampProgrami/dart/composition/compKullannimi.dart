import 'filmler.dart';
import 'katogoriler.dart';
import 'yonetmenler.dart';

void main(List<String> args) {
  //var k1 = Katogoriler(katagori_id: 1, katogori_ad: "dram");
  var k2 = Katogoriler(katagori_id: 2, katogori_ad: "bilim kurgu");

  var y1 = Yonetmenler(yonetmen_id: 1, yonetmen_ad: "apo");
  //var y2 = Yonetmenler(yonetmen_id: 2, yonetmen_ad: "ali");

  var f1 = Filmler(
      film_id: 1,
      film_ad: "veri",
      film_yil: 2002,
      katogori_id: k2,
      yonetmen_id: y1);

  print("filim id         : ${f1.film_id}");
  print("filim ad         : ${f1.film_ad}");
  print("filim yil        : ${f1.film_yil}");
  print("filim katagori   : ${f1.katogori_id?.katogori_ad}");
  print("filim yonetmen   : ${f1.yonetmen_id?.yonetmen_ad}");
}
