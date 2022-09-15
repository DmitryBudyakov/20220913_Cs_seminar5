// Задача 33:
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsElemInArray(int[] array, int num)    // проверяет есть ли заданный элемент в массиве или нет
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = true;
            break;
        }
    }
    return result;
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
PrintArray(arr);
// вывод массива в строку
string initArrayOut = PrintArrayAsString(arr);
// задаём число, которое будем искать в массиве
Console.Write("Введите число для поиска в массиве: ");
int searchNum = Convert.ToInt32(Console.ReadLine());
// результат поиска
bool searchNumResult = IsElemInArray(arr, searchNum);
// вывод в консоль
if (searchNumResult) Console.WriteLine($"{searchNum}; массив {initArrayOut} -> да");
else Console.WriteLine($"{searchNum}; массив {initArrayOut} -> нет");
