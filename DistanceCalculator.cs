using System;
    class DistanceCalculator
    {
        static void Main(string[] args)
        {
            //Requesting to prompt the user to select which unit to convert from (Miles, Feet or Metres)
            Console.WriteLine("Please select the unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");

            //Validating weather the user has inputted the correct input, if not then there is an error message displayed
            int fromUnit;
            if (!int.TryParse(Console.ReadLine(), out fromUnit) || fromUnit < 1 || fromUnit > 3)
            {
                Console.WriteLine("Invalid unit choice");
                return;
            }

          //Requesting to Prompt the user to select which unit to convert to (Miles, feet or Metres)
            Console.WriteLine("Please select the unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            int toUnit;

            //Validating weather the user has inputted the correct input, if not then there is an error message displayed
             if (!int.TryParse(Console.ReadLine(), out toUnit) || toUnit < 1 || toUnit > 3)
            {
                Console.WriteLine("Invalid unit choice");
                return;
            }

            Console.WriteLine("Please enter the distance to convert:");
            double distance;
            if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Invalid distance entered");
                return;
            }

            double result;
            switch (fromUnit)
            {
                case 1: // Miles
                    result = distance * 5280.0;
                    break;
                case 2: // Feet
                    result = distance;
                    break;
                case 3: // Metres
                    result = distance * 3.28084;
                    break;
                default:
                    Console.WriteLine("Invalid unit choice");
                    return;
            }

            switch (toUnit)
            {
                case 1: // Miles
                    result /= 5280.0;
                    break;
                case 2: // Feet
                    // already in feet
                    break;
                case 3: // Metres
                    result /= 3.28084;
                    break;
                default:
                    Console.WriteLine("Invalid unit choice");
                    return;
            }
            //Displaying the output
            Console.WriteLine($"Result: {result} {toUnit}");
        }
    }
