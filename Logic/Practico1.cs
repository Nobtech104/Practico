using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Practico1
    {

        public Practico1()
        {

        }

        public string ej1()
        {

            int num = 1;
            string res = "";

            while (num <= 10)
            {

                if (num == 10)
                {

                    res = res + num;

                }

                else
                {
                    res = res + num + " - ";
                }
                num++;
                
            }
            return res;
        }

        public string ej2()
        {

            int num = 1;
            string res = "";

            do
            {
                if (num == 10)
                {

                    res = res + num;

                }

                else
                {
                    res = res + num + " - ";
                }

                num++;
            }

            while (num <= 10);

            return res;
        }

        public string ej3()
        {


            string res = "";

            for (int i = 1; i <= 10; i++)
            {

                if (i == 10)
                {

                    res = res + i;

                    

                }

                else
                {
                    res = res + i + " - ";
                }


            }

            return res;

        }


        public string ej4()
        {

            string res = "";

            for(int i = 1; i <=100; i = i + 2)
            {

                res = res + i + " ";
            }

            res = res + "100";

            return res;

        }



    }
}
