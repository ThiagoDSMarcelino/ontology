namespace AlgebraicSharp;

public class ComplexNumber
{
    private double real;

    private double imaginary;

    public ComplexNumber(double real, double complex)
    {
        this.real = real;
        imaginary = complex;
    }

    public static bool operator ==(ComplexNumber X, ComplexNumber Y) =>
        X.real == Y.real && X.imaginary == Y.imaginary;

    public static bool operator !=(ComplexNumber X, ComplexNumber Y) =>
        X.real != Y.real || X.imaginary != Y.imaginary;
    
    public static ComplexNumber operator +(ComplexNumber X, ComplexNumber Y)
    {
        ComplexNumber result = new(0, 0)
        {
            real = X.real + Y.real,
            imaginary = X.imaginary + Y.imaginary
        };

        return result;
    }

    public static ComplexNumber operator -(ComplexNumber X, ComplexNumber Y)
    {
        ComplexNumber result = new(0, 0)
        {
            real = X.real - Y.real,
            imaginary = X.imaginary - Y.imaginary
        };

        return result;
    }

    public static ComplexNumber operator *(ComplexNumber X, ComplexNumber Y)
    {
        ComplexNumber result = new(0, 0);

        double
            xReal = X.real,
            xImaginary = X.imaginary,
            yReal = Y.real,
            yImaginary = Y.imaginary;

        result.real = xReal * yReal - xImaginary * yImaginary;
        result.imaginary = xReal * yImaginary + yReal * xImaginary;

        return result;
    }

    public static ComplexNumber operator /(ComplexNumber X, ComplexNumber Y)
    {
        ComplexNumber result = new(0, 0);

        double
            xReal = X.real,
            xImaginary = X.imaginary,
            yReal = Y.real,
            yImaginary = Y.imaginary,
            ySquare = yReal * yReal + yImaginary * yImaginary;

        result.real = (xReal * yReal + xImaginary * yImaginary) / ySquare;
        result.imaginary = (yReal * xImaginary - xReal * yImaginary) / ySquare;

        return result;
    }

    public override string ToString() =>
        $"{real} + {imaginary}i";

    public override bool Equals(object obj) =>
        base.Equals(obj);

    public override int GetHashCode() =>
        base.GetHashCode();
}