using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class PlayerInterface : DisplayElementInConsole
    {
        public static char[,] UILines = new char[20, 24];
        public List<HeroMovement> HeroUI = new List<HeroMovement>();

        public void GenerateUI()
        {
            //wall upper and lower
            for (int index = 0; index <= 19; index++)
            {
                UILines[index, 0] = (char)127;
                UILines[index, 23] = (char)22;
            }
            //wall left and right
            for (int index = 1; index <= 23; index++)
            {
                UILines[0, index] = (char)204;
                UILines[19, index] = (char)204;
            }
        }

        public void CreateUI()
        {
            for(int x = 0; x <= 19; x++)
            {
                for (int y = 0; y <= 23; y++)
                {
                    DisplayElement(x, y, UILines[x, y]);
                }
            }
        }
    }
}
