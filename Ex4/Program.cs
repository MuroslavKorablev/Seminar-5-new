// Задайте одномернный масив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int size = 4;
int[] numbers = new int[size];
FillArray(numbers); 
PrintArray(numbers);
int count = CountNumInArray(10, 99, numbers);
Console.WriteLine(count);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 124);
    }
}


int CountNumInArray(int min, int max, int[] collection)
{
    int res = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= min && collection[i] <= max) res += 1;
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
