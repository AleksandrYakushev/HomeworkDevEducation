using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaHall
{
    //Зал кинотеатра со всеми сеансами
    public class CinemaHallSessions : IComparable<CinemaHallSessions>
    {
        public List<Film> sessions;
        public int RemainingTime { get; set; }
        public int DifferentFilms { get; set; } // количество разных фильмо которые есть в расписаний

        public CinemaHallSessions()
        {

        }

        public CinemaHallSessions(int remainingTime, List<Film> sessions) //лист самого расписания
        {
            this.RemainingTime = remainingTime;
            this.sessions = sessions;
            IEnumerable<Film> differentFilms = sessions.Distinct(new FilmComparer());
            this.DifferentFilms = differentFilms.Count();
        }

        public void PrintAllSessionsInThisHall()
        {
            DateTime timeStart = new DateTime(2020, 1, 1, 14, 00, 00);
            foreach (var i in sessions)
            {
                DateTime timeEnd = timeStart.AddMinutes(i.Duration);
                Console.WriteLine($"{timeStart.ToShortTimeString()} - {timeEnd.ToShortTimeString()} \t {i.Name}");
                timeStart = timeEnd;
            }
        }

        public int CompareTo(CinemaHallSessions compareCinemaHall)
        {
            if (compareCinemaHall == null)
                return 1;

            if (this.RemainingTime == compareCinemaHall.RemainingTime)
            {
                if (this.DifferentFilms == compareCinemaHall.DifferentFilms)
                {
                    return 0;
                }
                else if (this.DifferentFilms > compareCinemaHall.DifferentFilms)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
                return this.RemainingTime.CompareTo(compareCinemaHall.RemainingTime);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            CinemaHallSessions compare = (CinemaHallSessions)obj;

            return (sessions.SequenceEqual(compare.sessions)
                && this.RemainingTime == compare.RemainingTime
                && this.DifferentFilms == compare.DifferentFilms);
        }
    }
}
