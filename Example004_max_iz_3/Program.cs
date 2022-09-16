//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Vvedite chislo A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Vvedite chislo B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Vvedite chislo C: ");
int numberC = int.Parse(Console.ReadLine());
if(numberA > numberB & numberA > numberC)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
else if(numberB > numberA & numberB > numberC)
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
}
else if(numberC > numberA & numberC > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberC);
}
else
{
    Console.Write("Chisla ravny ");
}
