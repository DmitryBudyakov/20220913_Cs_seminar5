// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123 элементов.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int size, int min, int max)   // создает массив исходя из заданных пользователем данных
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

string PrintArrayAsString(int[] array)  // возвращает элементы массива в виде строки типа [1, 2, 3]
{
    string output = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) output += array[i];
        else output += $"{array[i]}, ";
    }
    return $"[{output}]";
}

int CountIsInRange(int[] array, int lowerRange = 10, int upperRange = 99)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= lowerRange && array[i] <= upperRange) count++;
    }

    return count;
}

// данные для создания массива
Console.Write("Введите кол-во элементов в массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент в массиве: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент в массиве: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());

// результат создания массива
int[] arr = CreateArray(arraySize, arrayMin, arrayMax);
// вывод массива в консоль
// PrintArray(arr);

// вывод массива в строку
string initArrayOut = PrintArrayAsString(arr);
// результат проверки вхождения в диапазон [10,99]
// int result = CountIsInRange(arr);
Console.Write("Задайте нижнюю границу диапазона: ");
int lowerNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте верхнюю границу диапазона: ");
int upperNum = Convert.ToInt32(Console.ReadLine());
int result = CountIsInRange(arr, lowerNum, upperNum);
// вывод в консоль результата
Console.WriteLine($"Вхождений в диапазон [{lowerNum},{upperNum}] в массиве {initArrayOut} -> {result}");
