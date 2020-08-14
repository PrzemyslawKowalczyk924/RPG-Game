using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    class Artefacts : DisplayElementInConsole
    {
        public static char[,] artefacts = new char[78, 22];
        public static List<int> xArtefactList = new List<int>();
        public static List<int> yArtefactList = new List<int>();
        public static List<Random> Randoms = new List<Random>();

        public void CreateArtefacts()
        {
            Random random = new Random();
            for (int index = 0; index < 4; index++)
            {
                int x = random.Next(1, 78);
                int y = random.Next(1, 22);
                artefacts[x, y] = (char)258;
                xArtefactList.Add(x);
                yArtefactList.Add(y);
            }
        }

        public void ShowArtefactsOnMap()
        {
            //left and right
            for (int x = 1; x < 78; x++)
            {
                //up and down
                for (int y = 1; y < 22; y++)
                {
                    DisplayElement(x, y, artefacts[x, y]);
                }
            }
        }
    }
}
