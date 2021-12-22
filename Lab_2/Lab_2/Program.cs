Console.WriteLine("Введіть кількість даних");
int amount = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть дані строчкой за строчкой, щоб припинити напишіть stop");
double[] data = new double[amount];
int k = 0;
string s = Console.ReadLine().Trim();
while (s != "stop")
{
    data[k] = double.Parse(s);
    k++;
    s = Console.ReadLine().Trim();
}


Console.WriteLine("Введіть n для метода усереднення");
int n = int.Parse(Console.ReadLine());

double avarage = 0;
for (int i = amount - n; i < amount; i++)
{
    avarage += data[i];
}
avarage /= n;

Console.WriteLine("Введіть alpha для метода ЕКСПОНЕНЦIЙНОГО ЗГЛАДЖУВАННЯ");
double alpha = double.Parse(Console.ReadLine());
double[] result = new double[amount];
result[0] = data[0];
for (int i = 1; i < amount; i++)
{
    result[i] = alpha * data[i] + (1 - alpha) * result[i - 1];
}
Console.WriteLine($"МЕТОД ЗГЛАДЖУВАННЯ УСЕРЕДНЕННЯМ: {avarage} \n МЕТОД ЕКСПОНЕНЦІЙНОГО ЗГЛАДЖУВАННЯ: {result[amount - 1]}");
