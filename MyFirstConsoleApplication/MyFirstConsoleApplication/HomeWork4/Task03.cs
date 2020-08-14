using System;

namespace HomeWork4
{
    public class Task03
    {
        public void CollectorInformationAboutTheNextHippo()
        {
            Helper helper = new Helper();

            int grass = helper.EnterTheNumber("Ate grass (kg):");
            int seaweed = helper.EnterTheNumber("Ate seaweed (kg):");
            int crocodile = helper.EnterTheNumber("Ate crocodiles (kg):");
            int hideAndSeek = helper.EnterTheNumber("Played hide and seek (in hours):");
            int catchUp = helper.EnterTheNumber("Played cath-up to survive (in hours):");
            int dotaGame = helper.EnterTheNumber("Played 'Dota' (in hours):");
            int chess = helper.EnterTheNumber("Played chess (in hours):");

            if (grass < 0 || seaweed < 0 || crocodile < 0 ||
                     hideAndSeek < 0 || catchUp < 0 || dotaGame < 0 || chess < 0)
            {
                throw new Exception("Invalid data entered.");
            }
            else
            {
                int caloriesAcquired = CaloriesAcquired(grass, seaweed, crocodile);
                int caloriesBurned = CaloriesBurned(hideAndSeek, catchUp, dotaGame, chess);
                PrintResult(grass, seaweed, crocodile, hideAndSeek, catchUp, dotaGame, chess, caloriesAcquired, caloriesBurned);
            }
        }

        public int CaloriesAcquired(int grass, int seaweed, int crocodile)
        {
            if (grass < 0 || seaweed < 0 || crocodile < 0)
            {
                return 0;
            }
            else
            {
                int resultCalories = grass * 21 + seaweed * 32 + crocodile * 54;
                return resultCalories;
            }
        }
        public int CaloriesBurned(int hideAndSeek, int catchUp, int dotaGame, int chess)
        {
            if (hideAndSeek < 0 || catchUp < 0 || dotaGame < 0 || chess < 0)
            {
                return 0;
            }
            else
            {
                return hideAndSeek * 132 + catchUp * 432 + dotaGame * 0 + chess * 67;
            }
        }

        public void PrintResult(int grass, int seaweed, int crocodile,
                                    int hideAndSeek, int catchUp, int dotaGame, int chess, 
                                        int caloriesAcquired, int caloriesBurned)
        {
            Console.WriteLine($"Hippo ate: \n{grass} kg grass \n{seaweed} kg seaweed \n{crocodile} kg crocodiles");
            Console.WriteLine($"Hippo played:\n{hideAndSeek} hour(s) hide and seek \n{catchUp} hour(s) catch-up \n{dotaGame} hour(s) DOTA \n{chess} hour(s) chess");
            Console.WriteLine($"Hippo fat level up {caloriesAcquired} ccal");
            Console.WriteLine($"Hippo berned {caloriesBurned} ccal");
        }
    }
}
