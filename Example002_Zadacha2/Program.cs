//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

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