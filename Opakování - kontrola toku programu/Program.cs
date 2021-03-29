using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakování___kontrola_toku_programu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int n = 10;


            Console.WriteLine(While(x, n));
            Console.WriteLine(For(x, n));
            Console.WriteLine(DoWhile(x, n));
            Console.WriteLine(Vypocet(x, n));
            Console.ReadLine();
        }

        private static int DoWhile(int x, int n)
        {
            int i = 1;
            int vysledek = 1;
            do
            {
                //faktorial
                int j = i;
                int faktorial = 1;
                do
                {
                    faktorial *= j;
                    j--;
                } while (j > 1);

                if (i % 2 == 0) vysledek -= x * i / faktorial;
                else vysledek += x * i / faktorial;
                i++;

            } while (i <= n);
            return vysledek;
        }

        private static int While(int x, int n)
        {
            int i = 1;
            int vysledek = 1;
            while (i <= n)
            {
                //faktorial
                int j = i;
                int faktorial = 1;
                while (j >= 1)
                {
                    faktorial *= j;
                    j--;
                }

                if (i % 2 == 0) vysledek -= x * i / faktorial;
                else vysledek += x * i / faktorial;
                i++;
            }
            return vysledek;
        }

        private static int For(int x, int n)
        {
            int vysledek = 1;
            for (int i = 1; i <= n; i++)
            {
                int faktorial = 1;
                for (int j = i; j >= 1; j--) //faktorial
                {
                    faktorial *= j;
                }
                if (i % 2 == 0) vysledek -= x * i / faktorial;
                else vysledek += x * i / faktorial;
            }
            return vysledek;   
        }

        public static int Vypocet(int x, int n, int soucet = 0, int n_puvodni = 1)
        {
            if (n_puvodni == n)
                return soucet;

            if(n_puvodni == 1) { soucet += x * n_puvodni / Faktorial(n_puvodni); return Vypocet(x, n, soucet, n_puvodni + 1); }
            else if (soucet % 2 != 0) { soucet -= x * n_puvodni / Faktorial(n_puvodni); return Vypocet(x, n, soucet, n_puvodni + 1); }
            else { soucet += x * n_puvodni / Faktorial(n); return Vypocet(x, n, soucet, n_puvodni + 1); }   
        }

        public static int Faktorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Faktorial(n - 1);
        }
    }
}
