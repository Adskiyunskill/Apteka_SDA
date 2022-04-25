using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cl_farm
    {

        public string Name;
        public string[] NameFarm = new string[5];
        public int[] PriceFarm = new int[5];

        public void SetFarm()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите назвние аптеки: ");
            Console.ForegroundColor = ConsoleColor.White;
            Name = Console.ReadLine();
            for (int i = 0; i < NameFarm.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Название лекарства:");
                Console.ForegroundColor = ConsoleColor.White;
                NameFarm[i] = Console.ReadLine();
                bool On = false;
                while (On == false)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Введите цену:");
                    Console.ForegroundColor = ConsoleColor.White;
                    string num = Console.ReadLine();
                    On = int.TryParse(num, out PriceFarm[i]);
                    if (On == false)
                    {
                        Console.WriteLine("Не правильно. Попробуйте ещё раз.");

                    }

                    else
                    {
                        if (PriceFarm[i] <= 0 && PriceFarm[i] <= 10000000)
                        {
                            Console.WriteLine("Не правильно. Попробуйте ещё раз.");
                            On = false;
                        }
                       
                    }
                }
                Console.Clear();
            }
        }
        public void writeFarm()
        {
            Console.WriteLine("Название:" + Name);
            for (int i = 0; i < PriceFarm.Length; i++)
            {
                Console.WriteLine("Лекарство: {0} цена: {1} р.", NameFarm[i], PriceFarm[i]);
            }
        }
        public void GiveBigNum()
        {
            double Max = 0;
            int imax = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Max < PriceFarm[i])
                {
                    Max = PriceFarm[i];
                    imax = i;
                }
            }
            Console.WriteLine("Самое большая цена у {0} с ценой {1} р.", NameFarm[imax], PriceFarm[imax]);
        }
        public void GiveSumm()
        {
            double Sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Sum += PriceFarm[i];
            }
            Console.WriteLine("Сумма всех цен лекарств:  " + Sum + " p.");
        }
    }
}
