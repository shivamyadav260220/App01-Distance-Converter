using System;
    class DistanceCalculator
{
        static void Main(string[] args)
        {
            int fromUnit, toUnit;
            double distance;

            while (true) // keep looping until a valid input is entered
            {
                Console.WriteLine("Please select the unit to convert from:");
                Console.WriteLine("1. Miles");
                Console.WriteLine("2. Feet");
                Console.WriteLine("3. Metres");

                if (!int.TryParse(Console.ReadLine(), out fromUnit) || fromUnit < 1 || fromUnit > 3)
                {
                    Console.WriteLine("Invalid unit choice. Please try again.");
                    continue; // repeat the loop
                }

                break; // exit the loop if a valid input is entered
            }

            while (true) // repeat the same logic for the toUnit selection
            {
                Console.WriteLine("Please select the unit to convert to:");
                Console.WriteLine("1. Miles");
                Console.WriteLine("2. Feet");
                Console.WriteLine("3. Metres");

                if (!int.TryParse(Console.ReadLine(), out toUnit) || toUnit < 1 || toUnit > 3)
                {
                    Console.WriteLine("Invalid unit choice. Please try again.");
                    continue;
                }

                break;
            }

            while (true) // repeat the same logic for the distance input
            {
                Console.WriteLine("Please enter the distance to convert:");

                if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
                {
                    Console.WriteLine("Invalid distance entered. Please try again.");
                    continue;
                }

                break;
            }

            double result = 0;

            // perform the conversion based on the selected units
            switch (fromUnit)
            {
                case 1: // miles
                    if (toUnit == 2)
                        result = distance * 5280; // miles to feet
                    else if (toUnit == 3)
                        result = distance * 1609.34; // miles to metres
                    else
                        result = distance; // no conversion needed
                    break;
                case 2: // feet
                    if (toUnit == 1)
                        result = distance / 5280; // feet to miles
                    else if (toUnit == 3)
                        result = distance / 3.28084; // feet to metres
                    else
                        result = distance; // no conversion needed
                    break;
                case 3: // metres
                    if (toUnit == 1)
                        result = distance / 1609.34; // metres to miles
                    else if (toUnit == 2)
                        result = distance * 3.28084; // metres to feet
                    else
                        result = distance; // no conversion needed
                    break;
            }

            Console.WriteLine($"The converted distance is: {result} {(toUnit == 1 ? "miles" : (toUnit == 2 ? "feet" : "metres"))}");
            Console.ReadLine();
        }
    }

