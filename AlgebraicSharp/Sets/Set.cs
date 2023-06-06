namespace AlgebraicSharp.Sets;

public interface ISet
{
    public abstract bool IsIn(ISet set);

    public virtual ISet Union(ISet set)
    {
        UnionSet unionSet = new(this, set);
        return unionSet;
    }

    public virtual ISet Intersect(ISet set)
    {
        IntersectSet unionSet = new(this, set);
        return unionSet;
    }
}