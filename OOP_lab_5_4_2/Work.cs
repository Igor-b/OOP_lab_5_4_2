using System;
using System.IO;

namespace OOP_lab_5_4_1
{
    class Work
    {
        public static void Add()
        {
            StreamWriter file = new StreamWriter("base.txt", true);

            Console.WriteLine("\nВведiть новi данi");

            Console.Write("Назва: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Мiсце проведення: ");

            file.WriteLine(Console.ReadLine());

        Retry:
            Console.Write("Дата: ");

            try
            {
                file.WriteLine(DateTime.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Неправильно вказана дата!");

                goto Retry;
            }

            Console.Write("Тема: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Кiлькiсть учасникiв: ");

            file.WriteLine(Console.ReadLine());

            file.Close();

            Input.ReadBase();
        }

        public static void Remove()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для видалення: ");

            bool[] remove = new bool[Program.meetings.Length];

            for (int i = 0; i < remove.Length; ++i)
            {
                remove[i] = false;
            }

            try
            {
                remove[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (!remove[i])
                {
                    file.WriteLine(Program.meetings[i].Name);
                    file.WriteLine(Program.meetings[i].Place);
                    file.WriteLine(Program.meetings[i].Date.ToShortDateString());
                    file.WriteLine(Program.meetings[i].Theme);
                    file.WriteLine(Program.meetings[i].ParticipantsCount);
                }
            }

            Console.Write("Видалено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void Edit()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для редагування: ");

            bool[] edit = new bool[Program.meetings.Length];

            for (int i = 0; i < edit.Length; ++i)
            {
                edit[i] = false;
            }

            try
            {
                edit[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (edit[i])
                {
                    Console.WriteLine("\nВведiть новi данi");

                    Console.Write("Назва: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Мiсце проведення: ");

                    file.WriteLine(Console.ReadLine());

                Retry:
                    Console.Write("Дата: ");

                    try
                    {
                        file.WriteLine(DateTime.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Неправильно вказана дата!");

                        goto Retry;
                    }

                    Console.Write("Тема: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Кiлькiсть учасникiв: ");

                    file.WriteLine(Console.ReadLine());
                }
                else
                {
                    file.WriteLine(Program.meetings[i].Name);
                    file.WriteLine(Program.meetings[i].Place);
                    file.WriteLine(Program.meetings[i].Date.ToShortDateString());
                    file.WriteLine(Program.meetings[i].Theme);
                    file.WriteLine(Program.meetings[i].ParticipantsCount);
                }
            }

            Console.Write("Змiни внесено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void InitialiseBase(int n)
        {
            Program.meetings = new Meeting[n];
        }
    }
}
