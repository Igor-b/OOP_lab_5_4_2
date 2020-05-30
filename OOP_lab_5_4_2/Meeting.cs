using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_5_4_1
{
    class Meeting : Conference
    {
        private DateTime _date;
        private string _theme;
        private int _participantsCount;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public string Theme
        {
            get => _theme;
            set => _theme = value;
        }

        public int ParticipantsCount
        {
            get => _participantsCount;
            set => _participantsCount = value;
        }

        public Meeting()
        {
            base.Name = "Не вказано";
            base.Place = "Не вказано";

            _date = DateTime.Parse("01.01.01");
            _theme = "Не вказано";
            _participantsCount = 0;
        }

        public Meeting(string name, string place, DateTime date, string theme, int participantsCount)
        {
            base.Name = UkrainianI(name);
            base.Place = UkrainianI(place);

            _date = date;
            _theme = UkrainianI(theme);
            _participantsCount = participantsCount;
        }

        public static void Average()
        {
            Console.Write("\nСередня кiлькiсть учасникiв на засiданнi: ");

            double sum = 0;

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                sum += Program.meetings[i].ParticipantsCount;
            }

            Console.WriteLine(sum / Program.meetings.Length);
        }

        public static void Max()
        {
            Console.WriteLine("\nЗасiдання з найбiльшою кiлькiстю учасникiв:");

            Console.WriteLine(Output.Format, "Назва", "Мiсце проведення", "Дата", "Тема", "Кiлькiсть учасникiв");

            int max = 0;

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (Program.meetings[i].ParticipantsCount >= max)
                {
                    max = Program.meetings[i].ParticipantsCount;
                }
            }

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (Program.meetings[i].ParticipantsCount == max)
                {
                    Console.WriteLine(Output.Format, Program.meetings[i].Name, Program.meetings[i].Place, Program.meetings[i].Date.ToShortDateString(), Program.meetings[i].Theme, Program.meetings[i].ParticipantsCount);
                }
            }
        }

        public static void Length()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для визначення довжини назви засiдання: ");

            try
            {
                Console.WriteLine("Довжина назви засiдання: {0}", Program.meetings[int.Parse(Console.ReadLine())].Name.Length);
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }
        }
    }
}
