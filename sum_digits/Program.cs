using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Digitsum()
        {
            Console.WriteLine("------ Digit Sum ------");
            int n, sum = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
            Console.ReadLine();


        }

        static void Multiplication()
        {
            Console.WriteLine("------ Multiplication ------");
            int num, value;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            int count = 1;
            Console.WriteLine("Values are ");
            while (count <= 10)
            {
                value = num * count;
                Console.WriteLine(value);
                count++;
            }


        }

        static void Greatest()
        {
            Console.WriteLine("------ Find Greatest ------");
            int first_num, second_num, third_num;
            Console.Write("Enter 1st Number: ");
            first_num = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
            second_num = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd Number: ");
            third_num = int.Parse(Console.ReadLine());
            if (first_num > second_num && first_num > third_num)
            {
                Console.WriteLine(first_num + " is greatest of all");
            }
            else if (second_num > first_num && second_num > third_num)
            {
                Console.WriteLine(second_num + " is greatest of all");
            }
            else
            {
                Console.WriteLine(third_num + " is greatest of all");
            }


        }


        static void CountPositiveNegative()
        {
            Console.WriteLine("------ Get Positive & Negtive Count ------");
            int limit;
            Console.Write("Enter the array limit ");
            limit = int.Parse(Console.ReadLine());
            int[] numbers = new int[limit];
            int positive_count = 0;
            int neg_count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the array values ");
                int readed = int.Parse(Console.ReadLine());
                if (readed < 1)
                {
                    neg_count++;
                }
                else
                {
                    positive_count++;
                }

            }
            Console.WriteLine(positive_count + "is the pos count");
            Console.WriteLine(neg_count + "is the neg count");
            Console.ReadLine();


        }

        static void CheckEqual()
        {
            Console.WriteLine("------ Check Arrays are Equal ------");
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int i;
            Console.Write("Input 5 elements in the array1 :\n"); 
            for (i = 0; i < 5; i++)
            {
                Console.Write("number : ", i); 
                arr1[i] = Convert.ToInt32(Console.ReadLine());  
            }
            Console.Write("Input 5 elements in the array2 :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("number : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool isEqual = Enumerable.SequenceEqual(arr1, arr2);
            if (isEqual == true)
            {
                Console.Write("array1 and array2 are equal");
            }
            else {
                Console.Write("array1 and array2 are not equal");
            }
            

        }

        static void Calculator()
        {
            Console.WriteLine("------ Simple Calculator ------");
            int first_num, second_num, action, value;
            Console.Write("Enter 1st number ");
            first_num = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number ");
            second_num = int.Parse(Console.ReadLine());
            Console.Write("Enter the operation to be performed \n 1) Enter 1 for Addition \n 2) Enter 2 for Subtraction  \n 3) Enter 3 for Multiplication  \n 4) Enter 4 for Division \n");
            action = int.Parse(Console.ReadLine());
            switch (action)
            {
            case 1:
                value = first_num + second_num;
                Console.WriteLine("Sum is " + value);
                break;
            case 2:
                value = first_num - second_num;
                Console.WriteLine("Differece is " + value);
                break;
            case 3:
                value = first_num * second_num;
                Console.WriteLine("Product is " + value);
                break;
            case 4:
                value = first_num / second_num;
                Console.WriteLine("Quotient is " + value);
                break;
            }
        }

        static void Main(string[] args)
                {
                    Console.WriteLine("Checckkkk");
                    Digitsum();
                    Greatest();
                    Multiplication();
                    CountPositiveNegative();
                    CheckEqual();
                    Calculator();
                }


    }
}
