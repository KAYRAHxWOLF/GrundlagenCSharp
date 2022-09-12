//aufgabe 1

Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
string input1 = Console.ReadLine();
Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
string input2 = Console.ReadLine();

int input11 = Convert.ToInt32(input1);
int input22 = Convert.ToInt32(input2);

if (input11 > input22)

    Console.WriteLine(input22);


else

    Console.WriteLine(input11);

w
Console.ReadLine();
Console.Clear();   


//aufgabe 2

{
    static void Main(string[] args)
    {
        string eing;
        int geraten;
        int geheim;
        int versuche = 0;
        Random zufall = new Random();
        geheim = zufall.Next(101);
        do
        {
            Console.Write("Rate eine Zahl von 0-1000: ");
            eing = Console.ReadLine();

            geraten = Convert.ToInt32(eing);

            if (geraten < geheim)
            {
                Console.WriteLine("Eingabe zu klein");
            }
            if (geraten > geheim)
            {
                Console.WriteLine("Eingabe zu groß");
            }
            versuche = versuche + 1;
        } while (geraten != geheim && versuche < 10);

        if (geraten == geheim)
        {
            Console.WriteLine("Super! Du hast nur " + versuche
            + " Versuche benötigt");
        }
        else
        {
            Console.WriteLine("Verloren es wäre " + geheim
                + " gewesen!");
        }
        Console.ReadKey();
    }
    
}
Console.ReadLine();
Console.Clear();


//aufgabe 3

Console.WriteLine("Herzenfakt - risikotest:\n Bitte beantworten sie die folgenden fragen \n Mit true = ja oder false = nein");
Console.WriteLine("Haben sie stress?");
bool S = Convert.ToBoolean(Console.ReadLine());
Console.SetCursorPosition(0, 3);
Console.WriteLine("Sind sie Fett?     \n       ");
Console.SetCursorPosition(0, 4);
bool F = Convert.ToBoolean(Console.ReadLine());
Console.Clear();
Console.WriteLine("Risiko nach tabelle:");
if (S == false && F == false)
    Console.WriteLine("5%");
else if (S == false && F == true)
    Console.WriteLine("18%");
else if (S == true && F == false)
    Console.WriteLine("15%");
else if (S == true && F == true)
    Console.WriteLine("62%");
Console.WriteLine("Press Enter to contnue!");
Console.ReadLine();
Console.Clear();

//aufgabe 4.1

Console.Clear();
Console.WriteLine("Zahl 1 bitte:");
double numm1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Zahl 2 bitte:");
double numm2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Bitte Rechenart anhand von nummerierung wählen:\n1.Addition\n2.Suptrakrion\n3.Multiplikation\n" +
    "4.Division\n5.Potez");
Console.Write("Operator:");
short numm3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");
if (numm3 == 1)
    Console.WriteLine(numm1 + numm2);
if (numm3 == 2)
    Console.WriteLine(numm1 - numm2);
if (numm3 == 3)
    Console.WriteLine(numm1 * numm2);
if (numm3 == 4)
    Console.WriteLine(numm1 / numm2);
if (numm3 == 5)
    Console.WriteLine(Math.Pow(numm1, numm2));
Console.WriteLine("Press Enter to continue!");
Console.ReadLine();
Console.Clear();

//aufgabe 4.2

Console.WriteLine("Die erste Zahl eingeben bitte:");
numm1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Die zweite Zahl eingeben bitte:");
numm2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Bitte Rechenart anhand von nummerierung wählen:\n1.Addition\n2.Suptrakrion\n3.Multiplikation\n" +
    "4.Division\n5.Potez");
Console.Write("Operator:");
numm3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");
switch (numm3)
{
    case 1:
        Console.WriteLine(numm1 + numm2);
        break;
    case 2:
        Console.WriteLine(numm1 - numm2);
        break;
    case 3:
        Console.WriteLine(numm1 * numm2);
        break;
    case 4:
        Console.WriteLine(numm1 / numm2);
        break;
    case 5:
        Console.WriteLine(Math.Pow(numm1, numm2));
        break;
}
Console.ReadLine();
Console.Clear();
