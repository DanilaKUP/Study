using System;

namespace SP__1_
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag2 = true;
            while (flag2)
            {
                Console.WriteLine("podzadanie");
                int choise2 = System.Convert.ToInt32(Console.ReadLine());
                System.IO.StreamReader sr = new System.IO.StreamReader("Z://Файлы//inputFile.txt");

                Class1 country = new Class1();

                switch (choise2)
                {
                    case 1:
                        {
                            country.vivod();
                            country.vivod();
                            country.vivod();
                            country.vivod();
                            Console.WriteLine(country);
                            break;
                        }
                    case 2:
                        {
                            flag2 = false;
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
