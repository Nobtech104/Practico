using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Practico3
    {

        public Practico3()
        {


        }


        public string ej1(int contH, int contM)
        {
            decimal total = contH + contM;

            decimal porcentajeH = (contH / total) * 100;
            decimal porcentajeM = (contM / total) * 100;

            string res = "El porcentaje de hombres es: " + porcentajeH 
                + "\r\nEl porcentaje de mujeres es: " + porcentajeM;


            return res;

        }


        public string ej2()
        {

            string res = "";

            int calc = 0;

            for(int i = 1; i <= 500; i++)
            {

                calc = calc + i;

                res = "" + calc;


            }

            return res;

        }

        public string ej3(decimal userIn)
        {

            string res = "";


            for (int i = 1; i <= 10; i++)
            {

                res = res + "" + userIn + " x " + i + " = " + (userIn * i) + ". ";

            }

            return res;


        }


        public string ej4(decimal userIn)
        {

            string res = "";

            int num1 = 0;
            int num2 = 1;

            int cont = 0;

            for(int i = 1; i <= userIn; i++)
            {

                try
                {

                    res = res + (num1 + num2) + " - ";

                    cont = num1;

                    num1 = num2;
                    num2 = cont + num1;

                   


                }
                catch(Exception ex)
                {

                    Console.WriteLine("Error:" + ex);

                }


            }

            

            return res;

        }

    }
}
