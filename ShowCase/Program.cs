using static AlgebraicSharp.Calculus;

double n = 2;

var f = x^3;

WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n, 1);