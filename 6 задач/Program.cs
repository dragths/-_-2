using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_задач
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Console.WriteLine($"byte  -  {byte.MaxValue}  -  {byte.MinValue}");
            Console.WriteLine($"sbyte  -  {sbyte.MaxValue}  -  {sbyte.MaxValue}");
            Console.WriteLine($"short  -  {short.MaxValue}  -  {short.MinValue}");
            Console.WriteLine($"ushort  -  {ushort.MaxValue}  -  {ushort.MinValue}");
            Console.WriteLine($"int  -  {int.MaxValue}  -  {int.MinValue}");
            Console.WriteLine($"uint  -  {uint.MaxValue}  -  {uint.MinValue}");
            Console.WriteLine($"long  -  {long.MaxValue}  -  {long.MinValue}");
            Console.WriteLine($"ulong  -  {ulong.MaxValue}  -  {ulong.MinValue}");
            Console.WriteLine($"float  -  {byte.MaxValue}  -  {byte.MinValue}");
            Console.WriteLine($"double  -  {double.MaxValue}  -  {double.MinValue}");
            Console.WriteLine($"decimal  -  {decimal.MaxValue}  -  {decimal.MinValue}");

            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();
            string name = Console.ReadLine();
            string city = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            int pin = Convert.ToInt32(Console.ReadLine());
            (string, string, int, int) person = (name, city, age, pin);
            Console.WriteLine(person);

            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные.*/
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();
            string stroka1 = Console.ReadLine();

            char[] strokamass = new char[stroka1.Length];

            for (int i = 0; i < stroka1.Length; i++)
            {
                if (char.IsLower(stroka1[i]))//метод islower проверяют относится ли к нижнему регистру символ 
                {
                    strokamass[i] = char.ToUpper(stroka1[i]);
                }
                else if (char.IsUpper(stroka1[i]))//то же самое,только наоборот
                {
                    strokamass[i] = char.ToLower(stroka1[i]);
                }
                else
                {
                    strokamass[i] = stroka1[i]; // если символ не буква
                }
            }

            string result = new string(strokamass);
            Console.WriteLine(result);


            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.*/
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine();
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string podstroka = Console.ReadLine();

            int count = 0;
            int index = 0;

            while ((index = stroka.IndexOf(podstroka, index)) != -1)
            {
                count++;
                index += podstroka.Length;
            }

            Console.WriteLine($"Количество вхождений подстроки: {count}");

            /*5. определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice).*/
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine();
            int normPrice = Convert.ToInt32(Console.ReadLine());
            double salePrice = Convert.ToInt32(Console.ReadLine());
            double holidayPrice = Convert.ToInt32(Console.ReadLine());
            double price1 = (normPrice * salePrice) / 100;
            Console.WriteLine(Math.Floor(price1 * holidayPrice));


        }
 

    }
}
