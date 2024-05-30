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
    public partial class WindowPractico2 : Form
    {

        private Form parentForm;
        private List<int> listNumIn;



        public Form ParentForm1 { get => parentForm; set => parentForm = value; }

        public WindowPractico2(Form window)
        {

            parentForm = window;

            listNumIn = new List<int>();

            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                ParentForm1.Show();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {

            try
            {
                ParentForm1.Show();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {

            try
            {
                ParentForm1.Show();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {

            try
            {
                ParentForm1.Show();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            try
            {

                ParentForm1.Show();

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            TxtResultado.Text = practico.ej1(numUser.Value);

        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            TxtResultado1.Text = practico.ej2(numUser1.Value);

        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            TxtResultado2.Text = practico.ej3(numUser2.Value);

        }

        private void btnInList_Click(object sender, EventArgs e)
        {

            try
            {

                listNumIn.Add(Convert.ToInt32(numUser4.Value));

                listNumsIn.Items.Add(numUser4.Value);

                numUser4.Focus();

            }
            catch(Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            TxtResultado4.Text = practico.ej4(listNumIn);

        }

       
    }
        
}
