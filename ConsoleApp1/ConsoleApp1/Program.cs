//Марюх вячеслав


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static double pointDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        static void print(string message)
        {
                 Console.WriteLine(message);
        }

        

        static void Main(string[] args)
        {

//            1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
//            В результате вся информация выводится в одну строчку.
//            а) используя склеивание;
//            б) используя форматированный вывод;
//            в) *используя вывод со знаком $.
      
            
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            string surName = Console.ReadLine();
            Console.WriteLine("Введите ваш Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост (в см.): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес: ");
            int weigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Имя Фамилия: {name} {surName}; Возраст: {age}; Рост:{height}; Вес: {weigth}; ");
            Console.WriteLine("Имя Фамилия: "+name+" "+surName+"; Возраст: "+age+"; Рост:"+height+"; Вес: "+weigth+"; ");// склеивание
            Console.WriteLine("Имя Фамилия: {0} {1}; Возраст: {2}; Рост:{3}; Вес: {4};", name, surName, age, height, weigth); 
            Console.ReadKey();


            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); 
            //где m — масса тела в килограммах, h — рост в метрах

            double indexWeight;
            height /= 100;
            indexWeight = weigth/ Math.Pow(height,2);
            Console.WriteLine($"Индекс массы тела = {indexWeight}");
            Console.ReadKey();


            //а) Написать программу, которая подсчитывает расстояние между точками с координатами 
            //    x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //    Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

            Console.WriteLine("Введите х1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите х2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

           // double distance = 

            Console.WriteLine($"Расстояние между точками ({x1};{y1}) и ({x2};{y2}): {pointDistance(x1, y1, x2, y2):F2}");   
            Console.ReadKey();

            //            4.написать программу обмена значениями двух переменных.
            //            а) с использованием третьей переменной;
            int A = 3;
            int B = 5;
            int T = A;
                A = B;
                B = T;
            //            б) *без использования третьей переменной.
            int C = 3;
            int D = 5;
            C = C + D; // C = 3 + 5;  8
            D = C - D; // D = 8 - 5;  3
            C = C - D; // C = 8 - 3;  5


            //5.
            //а) написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *сделать задание, только вывод организовать в центре экрана.
            //в) **сделать задание б с использованием собственных методов(например, print(string ms, int x, int y).

            Console.Clear();
            print("Вячеслав Марюх", 51, 10);

            //6 Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            Classes.Print("г.Харьков", 53, 12);


            Classes.Pause();

            



        }
    }
}
