using System.Collections.Generic;

namespace AlgebraicSharp.Matrix;

using Functions;

public interface IMatrix : IEnumerable<IFunction>
{
    public IMatrix this[double x] { get; }
    public IFunction this[int row, int col] { get; }

    IFunction Derive();
    IFunction Integrate();
    IFunction Simplify();
}