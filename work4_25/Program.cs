// Задача 25

int a = new Random().Next(1, 5);
int b = new Random().Next(1, 5);
int s = a;
for(int i = 0; i < b - 1; i++)
{
    s = s * a;
}
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine(a + " в степени " + b + " равно: "+ s);