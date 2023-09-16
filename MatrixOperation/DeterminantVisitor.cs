using System;

/// class for determinant visitor.
public class DeterminantVisitor : IDeterminantVisitor
{
    public int CalculateDeterminant(Matrix matrix)
    {
        int[,] data = matrix.Data;
        return data[0, 0] * (data[1, 1] * data[2, 2] - data[1, 2] * data[2, 1]) -
               data[0, 1] * (data[1, 0] * data[2, 2] - data[1, 2] * data[2, 0]) +
               data[0, 2] * (data[1, 0] * data[2, 1] - data[1, 1] * data[2, 0]);
    }
}
