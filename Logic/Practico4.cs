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

        public string ej2(decimal userBase, decimal userAlto)
        {

            string res = ((userBase * userAlto) / 2) + "";

            return res;

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
