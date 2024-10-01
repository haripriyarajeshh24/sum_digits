using System;

namespace MyApplication
{
    class Program
    {
        public enum MathOperator { Add, Subtract, Multiply, Divide, };

        public static int Test5(int num1, int num2, MathOperator op)
        {
            int num3;

            switch (op)
            {
                case MathOperator.Add:
                    num3 = num1 + num2;
                    return num3;
                case MathOperator.Subtract:
                    num3 = num1 - num2;
                    return num3;
                case MathOperator.Multiply:
                    num3 = num1 * num2;
                    return num3;
                case MathOperator.Divide:
                    num3 = num1 / num2;
                    return num3;
                //add default switch case for error: not all code paths return a value  bla bla..
                default:
                    return 0;
            };

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Test5(10, 10, MathOperator.Add));
        }
    }


}
