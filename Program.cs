using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            // S or N
            // Kiem tra du lieu nguoi dung
            do
            {
                Console.Write("Dong xu cua An: ");
                a = Console.ReadLine();
                Console.Write("Dong xu cua Binh: ");
                b = Console.ReadLine();
                Console.Write("Dong xu cua Cuong: ");
                c = Console.ReadLine();
                if (((a != "S") & (a != "N")) || ((b != "S") & (b != "N")) || ((c != "S") & (c != "N")))
                    Console.WriteLine("Moi ban nhap lai: 'S' hoac 'N'");
            }
            while (((a != "S") & (a != "N")) || ((b != "S") & (b != "N")) || ((c != "S") & (c != "N")));
            if ((a == b) && (b == c))
                Console.Write("Tat ca hoa nhau");
            else if ((a != b) && (a != c))
                Console.Write("An la nguoi thang cuoc");
            else if ((b != a) && (b != c))
                Console.Write("Binh la nguoi thang cuoc");
            else //if ((c != a) && (c != b))
                Console.Write("Cuong la nguoi thang cuoc");
            
            Console.Read();

        }
    }
}
