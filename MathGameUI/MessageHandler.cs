using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameUI
{
    public static class MessageHandler
    {
        public static void WelcomeMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}. Welcome to Math's game.");
        }
    }
}
