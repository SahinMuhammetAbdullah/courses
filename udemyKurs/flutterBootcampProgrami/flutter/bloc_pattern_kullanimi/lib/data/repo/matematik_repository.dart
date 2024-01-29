class MatematikRepository {
  int toplamaYap(String sayi1, String sayi2) {
    int toplam = int.parse(sayi1) + int.parse(sayi2);
    return toplam;
  }

  int carpmaYap(String sayi1, String sayi2) {
    int carpim = int.parse(sayi1) * int.parse(sayi2);
    return carpim;
  }
}
