import 'hayvan.dart';
import 'kedi.dart';
import 'kopek.dart';
import 'memeli.dart';

void main(List<String> args) {
  var hayvan = Hayvan();
  var memeli = Memeli();
  var kedi = Kedi();
  var kopek = Kopek();

  hayvan.sesCikar(); //! kalitim yok
  memeli.sesCikar(); //! kalitim var
  kedi.sesCikar(); //! kalitim var ama override ile
  kopek.sesCikar(); //! kalitim var ama override ile
}
