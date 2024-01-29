import 'package:calisma_yapisi/bottom_nav_kullanimi/sayafa_bir.dart';
import 'package:calisma_yapisi/bottom_nav_kullanimi/sayfa_iki.dart';
import 'package:calisma_yapisi/bottom_nav_kullanimi/sayfa_uc.dart';
import 'package:flutter/material.dart';

class BottomNavSayfa extends StatefulWidget {
  const BottomNavSayfa({super.key});

  @override
  State<BottomNavSayfa> createState() => _BottomNavSayfaState();
}

class _BottomNavSayfaState extends State<BottomNavSayfa> {
  int secilenIndex = 0;
  var sayfaler = [const SayfaBir(),const SayfaIki(),const SayfaUc(),];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("Bottom Nav "), backgroundColor: Colors.blue,),
      body: sayfaler[secilenIndex],
      bottomNavigationBar: BottomNavigationBar(
        items: const [
          BottomNavigationBarItem(icon: Icon(Icons.looks_one_outlined), label: "Bir"),
          BottomNavigationBarItem(icon: Icon(Icons.looks_two_outlined), label: "İki"),
          BottomNavigationBarItem(icon: Icon(Icons.looks_3_outlined), label: "Üç"),
        ],
        backgroundColor: Colors.blue,
        currentIndex: secilenIndex,
        selectedItemColor: Colors.black,
        unselectedItemColor: Colors.pink,
        onTap: (index){
          setState(() {
            secilenIndex = index;
          });
        },
      ),
    );
  }
}
