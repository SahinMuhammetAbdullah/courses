import 'package:flutter/material.dart';

class Anasayfa extends StatefulWidget {
  const Anasayfa({Key? key}) : super(key: key);

  @override
  State<Anasayfa> createState() => _AnasayfaState();
}

class _AnasayfaState extends State<Anasayfa> {
  var tfKontrol = TextEditingController();
  String alinanVeri = "";
  String resimAdi = "baklava.png";
  bool switchKontrol = false;
  bool chackboxKontrol = false;
  int radioDegeri = 0;
  bool progressKontrol = false;
  double ilerleme = 30.0;
  var tfSaat = TextEditingController();
  var tfTarih = TextEditingController();
  var ulkelerListesi = <String>[];
  String secilenUlke = "Türkiye";

  @override
  void initState() {
    super.initState();
    ulkelerListesi.add("Türkiye");
    ulkelerListesi.add("Almanya");
    ulkelerListesi.add("USA");
    ulkelerListesi.add("UK");
    ulkelerListesi.add("Hollanda");
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Witget Kullanımı"),
        backgroundColor: Colors.blue,
      ),
      body: SingleChildScrollView(
        child: Center(
          child: Column(
            children: [
              Text(alinanVeri),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: TextField(
                  controller: tfKontrol,
                  decoration: const InputDecoration(hintText: "veri"),
                  keyboardType: TextInputType.number,
                  obscureText: true,
                ),
              ),
              ElevatedButton(
                onPressed: () {
                  setState(() {
                    alinanVeri = tfKontrol.text;
                  });
                },
                child: const Text("veriyi al"),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  ElevatedButton(
                    onPressed: () {
                      setState(() {
                        resimAdi = "kofte.png";
                      });
                    },
                    child: const Text("Resim 1"),
                  ),
                  //Image.asset("images/$resimAdi"),
                  SizedBox(
                      width: 48,
                      height: 48,
                      child: Image.network(
                          "http://kasimadalan.pe.hu/yemekler/resimler/$resimAdi")),
                  ElevatedButton(
                    onPressed: () {
                      setState(() {
                        resimAdi = "ayran.png";
                      });
                    },
                    child: const Text("Resim 2"),
                  ),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  SizedBox(
                    width: 200,
                    child: SwitchListTile(
                        title: const Text("Dart"),
                        controlAffinity: ListTileControlAffinity.leading,
                        value: switchKontrol,
                        onChanged: (veri) {
                          setState(() {
                            switchKontrol = veri;
                          });
                        }),
                  ),
                  SizedBox(
                    width: 200,
                    child: CheckboxListTile(
                        title: const Text("Flutter"),
                        controlAffinity: ListTileControlAffinity.leading,
                        value: chackboxKontrol,
                        onChanged: (veri) {
                          setState(() {
                            chackboxKontrol = veri!;
                          });
                        }),
                  ),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  SizedBox(
                    width: 200,
                    child: RadioListTile(
                        title: const Text("Galatasarya"),
                        value: 1,
                        groupValue: radioDegeri,
                        onChanged: (veri) {
                          setState(() {
                            radioDegeri = veri!;
                          });
                        }),
                  ),
                  SizedBox(
                    width: 200,
                    child: RadioListTile(
                        title: const Text("Fenerbahçe"),
                        value: 2,
                        groupValue: radioDegeri,
                        onChanged: (veri) {
                          setState(() {
                            radioDegeri = veri!;
                          });
                        }),
                  ),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  ElevatedButton(
                    onPressed: () {
                      setState(() {
                        progressKontrol = true;
                      });
                    },
                    child: const Text("Başla"),
                  ),
                  Visibility(
                      visible: progressKontrol,
                      child: const CircularProgressIndicator()),
                  ElevatedButton(
                    onPressed: () {
                      setState(() {
                        progressKontrol = false;
                      });
                    },
                    child: const Text("Dur"),
                  ),
                ],
              ),
              Text(ilerleme.toInt().toString()),
              Slider(
                  max: 100.0,
                  min: 0.0,
                  value: ilerleme,
                  onChanged: (veri) {
                    setState(() {
                      ilerleme = veri;
                    });
                  }),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  SizedBox(
                    width: 120,
                    child: TextField(
                      controller: tfSaat,
                      decoration: const InputDecoration(hintText: "Saat"),
                    ),
                  ),
                  IconButton(
                      onPressed: () {
                        showTimePicker(
                                context: context,
                                initialTime:
                                    TimeOfDay.fromDateTime(DateTime.now()))
                            .then((value) => {
                                  tfSaat.text =
                                      "${value!.hour} : ${value.minute}"
                                });
                      },
                      icon: const Icon(Icons.access_time)),
                  SizedBox(
                    width: 120,
                    child: TextField(
                      controller: tfTarih,
                      decoration: const InputDecoration(hintText: "Tarih"),
                    ),
                  ),
                  IconButton(
                      onPressed: () {
                        showDatePicker(
                                context: context,
                                initialDate: DateTime.now(),
                                firstDate: DateTime(2000),
                                lastDate: DateTime(2030))
                            .then((value) => {
                                  tfTarih.text =
                                      "${value!.day}.${value.month}.${value.year}"
                                });
                      },
                      icon: const Icon(Icons.date_range)),
                ],
              ),
              DropdownButton(
                  value: secilenUlke,
                  icon: const Icon(Icons.pin_drop),
                  items: ulkelerListesi.map((ulke) {
                    return DropdownMenuItem(
                      value: ulke,
                      child: Text(ulke),
                    );
                  }).toList(),
                  onChanged: (veri) {
                    setState(() {
                      secilenUlke = veri!;
                    });
                  }),
              GestureDetector(
                  onTap: () {
                    print("Tıklandı");
                  },
                  onDoubleTap: () {
                    print("Çok tıklandı");
                  },
                  onLongPress: () {
                    print("basılı kaldı");
                  },
                  child: Container(
                    width: 200,
                    height: 200,
                    color: Colors.red,
                  )),
              ElevatedButton(
                onPressed: () {
                  setState(() {
                    print("Switch Durum : $switchKontrol");
                    print("Checkbox Durum : $chackboxKontrol");
                    print("Radio Durum : $radioDegeri");
                    print("Slider Durum : $ilerleme");
                    print("Son Ülke Durum : $secilenUlke");
                  });
                },
                child: const Text("Göster"),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
