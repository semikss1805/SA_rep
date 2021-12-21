double[] first = new double[2];
Console.WriteLine("Введiть критерiй p");
first[0] = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть критерiй q");
first[1] = double.Parse(Console.ReadLine());

double[] second = new double[4];
Console.WriteLine("Введіть критерiї другого рiвня p1 та р2");
for (int i = 0; i < 2; i++)
{
    second[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Введiть критерiї другого рiвня q1 та q2");
for (int i = 2; i < 4; i++)
{
    second[i] = double.Parse(Console.ReadLine());
}

double[,] third = new double[3, 4];
Console.WriteLine("Введiть критерiї p[i,j] та q[i,j] для альтернативи 1");
for (int i = 0; i < 4; i++)
{
    third[0, i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Введiть критерiї p[i,j] та q[i,j] для альтернативи 2");
for (int i = 0; i < 4; i++)
{
    third[1, i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Введiть критерiї p[i,j] та q[i,j] для альтернативи 3");
for (int i = 0; i < 4; i++)
{
    third[2, i] = double.Parse(Console.ReadLine());
}

double[] result = new double[3];
double temp = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        result[i] += second[j] * third[i, j];
    }
    result[i] *= first[0];
    for (int j = 2; j < 4; j++)
    {
        temp += second[j] * third[i, j];
    }
    temp *= first[1];

    result[i] += temp;
    temp = 0;
}

double max = result[0];
int p = 1;
Console.WriteLine($"Вага альтернативи 1 = {result[0]}");
for (int i = 1; i < 3; i++)
{
    Console.WriteLine($"Вага альтернативи {i + 1} = {result[i]}");
    if (max < result[i])
    {
        max = result[i];
        p = i + 1;
    }
}
Console.WriteLine($"Максимальна вагу має альтернатива {p} i дорiвнює {max}");