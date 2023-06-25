// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//ФУНКЦИЯ ОБЩАЯ ДЛЯ 1 И 2 ЗАДАНИЯ СДЕЛАНА С ИСПОЛЬЗОВАНИЕМ ПЕРЕЗАГРУЗКИ
int[] CreateArrayInt(int sizeArr, int maxNumber = 1000, int minNumber = 100)
{
    int[] tempArr = new int[sizeArr];
    Random rnd = new Random();
    for (int i = 0; i < sizeArr; i++)
    {
        tempArr[i] = rnd.Next(minNumber, maxNumber + 1);
    }
    return tempArr;
}

int CountNumbers(int[] arr)
{
    int countNumbers = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        countNumbers += arr[i] % 2 == 0 ? 1 : 0;
    }
    return countNumbers;
}

// Console.Clear();
// System.Console.Write("Размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArrayInt(size);
// System.Console.Write("[" + string.Join(", ", array) + "]");
// System.Console.Write(" -> " + CountNumbers(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int countSumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            sum += arr[i];
    }
    return sum;
}

// Console.Clear();
// System.Console.Write("Размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Минимальное значение числа: ");
// int minSize = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Максимальное значение: ");
// int maxSize = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArrayInt(size, maxSize, minSize);
// System.Console.Write("[" + string.Join(", ", array) + "]");
// System.Console.Write(" -> " + countSumArray(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayDouble(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double d = rand.NextDouble();
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }
    return array;
}

void SearchMaxMin(double[] array, out double min, out double max)
{
    min = max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
}

double DifferenceMinMax(double min, double max)
{
    return Math.Round(max - min, 2);
}

Console.Clear();
System.Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayDouble(size);
System.Console.Write("[" + string.Join("; ", array) + "]");
SearchMaxMin(array, out double min, out double max);
System.Console.Write($" => {max} - {min} = {DifferenceMinMax(min, max)}");