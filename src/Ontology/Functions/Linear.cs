namespace Ontology.Functions;

internal class Linear : IFunction
{
    public double this[double x] =>
        x;

    public IFunction Derive() =>
        new Constant(1);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        "x";
}