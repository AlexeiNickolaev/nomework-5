void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}
// Вывод мвссива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
// Поиск минимума
int MinPosition(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
// Поиск максимума
int MaxPosition(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}
//Поиск суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    sum += array[i];
    return sum;
}

Console.WriteLine();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[] array = new int[size];

FillArray(array, 0, 15);
Console.WriteLine("Ваш массив ");

PrintArray(array);

Console.WriteLine();
Console.Write($"Минимальное значение: {MinPosition(array)} ");

Console.WriteLine();
Console.Write($"Максимальное значение: {MaxPosition(array)} ");

Console.WriteLine();
Console.Write($"Сумма элементов массива равна: {SumArray(array)} ");

