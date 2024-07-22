using System;

public class Program
{
    public static void Main(string[] args)
    {
        Rational rational1 = new Rational();

        Rational rational2 = new Rational(3, 4);
        Rational rational3 = new Rational(5, 6);

        rational1.WriteRational();
        rational2.WriteRational();

        rational2.Negate();
        Console.Write("After negation: ");
        rational2.WriteRational();
        rational2.Invert();
        Console.Write("After inversion: ");
        rational2.WriteRational();

        Console.WriteLine($"As double: {rational2.ToDouble()}");

        Rational reduced = rational2.Reduce();
        Console.Write("After reduction: ");
        reduced.WriteRational();

        Rational sum = rational2.Add(rational3);
        Console.Write("Sum of rational2 and rational3: ");
        sum.WriteRational();
    }
}