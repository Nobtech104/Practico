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
    public partial class WindowPractico1 : Form
    {
        //Attributes
        private Form parentForm;


        //Constructor
        public WindowPractico1(Form window)
        {

            parentForm = window;

            InitializeComponent();

            //window.Dispose();
        }


        //Get && Set
        public Form ParentForm1 { get => parentForm; set => parentForm = value; }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm1.Show();

            this.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            ParentForm1.Show();

            this.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            ParentForm1.Show();

            this.Close();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            ParentForm1.Show();

            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Practico1 practico = new Practico1();

            TxtResultado.Text = practico.ej1();
        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {
            Practico1 practico = new Practico1();

            TxtResultado1.Text = practico.ej2();
        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            Practico1 practico = new Practico1();

            TxtResultado2.Text = practico.ej3();
        }

        private void btnAccept3_Click(object sender, EventArgs e)
        {
            Practico1 practico = new Practico1();

            TxtResultado3.Text = practico.ej4();
        }





        /*          TESTING
        private void tbcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            Practico1 practico = new Practico1();

            if (tbcMenu.SelectedIndex == 0)
            {

                TxtResultado.Text = practico.ej1();
                

            }

            if (tbcMenu.SelectedIndex == 1)
            {

                TxtResultado1.Text = practico.ej2();


            }

            if(tbcMenu.SelectedIndex == 2)
            {

                TxtResultado2.Text = practico.ej3();

            }

            if(tbcMenu.SelectedIndex == 3)
            {

                TxtResultado3.Text = practico.ej4();

            } 
        } */
    }
}
