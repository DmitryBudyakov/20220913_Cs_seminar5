// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// Оставшийся непарный элемент (в нечётном массиве) записать в конце нового массива.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1) Console.Write(array[i]);
//         // else Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine("]");
// }

string PrintArrayAsString(int[] array)  // возвращает элементы массива в виде строки типа [1, 2, 3]
{
    string output = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) output += array[i];
        // else output += $"{array[i]}, ";
        else output += $"{array[i]} ";
    }
    return $"[{output}]";
}

int[] ProductCouplesInArray(int[] array)
{
    int length = array.Length;
    int[] productArray;
    if (length % 2 == 0) productArray = new int[length / 2];
    else productArray = new int[length / 2 + 1];

    int j = length - 1;
    for (int i = 0; i < productArray.Length; i++)
    {
        if (i == j) productArray[i] = array[i];
        // {
        //     productArray[i] = array[i];
        //     Console.WriteLine($"i={i}, j={j}: {productArray[i]}");
        // }
        else productArray[i] = array[i] * array[j];
        // {
        //     productArray[i] = array[i] * array[j];
        //     Console.WriteLine($"i={i}, j={j}: {productArray[i]}");
        // }
        j--;
    }
    return productArray;
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

// массив с произведением пар
int[] resultArray = ProductCouplesInArray(arr);
// вывод массива с произведениями в консоль
// PrintArray(resultArray);

// вывод массива с произведениями в строку
string resultArrayOut = PrintArrayAsString(resultArray);

// вывод в консоль результата
Console.WriteLine($"Произведение элементов массива {initArrayOut} -> {resultArrayOut}");
