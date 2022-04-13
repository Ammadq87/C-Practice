using System;

namespace CalculatorApp 
{

    class Program
    {
        public static void Main (string[] args)
        {
            double value = 0;

            Console.WriteLine("+ - / *");
            char operation = Convert.ToChar(Console.ReadLine());
            while (operation != 'q')
            {
                switch (operation)
                {
                    case '+':
                        value = add(value);
                        break;
                    case '-':
                        value = sub(value);
                        break;
                    case '*':
                        value = mul(value);
                        break;
                    case '/':
                        value = div(value);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation Enetered");
                        break;
                }
                Console.WriteLine("= "+value);
                Console.WriteLine("\n+ - / *");
                operation = Convert.ToChar(Console.ReadLine());
            }
        }

        public static double div(double value)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            double x, y;

            if (Convert.ToDouble(Y) == 0.00)
            {
                Console.WriteLine("Error: Cannot Divide By 0");
                return value;
            }

            if (X.Equals("a") && Y.Equals("a"))
            {
                return 1;
            }

            if (X.Equals("a"))
            {
                return (value / Convert.ToDouble(Y));
            }

            if (Y.Equals("a"))
            {
                if (value != 0)
                {
                    return (Convert.ToDouble(X) / value);
                } else
                {
                    Console.WriteLine("Error: Cannot Divide By 0");
                    return 0;
                }
            }

            x = Convert.ToDouble(X);
            y = Convert.ToDouble(Y);

            return (x / y);
        }

        public static double mul(double value)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            double x, y;

            if (X.Equals("a") && Y.Equals("a"))
            {
                return value * value;
            }

            if (X.Equals("a"))
            {
                return (value * Convert.ToDouble(Y));
            }

            if (Y.Equals("a"))
            {
                return (value * Convert.ToDouble(X));
            }

            x = Convert.ToDouble(X);
            y = Convert.ToDouble(Y);

            return (x * y);
        }

        public static double sub(double value)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            double x, y;

            if (X.Equals("a") && Y.Equals("a"))
            {
                return 0;
            }

            if (X.Equals("a"))
            {
                return (value - Convert.ToDouble(Y));
            }

            if (Y.Equals("a"))
            {
                return (Convert.ToDouble(X) - value);
            }

            x = Convert.ToDouble(X);
            y = Convert.ToDouble(Y);

            return (x - y);
        }

        public static double add(double value)
        {

            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            double x, y;

            if (X.Equals("a") && Y.Equals("a"))
            {
                return 2 * value;
            }

            if (X.Equals("a"))
            {
                return (value + Convert.ToDouble(Y));
            }

            if (Y.Equals("a"))
            {
                return (value + Convert.ToDouble(X));
            }

            x = Convert.ToDouble(X);
            y = Convert.ToDouble(Y);

            return (x+y);
        }
    }


}
