// See https://aka.ms/new-console-template for more information

using System.Reflection;

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
Console.WriteLine("_____________________Increment/Decrement Operators _____________________________");
a =10M;
Console.WriteLine(a);
Console.WriteLine(++a); // output 11
Console.WriteLine(a++); // Output 11
Console.WriteLine(a);   // Output 12
Console.WriteLine(--a); // Output 11
Console.WriteLine(a--); // Output 11
Console.WriteLine(a);   // Output 10

Console.WriteLine("_____________Comperation Operators__________________");
bool b1 = a == 10;
Console.WriteLine(b1);  //True
bool b2 = a != 10;
Console.WriteLine(b2);  //False
bool b3 = a < 10;
Console.WriteLine(b3);  //False
bool b4 = a > 10;
Console.WriteLine(b4);  // False
bool b5 = a <= 10;
Console.WriteLine(b5);  //True
bool b6 = a >= 10;
Console.WriteLine(b6);  //True
Console.WriteLine();
Console.WriteLine("_______________Logical Operators________________________________");

bool b7 = a==10 & b==10;// a=10 a b=3
Console.WriteLine(b7);  // False
bool b8 = a==10 && b==10;
Console.WriteLine(b8);  // False
bool b9 = a==10 | b==10;// Or
Console.WriteLine(b9);  // True
bool b10 = a==10 || b==10;
Console.WriteLine(b10); // True
bool b11 = !(a==10);
Console.WriteLine(b11); // False
bool b12 = a==10 ^ b==10;
Console.WriteLine(b12); //True
Console.WriteLine();
Console.WriteLine("_______________Concatenation Operators________________________________");
string name = "Mchal";
int age = 20;
string message = "Hey " + name + ", your age is " + age +".";
Console.WriteLine(message);

Console.WriteLine("_______________Ternary Operators________________________________");
Console.Write("Insert age:");
int test = Convert.ToInt32(Console.ReadLine());

string title = (test<14)? "Child" : (test>=14 && test<= 17)? "Teenager" : "adult";
Console.WriteLine(title);



Console.ReadKey();