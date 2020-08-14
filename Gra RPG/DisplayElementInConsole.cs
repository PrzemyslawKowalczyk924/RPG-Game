using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class DisplayElementInConsole
    {
        public static void DisplayElement(int x, int y, char element)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(element);
        }
    }
}
