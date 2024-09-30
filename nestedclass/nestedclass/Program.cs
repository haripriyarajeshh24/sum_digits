using System;
namespace NestedClass
{

    // outer class
    public class Cpu
    {

        // inner class
        public class Ram
        {
            public string memory = "memory";
            public string manufacturer = "manufacturer";
            public void getClockspeed()
            {
                Console.WriteLine("Got Clock speed");
            }
        }
        public class Processor
        {
            public string manufacturer = "manufacturer";
            public string cores = "core";
            public void getCache()
            {
                Console.WriteLine("Got Cache");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Cpu.Processor processor = new Cpu.Processor();
            Cpu.Ram ram = new Cpu.Ram();
            ram.getClockspeed();
            processor.getCache();
            Console.ReadLine();

        }
    }
}
