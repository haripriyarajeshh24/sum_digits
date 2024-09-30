using System;
using System.Reflection;
namespace MethodOverloadingCsharp
{
    class Logger
    {
        public void log(string classname, string methodname, string errormessage)
        {
            Console.WriteLine(classname + ", " + methodname + ", " + errormessage);
        }
        public void log(string errormessage)
        {
            Console.WriteLine(errormessage);
        }
        public void log(string classname, string errormessage)
        {
            Console.WriteLine(classname + ", " + errormessage);
        }
        public void log(string classname, string methodname, string dateTime, string errormessage)
        {
            DateTime result = DateTime.Parse(dateTime);
            Console.WriteLine(classname + ", " + methodname + ", " + dateTime + ", " + errormessage);
        }
        static void Main(string[] args)
        {
            Logger logobj = new Logger();
            logobj.log("logger", "method a", "No error");
            logobj.log("No error");
            logobj.log("logger", "No error");
            logobj.log("logger", "method a", "16/09/2019", "No error");
            Console.ReadLine();
        }
    }
}
