Console.Write("Vvedite chislo A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Vvedite chislo B: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.WriteLine(numberB);
}
else if(numberB > numberA)
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
    Console.Write("min = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("max = min = ");
    Console.WriteLine(numberA);
}