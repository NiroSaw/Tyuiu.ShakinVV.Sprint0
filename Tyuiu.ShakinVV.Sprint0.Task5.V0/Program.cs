using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShakinVV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShakinVV.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Линейная структура
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            //Разветвляющаяся структура в библиотеке классов Division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();

        }
    }
}
