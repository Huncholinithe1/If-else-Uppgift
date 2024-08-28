using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Skriv in ett nummer");
string UserNum = Console.ReadLine();
int number;
if (int.TryParse(UserNum, out number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Ditt tal ät ett jämnt tal");
    }
    else
    {
        Console.WriteLine("Ditt tal är udda");
    }
}
Console.ReadLine();

