// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

decimal[] numbers = { 2.4m, 8.6m, 1.9m, 4.1m, 2.9m };

decimal max = numbers[0];
decimal min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
 if (numbers[i] > max)
     {
     max = numbers[i];
     }
     if (numbers[i] < min)
    {
        min = numbers[i];
     }
}
decimal diff = max - min;
Console.WriteLine($"Сумма максимального и минимального элементов равна {diff}");
