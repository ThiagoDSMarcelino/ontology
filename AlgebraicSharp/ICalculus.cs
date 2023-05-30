namespace AlgebraicSharp;

public interface ICalculus<T>
{
    public T Derive();

    public T Integrate();

    public T Simplify();
}