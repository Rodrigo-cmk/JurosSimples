using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {



            string c, i, m;
            Decimal cs, ic, ms;
            Decimal j, mt;

            Console.WriteLine();
            Console.WriteLine("<----> Exercício Juros Simples <---->");
            Console.WriteLine("Cálculo do montante final de um investimento a juros simples.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--> Insira o Capital:");
            c = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("--> Insira o Juros:");
            i = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("--> Insira o Tempo em meses:");
            m = Console.ReadLine();
            Console.WriteLine();

            cs = Convert.ToDecimal(c);
            ic = Convert.ToDecimal(i);
            ms = Convert.ToDecimal(m);

            j = (cs * ic / 100) * ms;
            mt = j + cs;

            Console.WriteLine($"Juros: {j:C2}");
            Console.WriteLine($"Montante: {mt:C2}");















        }
    }
}
