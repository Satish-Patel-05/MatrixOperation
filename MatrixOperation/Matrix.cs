using System;

///class for a 3x3 matrix.
public class Matrix
{
    public int[,] Data { get; } 

    /// Initializes a new instance of the Matrix class.
    public Matrix(int[,] data)
    {
        Data = data;
    }

    /// Accepts a visitor to calculate the determinant.
    public int Accept(IDeterminantVisitor visitor)
    {
        return visitor.CalculateDeterminant(this);
    }

    /// Accepts a visitor to calculate the transpose.
    public Matrix Accept(ITransposeVisitor visitor)
    {
        return visitor.Transpose(this);
    }
}
