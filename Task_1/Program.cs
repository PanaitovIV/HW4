// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Exponentiation(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

int x = InputInt("Введите число А");
int y = InputInt("Введите число В");
System.Console.WriteLine($"Число {x} в степени {y} равно {Exponentiation(x,y)}");