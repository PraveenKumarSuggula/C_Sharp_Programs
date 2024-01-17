#region Fibonacci using recurison
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static int p1=0,p2=1,p3;
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number");

//            int count = Int32.Parse(Console.ReadLine());
//            Console.Write(p1 + " " + p2);
//            Fibonacci(count - 2);
//            Console.WriteLine(); 
//        }
//        public static void Fibonacci(int count)
//        {
//            if (count > 0)
//            {
//                p3 = p1 + p2;
//                Console.Write(" " + p3);
//                p1 = p2;
//                p2 = p3;
//                Fibonacci(count - 1);
//            }
//        }
//    }
//}
#endregion

#region Fibonacci general method
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static void Main(String[] args)
//        {
//            int p1 = 0, p2 = 1, p3;
//            Console.WriteLine("Please enter a value");
//            int count = Int32.Parse(Console.ReadLine());
//            if(count > 0)
//            {
//                Console.Write(p1+" "+p2);
//                for (int i = 2; i<=count; i++)
//                {
//                    p3 = p1 + p2;   
//                    Console.Write(" "+p3);
//                    p1 = p2;
//                    p2 = p3;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Please enter a value greater than zero");
//            }
//        }
//    }
//}
#endregion

#region Fatorial general method
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static int factResult = 1;
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number");
//            int factNumber = Int32.Parse(Console.ReadLine());
//            if (factNumber > 0)
//            {
//                ////5! = 1*2*3*4*5
//                //for (int i = 1; i <= factNumber; i++)
//                //{
//                //    factResult = factResult * i;
//                //}

//                ////5! = 5*4*3*2*1
//                //    for (int i = factNumber; i >= 1; i--)
//                //    {
//                //        factResult = factResult * i;
//                //    }
//                //    Console.Write("{0}! is {1}", factNumber, factResult);
//            }
//            else
//            {
//                Console.WriteLine("Please enter a number greater than zero");

//            }
//        }
//    }
//}
#endregion

#region Fatorial recursion method
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static int factResult = 1;
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number");
//            int factNumber = Int32.Parse(Console.ReadLine());
//            if (factNumber > 0)
//            {
//                int result = factorialCalculation(factNumber);
//                Console.WriteLine("{0}! is {1}", factNumber, result);
//            }
//            else
//            {
//                Console.WriteLine("Please enter a number greater than zero");
//            }
//        }
//        public static int factorialCalculation(int factnumber)
//        {
//            int fact = 1;
//            if (factnumber > 0)
//            {
//                fact = factnumber * factorialCalculation(factnumber - 1);
//            }
//            return fact;
//        }
//    }
//}
#endregion

#region Sum of Digits of a given number
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number");
//            int inputNumber = Int32.Parse(Console.ReadLine());
//            int backupNumber = inputNumber; //ex:123
//            int sum = 0, remainder = 0;
//            //while (inputNumber != 0)
//            //{
//            for (int i = 1; i <= inputNumber; i++)
//            {
//                remainder = inputNumber % 10; //3
//                sum = sum + remainder; //0+3=3.. 3+2=5..
//                inputNumber = inputNumber / 10; // inputNumber = 12.. 1 .. 0(while condition fails)
//            }
//            //}
//            Console.WriteLine("Sum of {0} is {1}", backupNumber, sum);
//        }
//    }
//}
#endregion

#region Fahrenheit to celsius and celsius to fahrenheit
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            TempConversion Temp = new TempConversion();

//            while (true)
//            {
//                Console.WriteLine("\nPlease choose conversion:");
//                Console.WriteLine("fahrenhiet to celcius: F");
//                Console.WriteLine("celcius to fahrenhiet: C");
//                Console.WriteLine("For exit: press '.'");
//                string CorF = Console.ReadLine().ToUpper();
//                if (CorF == ".")
//                {
//                    break;
//                }
//                else if (CorF == "F")
//                {
//                    double val1;
//                    Console.Write("Please enter value in fahrenhiet :");
//                    bool a = double.TryParse(Console.ReadLine(),out val1);
//                    while (true)
//                    {
//                        if (a)
//                        {
//                            double celcius = Temp.FahrenheitToCelcius(val1);
//                            Console.WriteLine($"The value of {val1} fahrenhiet is {celcius} celcius");
//                            break;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Please choose a valid value\n");
//                        }
//                    }
//                }
//                else if (CorF == "C")
//                {
//                    while (true)
//                    {
//                        double val2;
//                        Console.Write("Please enter value celcius :");
//                        bool b = double.TryParse(Console.ReadLine(), out val2);
//                        if (b)
//                        {
//                            double fahrenhiet = Temp.CelciusToFahrenheit(val2);
//                            Console.WriteLine($"The value of {val2} celcius is {fahrenhiet}");
//                            break;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Please choose a valid value\n");
//                        }
//                    }
//                }
//            }
//        }

//    }
//    class TempConversion
//    {
//        public double FahrenheitToCelcius(double fahrenheit)
//        {
//            double celcius = (fahrenheit - 32) * (5 / 9);
//            return celcius;
//        }
//        public double CelciusToFahrenheit(double celcius)
//        {
//            double fahrenheit = celcius * (9 / 5) + 32;
//            return fahrenheit;
//        }
//    }
//}
#endregion

#region Fahrenheit to celsius and celsius to fahrenheit using switchcase 
//using System;
//namespace cSharpProgram{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("\nPlease choose conversion:C)elcius, F)ahrenheit, E)xit.");
//            string selection = string.Empty;
//            while(selection != "E")
//            {
//                selection = Console.ReadLine().ToUpper();
//                TempConverter temp = new TempConverter();
//                switch (selection.ToUpper()) 
//                {
//                    case "C":
//                        Console.WriteLine("Please provide celcius temp:");
//                        double fahrenhietResult = temp.CelciusToFahrenheit(Console.ReadLine());
//                        Console.WriteLine($"Fahrenheit temperature: {fahrenhietResult}°F");
//                        break;
//                    case "F":
//                        Console.WriteLine("Please provide fahrenhiet temp:");
//                        double celciusResult = temp.FahrenheitToCelcius(Console.ReadLine());
//                        Console.WriteLine($"Celcius temperature: {celciusResult}°C");
//                        break;
//                    case "E":
//                        break;
//                    default:
//                        Console.WriteLine("Please provide C or F or E");
//                        break;
//                }
//            }

//        }
//    }
//}
//namespace cSharpProgram
//{
//    class TempConverter
//    {
//        public double FahrenheitToCelcius(string FahrenheitTemp)
//        {
//            double fahrenheit = double.Parse(FahrenheitTemp);
//            double celcius = (fahrenheit - 32) * (5 / 9);
//            return celcius;
//        }
//        public double CelciusToFahrenheit(string CelciusTemp)
//        {
//            double celcius = double.Parse(CelciusTemp);
//            double fahrenheit = celcius * (9 / 5) + 32;
//            return fahrenheit;
//        }
//    }
//}
#endregion

#region Sum of natural numbers
//using System;
//namespace CsharpProgram
//{
//    class program {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please provide a number");
//            int count = Int32.Parse(Console.ReadLine());
//            int sum = 0;
//            for (int i = 1; i <= count; i++)
//            {
//                //if (i % 2 == 0) // For even natural numbers
//                //{
//                //    sum = sum + i;
//                //}
//                sum = sum + i; //For All natural numbers
//            }
//            Console.WriteLine($"Sum of {count} natural numbers is {sum}");
//        }
//    }
//}
#endregion

#region Factors of a given number
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please provide a number");
//            int number = Int32.Parse(Console.ReadLine());

//            for (int i = 1; i <= number; i++) //like maths tables
//            {
//                if (number%i == 0)// remainder is null (6%(1,2,3,4,5,6))
//                {
//                    Console.WriteLine($"{i} is a factor of {number}");
//                }
//            }
//        }
//    }
//}
#endregion

#region Swapping 2 numbers with temp variable
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            int temp;
//            Console.Write("Please provide a first number:a = ");
//            int a = Int32.Parse(Console.ReadLine());

//            Console.Write("Please provide a secound number:b = ");
//            int b = Int32.Parse(Console.ReadLine());
//            temp = a;
//            a = b;
//            b = temp;
//            Console.WriteLine("Result after swapping:");
//            Console.WriteLine($"First number:a = {a}");
//            Console.WriteLine($"Secound number:b = {b}");

//        }
//    }
//}
#endregion

#region Swapping 2 numbers without temp variable
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please provide a first number:a = ");//4
//            int a = Int32.Parse(Console.ReadLine());

//            Console.Write("Please provide a secound number:b = ");//5
//            int b = Int32.Parse(Console.ReadLine());

//            a = a - b;//4-5=-1
//            b = a + b;//-1+5=4..b out
//            a = b - a;//4-(-1)=5..a out
//            //or
//            //a = a + b;//4-5=-1
//            //b = a - b;//-1+5=4..b out
//            //a = a - b;//4-(-1)=5..a out
//            //or
//            //a = a * b;
//            //b = a / b;
//            //a = a / b;

//            Console.WriteLine("Result after swapping:");
//            Console.WriteLine($"First number:a = {a}");
//            Console.WriteLine($"Secound number:b = {b}");
//        }
//    }
//}
#endregion

#region Reversing a number 1234 =>4321
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {

//            Console.Write("Please provide a number: ");
//            int number = Int32.Parse(Console.ReadLine());
//            int backup = number;
//            int remainder, reverse = 0;
//            for(int i = 1; i <= number; i++) {
//                remainder = number % 10;
//                reverse = reverse * 10 + remainder;
//                number = number / 10;
//            }
//            Console.WriteLine($"Number reverse for {backup} is {reverse}");
//        }
//    }
//}
#endregion

#region Checking a number is palindrome or not
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please provide a number: ");
//            int number = Int32.Parse(Console.ReadLine());
//            int backup = number;
//            int remainder, reverse = 0;
//            for (int i = 1; i <= number; i++)
//            {
//                remainder = number % 10;
//                reverse = reverse * 10 + remainder;
//                number = number / 10;
//            }
//            if (reverse == backup)
//            {
//                Console.WriteLine($"Number {backup} is Palindrome");
//            }
//            else
//            {
//                Console.WriteLine($"Number {backup} is Not Palindrome");
//            }
//        }
//    }
//}
#endregion

#region Reversing a String without using predefined funtion in C# {Hello World => dlroW olleH} 
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please provide an input string: ");
//            string input = Console.ReadLine();
//            string backup = input;
//            string reverse = string.Empty;

//            //for(int i = input.Length -1; i >= 0; i--)
//            //{
//            //    reverse = reverse + input[i];
//            //}
//            int len = input.Length; //abc=3
//            while (len != 0)//3,2,1
//            {
//                reverse = reverse + input[len-1]; //c,b,a ==[2],[1],[0]
//                len--;
//            }
//            Console.Write($"Reverse of a given string {backup} is: {reverse}");
//        }
//    }
//}
#endregion

#region Check wether given String is Palindrome or not
//using System;
//namespace CsharpProgram
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please provide an input string: ");
//            string input = Console.ReadLine().ToUpper();
//            string backup = input;
//            string reverse = string.Empty;

//            //for(int i = input.Length -1; i >= 0; i--)
//            //{
//            //    reverse = reverse + input[i];
//            //}
//            int len = input.Length; //abc=3
//            while (len != 0)//3,2,1
//            {
//                reverse = reverse + input[len - 1]; //c,b,a ==[2],[1],[0]
//                len--;
//            }
//            if (backup == reverse)
//            {
//                Console.Write($"Given string {backup} is Palindrome");
//            }
//            else
//            {
//                Console.Write($"Given string {backup} is Not Palindrome");
//            }
//        }
//    }
//}
#endregion