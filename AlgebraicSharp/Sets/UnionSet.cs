namespace AlgebraicSharp.Sets;

public class UnionSet : ISet
{
    public ISet A { get; set; }

    public ISet B { get; set; }

    public UnionSet(ISet a, ISet b)
    {
        A = a;
        B = b;
    }

    public bool IsIn(ISet set) =>
        A.IsIn(set) || B.IsIn(set);
}