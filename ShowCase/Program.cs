using static AlgebraicSharp.Calculus;

double n = 10;

var f = ln(x - 1);
 
WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);