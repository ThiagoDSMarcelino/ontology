using static AlgebraicSharp.Calculus;
using System;

double n = 1;

var f = log(x) - ln(x) + log(x, 5);


WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n, 1);