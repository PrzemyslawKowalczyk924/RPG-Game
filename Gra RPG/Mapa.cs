using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class Mapa : DisplayElementInConsole
    {
        public static char[,] map = new char[80, 24];
        public static char[,] obstacles = new char[78, 22];
        public static List<int> minList = new List<int>();
        public static List<int> maxList = new List<int>();
        public static char[,] UILines = new char[20, 24];

        public static char[,] artefacts = new char[78, 22];
        public static List<int> xArtefactList = new List<int>();
        public static List<int> yArtefactList = new List<int>();

        public void GenerateMap()
        {
            //wall upper and lower
            for(int index = 20; index < 80; index++)
            {
                map[index, 0] = (char)5;
                map[index, 23] = (char)5;
            }
            //wall right and left
            for(int index = 0; index < 24; index++)
            {
                map[20, index] = (char)5;
                map[79, index] = (char)5;
            }
        }

        public void CreateObstacles()
        {
            Random random = new Random();
            for (int index = 0; index < 79; index++)
            {
                
                int x = random.Next(1, 78);
                int y = random.Next(1, 22);
                obstacles[x, y] = (char)5;
                minList.Add(x);
                maxList.Add(y);
                /*if (index == 0 || index == 1 || index == 2 || index == 3)
                {
                    artefacts[x, y] = (char)258;
                    xArtefactList.Add(x);
                    yArtefactList.Add(y);
                }*/
            }
        }
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

        public void CreateMap()
        {
            //left and right
            for (int x = 20; x < 80; x++)
            {
                //up and down
                for (int y = 0; y < 24; y++)
                {
                    DisplayElement(x, y, map[x, y]);
                }
            }
            for (int x = 21; x < 78; x++)
            {
                for (int y = 1; y < 22; y++)
                {
                    DisplayElement(x, y, artefacts[x, y]);
                }
            }
            for (int x = 21; x < 78; x++)
            {
                for (int y = 1; y < 22; y++)
                {
                    DisplayElement(x, y, artefacts[x, y]);
                    DisplayElement(x, y, obstacles[x, y]);
                }
            }
            DisplayElement(21, 10, (char)2);
        }
    }
}
