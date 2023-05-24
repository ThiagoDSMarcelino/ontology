using static AlgebraicSharp.Calculus;
using System;

double n = 0.13;

var f = arcsin(x);
var u = x ^ 2;
//1 / ((1 - (u ^ 2)) | 2);
//WriteLineFunc(f, n);

Console.WriteLine(u);
Console.WriteLine(u[n]);
Console.WriteLine();
WriteLineFunc(f.Derive(), n);