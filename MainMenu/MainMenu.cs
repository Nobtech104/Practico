using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPractico1_Click(object sender, EventArgs e)
        {
            Form windowPractico = new WindowPractico1(this);

            try {

                windowPractico.Show();

                Hide();


            }
             catch(Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

                   

           

            
        }

        private void btnPractico2_Click(object sender, EventArgs e)
        {
            Form windowPractico = new WindowPractico2(this);

            try
            {

                Hide();

                windowPractico.Show();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }

        private void btnPractico3_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico3(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }



        }

        private void btnPractico4_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico1(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }


        }

        private void btnPractico5_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico1(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }

        private void btnPractico6_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico1(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }

        private void btnPractico7_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico1(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }

        private void btnPractico8_Click(object sender, EventArgs e)
        {

            Form windowPractico = new WindowPractico1(this);

            try
            {

                windowPractico.Show();

                Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }
    }
}
