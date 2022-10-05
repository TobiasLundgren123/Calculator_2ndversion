using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2ndversion
{
    public static class Calc
    {

        public static void Calculator(){

        var keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("Enter mathematical operation - (or -1 to exit)");
                    Console.WriteLine("1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n");
                    var operation = int.Parse(Console.ReadLine() ?? "");
                    //Console.ForegroundColor = ConsoleColor.Green;
                    switch (operation)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Addition");
                            int termAmount = AmountOfTerms();
                            
                            
                            double[] termsAdded = AddingTheNumbers(termAmount);
                            if (termAmount == 2)
                            {
                                double totalAdd = Add(termsAdded[0], termsAdded[1]);
                                Console.WriteLine("Adding " + termsAdded[0] + " + " + termsAdded[1] + " = " + totalAdd);
                            }
                            else
                            {
                                double totalAdd = Add(termsAdded);
                                foreach (double term in termsAdded)
                                {
                                    Console.Write(term + " + ");
                                }
                                Console.WriteLine(" = " + totalAdd);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Subtraction");
                            termAmount = AmountOfTerms();


                            termsAdded = AddingTheNumbers(termAmount);
                            if (termAmount == 2)
                            {
                                double totalSub = Subtract(termsAdded[0], termsAdded[1]);
                                Console.WriteLine("Subtracting " + termsAdded[0] + " - " + termsAdded[1] + " = " + totalSub);
                            }
                            else
                            {
                                double totalSub = Subtract(termsAdded);
                                foreach (double term in termsAdded)
                                {
                                    Console.Write(term + " - ");
                                }
                                Console.WriteLine(" = " + totalSub);
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Multiplication");
                            termAmount = 2;

                            termsAdded = AddingTheNumbers(termAmount);
                            double total = Multiply(termsAdded[0], termsAdded[1]);
                            Console.WriteLine("Multiplying " + termsAdded[0] + " * " + termsAdded[1] + " = " + total);

                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Multiplication");
                            termAmount = 2;

                            termsAdded = AddingTheNumbers(termAmount);
                            total = Division(termsAdded[0], termsAdded[1]);
                            Console.WriteLine("Dividing " + termsAdded[0] + " / " + termsAdded[1] + " = " + total);
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number");
                            break;
                    }
    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("That is not a valid assignment number");
    Console.ResetColor();
}
            }
}

        public static int AmountOfTerms()
        {
            Console.WriteLine("How many terms would you like to calculate?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double[] AddingTheNumbers(int totalTerms)
        {
            double[] numbers = new double[totalTerms];
            int i = 0;
            foreach (double term in numbers)
            {
                Console.WriteLine("Write term number " + term + ":");
                numbers[i] = Convert.ToDouble(Console.ReadLine);
                i++;            
            }
            return numbers;
        }

        public static double Add(double nr1, double nr2)
        {
            return nr1 + nr2;
        }

        public static double Add(double[] arrayTerms)
        {
            double total = 0;
            foreach (double term in arrayTerms)
            {
                total += term;
            }
            return total;
        }

        public static double Subtract(double nr1, double nr2)
        {
            return nr1 - nr2;
        }

        public static double Subtract(double[] arrayTerms)
        {
            double total = 0;
            foreach (double term in arrayTerms)
            {
                total -= term;
            }
            return total;
        }

        public static double Multiply(double nr1, double nr2)
        {
            return nr1 * nr2;
        }

        public static double Division(double nr1, double nr2)
        {
            return nr1 / nr2;
        }

        //public static double[] numbers()
        //{
        //    double[] numberToCalc = new double[2];
        //    Console.WriteLine("Enter number 1:");
        //    numberToCalc[0] = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter number 2:");
        //    numberToCalc[1] = double.Parse(Console.ReadLine());

        //    return numberToCalc[];
        //}

        //public static double[] numberArray()
        //{
        //    double[] numberToCalc = new double[20];
        //    Console.WriteLine("Enter numbers separated by a comma:");
        //    //string numberedarray = Console.ReadLine();
        //    numberToCalc = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToDouble);
        //    foreach (double number in numberToCalc)
        //    { Console.WriteLine(number); }


        //    return numberToCalc;
        //}
        //public double Add(double number1, double number2)
        //{
        //    return number1 + number2;
        //}

        //public double Add(double[] numbers)
        //{
        //    double result = 0;
        //    foreach (double number in numbers)
        //    {
        //        result += number;
        //    }
        //    return result;
        //}

        //public double Subtract(double number1, double number2)
        //{
        //    return number1 - number2;
        //}

        //public double Subtract(double[] numbers)
        //{
        //    double result = 0;
        //    foreach (double number in numbers)
        //    {
        //        result -= number;
        //    }
        //    return result;
        //}
    }
}
