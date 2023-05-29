using AlgebraicSharp.Functions;
using static AlgebraicSharp.Calculus;

double n = 2;

IFunction f = 2;

WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);