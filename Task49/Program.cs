﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0 , 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // rows
{
for (int j = 0; j < matrix.GetLength(1); j++) // columns
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}


void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
else Console.Write($"{matrix[i, j], 3}");
}
Console.WriteLine("|");
}
}

void ReplaceEvenElems(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i += 2)
{
for (int j = 0; j < array.GetLength(1); j += 2)
{
array[i, j] *= array[i, j];
}
}
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);