using Number;

Mohasebe mohasebe = new Mohasebe();
Console.WriteLine("Welcome");
Console.WriteLine("Information App: Daryaft Add Va Tabdil Be Aval Ya Aynei ");
Console.WriteLine("*************************************************************************");
Console.WriteLine("1: Add Aval");
Console.WriteLine("2: Add Aynei");
Console.WriteLine("*************************************************************************");
Console.Write("Pealse Enter Number (1/2):");
int quiz = int.Parse(Console.ReadLine());

if (quiz == 1)
{
    Console.WriteLine("Adad Aval:");
    mohasebe.AddAval();
}
else if (quiz == 2)
{
    mohasebe.AddAynei();
}
else 
{
    Console.WriteLine("Error");
    return;
}


