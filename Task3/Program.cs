///Задайте массив случайных вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int length) //принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array) //этот цикл только для просмотров и тут нет индексов
        Console.Write($"{el} ");
    // for(int i =0; i < array.Length; i++)
    //  Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int max(int[] array)
{
    array[i] = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) ;
        array[i] = max;
    }
    return max;
}

int min(int[] array)
{
    array[i] = min;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min) ;
        array[i] = min;
    }
    return min;
}

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);
Console.WriteLine(max(array), min(array));
Console.WriteLine($"{max - min}");