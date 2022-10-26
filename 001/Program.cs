int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
    return array;
}
// Вывод мвссива на экран
void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}
// Поиск минимума
int MinPosition(int[] array)
{
    int min = array[0];
    foreach (int element in array)
    {
        if (min > element) min = element;
    }
    return min;
}
// Поиск максимума
int MaxPosition(int[] array)
{
    int max = array[0];
    foreach (int element in array)
    {
        if (max < element) max = element;
    }
    return max;
}
// Поиск суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    foreach (int element in array)
        sum += element;
    return sum;
}
// Поиск произведения элементов массива
int ProductArrayElement(int[] array)
{
    int product = 1;
    foreach (int element in array)
        product *= element;
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
// Подсчёт количества отрицательных элементов массива
int NegativeElementsArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element < 0)
            count++;
    return count;
}
// Подсчёт количества положительных элементов в массиве
int PositiveElementsArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element > 0)
            count++;
    return count;
}
// Подсчёт количества вхождений элемента в массив
int Count(int[]array, int check)
{
    int count=0;
    foreach(int element in array)
        if(check==element)
        count++;
    return count;    
}
// Подсчёт количества чётных элементов в массиве
int EvenElements(int[]array)
{
    int count=0;
    foreach(int element in array)
        if(element%2==0)
        count++;
    return count;    
}
// Подсчёт количества нечётных элементов в массиве
int OddElements(int[]array)
{
    int count=0;
    foreach(int element in array)
        if(element%2==1)
        count++;
    return count;    
}
// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortedArray(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
        if(array[i]>array[i+1])
        return false;
    return true;    
}
Console.WriteLine();
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[] array = CreateArray(length, 1, 10);
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
Console.Write($"Отрицательных элементов в массиве: {NegativeElementsArray(array)} ");
Console.WriteLine();
Console.Write($"Положительных элементов в массиве: {PositiveElementsArray(array)} ");
Console.WriteLine();
Console.Write($"Четных элементов в массиве: {EvenElements(array)} ");
Console.WriteLine();
Console.Write($"Нечетных элементов в массиве: {OddElements(array)} ");
Console.WriteLine();
Console.Write($"Является ли массив отсортированным: {SortedArray(array)} ");
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

Console.WriteLine();
Console.Write("Введите число для подсчёта количества вхождений элемента в массив: ");
int check = int.Parse(Console.ReadLine() ?? "0");
int count = Count(array, check);
Console.WriteLine($"Число {check} встречается {count} раз(а)");
Console.WriteLine();


