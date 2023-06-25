namespace Ontology.Functions.Trigonometry.Inverse;

public class InverseSine : IFunction
{
    private readonly IFunction u;
    public InverseSine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        System.Math.Asin(x);

    public IFunction Derive() =>
        u.Derive() / ((1 - (u^2)) | 2);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arcsin({u})";
}