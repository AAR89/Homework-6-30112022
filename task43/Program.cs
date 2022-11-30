// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[,] graph = new double[2, 2];

void InputCoefficients()
{
    for (int i = 0; i < graph.GetLength(0); i++)
    {
        Console.Write(
            $"Введите коэффициенты для {i + 1} уравнения (y = k{i + 1} * x + b{i + 1})\n"
        );
        for (int j = 0; j < graph.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"\nВведите коэффициент k{i + 1}: ");
            else
                Console.Write($"Введите коэффициент b{i + 1}: ");
            graph[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
InputCoefficients();

double[] crossPoint = new double[2];
double[] Decision(double[,] graph)
{
    crossPoint[0] = (graph[1, 1] - graph[0, 1]) / (graph[0, 0] - graph[1, 0]);
    crossPoint[1] = crossPoint[0] * graph[0, 0] + graph[0, 1];
    return crossPoint;
}
void OutputResponse(double[,] graph)
{
    if (graph[0, 0] == graph[1, 0] && graph[0, 1] == graph[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (graph[0, 0] == graph[1, 0] && graph[0, 1] != graph[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Decision(graph);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}
OutputResponse(graph);
