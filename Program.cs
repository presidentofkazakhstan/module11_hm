using System;

namespace module_hm
{
    class Program
    {
     


        static void Main(string[] args)
        {

            Console.Write("Введите количество сотрудников: ");

            int countOfWorkers = int.Parse(Console.ReadLine());
            Workers[] workers = new Workers[countOfWorkers];
            Console.WriteLine("-----------------------------------------------------");

            for (int i = 0; i < countOfWorkers; i++)
            {
                Console.Write("Введите имя: ");
                workers[i].name = Console.ReadLine();

                Console.WriteLine("1.Менеджер" +
                    "\n2.Босс" +
                    "\n3.Клерк");

                Console.Write("Введите должность(1-3): "  );
                int position = int.Parse(Console.ReadLine());
                if (position == 1)
                {
                    workers[i].vacancy = VacanciesName.Manager;
                }
                else if (position == 2)
                {
                    workers[i].vacancy = VacanciesName.Boss;
                }
                else if (position == 3)
                {
                    workers[i].vacancy = VacanciesName.Clerk;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }


                workers[i].salary = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("a.  полная информацию обо всех сотрудниках");
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < workers.Length; i++)
            {
                for (int k = 0; k < workers.Length - 1; k++)
                {
                    var s = workers[k];
                    workers[k] = workers[k + 1];
                    workers[k + 1] = s;
                }
            }
            foreach (Workers wrk in workers)
            {
                Console.WriteLine("Имя: " + wrk.name);
                Console.WriteLine("Должность: " + wrk.vacancy);
                Console.WriteLine("Зарплата: " + wrk.salary);
                Console.WriteLine("-----------------------------------------------------");
            }

            float d = 0;
            int cnt = 0;

            foreach (Workers wrk in workers)
            {
                if (wrk.vacancy == VacanciesName.Clerk)
                {
                    cnt++;
                    d += wrk.salary;
                    d /= cnt;
                }
            }
            Console.WriteLine("b.  зарплата  менеджеров которых больше средней зарплаты всех клерков");
            foreach (Workers wrk in workers)
            {
                if (wrk.vacancy == VacanciesName.Manager && wrk.salary > d)
                {

                    Console.WriteLine("Имя: " + wrk.name);
                    Console.WriteLine("Должность: " + wrk.vacancy);
                    Console.WriteLine("Заработная: " + wrk.salary);
                }
            }
            Console.Read();
        }
    }
}
