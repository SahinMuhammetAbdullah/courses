import 'package:bloc_pattern_kullanimi/data/repo/matematik_repository.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class AnasayfaCubit extends Cubit<int> {
  AnasayfaCubit() : super(0);

  var mrepo = MatematikRepository();

  void toplamaYap(String sayi1, String sayi2) {
    emit(mrepo.toplamaYap(sayi1, sayi2)); //tetikleme ve veri gönderme
  }

  void carpmaYap(String sayi1, String sayi2) {
    emit(mrepo.carpmaYap(sayi1, sayi2)); //tetikleme ve veri gönderme
  }
}
