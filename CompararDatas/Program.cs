using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararDatas
{
    class Program
    {

        static void Main(string[] args)
        {

            //Data Dt = new Data();
            DateTime pd1, pd2;
            DateTime pr1, pr2;

            Console.Write("Informe uma data1: ");
            pd1 = DateTime.Parse(Console.ReadLine());

            Data.d1 = pd1;

            Console.Write("Informe uma data2: ");
            pd2 = DateTime.Parse(Console.ReadLine());

            Data.d2 = pd2;

            Console.WriteLine("*** trabalhando com atributo diretamente ***");

            Console.Write("Data1: " + Data.d1.ToString("dd/MM/yyyy"));
            Console.WriteLine();
            Console.Write("Data2: " + Data.d2.ToString("dd/MM/yyyy"));


            Console.WriteLine();
            Console.WriteLine("*** trabalhando com método diretamente ***");

            pr1 = Data.Data1(pd1);
            pr2 = Data.Data2(pd2);

            Console.Write("Data1: " + pr1.ToString("dd/MM/yyyy"));

            Console.WriteLine();

            Console.Write("Data2: " + pr2.ToString("dd/MM/yyyy"));
            Console.WriteLine();

            //Console.Write("Informe a data final: ");
            //d2 = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine(d1);
            //CompData = new Data(d1, d2);

            //CompData.CalculoData(d1, d2);


        }


    }
}
