using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    internal class Mohasebe
    {
        public void AddAval()
        {
            Console.WriteLine("Plese Enter Number(<=0):");
            Console.Write("AZ: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("TA:");
            int M = int.Parse(Console.ReadLine());
            if (M < N)
            {
                Console.WriteLine("Error M<N");
                return;
            }
            for (int X = N; X < M; X++)
            {
                bool Pirme = true;
                if (X < 2)  Pirme  = false;
                for (long i = 2; i*i <= X; i++)
                {
                   
                    if (X % i == 0)
                    {
                        Pirme = false;
                        break;
                    }
                }
                if (Pirme) { Console.WriteLine("("+" "+ X + " " +")"); }
            }
            Console.ReadKey();
        }
        public void AddAynei() 
        {
            Console.WriteLine("Plese Enter Number(<=0):");
            Console.Write("AZ: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("TA:");
            int M = int.Parse(Console.ReadLine());
            if (M < N)
            {
                Console.WriteLine("Error M<N");
                return;
            }
            for (int Y = N; Y <= M; Y++)
            {
                int sum = 0;
                int n = Y;
                int R;
                int temp = n;
                while (n > 0)
                {
                    R = n % 10;
                    sum = (sum * 10) + R;
                    n = n / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine("(" + " " + Y + " " + ")");
                }
            }
            Console.ReadKey();
        }
    }
}
