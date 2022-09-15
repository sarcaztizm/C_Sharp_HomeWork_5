// Массив заполенный случайными трехзначными числами.
// Показать количество четных чисел в массив

Console.Clear();

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] MyArray = new int[N];

void ArrayInput (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int CountArray(int [] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        Count++;
    }
    return Count;
}

ArrayInput (MyArray);
Console.WriteLine($"Массив на {N} элементов:");
PrintArray (MyArray);
Console.WriteLine("Количество четных чисел в массиве: " + CountArray(MyArray));