string hello;
hello = "jopa";
string world = hello; // jopa slona
const int kek = 666;
string input = Console.ReadLine();
Console.WriteLine(input);
string reference;
int? value = int.Parse(Console.ReadLine());
if (value == 12)
    Console.WriteLine("Jopa slona");
else if (value == 13)
    Console.WriteLine("Jopa kota");
else
    Console.WriteLine("Prosto Jopa");

switch (input)
{
    case "o":
        Console.WriteLine("Jopa");
        break;
    case "p":
        Console.WriteLine("Jopaaa");
        break;
    default: Console.WriteLine("Jopka");
            break;
}
int number = 10;
string res = (number > 5) ? "Bigger than 5" : "Less than 5";

string a = "b";
while (a == "b")
    Console.WriteLine("Jopa");

int jopa = 10;
int bigjopa = 100;

for (int j = 0; j <= jopa; j++)
{
    Console.WriteLine("test");
}

for (int b = 0; b <= bigjopa; b++)
    Console.WriteLine(b);

bool uslovie = false;
do {     Console.WriteLine("hello");}while (uslovie);

int[] array = new int[5] { 1, 2, 3, 4, 5 };
foreach (int x in array)
    Console.WriteLine(x);

Console.WriteLine(array.Length);

DateTime Date = DateTime.Now;
Date = Date.AddYears(1);
String.Concat(input + " " + Date);

string aaa = $"Hi, my name is {input}";
try
{
    throw new Exception("error");
}
catch (Exception e)
{
    Console.WriteLine("error was caught" + e);
}
finally
{
    Console.WriteLine("jopa");
}












