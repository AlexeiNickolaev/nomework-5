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
// Поиск произведения элементов массива
int ProductArrayElement(int[] array)
{
    int product = 1;
    for (int i = 0; i < array.Length; i++)
        product *= array[i];
    return product;
}
// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int IndexSearch(int[] array, int search)
{
    int position = -1;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == search)
        {
            position = i;
            return position;
        }
    return position;
}
// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет
bool CheckingElementArray(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == find)
            return true;
    return false;
}
// Среднее арифметическое элеметов массива
float AverageArray(int[] array)
{
    return SumArray(array) / array.Length;
}

Console.WriteLine();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[] array = new int[size];

FillArray(array, 1, 15);
Console.WriteLine("Ваш массив ");

PrintArray(array);

Console.WriteLine();
Console.Write($"Минимальное значение: {MinPosition(array)} ");

Console.WriteLine();
Console.Write($"Максимальное значение: {MaxPosition(array)} ");

Console.WriteLine();
Console.Write($"Сумма элементов массива равна: {SumArray(array)} ");

Console.WriteLine();
Console.Write($"Произведение элементов массива равна: {ProductArrayElement(array)} ");

Console.WriteLine();
Console.Write($"Среднее арифметическое элементов массива равно: {AverageArray(array)} ");
Console.WriteLine();

Console.WriteLine();
Console.Write("Введите число для поиска индекса: ");
int search = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Индекс заданного числа равен: {IndexSearch(array, search)} ");
Console.WriteLine();

Console.WriteLine();
Console.Write("Введите число для проверки наличия в массиве: ");
int find = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Наличие данного числа в массиве: {CheckingElementArray(array, find)} ");
Console.WriteLine();

