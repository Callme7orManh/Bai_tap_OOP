namespace BTVN_1
{
    class Program
    {
        static void Ex1() // Turn the letter into capital
        {
            char letter;
            int Capital;

            Console.Write("The letter you want to capitalize: ");
            letter = Convert.ToChar(Console.ReadLine());

            Capital = (int)letter - 32;    // Change to number
            letter = (char)Capital;  // Change to capital letter
            Console.WriteLine(letter);

        }
        static void Ex2() // Check 3 point are in the straight line
        {
            int x1, y1, x2, y2, x3, y3;
            double pttd_a, pttd_b;

            Console.Write("First point coordinates: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second point coordinates: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Third point coordinates: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            pttd_a = (y1 - y2) / (x1 - x2);
            pttd_b = y1 - x1 * (y1 - y2) / (x1 - x2);

            if (pttd_a * x3 - pttd_b - y3 == 0) // check if the 3rd point is on the same line with the other 2 points
            {
                Console.Write("All the three points fall on one straight line.");
            }
            else
            {
                Console.Write("All the three points do not fall on one straight line..");
            }
        }
        static void Ex3() // Check if the point is in or outside the circle
        {
            int x, y, x_check, y_check;
            double radius, distance;

            Console.Write("The coordinates of the circle center: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("The radius of the circle: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("The coordinates of the point: ");
            x_check = Convert.ToInt32(Console.ReadLine());
            y_check = Convert.ToInt32(Console.ReadLine());

            // The distance of the circle and the point
            distance = Math.Sqrt((x - x_check) * (x - x_check) + (y - y_check) * (y - y_check));

            if (distance > radius)  // If the distance > radius them the point is outsdide the circle
            {
                Console.Write("The point is outside the circle.");
            }
            else  // If the distance <= radius then the point is inside the circle
            {
                Console.Write("The point is inside the circle.");
            }
        }
        static void Ex4() // What is the character entered is
        {
            int test;
            char check;
            Console.Write("Enter the character: ");
            check = Convert.ToChar(Console.ReadLine());

            test = (int)check;
            if ((test < 48) || (57 < test && test < 65) || (90 < test && test < 97) || (test > 122))
            {
                Console.Write("The character entered is a special symbol.");
            }
            else if (48 <= test && test <= 57)
            {
                Console.Write("The character entered is a digit.");
            }
            else if (65 <= test && test <= 90)
            {
                Console.Write("The character entered is a capital letter.");
            }
            else
            {
                Console.Write("The character entered is a small case letter.");
            }
        }
        static void Ex5() // Conversion 
        {
            char choose;
            int typeofchange;

            Console.Write("Nhap cach muon chuyen doi: ");
            choose = Convert.ToChar(Console.ReadLine());

            typeofchange = (int)choose;

            switch (typeofchange)
            {
                case 73:
                    double inch, cm;

                    Console.Write("Inches = ");
                    inch = Convert.ToDouble(Console.ReadLine());

                    cm = inch * 2.54;

                    Console.Write("=> Centimeters = {0}", cm);

                    break;
                case 71:
                    double gallon, lit;

                    Console.Write("Gallons = ");
                    gallon = Convert.ToDouble(Console.ReadLine());

                    lit = 3.785411784 * gallon;

                    Console.Write("=> Liters = {0}", lit);

                    break;
                case 77:
                    double m, km;

                    Console.Write("Mile = ");
                    m = Convert.ToDouble(Console.ReadLine());

                    km = 1.609344 * m;

                    Console.Write("=> Kilometer = {0}", km);

                    break;
                case 80:
                    double pound, kg;

                    Console.Write("Pound = ");
                    pound = Convert.ToDouble(Console.ReadLine());

                    kg = 0.45359237 * pound;

                    Console.Write("=> Kilogram = {0}", kg);

                    break;
                default:
                    Console.Write("The conversion is not suitable.");
                    break;
            }
        }
        static void Ex6() // Check the efficiency 
        {
            int work_time;

            Console.Write("The time taken by the worker: ");
            work_time = Convert.ToInt32(Console.ReadLine());

            if (work_time >= 2 && work_time <= 3)
            {
                Console.Write("The worker is highly efficient.");
            }
            else if (work_time >= 3 && work_time <= 4)
            {
                Console.Write("The worker need to increase the speed.");
            }
            else if (work_time >= 4 && work_time <= 5)
            {
                Console.Write("The worker is given a training.");
            }
            else
            {
                Console.Write("The worker must leave the company.");
            }
        }
        static void Ex7() // Check if the year is leap or not
        {
            int year;

            Console.Write("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write((year % 4 == 0 && year % 100 != 0) ? "The year is leap." : "The year is not leap.");
        }
        static void Ex8() // Check the character entered is
        {
            string check;

            Console.Write("Enter the character: ");
            check = Convert.ToString(Console.ReadLine());

            switch (check)  // What is check depend on what case it go to
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                case "++":
                case "--":
                    Console.WriteLine("Arithmetic operator");
                    break;
                case "&":
                case "||":
                case "!":
                    Console.WriteLine("Logical operator");
                    break;
                case "?":
                    Console.WriteLine("Conditional operator");
                    break;
                case "==":
                case "!=":
                case ">":
                case "<":
                case ">=":
                case "<=":
                    Console.WriteLine("Relational operator");
                    break;
                default:
                    Console.WriteLine("Something else");
                    break;
            }

        }
        static void Ex9() // Identity matrix 
        {
            int[,] IdenMatrix; // 2 dimension array
            int n;

            Console.Write("The size of the matrix: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) // The value in the position ij will be one while the others is 0
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Ex10() //Print the series 1 2 4...2^n
        {
            int n;
            double seiries;

            Console.Write("The power of the series: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                seiries = Math.Pow(2, i);
                Console.Write(seiries); // print the 2^n 
                Console.Write(" ");
            }
        }
        static void Ex11() // Print the character series
        {
            int x = 1, output = 64;
            for( x = 1; x < 26; x*= 2)  // only in the alphabet
            {
                Console.Write((char)(output + x) + " "); // the ascii of the upper case letter
                output = 64;
            }

        }
        static void Ex12() // Print the loop series 1 2 2 3 3 3 ... nth
        {
            int n;

            Console.Write("Enter the length of the series: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int output = i;
                for (int j = 0; j < i; j++)
                {
                    Console.Write(output + " "); // print the number by its value time
                }
            }
        }
        static void Ex13() // Print the ASCII value with while loop
        {
            int value = 0;
            while (value <= 255)
            {
                Console.Write((char)value + " ");
                value++;
            }
        }
        static void Ex14() // Print the ASCII values with do while loop
        {
            int value = 0;
            do
            {
                Console.Write((char)value + " ");
                value++;
            } while (value <= 255);
        }
        static void Main(string[] args)
        {
            Ex11();
        }
    }
}



