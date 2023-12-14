// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f 

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

char[,] GenerateMatrix(int row, int column)
{
    char[,] matrix = new char[row, column];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            char randomChar = (char)('a' + rand.Next(26)); 
            matrix[i, j] = randomChar;
        }
    }
    return matrix;
}

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");  
        }
        Console.WriteLine();
    }
}

string GetStringFromMatrix(char[,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        str += matrix[i, j];
        }
    }
    return str;
}

Console.Clear();
int row = ReadInt("Введите количество строк матрицы: ");
int column = ReadInt("Введите количество столбцов матрицы: ");
char[,] charMatrix = GenerateMatrix(row, column);
PrintMatrix(charMatrix);

string str = GetStringFromMatrix(charMatrix);
System.Console.WriteLine("\n" + str);