import 'package:flutter/material.dart';

import 'package:urunler_app/data/entity/urunler.dart';

// ignore: must_be_immutable
class DetaySayfa extends StatefulWidget {
  Urunler urun;
  DetaySayfa({
    super.key,
    required this.urun,
  });

  @override
  State<DetaySayfa> createState() => _DetaySayfaState();
}

class _DetaySayfaState extends State<DetaySayfa> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.urun.ad),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: [
            Image.asset("images/${widget.urun.resim}"),
            Text(
              "${widget.urun.fiyat} ₺",
              style: const TextStyle(fontSize: 50),
            ),
          ],
        ),
      ),
    );
  }
}
