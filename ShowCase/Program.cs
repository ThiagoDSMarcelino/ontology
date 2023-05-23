using static AlgebraicSharp.Calculus;
using System;

double n = 2;

var f = x * x * x;
Console.WriteLine(f.Derive());

//WriteLineFunc(f, n);
//WriteLineFunc(f.Derive(), n, 1);