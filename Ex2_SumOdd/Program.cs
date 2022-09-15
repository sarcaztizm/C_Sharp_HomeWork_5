// Одномерный массив заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] MyArray = new int[N];

void ArrayInput (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int ArraySum (int [] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            Sum += array[i];
            
    }
    return Sum;
}

ArrayInput (MyArray);
Console.WriteLine($"Массив на {N} элементов:");
PrintArray (MyArray);
Console.WriteLine("Сумма элементов на нечетных позициях: " + ArraySum(MyArray));