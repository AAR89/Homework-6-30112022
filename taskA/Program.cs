// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

// Console.Clear();
// int[] FillArray(int size) // вариант со случайным числом из массива
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
//     return arr;
// }
// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// int count = 0;

// Console.WriteLine(string.Join("", array));

// int[] newArray = new int[num];
// for (int i = 0; i < array.Length; i++)
// {
//     newArray[i] = array[i];
//     count = count + 1;
// }

// Console.WriteLine(string.Join("", newArray) + $" -> {count}");


Console.Clear();
Console.Write("Введите число: "); // вариант с вводом с клавиатуры
string? str = Console.ReadLine();
int count = str.Length;
void stringLength(int count)
{
    for (int i = 0; i < str.Length; i++)
    {
        count += 1;
        stringLength(count);
    }
}
Console.Write($"{str} -> {count}");
