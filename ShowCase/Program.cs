using static AlgebraicSharp.Calculus;

double n = 10;

var f = x - x + x;
 
WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);