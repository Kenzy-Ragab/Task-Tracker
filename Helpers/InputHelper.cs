using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Helpers
{
    public static class InputHelper
    {

        static public bool IsNumberBetween(int Num, int From, int To)
        {
            return !(Num < From || Num > To);
        }
        static public int ReadInt(string prompotMessage = "", string InvalidInputMessage = "Invalid Number, Enter again:\n")
        {
            Console.Write(prompotMessage);

            int Num = 0;
            while (!int.TryParse(Console.ReadLine(), out Num))
                Console.WriteLine(InvalidInputMessage);

            return Num;
        }
        static public int ReadIntNumberBetween(int From, int To, string OutOfRangeMessage = "Number is not within range, enter again:\n")
        {
            int Num = ReadInt();
            while (!IsNumberBetween(Num, From, To))
            {
                Console.WriteLine(OutOfRangeMessage);
                Num = ReadInt();
            }
            return Num;
        }
  
        public static DateTime ReadDate(string message)
        {
            Console.Write(message);
            DateTime result;
            while (!DateTime.TryParse(Console.ReadLine(), out result))
                Console.Write("Invalid date, try again: ");
            return result;
        }
    }
}
