


// Домашняя работа

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray2(rows, columns, -10, 10);
// PrintArray2(array);


// Задача 50. Напишите программу, которая на вход принимает число, 
// проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.

// int[,] array = GetArray(3, 4, 1, 10);
// PrintArray(array);
// Console.WriteLine($"Введите число:");
// int N = int.Parse(Console.ReadLine()!);
// if (Element(array, N))
// {
//    Console.WriteLine($"Число {N} есть в массиве"); 
// }
// else
// {
//    Console.WriteLine($"Числа {N} нет в массиве"); 
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] arifmet = GetArifmet(array);
Console.Write($"Среднее арифметическое каждого столбца = {String.Join(";", arifmet)}");

//-----------методы-----------------------

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}



double[,] GetArray2(int m, int n, int min, int max){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().NextDouble()* (max-min);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void PrintArray2(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}


bool Element(int[,] array, int N)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N) return true;
        }
    }
    return false;
}
    

double[] GetArifmet(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum+= array[j,i];
        }
        result[i]=Math.Round(sum/array.GetLength(0),2);
    }
    return result;
}