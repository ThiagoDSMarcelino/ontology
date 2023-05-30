using System.Collections.Generic;
using System.Collections;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class Matrix : IEnumerable<IFunction>
{
    public int Rows { get; protected set; }

    public int Columns { get; protected set; }
    
    public abstract char Symbol { get; set; }

    public Matrix this[double x] =>
        throw new System.NotImplementedException();

    public IFunction this[int row, int col] =>
        throw new System.NotImplementedException();

    public abstract override string ToString();

    public IEnumerator<IFunction> GetEnumerator() =>
        throw new System.NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() =>
        throw new System.NotImplementedException();
}