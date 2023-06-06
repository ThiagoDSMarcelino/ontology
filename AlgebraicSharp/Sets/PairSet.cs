namespace AlgebraicSharp.Sets;

public class PairSet : ISet
{
    public ISet A { get; set; }

    public ISet B { get; set; }

    public PairSet(ISet a, ISet b)
    {
        A = a;
        B = b;
    }

    public bool IsIn(ISet set) =>
        A.Equals(set) || B.Equals(set);
    
    public override bool Equals(object obj)
    {
        if (obj is PairSet pair)
        {
            return
                (pair.A.Equals(A) && pair.B.Equals(B)) ||
                (pair.A.Equals(B) && pair.B.Equals(A)) ||
                (pair.A.Equals(pair.B) && (pair.A.Equals(A) ||
                pair.A.Equals(B)));
        }

        return false;
    }

    public override int GetHashCode() =>
        base.GetHashCode();
}