class Program
{
    static void PrintMatrix( int[,] matrix )
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write( matrix[i , j] + " " );
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] matrixData = new int[3, 3];
        Console.WriteLine("Enter a 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element at [{i},{j}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    matrixData[i, j] = element;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    j--;
                }
            }
        }

        Matrix matrix = new(matrixData);
        IDeterminantVisitor determinantVisitor = new DeterminantVisitor();
        ITransposeVisitor transposeVisitor = new TransposeVisitor();

        int determinant = matrix.Accept(determinantVisitor);
        Matrix transposedMatrix = matrix.Accept(transposeVisitor);

        Console.WriteLine($"Determinant of the matrix: {determinant}");
        Console.WriteLine("Transposed matrix:");
        PrintMatrix(transposedMatrix.Data);
    }

    
}
