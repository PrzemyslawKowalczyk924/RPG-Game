using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class HeroMovement : DisplayElementInConsole
    {
        //wygląd
        public char avatar = (char)2;
        //starting point
        public int x = 21;
        public int y = 10;
        public void Movement(char[,] mapa, ref int graczX, ref int graczY)
        {
            ConsoleKey WcisnietyKlawisz = ConsoleKey.Enter;
            while (WcisnietyKlawisz != ConsoleKey.Escape)
            {
                WcisnietyKlawisz = Console.ReadKey(true).Key;
                DisplayElement(graczX, graczY, mapa[graczX, graczY]);
                switch (WcisnietyKlawisz)
                {
                    case ConsoleKey.W:
                        graczY = ObstaclesCheckW(graczX, graczY);
                        break;
                    case ConsoleKey.S:
                        graczY = ObstaclesCheckS(graczX, graczY);
                        break;
                    case ConsoleKey.A:
                        graczX = ObstaclesCheckA(graczX, graczY);
                        break;
                    case ConsoleKey.D:
                        graczX = ObstaclesCheckD(graczX, graczY);
                        break;
                }
                DisplayElement(graczX, graczY, (char)2);
            }
        }

        private static int ObstaclesCheckD(int graczX, int graczY)
        {
            graczX++;
            if (graczX >= 79)
            {
                graczX--;
            }
            if (graczX == Mapa.minList.ElementAt(0) && graczY == Mapa.maxList.ElementAt(0) ||
                graczX == Mapa.minList.ElementAt(1) && graczY == Mapa.maxList.ElementAt(1) ||
                graczX == Mapa.minList.ElementAt(2) && graczY == Mapa.maxList.ElementAt(2) ||
                graczX == Mapa.minList.ElementAt(3) && graczY == Mapa.maxList.ElementAt(3) ||
                graczX == Mapa.minList.ElementAt(4) && graczY == Mapa.maxList.ElementAt(4) ||
                graczX == Mapa.minList.ElementAt(5) && graczY == Mapa.maxList.ElementAt(5) ||
                graczX == Mapa.minList.ElementAt(6) && graczY == Mapa.maxList.ElementAt(6) ||
                graczX == Mapa.minList.ElementAt(7) && graczY == Mapa.maxList.ElementAt(7) ||
                graczX == Mapa.minList.ElementAt(8) && graczY == Mapa.maxList.ElementAt(8) ||
                graczX == Mapa.minList.ElementAt(9) && graczY == Mapa.maxList.ElementAt(9) ||
                graczX == Mapa.minList.ElementAt(10) && graczY == Mapa.maxList.ElementAt(10) ||
                graczX == Mapa.minList.ElementAt(11) && graczY == Mapa.maxList.ElementAt(11) ||
                graczX == Mapa.minList.ElementAt(12) && graczY == Mapa.maxList.ElementAt(12) ||
                graczX == Mapa.minList.ElementAt(13) && graczY == Mapa.maxList.ElementAt(13) ||
                graczX == Mapa.minList.ElementAt(14) && graczY == Mapa.maxList.ElementAt(14) ||
                graczX == Mapa.minList.ElementAt(15) && graczY == Mapa.maxList.ElementAt(15) ||
                graczX == Mapa.minList.ElementAt(16) && graczY == Mapa.maxList.ElementAt(16) ||
                graczX == Mapa.minList.ElementAt(17) && graczY == Mapa.maxList.ElementAt(17) ||
                graczX == Mapa.minList.ElementAt(18) && graczY == Mapa.maxList.ElementAt(18) ||
                graczX == Mapa.minList.ElementAt(19) && graczY == Mapa.maxList.ElementAt(19) ||
                graczX == Mapa.minList.ElementAt(20) && graczY == Mapa.maxList.ElementAt(20) ||
                graczX == Mapa.minList.ElementAt(21) && graczY == Mapa.maxList.ElementAt(21) ||
                graczX == Mapa.minList.ElementAt(22) && graczY == Mapa.maxList.ElementAt(22) ||
                graczX == Mapa.minList.ElementAt(23) && graczY == Mapa.maxList.ElementAt(23) ||
                graczX == Mapa.minList.ElementAt(24) && graczY == Mapa.maxList.ElementAt(24) ||
                graczX == Mapa.minList.ElementAt(25) && graczY == Mapa.maxList.ElementAt(25) ||
                graczX == Mapa.minList.ElementAt(26) && graczY == Mapa.maxList.ElementAt(26) ||
                graczX == Mapa.minList.ElementAt(27) && graczY == Mapa.maxList.ElementAt(27) ||
                graczX == Mapa.minList.ElementAt(28) && graczY == Mapa.maxList.ElementAt(28) ||
                graczX == Mapa.minList.ElementAt(29) && graczY == Mapa.maxList.ElementAt(29) ||
                graczX == Mapa.minList.ElementAt(30) && graczY == Mapa.maxList.ElementAt(30) ||
                graczX == Mapa.minList.ElementAt(31) && graczY == Mapa.maxList.ElementAt(31) ||
                graczX == Mapa.minList.ElementAt(32) && graczY == Mapa.maxList.ElementAt(32) ||
                graczX == Mapa.minList.ElementAt(33) && graczY == Mapa.maxList.ElementAt(33) ||
                graczX == Mapa.minList.ElementAt(34) && graczY == Mapa.maxList.ElementAt(34) ||
                graczX == Mapa.minList.ElementAt(35) && graczY == Mapa.maxList.ElementAt(35) ||
                graczX == Mapa.minList.ElementAt(36) && graczY == Mapa.maxList.ElementAt(36) ||
                graczX == Mapa.minList.ElementAt(37) && graczY == Mapa.maxList.ElementAt(37) ||
                graczX == Mapa.minList.ElementAt(38) && graczY == Mapa.maxList.ElementAt(38) ||
                graczX == Mapa.minList.ElementAt(39) && graczY == Mapa.maxList.ElementAt(39) ||
                graczX == Mapa.minList.ElementAt(40) && graczY == Mapa.maxList.ElementAt(40) ||
                graczX == Mapa.minList.ElementAt(41) && graczY == Mapa.maxList.ElementAt(41) ||
                graczX == Mapa.minList.ElementAt(42) && graczY == Mapa.maxList.ElementAt(42) ||
                graczX == Mapa.minList.ElementAt(43) && graczY == Mapa.maxList.ElementAt(43) ||
                graczX == Mapa.minList.ElementAt(44) && graczY == Mapa.maxList.ElementAt(44) ||
                graczX == Mapa.minList.ElementAt(45) && graczY == Mapa.maxList.ElementAt(45) ||
                graczX == Mapa.minList.ElementAt(46) && graczY == Mapa.maxList.ElementAt(46) ||
                graczX == Mapa.minList.ElementAt(47) && graczY == Mapa.maxList.ElementAt(47) ||
                graczX == Mapa.minList.ElementAt(48) && graczY == Mapa.maxList.ElementAt(48) ||
                graczX == Mapa.minList.ElementAt(49) && graczY == Mapa.maxList.ElementAt(49) ||
                graczX == Mapa.minList.ElementAt(50) && graczY == Mapa.maxList.ElementAt(50) ||
                graczX == Mapa.minList.ElementAt(51) && graczY == Mapa.maxList.ElementAt(51) ||
                graczX == Mapa.minList.ElementAt(52) && graczY == Mapa.maxList.ElementAt(52) ||
                graczX == Mapa.minList.ElementAt(53) && graczY == Mapa.maxList.ElementAt(53) ||
                graczX == Mapa.minList.ElementAt(54) && graczY == Mapa.maxList.ElementAt(54) ||
                graczX == Mapa.minList.ElementAt(55) && graczY == Mapa.maxList.ElementAt(55) ||
                graczX == Mapa.minList.ElementAt(56) && graczY == Mapa.maxList.ElementAt(56) ||
                graczX == Mapa.minList.ElementAt(57) && graczY == Mapa.maxList.ElementAt(57) ||
                graczX == Mapa.minList.ElementAt(58) && graczY == Mapa.maxList.ElementAt(58) ||
                graczX == Mapa.minList.ElementAt(59) && graczY == Mapa.maxList.ElementAt(59) ||
                graczX == Mapa.minList.ElementAt(60) && graczY == Mapa.maxList.ElementAt(60) ||
                graczX == Mapa.minList.ElementAt(61) && graczY == Mapa.maxList.ElementAt(61) ||
                graczX == Mapa.minList.ElementAt(62) && graczY == Mapa.maxList.ElementAt(62) ||
                graczX == Mapa.minList.ElementAt(63) && graczY == Mapa.maxList.ElementAt(63) ||
                graczX == Mapa.minList.ElementAt(64) && graczY == Mapa.maxList.ElementAt(64) ||
                graczX == Mapa.minList.ElementAt(65) && graczY == Mapa.maxList.ElementAt(65) ||
                graczX == Mapa.minList.ElementAt(66) && graczY == Mapa.maxList.ElementAt(66) ||
                graczX == Mapa.minList.ElementAt(67) && graczY == Mapa.maxList.ElementAt(67) ||
                graczX == Mapa.minList.ElementAt(68) && graczY == Mapa.maxList.ElementAt(68) ||
                graczX == Mapa.minList.ElementAt(69) && graczY == Mapa.maxList.ElementAt(69) ||
                graczX == Mapa.minList.ElementAt(70) && graczY == Mapa.maxList.ElementAt(70) ||
                graczX == Mapa.minList.ElementAt(71) && graczY == Mapa.maxList.ElementAt(71) ||
                graczX == Mapa.minList.ElementAt(72) && graczY == Mapa.maxList.ElementAt(72) ||
                graczX == Mapa.minList.ElementAt(73) && graczY == Mapa.maxList.ElementAt(73) ||
                graczX == Mapa.minList.ElementAt(74) && graczY == Mapa.maxList.ElementAt(74) ||
                graczX == Mapa.minList.ElementAt(75) && graczY == Mapa.maxList.ElementAt(75) ||
                graczX == Mapa.minList.ElementAt(76) && graczY == Mapa.maxList.ElementAt(76) ||
                graczX == Mapa.minList.ElementAt(77) && graczY == Mapa.maxList.ElementAt(77) ||
                graczX == Mapa.minList.ElementAt(78) && graczY == Mapa.maxList.ElementAt(78)
                )
            {
                graczX--;
            }

            return graczX;
        }

        private static int ObstaclesCheckA(int graczX, int graczY)
        {
            graczX--;
            if (graczX <= 20)
            {
                graczX++;
            }
            if (graczX == Mapa.minList.ElementAt(0) && graczY == Mapa.maxList.ElementAt(0) ||
                graczX == Mapa.minList.ElementAt(1) && graczY == Mapa.maxList.ElementAt(1) ||
                graczX == Mapa.minList.ElementAt(2) && graczY == Mapa.maxList.ElementAt(2) ||
                graczX == Mapa.minList.ElementAt(3) && graczY == Mapa.maxList.ElementAt(3) ||
                graczX == Mapa.minList.ElementAt(4) && graczY == Mapa.maxList.ElementAt(4) ||
                graczX == Mapa.minList.ElementAt(5) && graczY == Mapa.maxList.ElementAt(5) ||
                graczX == Mapa.minList.ElementAt(6) && graczY == Mapa.maxList.ElementAt(6) ||
                graczX == Mapa.minList.ElementAt(7) && graczY == Mapa.maxList.ElementAt(7) ||
                graczX == Mapa.minList.ElementAt(8) && graczY == Mapa.maxList.ElementAt(8) ||
                graczX == Mapa.minList.ElementAt(9) && graczY == Mapa.maxList.ElementAt(9) ||
                graczX == Mapa.minList.ElementAt(10) && graczY == Mapa.maxList.ElementAt(10) ||
                graczX == Mapa.minList.ElementAt(11) && graczY == Mapa.maxList.ElementAt(11) ||
                graczX == Mapa.minList.ElementAt(12) && graczY == Mapa.maxList.ElementAt(12) ||
                graczX == Mapa.minList.ElementAt(13) && graczY == Mapa.maxList.ElementAt(13) ||
                graczX == Mapa.minList.ElementAt(14) && graczY == Mapa.maxList.ElementAt(14) ||
                graczX == Mapa.minList.ElementAt(15) && graczY == Mapa.maxList.ElementAt(15) ||
                graczX == Mapa.minList.ElementAt(16) && graczY == Mapa.maxList.ElementAt(16) ||
                graczX == Mapa.minList.ElementAt(17) && graczY == Mapa.maxList.ElementAt(17) ||
                graczX == Mapa.minList.ElementAt(18) && graczY == Mapa.maxList.ElementAt(18) ||
                graczX == Mapa.minList.ElementAt(19) && graczY == Mapa.maxList.ElementAt(19) ||
                graczX == Mapa.minList.ElementAt(20) && graczY == Mapa.maxList.ElementAt(20) ||
                graczX == Mapa.minList.ElementAt(21) && graczY == Mapa.maxList.ElementAt(21) ||
                graczX == Mapa.minList.ElementAt(22) && graczY == Mapa.maxList.ElementAt(22) ||
                graczX == Mapa.minList.ElementAt(23) && graczY == Mapa.maxList.ElementAt(23) ||
                graczX == Mapa.minList.ElementAt(24) && graczY == Mapa.maxList.ElementAt(24) ||
                graczX == Mapa.minList.ElementAt(25) && graczY == Mapa.maxList.ElementAt(25) ||
                graczX == Mapa.minList.ElementAt(26) && graczY == Mapa.maxList.ElementAt(26) ||
                graczX == Mapa.minList.ElementAt(27) && graczY == Mapa.maxList.ElementAt(27) ||
                graczX == Mapa.minList.ElementAt(28) && graczY == Mapa.maxList.ElementAt(28) ||
                graczX == Mapa.minList.ElementAt(29) && graczY == Mapa.maxList.ElementAt(29) ||
                graczX == Mapa.minList.ElementAt(30) && graczY == Mapa.maxList.ElementAt(30) ||
                graczX == Mapa.minList.ElementAt(31) && graczY == Mapa.maxList.ElementAt(31) ||
                graczX == Mapa.minList.ElementAt(32) && graczY == Mapa.maxList.ElementAt(32) ||
                graczX == Mapa.minList.ElementAt(33) && graczY == Mapa.maxList.ElementAt(33) ||
                graczX == Mapa.minList.ElementAt(34) && graczY == Mapa.maxList.ElementAt(34) ||
                graczX == Mapa.minList.ElementAt(35) && graczY == Mapa.maxList.ElementAt(35) ||
                graczX == Mapa.minList.ElementAt(36) && graczY == Mapa.maxList.ElementAt(36) ||
                graczX == Mapa.minList.ElementAt(37) && graczY == Mapa.maxList.ElementAt(37) ||
                graczX == Mapa.minList.ElementAt(38) && graczY == Mapa.maxList.ElementAt(38) ||
                graczX == Mapa.minList.ElementAt(39) && graczY == Mapa.maxList.ElementAt(39) ||
                graczX == Mapa.minList.ElementAt(40) && graczY == Mapa.maxList.ElementAt(40) ||
                graczX == Mapa.minList.ElementAt(41) && graczY == Mapa.maxList.ElementAt(41) ||
                graczX == Mapa.minList.ElementAt(42) && graczY == Mapa.maxList.ElementAt(42) ||
                graczX == Mapa.minList.ElementAt(43) && graczY == Mapa.maxList.ElementAt(43) ||
                graczX == Mapa.minList.ElementAt(44) && graczY == Mapa.maxList.ElementAt(44) ||
                graczX == Mapa.minList.ElementAt(45) && graczY == Mapa.maxList.ElementAt(45) ||
                graczX == Mapa.minList.ElementAt(46) && graczY == Mapa.maxList.ElementAt(46) ||
                graczX == Mapa.minList.ElementAt(47) && graczY == Mapa.maxList.ElementAt(47) ||
                graczX == Mapa.minList.ElementAt(48) && graczY == Mapa.maxList.ElementAt(48) ||
                graczX == Mapa.minList.ElementAt(49) && graczY == Mapa.maxList.ElementAt(49) ||
                graczX == Mapa.minList.ElementAt(50) && graczY == Mapa.maxList.ElementAt(50) ||
                graczX == Mapa.minList.ElementAt(51) && graczY == Mapa.maxList.ElementAt(51) ||
                graczX == Mapa.minList.ElementAt(52) && graczY == Mapa.maxList.ElementAt(52) ||
                graczX == Mapa.minList.ElementAt(53) && graczY == Mapa.maxList.ElementAt(53) ||
                graczX == Mapa.minList.ElementAt(54) && graczY == Mapa.maxList.ElementAt(54) ||
                graczX == Mapa.minList.ElementAt(55) && graczY == Mapa.maxList.ElementAt(55) ||
                graczX == Mapa.minList.ElementAt(56) && graczY == Mapa.maxList.ElementAt(56) ||
                graczX == Mapa.minList.ElementAt(57) && graczY == Mapa.maxList.ElementAt(57) ||
                graczX == Mapa.minList.ElementAt(58) && graczY == Mapa.maxList.ElementAt(58) ||
                graczX == Mapa.minList.ElementAt(59) && graczY == Mapa.maxList.ElementAt(59) ||
                graczX == Mapa.minList.ElementAt(60) && graczY == Mapa.maxList.ElementAt(60) ||
                graczX == Mapa.minList.ElementAt(61) && graczY == Mapa.maxList.ElementAt(61) ||
                graczX == Mapa.minList.ElementAt(62) && graczY == Mapa.maxList.ElementAt(62) ||
                graczX == Mapa.minList.ElementAt(63) && graczY == Mapa.maxList.ElementAt(63) ||
                graczX == Mapa.minList.ElementAt(64) && graczY == Mapa.maxList.ElementAt(64) ||
                graczX == Mapa.minList.ElementAt(65) && graczY == Mapa.maxList.ElementAt(65) ||
                graczX == Mapa.minList.ElementAt(66) && graczY == Mapa.maxList.ElementAt(66) ||
                graczX == Mapa.minList.ElementAt(67) && graczY == Mapa.maxList.ElementAt(67) ||
                graczX == Mapa.minList.ElementAt(68) && graczY == Mapa.maxList.ElementAt(68) ||
                graczX == Mapa.minList.ElementAt(69) && graczY == Mapa.maxList.ElementAt(69) ||
                graczX == Mapa.minList.ElementAt(70) && graczY == Mapa.maxList.ElementAt(70) ||
                graczX == Mapa.minList.ElementAt(71) && graczY == Mapa.maxList.ElementAt(71) ||
                graczX == Mapa.minList.ElementAt(72) && graczY == Mapa.maxList.ElementAt(72) ||
                graczX == Mapa.minList.ElementAt(73) && graczY == Mapa.maxList.ElementAt(73) ||
                graczX == Mapa.minList.ElementAt(74) && graczY == Mapa.maxList.ElementAt(74) ||
                graczX == Mapa.minList.ElementAt(75) && graczY == Mapa.maxList.ElementAt(75) ||
                graczX == Mapa.minList.ElementAt(76) && graczY == Mapa.maxList.ElementAt(76) ||
                graczX == Mapa.minList.ElementAt(77) && graczY == Mapa.maxList.ElementAt(77) ||
                graczX == Mapa.minList.ElementAt(78) && graczY == Mapa.maxList.ElementAt(78)
                )
            {
                graczX++;
            }

            return graczX;
        }

        private static int ObstaclesCheckS(int graczX, int graczY)
        {
            graczY++;
            if (graczY >= 23)
            {
                graczY--;
            }
            if (graczX == Mapa.minList.ElementAt(0) && graczY == Mapa.maxList.ElementAt(0) ||
                graczX == Mapa.minList.ElementAt(1) && graczY == Mapa.maxList.ElementAt(1) ||
                graczX == Mapa.minList.ElementAt(2) && graczY == Mapa.maxList.ElementAt(2) ||
                graczX == Mapa.minList.ElementAt(3) && graczY == Mapa.maxList.ElementAt(3) ||
                graczX == Mapa.minList.ElementAt(4) && graczY == Mapa.maxList.ElementAt(4) ||
                graczX == Mapa.minList.ElementAt(5) && graczY == Mapa.maxList.ElementAt(5) ||
                graczX == Mapa.minList.ElementAt(6) && graczY == Mapa.maxList.ElementAt(6) ||
                graczX == Mapa.minList.ElementAt(7) && graczY == Mapa.maxList.ElementAt(7) ||
                graczX == Mapa.minList.ElementAt(8) && graczY == Mapa.maxList.ElementAt(8) ||
                graczX == Mapa.minList.ElementAt(9) && graczY == Mapa.maxList.ElementAt(9) ||
                graczX == Mapa.minList.ElementAt(10) && graczY == Mapa.maxList.ElementAt(10) ||
                graczX == Mapa.minList.ElementAt(11) && graczY == Mapa.maxList.ElementAt(11) ||
                graczX == Mapa.minList.ElementAt(12) && graczY == Mapa.maxList.ElementAt(12) ||
                graczX == Mapa.minList.ElementAt(13) && graczY == Mapa.maxList.ElementAt(13) ||
                graczX == Mapa.minList.ElementAt(14) && graczY == Mapa.maxList.ElementAt(14) ||
                graczX == Mapa.minList.ElementAt(15) && graczY == Mapa.maxList.ElementAt(15) ||
                graczX == Mapa.minList.ElementAt(16) && graczY == Mapa.maxList.ElementAt(16) ||
                graczX == Mapa.minList.ElementAt(17) && graczY == Mapa.maxList.ElementAt(17) ||
                graczX == Mapa.minList.ElementAt(18) && graczY == Mapa.maxList.ElementAt(18) ||
                graczX == Mapa.minList.ElementAt(19) && graczY == Mapa.maxList.ElementAt(19) ||
                graczX == Mapa.minList.ElementAt(20) && graczY == Mapa.maxList.ElementAt(20) ||
                graczX == Mapa.minList.ElementAt(21) && graczY == Mapa.maxList.ElementAt(21) ||
                graczX == Mapa.minList.ElementAt(22) && graczY == Mapa.maxList.ElementAt(22) ||
                graczX == Mapa.minList.ElementAt(23) && graczY == Mapa.maxList.ElementAt(23) ||
                graczX == Mapa.minList.ElementAt(24) && graczY == Mapa.maxList.ElementAt(24) ||
                graczX == Mapa.minList.ElementAt(25) && graczY == Mapa.maxList.ElementAt(25) ||
                graczX == Mapa.minList.ElementAt(26) && graczY == Mapa.maxList.ElementAt(26) ||
                graczX == Mapa.minList.ElementAt(27) && graczY == Mapa.maxList.ElementAt(27) ||
                graczX == Mapa.minList.ElementAt(28) && graczY == Mapa.maxList.ElementAt(28) ||
                graczX == Mapa.minList.ElementAt(29) && graczY == Mapa.maxList.ElementAt(29) ||
                graczX == Mapa.minList.ElementAt(30) && graczY == Mapa.maxList.ElementAt(30) ||
                graczX == Mapa.minList.ElementAt(31) && graczY == Mapa.maxList.ElementAt(31) ||
                graczX == Mapa.minList.ElementAt(32) && graczY == Mapa.maxList.ElementAt(32) ||
                graczX == Mapa.minList.ElementAt(33) && graczY == Mapa.maxList.ElementAt(33) ||
                graczX == Mapa.minList.ElementAt(34) && graczY == Mapa.maxList.ElementAt(34) ||
                graczX == Mapa.minList.ElementAt(35) && graczY == Mapa.maxList.ElementAt(35) ||
                graczX == Mapa.minList.ElementAt(36) && graczY == Mapa.maxList.ElementAt(36) ||
                graczX == Mapa.minList.ElementAt(37) && graczY == Mapa.maxList.ElementAt(37) ||
                graczX == Mapa.minList.ElementAt(38) && graczY == Mapa.maxList.ElementAt(38) ||
                graczX == Mapa.minList.ElementAt(39) && graczY == Mapa.maxList.ElementAt(39) ||
                graczX == Mapa.minList.ElementAt(40) && graczY == Mapa.maxList.ElementAt(40) ||
                graczX == Mapa.minList.ElementAt(41) && graczY == Mapa.maxList.ElementAt(41) ||
                graczX == Mapa.minList.ElementAt(42) && graczY == Mapa.maxList.ElementAt(42) ||
                graczX == Mapa.minList.ElementAt(43) && graczY == Mapa.maxList.ElementAt(43) ||
                graczX == Mapa.minList.ElementAt(44) && graczY == Mapa.maxList.ElementAt(44) ||
                graczX == Mapa.minList.ElementAt(45) && graczY == Mapa.maxList.ElementAt(45) ||
                graczX == Mapa.minList.ElementAt(46) && graczY == Mapa.maxList.ElementAt(46) ||
                graczX == Mapa.minList.ElementAt(47) && graczY == Mapa.maxList.ElementAt(47) ||
                graczX == Mapa.minList.ElementAt(48) && graczY == Mapa.maxList.ElementAt(48) ||
                graczX == Mapa.minList.ElementAt(49) && graczY == Mapa.maxList.ElementAt(49) ||
                graczX == Mapa.minList.ElementAt(50) && graczY == Mapa.maxList.ElementAt(50) ||
                graczX == Mapa.minList.ElementAt(51) && graczY == Mapa.maxList.ElementAt(51) ||
                graczX == Mapa.minList.ElementAt(52) && graczY == Mapa.maxList.ElementAt(52) ||
                graczX == Mapa.minList.ElementAt(53) && graczY == Mapa.maxList.ElementAt(53) ||
                graczX == Mapa.minList.ElementAt(54) && graczY == Mapa.maxList.ElementAt(54) ||
                graczX == Mapa.minList.ElementAt(55) && graczY == Mapa.maxList.ElementAt(55) ||
                graczX == Mapa.minList.ElementAt(56) && graczY == Mapa.maxList.ElementAt(56) ||
                graczX == Mapa.minList.ElementAt(57) && graczY == Mapa.maxList.ElementAt(57) ||
                graczX == Mapa.minList.ElementAt(58) && graczY == Mapa.maxList.ElementAt(58) ||
                graczX == Mapa.minList.ElementAt(59) && graczY == Mapa.maxList.ElementAt(59) ||
                graczX == Mapa.minList.ElementAt(60) && graczY == Mapa.maxList.ElementAt(60) ||
                graczX == Mapa.minList.ElementAt(61) && graczY == Mapa.maxList.ElementAt(61) ||
                graczX == Mapa.minList.ElementAt(62) && graczY == Mapa.maxList.ElementAt(62) ||
                graczX == Mapa.minList.ElementAt(63) && graczY == Mapa.maxList.ElementAt(63) ||
                graczX == Mapa.minList.ElementAt(64) && graczY == Mapa.maxList.ElementAt(64) ||
                graczX == Mapa.minList.ElementAt(65) && graczY == Mapa.maxList.ElementAt(65) ||
                graczX == Mapa.minList.ElementAt(66) && graczY == Mapa.maxList.ElementAt(66) ||
                graczX == Mapa.minList.ElementAt(67) && graczY == Mapa.maxList.ElementAt(67) ||
                graczX == Mapa.minList.ElementAt(68) && graczY == Mapa.maxList.ElementAt(68) ||
                graczX == Mapa.minList.ElementAt(69) && graczY == Mapa.maxList.ElementAt(69) ||
                graczX == Mapa.minList.ElementAt(70) && graczY == Mapa.maxList.ElementAt(70) ||
                graczX == Mapa.minList.ElementAt(71) && graczY == Mapa.maxList.ElementAt(71) ||
                graczX == Mapa.minList.ElementAt(72) && graczY == Mapa.maxList.ElementAt(72) ||
                graczX == Mapa.minList.ElementAt(73) && graczY == Mapa.maxList.ElementAt(73) ||
                graczX == Mapa.minList.ElementAt(74) && graczY == Mapa.maxList.ElementAt(74) ||
                graczX == Mapa.minList.ElementAt(75) && graczY == Mapa.maxList.ElementAt(75) ||
                graczX == Mapa.minList.ElementAt(76) && graczY == Mapa.maxList.ElementAt(76) ||
                graczX == Mapa.minList.ElementAt(77) && graczY == Mapa.maxList.ElementAt(77) ||
                graczX == Mapa.minList.ElementAt(78) && graczY == Mapa.maxList.ElementAt(78)
                )
            {
                graczY--;
            }

            return graczY;
        }

        private static int ObstaclesCheckW(int graczX, int graczY)
        {
            graczY--;
            if (graczY <= 0)
            {
                graczY++;
            }
            if (graczX == Mapa.minList.ElementAt(0) && graczY == Mapa.maxList.ElementAt(0) ||
                graczX == Mapa.minList.ElementAt(1) && graczY == Mapa.maxList.ElementAt(1) ||
                graczX == Mapa.minList.ElementAt(2) && graczY == Mapa.maxList.ElementAt(2) ||
                graczX == Mapa.minList.ElementAt(3) && graczY == Mapa.maxList.ElementAt(3) ||
                graczX == Mapa.minList.ElementAt(4) && graczY == Mapa.maxList.ElementAt(4) ||
                graczX == Mapa.minList.ElementAt(5) && graczY == Mapa.maxList.ElementAt(5) ||
                graczX == Mapa.minList.ElementAt(6) && graczY == Mapa.maxList.ElementAt(6) ||
                graczX == Mapa.minList.ElementAt(7) && graczY == Mapa.maxList.ElementAt(7) ||
                graczX == Mapa.minList.ElementAt(8) && graczY == Mapa.maxList.ElementAt(8) ||
                graczX == Mapa.minList.ElementAt(9) && graczY == Mapa.maxList.ElementAt(9) ||
                graczX == Mapa.minList.ElementAt(10) && graczY == Mapa.maxList.ElementAt(10) ||
                graczX == Mapa.minList.ElementAt(11) && graczY == Mapa.maxList.ElementAt(11) ||
                graczX == Mapa.minList.ElementAt(12) && graczY == Mapa.maxList.ElementAt(12) ||
                graczX == Mapa.minList.ElementAt(13) && graczY == Mapa.maxList.ElementAt(13) ||
                graczX == Mapa.minList.ElementAt(14) && graczY == Mapa.maxList.ElementAt(14) ||
                graczX == Mapa.minList.ElementAt(15) && graczY == Mapa.maxList.ElementAt(15) ||
                graczX == Mapa.minList.ElementAt(16) && graczY == Mapa.maxList.ElementAt(16) ||
                graczX == Mapa.minList.ElementAt(17) && graczY == Mapa.maxList.ElementAt(17) ||
                graczX == Mapa.minList.ElementAt(18) && graczY == Mapa.maxList.ElementAt(18) ||
                graczX == Mapa.minList.ElementAt(19) && graczY == Mapa.maxList.ElementAt(19) ||
                graczX == Mapa.minList.ElementAt(20) && graczY == Mapa.maxList.ElementAt(20) ||
                graczX == Mapa.minList.ElementAt(21) && graczY == Mapa.maxList.ElementAt(21) ||
                graczX == Mapa.minList.ElementAt(22) && graczY == Mapa.maxList.ElementAt(22) ||
                graczX == Mapa.minList.ElementAt(23) && graczY == Mapa.maxList.ElementAt(23) ||
                graczX == Mapa.minList.ElementAt(24) && graczY == Mapa.maxList.ElementAt(24) ||
                graczX == Mapa.minList.ElementAt(25) && graczY == Mapa.maxList.ElementAt(25) ||
                graczX == Mapa.minList.ElementAt(26) && graczY == Mapa.maxList.ElementAt(26) ||
                graczX == Mapa.minList.ElementAt(27) && graczY == Mapa.maxList.ElementAt(27) ||
                graczX == Mapa.minList.ElementAt(28) && graczY == Mapa.maxList.ElementAt(28) ||
                graczX == Mapa.minList.ElementAt(29) && graczY == Mapa.maxList.ElementAt(29) ||
                graczX == Mapa.minList.ElementAt(30) && graczY == Mapa.maxList.ElementAt(30) ||
                graczX == Mapa.minList.ElementAt(31) && graczY == Mapa.maxList.ElementAt(31) ||
                graczX == Mapa.minList.ElementAt(32) && graczY == Mapa.maxList.ElementAt(32) ||
                graczX == Mapa.minList.ElementAt(33) && graczY == Mapa.maxList.ElementAt(33) ||
                graczX == Mapa.minList.ElementAt(34) && graczY == Mapa.maxList.ElementAt(34) ||
                graczX == Mapa.minList.ElementAt(35) && graczY == Mapa.maxList.ElementAt(35) ||
                graczX == Mapa.minList.ElementAt(36) && graczY == Mapa.maxList.ElementAt(36) ||
                graczX == Mapa.minList.ElementAt(37) && graczY == Mapa.maxList.ElementAt(37) ||
                graczX == Mapa.minList.ElementAt(38) && graczY == Mapa.maxList.ElementAt(38) ||
                graczX == Mapa.minList.ElementAt(39) && graczY == Mapa.maxList.ElementAt(39) ||
                graczX == Mapa.minList.ElementAt(40) && graczY == Mapa.maxList.ElementAt(40) ||
                graczX == Mapa.minList.ElementAt(41) && graczY == Mapa.maxList.ElementAt(41) ||
                graczX == Mapa.minList.ElementAt(42) && graczY == Mapa.maxList.ElementAt(42) ||
                graczX == Mapa.minList.ElementAt(43) && graczY == Mapa.maxList.ElementAt(43) ||
                graczX == Mapa.minList.ElementAt(44) && graczY == Mapa.maxList.ElementAt(44) ||
                graczX == Mapa.minList.ElementAt(45) && graczY == Mapa.maxList.ElementAt(45) ||
                graczX == Mapa.minList.ElementAt(46) && graczY == Mapa.maxList.ElementAt(46) ||
                graczX == Mapa.minList.ElementAt(47) && graczY == Mapa.maxList.ElementAt(47) ||
                graczX == Mapa.minList.ElementAt(48) && graczY == Mapa.maxList.ElementAt(48) ||
                graczX == Mapa.minList.ElementAt(49) && graczY == Mapa.maxList.ElementAt(49) ||
                graczX == Mapa.minList.ElementAt(50) && graczY == Mapa.maxList.ElementAt(50) ||
                graczX == Mapa.minList.ElementAt(51) && graczY == Mapa.maxList.ElementAt(51) ||
                graczX == Mapa.minList.ElementAt(52) && graczY == Mapa.maxList.ElementAt(52) ||
                graczX == Mapa.minList.ElementAt(53) && graczY == Mapa.maxList.ElementAt(53) ||
                graczX == Mapa.minList.ElementAt(54) && graczY == Mapa.maxList.ElementAt(54) ||
                graczX == Mapa.minList.ElementAt(55) && graczY == Mapa.maxList.ElementAt(55) ||
                graczX == Mapa.minList.ElementAt(56) && graczY == Mapa.maxList.ElementAt(56) ||
                graczX == Mapa.minList.ElementAt(57) && graczY == Mapa.maxList.ElementAt(57) ||
                graczX == Mapa.minList.ElementAt(58) && graczY == Mapa.maxList.ElementAt(58) ||
                graczX == Mapa.minList.ElementAt(59) && graczY == Mapa.maxList.ElementAt(59) ||
                graczX == Mapa.minList.ElementAt(60) && graczY == Mapa.maxList.ElementAt(60) ||
                graczX == Mapa.minList.ElementAt(61) && graczY == Mapa.maxList.ElementAt(61) ||
                graczX == Mapa.minList.ElementAt(62) && graczY == Mapa.maxList.ElementAt(62) ||
                graczX == Mapa.minList.ElementAt(63) && graczY == Mapa.maxList.ElementAt(63) ||
                graczX == Mapa.minList.ElementAt(64) && graczY == Mapa.maxList.ElementAt(64) ||
                graczX == Mapa.minList.ElementAt(65) && graczY == Mapa.maxList.ElementAt(65) ||
                graczX == Mapa.minList.ElementAt(66) && graczY == Mapa.maxList.ElementAt(66) ||
                graczX == Mapa.minList.ElementAt(67) && graczY == Mapa.maxList.ElementAt(67) ||
                graczX == Mapa.minList.ElementAt(68) && graczY == Mapa.maxList.ElementAt(68) ||
                graczX == Mapa.minList.ElementAt(69) && graczY == Mapa.maxList.ElementAt(69) ||
                graczX == Mapa.minList.ElementAt(70) && graczY == Mapa.maxList.ElementAt(70) ||
                graczX == Mapa.minList.ElementAt(71) && graczY == Mapa.maxList.ElementAt(71) ||
                graczX == Mapa.minList.ElementAt(72) && graczY == Mapa.maxList.ElementAt(72) ||
                graczX == Mapa.minList.ElementAt(73) && graczY == Mapa.maxList.ElementAt(73) ||
                graczX == Mapa.minList.ElementAt(74) && graczY == Mapa.maxList.ElementAt(74) ||
                graczX == Mapa.minList.ElementAt(75) && graczY == Mapa.maxList.ElementAt(75) ||
                graczX == Mapa.minList.ElementAt(76) && graczY == Mapa.maxList.ElementAt(76) ||
                graczX == Mapa.minList.ElementAt(77) && graczY == Mapa.maxList.ElementAt(77) ||
                graczX == Mapa.minList.ElementAt(78) && graczY == Mapa.maxList.ElementAt(78)
                )
            {
                graczY++;
            }

            return graczY;
        }
    }
}
