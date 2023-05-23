using static AlgebraicSharp.Calculus;

double n = 3;

var f =  -x - x - x;

WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n, 1);