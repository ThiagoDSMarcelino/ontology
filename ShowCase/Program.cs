using static AlgebraicSharp.Calculus;

double n = 0.13;

var f = arcsin(x);

//WriteLineFunc(f, n);
WriteLineFunc(f.Derive(), n);
System.Console.ReadKey(true);