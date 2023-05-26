using static AlgebraicSharp.Calculus;

double n = 0.5;

var f = log(x);

WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);