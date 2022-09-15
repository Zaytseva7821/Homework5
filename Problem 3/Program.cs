// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillDoubleArray(double[] array)
{
    for(int i=0; i< array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble()*200, 2);
}

double FindMax(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;
}

System.Console.WriteLine("Какой длины будет ваш массив?");
int lenght = Convert.ToInt32(Console.ReadLine());
double[] array = new double [lenght];
FillDoubleArray(array);
System.Console.WriteLine("[{0}]",string.Join(", ", array));
double max = FindMax(array);
double min = FindMin(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max-min}");