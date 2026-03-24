using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAi_Bot
{
    internal class Cyber_Bot
    {
        public String UserName { get; set; }

        public void ShowGreeting()
        {
            // Task 6: Enhanced UI (Colours)
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Task 2: ASCII Art Logo (Use the @ symbol for verbatim strings!)
            Console.WriteLine(@"
              _____       _               ____        _   
             / ____|     | |             |  _ \      | |  
            | |    _   _ | |__    ___  _ | |_) | ___ | |_ 
            | |   | | | || '_ \  / _ \| ||  _ < / _ \| __|
            | |___| |_| || |_) ||  __/| || |_) | (_) | |_ 
             \_____\__, ||_.__/  \___||_||____/ \___/ \__|
                    __/ |                                 
                   |___/                                  
        ");
            // Reset color back to normal
            Console.ResetColor();

            Console.WriteLine("==================================================");
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("==================================================");
            Console.WriteLine(); // Blank line for spacing

            // Task 3: Ask for the user's name
            Console.Write("To get started, what is your name? ");
            // Store the input in our Automatic Property
            UserName = Console.ReadLine();

            // Personalise the response
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello, {UserName}! It is great to meet you.");
            Console.ResetColor();
        }
    }
}
