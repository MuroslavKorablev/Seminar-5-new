// Напишите программу замена элементов
// массива:  положительные эллементы замените
// на сответствующие отрицательные и наоборот.

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

void Opposite(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = inArray[i] * -1;
    }
}


int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[] array = FillArray(size, minValue, maxValue);
PrintArray(array);
System.Console.WriteLine();
Opposite(array);
PrintArray(array);

