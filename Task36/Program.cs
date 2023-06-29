// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetRandomArray()
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}
int[] array = GetRandomArray();
int sum = 0;
for(int i = 1; i < array.Length; i+=2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма нечетных элементов равна = {sum}");