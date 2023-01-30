// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool CheckingArray(int min, int max, int size)
{
    if (max >= min || size == 0)
    {
        System.Console.WriteLine("MAX значение должно быть больше MIN значения и количество элементов в массиве не должно ровняться 0!");
        return false;
    }
    return true;
}

int[] CreateArray(int size, int min, int max)
{
    int[] massiv = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(min, max);
    }
    return massiv;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
}

int size = InputInt("Введите количество элементов массива");
int min = InputInt("Введите MIN значение числа в массиве");
int max = InputInt("Введите MAX значение числа в массиве");

if (CheckingArray(size, min, max))
{
    int[] array = CreateArray(size, min, max);
    PrintArray(array);
}