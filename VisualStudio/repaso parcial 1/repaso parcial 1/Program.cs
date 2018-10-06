using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(2000, 10, 10);
            DateTime fecha2 = new DateTime(2000, 10, 11);
            long wopa;
            Console.WriteLine((fecha1 - fecha2).TotalHours);
            Console.ReadKey();
        }
    }
}
