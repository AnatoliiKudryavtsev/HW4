// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{IntSum(Number)}");
int IntSum(int Number)
{
    int sum=0;
    for ( ;Number > 0; )
    
    {
        sum += Number % 10;
        Number /= 10;
    }
    return sum;
}
