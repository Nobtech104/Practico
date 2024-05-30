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
using MainMenu;

namespace Design
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void btnPractico1_Click(object sender, EventArgs e)
        {
            WindowPractico1 windowPractico = new WindowPractico1(this);

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
            WindowPractico2 windowPractico = new WindowPractico2(this);

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

            WindowPractico3 windowPractico = new WindowPractico3(this);

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

            WindowPractico4 windowPractico = new WindowPractico4(this);

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

		private void timerHour_Tick(object sender, EventArgs e)
		{
			lblHour.Text = DateTime.Now.ToShortTimeString();
		}
	}
}
