using System;

/// class for transpose visitor.
public class TransposeVisitor : ITransposeVisitor
{
    public Matrix Transpose(Matrix matrix)
    {
        int[,] data = matrix.Data;
        int[,] transposedData = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transposedData[i, j] = data[j, i];
            }
        }

        return new Matrix(transposedData);
    }
}
