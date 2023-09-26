//  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
//  Из промежкутка [-9, 9].  найдите сумму отрмцательных и положительных элементов массива.
//  Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна
//  29, сумма отрицательных равна -20.


// FillArray(size, rand);
// PrintArray(size);
int WorkWithUser (string message)
{
    System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] FillArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random(); // Create random object
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min, max + 1); // Использолвание одного и того же Random
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] GetSums(int[] inArray)
{
    int[] res = new int[2];
    foreach (int el in inArray)
    {
        if (el > 0) res[0] += el;
        else res[1] += el;
    }
    PrintArray(res);
    return res;
}


int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("Введите максимальное значение диапазона: ");
int[] array = FillArray(size, minValue, maxValue);
PrintArray(array);
System.Console.WriteLine();
int[] sums = GetSums(array);
// Console.WriteLine($"Сумма положительных чисел равна {sums[0]}, сумма отрицательных {sums[1]}");
// int sumSums = sums[0] + sums[1];
// System.Console.WriteLine(sumSums);

;
// System.Console.WriteLine(string.Join(" ", size)); //Новая фитча Join просто имба

// void PrintArray(int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         System.Console.Write(collection[i] + " ");
//     }
// }


