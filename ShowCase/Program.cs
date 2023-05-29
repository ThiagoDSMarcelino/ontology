using static AlgebraicSharp.Calculus;

double n = 2;

var f = arccsc(x);

WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);