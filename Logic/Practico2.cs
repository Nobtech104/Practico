﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
     public class Practico2
    {


        public Practico2()
        {


        }



        public string ej1(decimal userIn)
        {

            if(userIn < 18)
            {

                return "Es menor";
            }

            else
            {

                return "Es mayor";

            }

        }

        public string ej2(decimal userIn)
        {

            decimal calc = userIn % 2;

            if (calc == 0)
            {

                return "El número ingresado es par";

            }
            else
                return "El número ingresado es impar";

        }

        public string ej3(decimal userIn)
        {

            string res = "";

            for(int i = 2; i <= userIn * 2; i = i + 2)
            {

                res = res + i + " ";

            }

            return res;

        }

        public string ej4(decimal userIn)
        {

            string res = "";


            for (int i = 0; i <= 3; i++)
            {

                res = res + userIn + " ";

            }

    }
}
