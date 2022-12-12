//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

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

int sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);
Console.WriteLine(sum(array));