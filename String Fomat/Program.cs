using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Fomat
{
    class Program
    {
        static void Main(string[] args)
        {
            string tytgun = "18";
            string tytay = "06" ;
            string tytyil = "2022";
            string tytsaat = "10";
            string tytdakika = "00";
            string tytsaniye = "00";
            var tyttarih = string.Format("{0:yyyy MM dd HH mm ss}", tytyil+tytgun+tytay+tytsaat+tytdakika+tytsaniye);
            var bugun = string.Format("{0:yyyy MM dd HH mm ss}", DateTime.Now);

            Console.WriteLine(tyttarih);
            Console.WriteLine(bugun);
            Console.ReadKey();
        }
    }
}
