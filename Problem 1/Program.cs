// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    for(int i=0; i< array.Length; i++)
        array[i] = new Random().Next(100,999);
}

System.Console.WriteLine("Какой длины будет ваш массив?");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int [lenght];
FillArray(array);
System.Console.WriteLine("[{0}]",string.Join(", ", array));
int count = 0;
for(int i=0; i< array.Length; i++)
{
    if (array[i]%2 == 0)
    count++;
}
System.Console.WriteLine($"Количество четных чисел в вашем массиве: {count}");