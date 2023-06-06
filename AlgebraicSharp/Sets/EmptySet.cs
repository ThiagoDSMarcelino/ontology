namespace AlgebraicSharp.Sets;

public class EmptySet : ISet
{
    public bool IsIn(ISet set) =>
        false;
    
    public ISet Union(ISet set) =>
        set;
    
    public override bool Equals(object obj) =>
        obj is EmptySet;
}