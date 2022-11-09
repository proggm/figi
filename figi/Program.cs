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
            Figi fig = new Figi();

            Console.WriteLine(fig.Degree(11));
            Console.WriteLine(fig.Deg(169));
            Console.ReadKey();
        }
    }

    public class Figi
    {
        public double first { get; set; }


        public  double Degree(double first)
        {
            return first * first;
        }
        public  double Deg(double first)
        {
            return Math.Sqrt(first);
        }

    }
}

