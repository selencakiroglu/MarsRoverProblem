using System;

namespace MarsRoverProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int plateauX = 5;
            int plateauY = 5;
            int locationX = 1;
            int locationY = 2;
            string navigation = "N";
            int direction = 0;
            string letters = "LMLMLMLMM";
            int MathMod(int a, int b)
            {
                return (Math.Abs(a * b) + a) % b;
            }

            switch (navigation)
            {
                case "N":
                    direction = 0;
                    break;
                case "E":
                    direction = 1;
                    break;
                case "S":
                    direction = 2;
                    break;
                case "W":
                    direction = 3;
                    break;
            }

            char[] lettersArray = letters.ToCharArray();

            for (int i = 0; i < lettersArray.Length; i++)
            {
                if (lettersArray[i] == 'L')
                {
                    direction = MathMod((direction - 1), 4);
                }
                if (lettersArray[i] == 'R')
                {
                    direction = MathMod((direction + 1), 4);
                }
                if (lettersArray[i] == 'M')
                {
                    switch (direction)
                    {
                        case 0:
                            locationY++;
                            if (locationY > 5)
                            {
                                throw new Exception("Your position should be on plateou.");
                            }
                            break;
                        case 1:
                            locationX++;
                            if (locationX > 5)
                            {
                                throw new Exception("Your position should be on plateou.");
                            }
                            break;
                        case 2:
                            locationY--;
                            if (locationY < 0)
                            {
                                throw new Exception("Your position should be on plateou.");
                            }
                            break;
                        case 3:
                            locationX--;
                            if (locationX < 0)
                            {
                                throw new Exception("Your position should be on plateou.");
                            }
                            break;
                    }
                }

                switch (direction)
                {
                    case 0:
                        navigation = "N";
                        break;
                    case 1:
                        navigation = "E";
                        break;
                    case 2:
                        navigation = "S";
                        break;
                    case 3:
                        navigation = "W";
                        break;
                }
            }

            Console.WriteLine(locationX + " " + locationY + " " + navigation);
            Console.ReadKey();
        }
    }
}
