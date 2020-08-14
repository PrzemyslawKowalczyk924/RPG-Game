using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Mapa mapa = new Mapa();
            mapa.GenerateMap();
            mapa.CreateArtefacts();
            mapa.CreateObstacles();
            mapa.CreateMap();

           /* Artefacts artefacts = new Artefacts();
            artefacts.CreateArtefacts();
            artefacts.ShowArtefactsOnMap();*/

            PlayerInterface playerInterface = new PlayerInterface();
            playerInterface.GenerateUI();
            playerInterface.CreateUI();


            HeroMovement hero = new HeroMovement();
            hero.Movement(Mapa.map, ref hero.x, ref hero.y);

            
        }
    }
}
