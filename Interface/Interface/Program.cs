using System;
using System.Reflection.Metadata.Ecma335;

namespace Interfaces
{
    interface IMobileAuthenticationInterface
    {
        bool authenticate(); // interface method
    }

    // Implement multiple interfaces
    class FaceRecognitionAuthentication : IMobileAuthenticationInterface
    {
        public bool authenticate()
        {
            Console.WriteLine("Face Recognition successful");
            return true;
        }
    }    
    class FingerPrintAuthentication : IMobileAuthenticationInterface
    {
        public bool authenticate()
        {
            Console.WriteLine("FingerPrint Recognition successful");
            return true;
        }
        
    }    
    class PasswordAuthentication : IMobileAuthenticationInterface
    {
        public bool authenticate()
        {
            Console.WriteLine("Password Recognition successful");
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FaceRecognitionAuthentication facereg = new FaceRecognitionAuthentication();
            facereg.authenticate();
            FingerPrintAuthentication fingerreg = new FingerPrintAuthentication();
            fingerreg.authenticate();
            PasswordAuthentication passreg = new PasswordAuthentication();
            passreg.authenticate();            
        }
    }
}