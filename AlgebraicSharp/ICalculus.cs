namespace AlgebraicSharp;

public interface ICalculus<T>
{
    T Derive();

    T Integrate();

    T Simplify();
}