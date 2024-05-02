using System;

    class comparison_operators_random_generator
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Taste drücken || ESC zum Beenden");

        do
        {
            // Generiere zwei zufällige Zahlen
            int value1 = random.Next(1, 100);
            int value2 = random.Next(1, 100);

            // Wählt zufällig einen Vergleichsoperator
            int operatorChoice = random.Next(1, 7);
            bool result;

            switch (operatorChoice)
            {
                case 1:
                    result = value1 > value2;
                    Console.WriteLine($"{value1} > {value2} = {result}");
                    // Console.WriteLine(String.Format("{0} > {1} = {2}", value1, value2, result));
                    // Console.WriteLine(value1 + " > " + value2 + " = " + result);
                    break;
                case 2:
                    result = value1 < value2;
                    Console.WriteLine($"{value1} < {value2} = {result}");
                    break;
                case 3:
                    result = value1 <= value2;
                    Console.WriteLine($"{value1} <= {value2} = {result}");
                    break;
                case 4:

                    result = value1 >= value2;
                    Console.WriteLine($"{value1} >= {value2} = {result}");
                    break;
                case 5:

                    result = value1 == value2;
                    Console.WriteLine($"{value1} == {value2} = {result}");
                    break;
                case 6:
                    result = value1 != value2;
                    Console.WriteLine($"{value1} != {value2} = {result}");
                    break;
            }

            Console.WriteLine("\n");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
