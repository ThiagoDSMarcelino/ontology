using System.Linq;
using System.Text;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class MatrixFunction : Matrix
{
    public override char Symbol { get; set; }

    private IFunction[][] values { get; set; }

    public MatrixFunction(int rows, int columns, char symbol)
    {
        var matrix = new IFunction[rows][];
        for (int i = 0; i < matrix.Length; i++)
            matrix[i] = new IFunction[columns];
        
        values = matrix;
        Symbol = symbol;
    }

    public MatrixFunction(IFunction[][] matrix, char symbol)
    {
        values = matrix;
        Symbol = symbol;
    }

    public override Matrix Derive() =>
        throw new System.NotImplementedException();

    public override Matrix Integrate() =>
        throw new System.NotImplementedException();

    public override Matrix Simplify() =>
        throw new System.NotImplementedException();

    protected override string[] getRow(int index) =>
        values[index]
            .Select(x => x.ToString())
            .ToArray();
}