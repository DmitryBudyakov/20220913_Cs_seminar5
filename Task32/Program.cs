// Задача 32:
// Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
//         else Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
// }

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

int[] ChangeSignArrayElem(int[] array)  // меняет знаки элементов массива на противоположные
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -(array[i]);
    }

    return array;
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
// перечень элементов массива в виде строки в формате [1, 2, 3]
string initArrayOut = PrintArrayAsString(arr);
// массив после изменения в нем знаков элементов на противоположные
int[] resultArray = ChangeSignArrayElem(arr);
// перечень измененных элементов массива в виде строки в формате [-1, -2, -3]
string resultArrayOut = PrintArrayAsString(arr);
// вывод исходного и обраьотанного массивов в консоль
Console.WriteLine($"{initArrayOut} -> {resultArrayOut}");