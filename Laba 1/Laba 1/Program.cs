﻿using System;
using System.Xml.Serialization;

class Matrix
{
    private int[,] data;

    public int Rows { get; private set; }
    public int Columns { get; private set; }

    // Конструктор для створення матриці заданого розміру
    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        data = new int[rows, columns];
    }

    // Індексатор для доступу до елементів матриці
    public int this[int row, int column]
    {
        get { return data[row, column]; }
        set { data[row, column] = value; }
    }

    // Метод для введення матриці з консолі
    public void InputMatrix()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write($"Введіть елемент [{i},{j}]: ");
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Метод для виведення матриці на консоль
    public void OutputMatrix()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для знаходження максимального елемента матриці
    public int FindMax()
    {
        int max = data[0, 0];
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (data[i, j] > max)
                {
                    max = data[i, j];
                }
            }
        }
        return max;
    }

    // Метод для знаходження мінімального елемента матриці
    public int FindMin()
    {
        int min = data[0, 0];
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (data[i, j] < min)
                {
                    min = data[i, j];
                }
            }
        }
        return min;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт матриці розміром 3x3

        Console.WriteLine("Введіть кількість рядків матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть кількість стовпців матриці:");
        int col = int.Parse(Console.ReadLine());
        Matrix matrix = new Matrix(row, col);

        Console.WriteLine("Бажаєте ввести матрицю вручну (введіть '1') чи згенерувати рандомну (введіть '2')?");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Введіть матрицю:");
            matrix.InputMatrix();
        }
        else if (choice == 2)
        {
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(-101, 101);
                }

            }
        }
        else
        {
            Console.WriteLine("Невірний вибір. Будь ласка, введіть '1' для введення вручну або '2' для генерації рандомно.");
            return;
        }



        // Вводимо матрицю з консолі


        // Виводимо матрицю на консоль
        Console.WriteLine("Матриця:");
        matrix.OutputMatrix();

        // Знаходимо та виводимо максимальний та мінімальний елементи
        int max = matrix.FindMax();
        int min = matrix.FindMin();
        Console.WriteLine($"Максимальний елемент: {max}");
        Console.WriteLine($"Мінімальний елемент: {min}");
    }
}
