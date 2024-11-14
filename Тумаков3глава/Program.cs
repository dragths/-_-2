using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков3глава
{
    internal class Program
    {
        struct rabotnik //для дз 3.1
        {
            public string name;
            public VUZ vuz;

            public void print()
            {
                Console.WriteLine($"Имя: {name} ВУЗ: {vuz}");
            }
        }
        enum VUZ // для дз 3.1
        {
            КФУ,
            КАИ,
            КХТИ,
        }
        enum schet // для  3.1
        {
            текущий,
            сберегательный,
        }
        struct data // для 3.2
        {
            public long nomer;
            public string tip;
            public double balance;

            public void Print()
            {
                Console.WriteLine($"Номер банковского счета:{nomer}  Тип банковского счета: {tip}  Баланс:{balance}$");
            }
        }


        static void Main(string[] args)
        {
            /*Создать перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать.*/
            Console.WriteLine("Упражнение 3.1");
            schet now = schet.текущий;
            Console.WriteLine($"вид банковского счета: {now}");

            /*Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат.*/
            Console.WriteLine();
            Console.WriteLine("Упражнение 3.2");
            data Data = new data();
            Data.nomer = 220045678903219;
            Data.tip = "сберегательный";
            Data.balance = 789.60;
            Data.Print();

            /* Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать.*/
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 3.1");
            rabotnik Rabotnik = new rabotnik();
            Rabotnik.name = "Boris";
            Rabotnik.vuz = VUZ.КФУ;
            Rabotnik.print();

        }

    }
}
