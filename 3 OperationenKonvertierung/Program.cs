//Aufgabe 1

using System.Reflection.Metadata;
using System;

string a = "Hallo";
string b = "H";
b += "allo";

Console.WriteLine(b);

//Ausgabe:Hallo

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

Console.WriteLine(b.Length);

//Ausgabe:5

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

Console.WriteLine(a == b);

//Ausgab:True

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

Console.WriteLine((object)a == b);
//Ausgabe:False

Console.WriteLine("drücke Enter] um fortzufahren");
Console.ReadLine();



//Aufgabe 2



double x = 2.0;
double y = x * x + 1 + x / 4;
Console.WriteLine(y);

//Erwartet:5.5
//Ergebnis:5.5

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

x = 2.0;
y = x * (x + 1 + x / 4);
Console.WriteLine(y);

//Erwartet:7
//Ergebnis:7

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

bool c = true && false || 5 > 6;
Console.WriteLine(c);

//Erwartet:False
//Ergebnis:False

Console.WriteLine("drücke Enter um fortzufahren");
Console.ReadLine();

int z = 50; 
bool numeric = z > 47 && z < 58;
Console.WriteLine(z);

//Erwartet:50
//Ergebnis:50