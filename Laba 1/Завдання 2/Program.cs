using System;

public class TSquare
{
    private double sideLength;

    // Конструктори і методи класу TSquare

    public override string ToString()
    {
        return $"Квадрат зі стороною {sideLength}";
    }

    public double CalculateArea()
    {
        return sideLength * sideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * sideLength;
    }

    public bool CompareTo(TSquare otherSquare)
    {
        return this.sideLength == otherSquare.sideLength;
    }

    public static TSquare operator +(TSquare square1, TSquare square2)
    {
        double newSideLength = square1.sideLength + square2.sideLength;
        return new TSquare(newSideLength);
    }

    public static TSquare operator -(TSquare square1, TSquare square2)
    {
        double newSideLength = Math.Max(0, square1.sideLength - square2.sideLength);
        return new TSquare(newSideLength);
    }

    public static TSquare operator *(TSquare square, double multiplier)
    {
        double newSideLength = square.sideLength * multiplier;
        return new TSquare(newSideLength);
    }

    public TSquare()
    {
        sideLength = 0.0;
    }

    public TSquare(double side)
    {
        sideLength = side;
    }

    public TSquare(TSquare otherSquare)
    {
        sideLength = otherSquare.sideLength;
    }

    public void InputData()
    {
        Console.Write("Введіть довжину сторони квадрата: ");
        sideLength = double.Parse(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine(ToString());
        Console.WriteLine($"Площа: {CalculateArea()}");
        Console.WriteLine($"Периметр: {CalculatePerimeter()}");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу TSquare
        Console.WriteLine("Створення першого квадрата:");
        TSquare square1 = new TSquare();
        square1.InputData();
        square1.DisplayData();

        Console.WriteLine("\nСтворення другого квадрата:");
        TSquare square2 = new TSquare();
        square1.InputData();
        square1.DisplayData();

        Console.WriteLine("\nПеревірка на рівність двох квадратів:");
        bool areEqual = square1.CompareTo(square2);
        Console.WriteLine($"Квадрат 1 рівний квадрату 2: {areEqual}");

        Console.WriteLine("\nДодавання двох квадратів:");
        TSquare sumSquare = square1 + square2;
        sumSquare.DisplayData();

        Console.WriteLine("\nВіднімання другого квадрата від першого:");
        TSquare subSquare = square1 - square2;
        subSquare.DisplayData();

        Console.WriteLine("\nМноження першого квадрата на 2:");
        TSquare multSquare = square1 * 2;
        multSquare.DisplayData();
    }
}