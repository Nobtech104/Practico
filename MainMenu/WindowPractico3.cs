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
    public partial class WindowPractico3 : Form
    {

        private Form parentForm;

        public WindowPractico3(Form parentWindow)
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
            catch(Exception ex)
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

        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            Practico3 practico = new Practico3();

            TxtResultado2.Text = practico.ej3(numUser2.Value);

        }

        private void btnAccept3_Click(object sender, EventArgs e)
        {
            Practico3 practico = new Practico3();

            TxtResultado3.Text = practico.ej4(numUser3.Value);
        }
    }
}
