// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRandomArray()
{
    int[] array = new int[10];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}
int[] array = GetRandomArray();
int chetnie = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0)
    {
chetnie++;
    }
}

Console.WriteLine("Количество четных чисел:");
Console.WriteLine(String.Join(" , ", chetnie));