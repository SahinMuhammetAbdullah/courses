// ignore_for_file: prefer_const_constructors, prefer_const_literals_to_create_immutables

import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      home: const MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  final personelNextToMe =
      'asdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsdasdasdasdasdsd';
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('final')),
      body: Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: [
          SizedBox(
            width: 100,
            height: 100,
            child: Text('Hello'),
          ),
          Container(
            width: 100,
            height: 100,
            color: Colors.blue,
            child: Text('Hello'),
          ),
        ],
      ),
    );
  }
}
