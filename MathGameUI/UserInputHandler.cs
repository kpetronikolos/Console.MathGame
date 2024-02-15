using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameUI
{
    public static class UserInputHandler
    {
        public static string AskForUserName()
        {
            Console.Write("Please enter your name: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
