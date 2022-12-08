// Задача 29 Заполнение восьмимерного массива числами

int[] arr = new int[8];
int i = 0;
while (i < arr.Length)
{
    arr[i] = new Random().Next(1, 100);
    i++;
}
for (int k = 0; k < arr.Length; k++)
{
    Console.Write(arr[k] + " ");
}
Console.WriteLine();