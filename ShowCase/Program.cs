using static AlgebraicSharp.Calculus;
using AlgebraicSharp;
using System;

var num = new Constant(60);
var calc = sin(num) * sin(num) / cos(num) * cos(num);

Console.Write($"f(x) = {calc}\nf({num}) = {calc[60]}");