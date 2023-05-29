using System.Collections.Generic;
using System.Collections;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class Matrix : IMatrix, IEnumerable
{
    public int Row { get; protected set; }

    public int Columns { get; protected set; }
    
    public abstract char Symbol { get; set; }

    public IMatrix this[double x] =>
        throw new System.NotImplementedException();

    public IFunction this[int row, int col] =>
        throw new System.NotImplementedException();

    public abstract IMatrix Derive();

    public abstract IMatrix Integrate();

    public abstract IMatrix Simplify();

    public abstract override string ToString();
    
    public IEnumerator<IFunction> GetEnumerator() =>
        throw new System.NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() =>
        throw new System.NotImplementedException();
}