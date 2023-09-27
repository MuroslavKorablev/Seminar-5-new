// Задача 33: Зажайте массив. Напишите программу, которая
// Определяет, присутствует ли заданое число в массиве.

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

bool FindNum(int number, int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == number) return true;
    }
    return false;
}

int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[] array = FillArray(size, minValue, maxValue);
int number = WorkWithUser("Введите число для поиска: ");
PrintArray(array);
System.Console.WriteLine();
if(FindNum(number, array)) System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");