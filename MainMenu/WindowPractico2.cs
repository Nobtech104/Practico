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

        public Form ParentForm1 { get => parentForm; set => parentForm = value; }

        public WindowPractico2(Form window)
        {

            parentForm = window;

            InitializeComponent();
        }

        private void tbcMenu_Selected(object sender, TabControlEventArgs e)
        {

            Practico2 practico = new Practico2();




           /* if (tbcMenu.SelectedIndex == 2)
            {

                TxtResultado2.Text = practico.ej3();

            }

            if (tbcMenu.SelectedIndex == 3)
            {

                TxtResultado3.Text = practico.ej4();

            }*/
        }

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

            Practico2 practico = new Practico2();

            txtResultado.Text = practico.ej1(numUser.Value);

        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            txtResultado1.Text = practico.ej2(numUser1.Value);

        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            txtResultado2.Text = practico.ej3(numUser2.Value);

        }

        private void btnAccept3_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

            txtResultado.Text = practico.ej3(numUser.Value);

        }


    }
}
