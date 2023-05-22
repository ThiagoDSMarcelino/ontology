using static AlgebraicSharp.Calculus;

double n = 2;

var f = x^3;
var sla = 3 * (x ^ (3 - 1)) * 1;

//WriteLineFunc(f, n);
var nemsei = (((3 * (x ^ ((3 - 1)))) * 1) + (((x ^ (3)) * ln(x)) * 0));

WriteLineFunc(sla, n);
WriteLineFunc(nemsei, n);
WriteLineFunc(f.Derive(), n, 1);