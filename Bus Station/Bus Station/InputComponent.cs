using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class InputComponent
    {
        public int GetInputInt()
        {
            bool isParsed;
            int result;
            do
            {
                Console.WriteLine("Enter integer, and press Enter");
                var userChoice = Console.ReadLine();
                isParsed = int.TryParse(userChoice, out result);
            }
            while (!isParsed);
             return result;
        }
    }
}
