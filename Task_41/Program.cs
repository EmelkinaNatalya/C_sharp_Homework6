// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] Array = CreateArray();
Console.WriteLine ("Введённые числа:");
ShowArray(Array);
Console.WriteLine ("Количество введенных чисел больше 0:");
CountPositive (Array);
Console.WriteLine(CountPositive (Array));

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов для анализа");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}




void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountPositive (int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) 
        count++;
    }
    return count;
}