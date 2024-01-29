// ignore_for_file: avoid_print

import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

class Anasayfa extends StatefulWidget {
  const Anasayfa({super.key});

  @override
  State<Anasayfa> createState() => _AnasayfaState();
}

class _AnasayfaState extends State<Anasayfa> {
  int sayac = 0;

  @override
  void initState() {
    super.initState();
    //test();
    sayacKontrol();
  }

  Future<void> sayacKontrol() async {
    var prefs = await SharedPreferences.getInstance();
    sayac = prefs.getInt('sayac') ?? 0;
    setState(() {
      sayac = sayac + 1;
    });
    prefs.setInt("sayac", sayac);
  }

  Future<void> test() async {
    var sp = await SharedPreferences.getInstance();

    // veri kaydi
    sp.setString('ad', 'Ahmet');
    sp.setInt("yas", 23);
    sp.setBool("cinsiyet", true);
    sp.setDouble("boy", 183.5);

    var arakadasListesi = <String>[];
    arakadasListesi.add("ali");
    arakadasListesi.add("mehmet");
    sp.setStringList("arakadaslarim", arakadasListesi);

    // veri silme
    // sp.remove("ad");
    // sp.clear();

    //veri okuma
    String ad = sp.getString('ad') ?? "hatalı";
    int yas = sp.getInt("yas") ?? 0;
    bool cinsiyet = sp.getBool("cinsiyet") ?? false;
    double boy = sp.getDouble("boy") ?? 0;
    List<String> arakadaslarim = sp.getStringList("arakadaslarim") ?? [];
    print("gelen ad: $ad");
    print("gelen yas: $yas");
    print("gelen cinsiyet: $cinsiyet");
    print("gelen boy: $boy");
    print("gelen arakadaslarim: $arakadaslarim");
    // print("gelen arakadaslarim: ${sp.getStringList("arakadaslarim")}");

    if (arakadaslarim.isNotEmpty) {
      for (var a in arakadaslarim) {
        print(a);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Shared Proferences"),
      ),
      body: Center(
          child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: [
          Text(
            "Açılış Sayısı $sayac",
            style: const TextStyle(fontSize: 50),
          ),
        ],
      )),
    );
  }
}
