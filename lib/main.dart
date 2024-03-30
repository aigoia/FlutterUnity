import 'package:flutter/material.dart';
import 'simple_screen.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Unity Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: SimpleScreen(), // SimpleScreen을 메인 화면으로 설정
    );
  }
}