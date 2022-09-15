// Задан массив вещественных чисел. 
// Найти разницу между максимальным и минимальным элементом.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] MyArray = new int[N];

void ArrayInput (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
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

int ArrayScope (int[] array)
{
    int Scope = 0, max = array[0], min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine ("Минимальное значение массива: " + min);
    Console.WriteLine ("Максимальное значение массива: " + max);
    Scope = max - min;
    return Scope;
}

ArrayInput (MyArray);
Console.WriteLine($"Массив на {N} элементов:");
PrintArray (MyArray);
Console.WriteLine ("Разница между максимальным и минимальным элеметами массива равна: " +ArrayScope(MyArray));