using System;
namespace MethodOverriding
{
    class PaymentStrategy
    {
        public virtual int SalaryPaid(int base_salary, int worked_hours)
        {
            return base_salary;
        }
    }
    class HourlyPaymentStrategy : PaymentStrategy
    {
        public override int SalaryPaid(int base_salary, int worked_hours)
        {
            int hourlypay = 10;
            return base_salary + (hourlypay* worked_hours);
        }
    }

    class MonthlyPaymentStrategy : PaymentStrategy
    {
        public override int SalaryPaid(int base_salary, int worked_hours)
        {
            int dailypay = 80;
            return base_salary + dailypay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HourlyPaymentStrategy HourlyPaymentobj = new HourlyPaymentStrategy();
            Console.WriteLine("Hourly Payment : " + HourlyPaymentobj.SalaryPaid(10000, 2));
            MonthlyPaymentStrategy MonthlyPaymentobj = new MonthlyPaymentStrategy();
            Console.WriteLine("Monthly Payment : " + MonthlyPaymentobj.SalaryPaid(10000, 8));
            Console.ReadLine();
        }
    }
}
