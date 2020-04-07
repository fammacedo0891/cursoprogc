using System;
using System.Globalization;                            
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararDatas
{
    class Data
    {


        //public TimeSpan DifDatas { get; set; }
        //public DateTime DataInicio { get; set; }

        public static DateTime d1;
        public static DateTime d2;


        public static DateTime Data1(DateTime data1)
        {

            return d1;
        }

        // definir valor como static permite chamar diretamente no program sem a necessidade de instanciar
        public static DateTime Data2(DateTime data2)
        {

            return d2;
        }

        //public void CalculoData(DateTime dataincio, DateTime datafim)
        //{
        //    DifDatas = datafim.Subtract(dataincio);
        //}



        public override string ToString()
        {
            return "d1: "
            + d1.ToString("dd/MM/yyyy")
            + " d2: "
            + d2.ToString("dd/MM/yyyy");
        }
    }
}
