// Задача 27. Найти сумму цифр в числе

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int s = 0;
while (a > 0)
    {
        s = s + a % 10;
        a = a /10;
    }
Console.WriteLine("Сумма цифр в числе равна " + s);