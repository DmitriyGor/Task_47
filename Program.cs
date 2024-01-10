/*
Задача 47: 
Задайте двумерный массив размером m x n, заполненный случайными вещественными числами
m = 3, n = 4.
0,5  7  -2 -0,2
1 -3,3 8 -9,9
8 7,8  -7,1  9
*/
Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число (верхний порог) для заполнения массива случайными вещественными числами, ");
Console.Write("нижний порог равен 0 : ");
int maxElements = Convert.ToInt32(Console.ReadLine());
double[,] resMatrix = GetMatrix (rows, columns, 1, 2 );
PrintMatrix(resMatrix); // PrintMatrix(матрица)
double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows,columns]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        
        matrix[i, j] =  Math.Round((new Random().NextDouble() * new Random().Next(1, 1))*maxElements,2);
     
       } 
    }
    return matrix;
}
// Метод, который печатает массив
void PrintMatrix(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
       Console.WriteLine();
    }

}
