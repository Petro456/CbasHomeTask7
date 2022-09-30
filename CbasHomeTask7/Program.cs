using System;
using System.Linq;

namespace CbasHomeTask7
{
    struct Train
    {
        public string nameCity;
        public int nomerTrain;
        public string timeGo;

    }
    internal class Program
    {       /* Задание 2 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
        Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, 
        номер поезда, время отправления. Написать программу, выполняющую следующие действия: 
        ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны 
        быть упорядочены по номерам поездов);  вывод на экран информации о поезде, номер которого введен с 
        клавиатуры (если таких поездов нет, вывести соответствующее сообщение).  */
        static void Main(string[] args)
        {
            const int count = 2;
            var park = new Train[count];
            for (var i = 0; i < count; i++) park[i] = GetNewTrain();
            var sortPark = park.OrderBy(t => t.nomerTrain).ToArray();
            PrintTrains(sortPark);
            while (true)
            {
                Console.Write("Введіть номер поїзда: ");
                var num = int.Parse(Console.ReadLine());
                var trn = park.Where(t => t.nomerTrain == num);

                if (trn.Count() == 0) Console.WriteLine("Такого поїзда немає");
                else PrintTrain(trn.Single());
            }

        }
        static Train GetNewTrain()
        {
            var name = ReadConsole("Введіть місто в яке прямує потяг");
            var date = ReadConsole("введіть дату відправлення");
            var snum = ReadConsole("Введіть номер поїзда");

            return new Train
            {
                nameCity = name,
                timeGo = date,
                nomerTrain = int.Parse(snum)
            };
        }
        static void PrintTrains(Train[] park)
        {
            Console.WriteLine("На станції зараз знаходяться такі поїзда: ");
            foreach (var trn in park)
                PrintTrain(trn);
        }
        static void PrintTrain(Train trn)
        {
            Console.WriteLine("{0} {1}", trn.nomerTrain, trn.nameCity);
        }

        static string ReadConsole(string message)
        {
            Console.Write("{0}: ", message);
            return Console.ReadLine();
        }
    } 
}

