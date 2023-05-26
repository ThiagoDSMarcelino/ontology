using static AlgebraicSharp.Calculus;

double n = 4;

var f = x - (x - 5);
 
WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);