int[,] matrix = new int[4, 4];

// preenche a matriz com o número 1
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

// imprime a matriz
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}



// soma a diagonal primaria
int sumPrimaryDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sumPrimaryDiagonal += matrix[i, i];
}

// soma a diagonal secundaria
int sumSecondaryDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sumSecondaryDiagonal += matrix[i, matrix.GetLength(0) - 1 - i];
}

// imprime a soma das diagonais
Console.WriteLine("Soma da diagonal primaria: " + sumPrimaryDiagonal);
Console.WriteLine("Soma da diagonal secundaria: " + sumSecondaryDiagonal);





