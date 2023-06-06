using System;

namespace AlgebraicSharp;

public class BigNatural : IComparable, IDisposable
{
    private ulong a;

    private ulong b;

    public static BigNatural Parse(string str)
    {
        int splitCharacter = str.Length - 19;

        if (splitCharacter < 0)
            splitCharacter = 0;

        var parta = str[splitCharacter..];
        
        var partb = str[..splitCharacter];

        BigNatural bg = new()
        {
            a = ulong.Parse(parta)
        };

        if (partb.Length > 0)
            bg.b = ulong.Parse(partb);
        
        return bg;
    }

    public static BigNatural operator +(BigNatural n1, BigNatural n2)
    {
        BigNatural result = new()
        {
            b = n1.b + n2.b
        };

        result.b = n1.a + n2.a;

        return result;
    }

    public static bool operator ==(BigNatural n1, BigNatural n2) =>
        n1.CompareTo(n2) == 0;

    public static bool operator !=(BigNatural n1, BigNatural n2) =>
        n1.CompareTo(n2) != 0;

    public static bool operator <(BigNatural left, BigNatural right) =>
        left is null ? right is not null : left.CompareTo(right) < 0;

    public static bool operator >(BigNatural left, BigNatural right) =>
        left is not null && left.CompareTo(right) > 0;

    public static bool operator <=(BigNatural left, BigNatural right) =>
        left is null || left.CompareTo(right) <= 0;

    public static bool operator >=(BigNatural left, BigNatural right) =>
        left is null ? right is null : left.CompareTo(right) >= 0;

    public static explicit operator BigNatural(int i)
    {
        BigNatural n = new()
        {
            a = (ulong)i
        };

        return n;
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException();

        if (obj is BigNatural bn)
        {
            if (b > bn.b)
                return 1;

            else if (b < bn.b)
                return -1;

            else
                return (int)(a - bn.a);
        }
        else if (obj is int i)
        {
            if (b > 0)
                return 1;

            if (i < 0)
                return 1;

            return (int)(a - (ulong)i);
        }
        else if (obj is ulong u)
        {
            if (b > 0)
                return 1;

            return (int)(a - u);
        }

        throw new InvalidOperationException();
    }

    public void Dispose() { }

    public override string ToString() =>
        b.ToString("00000000000000000000") +
        a.ToString("0000000000000000000");

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        if (obj is null)
            return false;

        throw new NotImplementedException();
    }

    public override int GetHashCode() =>
        base.GetHashCode();
}