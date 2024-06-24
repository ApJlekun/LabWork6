using Class;

class Program 
{
    static void Main(string[] args)
    {
        var orders = new List<Order>
            {
                new Order("Владислав Казнин", "ул. Пушкина, д. 1", 10000.50),
                new Order("Никита Попов", "ул. Лермонтова, д. 5", 149.75),
                new Order("Речицкий Санечка", "ул. Толстого, д. 10", 150.30),
                new Order("Илья Першин", "ул. Гоголя, д. 3", 50.20),
                new Order("Илья Голышев", "ул. Пушкина д. Колотушкино", 69.01)
            };

        var order1 = new Order();
        order1.PrintCustomersByAddress("ул. Пушкина, д. 1", orders);
        Console.WriteLine();

        var order2 = new Order();
        order2.PrintCustomersByAmount(150, orders);

        Console.WriteLine($"Power {Power(2, 3)}");
        Console.WriteLine($"Square {Square(4)}");

            double squarePerimeter;
            squarePerimeter = CalculatePerimeter(5);
        Console.WriteLine($"Периметр: {squarePerimeter}");

        double rectanglePerimeter;
            rectanglePerimeter = CalculatePerimeter(7, 3);

        Console.WriteLine($"Периметр: {rectanglePerimeter}");
    }

        static double CalculatePerimeter(double sideLength)
        {
            return 4 * sideLength;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
    static int Power(int x, int n)
    {
        if (n < 0)
            return -1;

        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }
        return result;
    }

    static int Square(int x)
    {
        if (x < 0)
            return -1;

        return x * x;
    }
}

