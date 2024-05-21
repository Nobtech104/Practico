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

namespace MainMenu
{
    public partial class WindowPractico4 : Form
    {

        private Form parentForm;

        public WindowPractico4(Form parentWindow)
        {
            InitializeComponent();

            parentForm = parentWindow;
        }

        public Form ParentForm1 { get => parentForm; set => parentForm = value; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ParentForm1.Show();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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

                MessageBox.Show("Error: " + ex, null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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

                MessageBox.Show("Error: " + ex, null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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

                MessageBox.Show("Error: " + ex, null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            txtResultado.Text = practico.ej1(numUserAlto.Value, numUserBase.Value);
        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            
        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            txtResultado2.Text = practico.ej3(numUser2.Value);

        }

        private void btnAccept3_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            txtResultado3.Text = Convert.ToString(practico.ej4(numUser3.Value));

            
        }
    }
}
