//aufgabe 1

short short_max = short.MinValue;
Console.WriteLine(short_max);
Console.WriteLine(short.MaxValue+"\n");

/*
short
min:    -32768
max:    +32768
*/

Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue+"\n");

/*
integer
min:    -2147483647
max:    +2147483647
*/

Console.WriteLine(long.MinValue);
Console.WriteLine(long.MaxValue+"\n");

/*
long
min:    -9223372036854775807
max:    +9223372036854775807
*/

Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue + "\n");

/*
float
min:    -3,4028235E+38
max:    +3,4028235E+38
*/

Console.WriteLine(double.MinValue);
Console.WriteLine(double.MaxValue + "\n");

/*
double
min:    -1,7976931348623157E+308
max:    +1,7976931348623157E+308
*/

Console.WriteLine(decimal.MinValue);
Console.WriteLine(decimal.MaxValue + "\n");

/*
decimal
min:    -79228162514264337593543950335
max:    +79228162514264337593543950335
*/

Console.WriteLine("das war die aufgabe 1. click enter um fortzufahren");
Console.ReadLine();

//aufgabe 2

var vorname = "Nurullah";
short alter = 18;
bool antw = true;

Console.WriteLine($"Mein Name ist {vorname}. Ich bin Momentan {alter} und {antw} C# ist meine erste Programmiersprache");


Console.WriteLine("das war die aufgabe 2. click enter um fortzufahren");
Console.ReadLine();

//aufgabe 3

int DollarZahl = 36;
char Dollar = (char)DollarZahl;
Console.WriteLine(DollarZahl);
Console.WriteLine(Dollar);

Console.WriteLine("das war die aufgabe 3. click enter um fortzufahren");
Console.ReadLine();




// aufgabe 4

var eingabe = Console.ReadLine();
short short_number = Convert.ToInt16(eingabe);

Console.WriteLine(short_number / 10);

long long_number = Convert.ToInt64(eingabe);


Console.WriteLine();
























