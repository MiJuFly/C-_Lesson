﻿// See https://aka.ms/new-console-template for more information

decimal a = 10M;
decimal b = 3M;
decimal c = a + b; //Output 13
decimal d = a - b; //Output 7
decimal e = a * b; //Output 30
decimal f = a / b; //Output 3,33333333
decimal g = a % b; //Output 1 - reszta z dzielenia

Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine("_____________________Assigment Operators _____________________________");
// Assigment Operators
 a += 20M;  //a = 10 + 20 --> a=30
 Console.WriteLine(a);
 a -= 20M;  //a = 30 - 20 =10
 Console.WriteLine(a);
 a *= 3M;   // a= 10*3 = 30
 Console.WriteLine(a);
 a /= 3M;   // a= 30/3 = 10
 Console.WriteLine(a);
 a %= 3M;   // a= 10/3 reszta 1 a=1
 Console.WriteLine(a);


Console.ReadKey();