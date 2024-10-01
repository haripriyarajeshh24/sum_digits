using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace MethodOverloadingCsharp
{
    class ExceptionHandling
    { 
        static void DivZeroException()
        {
            try
            {
                Console.WriteLine("Enter num1 : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2 : ");
                int num2 = int.Parse(Console.ReadLine());

                int num3 = num1 / num2;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisible by 0 not possible");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid numbers");
            }
            finally
            {
                Console.WriteLine("Please check the entries");
            }
           
        }
    }

    class User
    {
        public int userId;
        public string name;
        public string email;
        public string mobile;
    }
    [Serializable]
    class InvalidEmailException : Exception
    {
        public InvalidEmailException() { }

        public InvalidEmailException(string email)
            : base(String.Format("Invalid Email : {0}", email))
        {

        }
    }
    class InvalidPhoneException : Exception
    {
        public InvalidPhoneException() { }

        public InvalidPhoneException(string mobile)
            : base(String.Format("Invalid Phone: {0}", mobile))
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.email = "hari@gmail";
            user.mobile = "+96238020003";
            try
            {

                ValidateEmail(user);
               
            }
            catch (InvalidEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                ValidatePhone(user);
            }
            catch (InvalidPhoneException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        private static void ValidateEmail(User user)
        {
            Regex regex = new Regex("^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$");

            if (!regex.IsMatch(user.email))
                throw new InvalidEmailException(user.email);

        }
        private static void ValidatePhone(User user)
        {
            Regex regex = new Regex("^(\\+[0-9]{9})$");

            if (!regex.IsMatch(user.mobile))
                throw new InvalidPhoneException(user.mobile);

        }
    }

}




