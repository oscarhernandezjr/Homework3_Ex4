using System;

public class Rational
{
    private int numerator;
    private int denominator;

    public Rational()
    {
        numerator = 0;
        denominator = 1;
    }

    public Rational(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public void WriteRational()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    public static void Negate()
    {
        numerator = -numerator;
    }

    public void Invert()
    {
        int temp = numerator;
        numerator = denominator;
        denominator = temp;
    }

    public double ToDouble()
    {
        return (double)numerator / denominator;
    }

    public Rational Reduce()
    {
        int gcd = GCD(numerator, denominator);
        return new Rational(numerator / gcd, denominator / gcd);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static Rational Add(Rational other)
    {
        int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator; // This will cause an error
        int newDenominator = this.denominator * other.denominator; // This will cause an error
        Rational result = new Rational(newNumerator, newDenominator);
        return result.Reduce();
    }
}

