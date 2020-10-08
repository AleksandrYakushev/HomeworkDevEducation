using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaHall
{
    public class Cinema
    {
        private int _hallNumber; // номер зала  

        private int _workTime;  // 600

        private List<Film> _films; //фильмы

        private List<CinemaHallSessions> _allPossibleSessions; // Все возможные расписания от 14 до 24 дерево в прогрессии

        private List<CinemaHallSessions> _relevantSessionsWithOptimalTime; // Все возможные расписания, где меньше простаивает кинотеатр 

        private List<CinemaHallSessions> _relevantSessionsWithAllFilms; // со звездочкой (чтобы все фильмы повторялись хотя бы один раз)
                                                                        // сортирует чтобы все фильмы разные были

        public int HallNumber // свойство номер зала
        {
            get
            {
                return _hallNumber;
            }
            set
            {
                if (value <= 0)
                {
                    IncorrectValueException(); // если менее 1 зала - то ошибка
                }
                else
                {
                    _hallNumber = value;  // если >= 1 - номер зала равен устанавливаемому значению
                    ChangeCinemaParameters(); // все possible и relevent сеансы обнуляем (null) 
                }
            }
        }

        public int WorkTime // рабочее время
        {
            get
            {
                return _workTime;
            }
            set
            {
                if (value <= 0)
                {
                    IncorrectValueException(); // если рабочее время меньше одной минуты - ошибка
                }
                else
                {
                    _workTime = value; // если > 0 - номер зала равен устанавливаемому значению
                    ChangeCinemaParameters(); // все possible и relevent сеансы обнуляем (null)
                }
            }
        }
        public List<Film> Films // свойство фильм с типом данных лист фильмов
        {
            get
            {
                return _films;  // возвращает все фильмы
            }
            set
            {
                if (value.Count == 0)
                {
                    IncorrectValueException();
                }
                else
                {
                    _films = value;
                    ChangeCinemaParameters();
                }
            }
        }
        public List<CinemaHallSessions> AllPossibleSessions
        {
            get
            {
                if (_allPossibleSessions == null)
                {
                    GetAllPossibleSessions();
                }
                return _allPossibleSessions;
            }
        }
        public List<CinemaHallSessions> RelevantSessionsWithOptimalTime
        {
            get
            {
                if (_relevantSessionsWithOptimalTime == null)
                {
                    GetRelevantSessionsWithOptimalTime();
                }
                return _relevantSessionsWithOptimalTime;
            }
        }
        public List<CinemaHallSessions> RelevantSessionsWithAllFilms
        {
            get
            {
                if (_relevantSessionsWithAllFilms == null)
                {
                    GetRelevantSessionsWithAllFilms(AllPossibleSessions);
                }
                return _relevantSessionsWithAllFilms;
            }
        }

        public Cinema() { }

        public Cinema(int hallNumber, int workTime, List<Film> films)
        {
            HallNumber = hallNumber;
            WorkTime = workTime;
            Films = films;
            _allPossibleSessions = GetAllPossibleSessions();
        }

        private void ChangeCinemaParameters()
        {
            _allPossibleSessions = null;
            _relevantSessionsWithOptimalTime = null;
            _relevantSessionsWithAllFilms = null;
        }

        private List<CinemaHallSessions> GetAllPossibleSessions()  // что здесь происходит?
        {
            _allPossibleSessions = new List<CinemaHallSessions>();
            Node node = new Node() { Length = _workTime };
            node.Create(_films);  // запускаем создание всех возможных расписаний, на вход передаем список фильмов

            if (node.Nexts.Count != 0)
            {
                CreateAllSessions(node);
            }
            else
            {
                NodeException();
            }

            if (_allPossibleSessions.Count < _hallNumber)
            {
                CinemaHallException();
            }

            _allPossibleSessions.Sort();
            return _allPossibleSessions;
        }

        private void CreateAllSessions(Node node)
        {
            if (node.Nexts.Count != 0)
            {
                foreach (Node n in node.Nexts)
                {
                    CreateAllSessions(n);
                }
            }
            else
            {
                CinemaHallSessions currentSession = new CinemaHallSessions(node.Length, node.CinemaSessions);
                _allPossibleSessions.Add(currentSession); // в олпосибле сэшнс записалось одно расписание
            }
        }

        private void GetRelevantSessionsWithOptimalTime()
        {
            _relevantSessionsWithOptimalTime = new List<CinemaHallSessions>();

            for (int i = 0; i < _hallNumber; i++)
            {
                _relevantSessionsWithOptimalTime.Add(AllPossibleSessions[i]);
            }
        }

        private List<CinemaHallSessions> GetRelevantSessionsWithAllFilms(List<CinemaHallSessions> allSessions)
        {
            Film film = new Film();
            List<Film> filmListCopy = film.Copy(_films);
            List<CinemaHallSessions> allSessionsCopy = Copy(allSessions);

            if (_relevantSessionsWithAllFilms == null)
            {
                _relevantSessionsWithAllFilms = new List<CinemaHallSessions>();
            }

            foreach (var cinemaHall in allSessions)
            {
                if (_relevantSessionsWithAllFilms.Count < _hallNumber)
                {
                    bool match = false;
                    if (filmListCopy.Count != 0)
                    {
                        foreach (var currentFilm in cinemaHall.sessions)
                        {
                            if (filmListCopy.Contains(currentFilm))
                            {
                                filmListCopy.Remove(currentFilm);
                                match = true;
                            }
                        }

                        if (match)
                        {
                            _relevantSessionsWithAllFilms.Add(cinemaHall);
                            allSessionsCopy.Remove(cinemaHall);
                        }
                    }
                    else
                    {
                        _relevantSessionsWithAllFilms.Add(cinemaHall);
                        allSessionsCopy.Remove(cinemaHall);
                    }
                }
                else
                {
                    return _relevantSessionsWithAllFilms;
                }
            }

            if (_relevantSessionsWithAllFilms.Count < _hallNumber)
            {
                GetRelevantSessionsWithAllFilms(allSessionsCopy);
            }

            return _relevantSessionsWithAllFilms;
        }

        private List<CinemaHallSessions> Copy(List<CinemaHallSessions> cinemaHallSessions)
        {
            List<CinemaHallSessions> newSessions = new List<CinemaHallSessions>();
            if (cinemaHallSessions != null)
            {
                foreach (var i in cinemaHallSessions)
                {
                    newSessions.Add(i);
                }
            }
            return newSessions;
        }

        public ArgumentOutOfRangeException CinemaHallException()
        {
            throw new ArgumentOutOfRangeException
                    ($"Количество уникальных расписаний для этого списка фильмов ({_allPossibleSessions.Count}) меньше, чем количество залов ({_hallNumber}). " +
                    $"Увеличьте количество фильмов или уменьшите количество залов.");
        }

        public Exception IncorrectValueException()
        {
            throw new Exception
                    ($"Значение должно быть больше нуля");
        }

        public ArgumentOutOfRangeException NodeException()
        {
            throw new ArgumentOutOfRangeException
                    ($"При заданных параметрах невозможно создать ни один сеанс. Измените продолжительность работы кинотеатра или продолжительность фильмов.");
        }
    }
}
