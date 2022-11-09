using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figi fig=new Figi();
            fig.first = 11;
            fig.second = 169 ;

            Console.Write($"Квадрат 1 числа: {Math.Pow(fig.first,2)},Корень 1 числа:{Math.Sqrt(fig.first)}");
            Console.Write($"Квадрат 2 числа: {Math.Pow(fig.second, 2)},Корень 2 числа:{Math.Sqrt(fig.second)}");
            Console.ReadKey();
        }
    }
}
public class Figi
{
   public double first { get; set; }    
    public double second { get; set; }
}
