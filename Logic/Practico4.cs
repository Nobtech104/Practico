using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Practico4
    {

        public Practico4()
        {


        }

        public string ej1(decimal userBase, decimal userAlto)
        {

            string res =  ((userBase * userAlto) / 2) + "";

            return res;

        }

        public string suma(string salida, double temp)
        {

			double suma = temp + double.Parse(salida);

			salida = suma.ToString();

			suma = 0;

			return salida;


		}

        public string resta(string salida, double temp)
        {

			double resta = temp - double.Parse(salida);

			salida = resta.ToString();

			resta = 0;

			return salida;

		}

        public string multiplicar(string salida, double temp)
        {

			double multiplicar = temp * double.Parse(salida);

			salida = multiplicar.ToString();

			multiplicar = 0;

			return salida;

		}

        public string dividir(string salida, double temp)
        {

			double dividir = temp / double.Parse(salida);

			salida = dividir.ToString();

			dividir = 0;

			return salida;

		}

        public string ej3(decimal userIn)
        {

            string res = "";

            for(int i = 0; i <= 10; i++)
            {

                res = res + userIn + " x " + i + " = " + (userIn * i) + " - ";


            }


            return res;

        }

        public Boolean ej4(decimal userIn)
        {

            do
            {

                decimal res = userIn % 2;

                if (res == 0)
                {

                    return true;

                }
                else
                    return false;

            }
            while (userIn != 0);

        }


    }
}
