using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Point
    {
        public int x = 10;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            /*
             * this code print the sum of
             * 2 varaible x and y
             */
            // init var x with value of 10
            int x = 10;
            // init var y with value of 20
            int y = 20;
            // sum var store the result of adding the value of x and y
            int sum = x + y;
            // Output the value of sum to the console
            Console.WriteLine(sum);

            /*
             * Comment: Ctrl + K, Ctrl + C
             * Uncomment: Ctrl + K, Ctrl + U
             */
            #endregion

            #region Problem2
            // the problem was we assign string value to var of type int
            int x = 10;
            // y was undefined var
            int y = 5;
            // console is incorrect it should be Console with capital C
            Console.WriteLine(x + y);

            /**
             * Runtime Error vs Logical Error
             * 
             * 1. Runtime Error:
             *  occurs while the program is running.
             *  It happens during the execution of the program and causes 
             *  it to stop or behave unexpectedly
             *  EX ==>  Division by zero.
             *  
             *  int a = 10;
             *  int b = 0;
             *  int result = a / b;
             *   (DivideByZeroException)
             *   ---------------------------------------------------
             *   
             *   2. Logical Error:
             *   program runs without crashing, but it produces incorrect results
             *   due to a flaw in the logic of the code.
             *   EX ==>
             *   int a = 100;
             *   int b = 25;
             *  int result = a - b * 2; we need the sub done first but
             *  her multi will done firt  this will change the result we must add () 
             *  int result = (a - b) * 2; correct
             */
            #endregion

            #region Problem3
            string FullName = "Ahmed Bassem Ramzy";
            int Age = 22;
            float MonthlySalary = 8800.55f;
            bool AreYouStudent = true;

            /**
             * C# follows specific naming conventions to ensure that the code is
             * consistent, readable, and maintainable. 
             */

            #endregion

            #region Problem4
            Point obj1 = new Point();
            // the 2 ref to the same object
            Point obj2 = obj1;
            Console.WriteLine("before " + obj1.x); // 10
            Console.WriteLine("before " + obj2.x); // 10
            obj1.x = 20;
            Console.WriteLine("after "+ obj1.x); //20
            Console.WriteLine("after "+ obj2.x); //20

            /**
             * Value Types VS Reference Types
             * ----------------
             * Value Types
             * Memory Allocation: Stored directly in the stack.
             * Copying: When a value type is assigned to another, a copy of the value is made.
             * Ex: int, float, bool, struct.
             * -----------------
             * Reference Types
             * Memory Allocation: Stored in the heap; a reference to the memory location is stored in the stack.
             * Copying: When a reference type is assigned to another, the reference is copied (MEMORY address), so both variables point to the same object.
             * Ex: string, class, array, delegate
             */
            #endregion

            #region Problem5
            int x = 15;
            int y = 4;

            int Sum = x + y;
            Console.WriteLine(sum);
            int Sub = x - y;
            Console.WriteLine(Sub);
            int Multi = x * y;
            Console.WriteLine(Multi);
            int Div = x / y;
            Console.WriteLine(Div);
            int Remainder = x % y;
            Console.WriteLine(Remainder);


            // =====================================
              int a = 2, b = 7;
            Console.WriteLine(a % b); //2

            /**
             * The output is 2 because 2 % 7 calculates the remainder 
             * when 2 is divided by 7. Since 2 is smaller than 7, the remainder is 2
             */

            #endregion

            #region Problem6
            int Input = 18;
            // or from user
            Console.Write("Enter the number: ");
            int Input = int.Parse(Console.ReadLine());

            if (Input > 10 && Input % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //-------------------------------------------------

            /**
             * && (Logical AND) VS & (Bitwise AND)
             * --------------------
             * && ==> Used for logical conditions. Short-circuits, meaning it stops evaluating if the first condition is false.
             * if (a > 5 && b > 10) → Skips b if a > 5 is false.
             * --------------------
             * & ===> Used for bit-level operations. Does not short-circuit, always evaluates both sides.
             * if (a > 5 & b > 10) → Always evaluates b.
             */
            #endregion

            #region Problem7
            Console.Write("Enter a value: ");
            double Input = double.Parse(Console.ReadLine());

            // Explicit casting (casting the double to an int explicitly)
            int ExplicitCast = (int)Input;
            // int ImplicitCast = Input; Implicit casting(not possible from double to int(compile-time error)
            Console.WriteLine("value (double): " + Input);
            Console.WriteLine("After explicit casting to int: " + ExplicitCast);

            //==============================================================================

            /**
             * Why is explicit casting required when converting a double to an int?
             * 
             * Explicit casting is required when converting a double to an int in C#
             * because a double is a floating-point number (with decimals), while an int is a whole number. 
             * Converting a double to an int
             * can lead to a loss of precision (decimal part gets truncated)
             * 
             */

            #endregion

            #region Problem8
            Console.Write("Enter your Age: ");
            string AgeInput = Console.ReadLine();
            try
            {
                int Age = int.Parse(AgeInput);

                if (Age > 0)
                {
                    Console.WriteLine("the age is vaild");
                }
                else
                {
                    Console.WriteLine("the age is not vaild");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, you should enter numeric value");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input. The number is too large");
            }
            /**
             * What exception might occur if the input is invalid and how can you handle it?
             * 
             * we can use try .... catch ex
             * 
             * 1. FormatException:  occurs if the input is not a valid number
             * 
             * 2. OverflowException: occurs if the input number is outside the range of an int
             */
            #endregion

            #region Problem9
            int x = 5;

            //postfix
            Console.WriteLine(x++);//5
            Console.WriteLine(x); //6

            //prefix
            Console.WriteLine(++x); //7
            Console.WriteLine(x); //7

            /**
             * Given the code below, what is the value of x after execution? Explain why
             *  int x = 5;
             *  int y = ++x + x++;
             *  000000000000000000000000000000000000000000
             *  first x = 5
             *  in ++x prefix ==> x = 6  do increment first and use it in 2st step
             *  in x++ postfix ==> x = 6 use it first and do increment in 2st step
             *  in final  x = 7 , y  = 6 + 6 = 12
             */

            #endregion

        }
    }
}