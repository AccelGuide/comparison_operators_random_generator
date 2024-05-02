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
            /*
             * Die Methode random.Next(1, 6) würde in disem Fall nicht korrekt sein,
             * wenn zwischen sechs verschiedenen Vergleichsoperatoren ausgewählt werden solte.
             * Wenn du also zufällig einen von sechs Operatoren wählen möchtest, sollte der Aufruf random.Next(1, 7) lauten. Dies gibt dir eine zufällige Ganzzahl von 1 bis einschließlich 6. Hier sind die Optionen:
             *
             *    1: größer als (>)
             *    2: größer oder gleich (>=)
             *    3: gleich (==)
             *    4: kleiner als (<)
             *    5: kleiner oder gleich (<=)
             *    6: ungleich (!=)

             *  ----> Mit random.Next(1, 7) deckt man somit alle sechs Möglichkeiten ab.
             */
            bool result;

            switch (operatorChoice)
            {
                case 1:
                    result = value1 > value2;
                    Console.WriteLine($"{value1} > {value2} = {result}");
                    // Console.WriteLine(String.Format("{0} > {1} = {2}", value1, value2, result));
                    // Console.WriteLine(value1 + " > " + value2 + " = " + result);
                    /*
                     * Erklärung:
                     * -----
                     * String.Format: Diese Methode nimmt eine Formatzeichenkette und eine Liste von Argumenten.
                     * Die Platzhalter {0}, {1}, {2} usw. in der Formatzeichenkette werden durch die entsprechenden Argumente ersetzt.
                     * In diesem Beispiel entspricht {0} value1, {1} value2 und {2} result.
                     * -----
                     * String-Konkatenation: Hierbei verbindest du einfach Teile der Nachricht durch das +-Zeichen.
                     * Dies ist weniger effizient als String.Format oder String Interpolation,
                     * besonders wenn viele Strings zusammengefügt werden, da es mehr temporäre String-Objekte erzeugt.
                     */
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
