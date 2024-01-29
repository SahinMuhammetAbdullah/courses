// ignore_for_file: must_be_immutable

import 'package:calisma_yapisi/sonuc_ekrani.dart';
import 'package:flutter/material.dart';
import 'package:calisma_yapisi/kisiler.dart';

class OyunEkrani extends StatefulWidget {
  Kisiler kisi;
  OyunEkrani({super.key, required this.kisi});

  @override
  State<OyunEkrani> createState() => _OyunEkraniState();
}

class _OyunEkraniState extends State<OyunEkrani> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Oyun Ekranı"),
        leading: IconButton(
            onPressed: () {
              Navigator.pop(context);
            },
            icon: const Icon(Icons.arrow_back_ios_new)),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: [
            Text(
                "${widget.kisi.ad} - ${widget.kisi.yas} - ${widget.kisi.boy} - ${widget.kisi.medeniHal}"),
            ElevatedButton(
                onPressed: () {
                  Navigator.pushReplacement(
                      context,
                      MaterialPageRoute(
                          builder: (context) => const SonucEkrani()));
                },
                child: const Text("Bitti")),
          ],
        ),
      ),
    );
  }
}
