using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaHall
{
    public class Schedule //график
    {
        public void ShowSessions(List<CinemaHallSessions> sessions) // покажи сеансы 
        {                                                           //принимает на вход лист 
            int count = 0;
            foreach (var i in sessions)
            {
                PrintSession(i, count);
                count++;
            }

            Console.WriteLine();
        }

        private void PrintSession(CinemaHallSessions hall, int count)
        {
            Console.WriteLine();
            Console.WriteLine($"Зал {count + 1}, свободное время: {hall.RemainingTime}");
            hall.PrintAllSessionsInThisHall();
        }
    }
}
