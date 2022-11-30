// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];
if (m <= 0)
{
    Console.WriteLine("Только положительные числа.");
    return;
}
void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} чисел:");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

InputNumbers(m);

int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine (string.Join(", ", massiveNumbers) + $" -> {Comparison(massiveNumbers)} ");