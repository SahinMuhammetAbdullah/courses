import 'package:calisma_yapisi/kisiler.dart';
import 'package:calisma_yapisi/oyun_ekrani.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Anasayfa extends StatefulWidget {
  const Anasayfa({super.key});

  @override
  State<Anasayfa> createState() => _AnasayfaState();
}

class _AnasayfaState extends State<Anasayfa> {

  int sayac = 0;
  bool kontrol = false;

  Future<int> toplama(int sayi1, int sayi2) async {
    return sayi1 + sayi2;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("Anasayfa"),),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: [
            Text("Sonuç: $sayac"),
            ElevatedButton(onPressed: (){
              setState(() {
                sayac++;
              });
            },
                child: const Text("Tıkla")
            ),
            ElevatedButton(onPressed: (){
              var kisi = Kisiler(ad: "abdullah", yas: 21, boy: 1.83, medeniHal: false);
              Navigator.push(context, MaterialPageRoute(builder: (context) => OyunEkrani(kisi: kisi)));
            },
                child: const Text("Basla")
            ),
            Visibility(visible: kontrol,child: const Text("Merhaba")),
            Text(kontrol ? "Merhaba" : "Güle Güle", style: TextStyle(color: kontrol ? Colors.blue : Colors.red,),),
            ((){
              if(kontrol){
                return const Text("Merhaba", style: TextStyle(color: Colors.blue),);
              }else {
                return const Text("Güle güle", style: TextStyle(color: Colors.red),);
              }
            }()),
            ElevatedButton(onPressed: (){
              setState(() {
                kontrol = true;
              });
            },
                child: const Text("durum true")
            ),
            ElevatedButton(onPressed: (){
              setState(() {
                kontrol = false;
              });
            },
                child: const Text("durum false")
            ),
            FutureBuilder<int>(
              future: toplama(10,20),
              builder: (context, snapshot){
                if(snapshot.hasError){
                  return const Text("Hata oluştu");
                }
                if(snapshot.hasData){
                  return Text("Sonuç: ${snapshot.data}");
                }else {
                  return const Text("Sonuç yok");
                }
              },
            )
          ],
        ),
      ),
    );
  }
}
