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
        private int contH = 0;
        private int contM = 0;


        public WindowPractico3(Form parentWindow)
        {
            InitializeComponent();

            parentForm = parentWindow;
        }

        public Form ParentForm1 { get => parentForm; set => parentForm = value; }
        public int ContH { get => contH; set => contH = value; }
        public int ContM { get => contM; set => contM = value; }

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

        private void btnAccept1_Click(object sender, EventArgs e)
        {

            Practico3 practico = new Practico3();

            TxtResultado1.Text = practico.ej2();
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

        private void btnCalc_Click(object sender, EventArgs e)
        {

            Practico3 practico = new Practico3();

            TxtResultado.Text = practico.ej1(ContH, ContM);


        }

        private void btnInH_Click(object sender, EventArgs e)
        {
            ContH++;
            listPersonasIn.Items.Insert(1, contH + " Hombres.");

            if(listPersonasIn.Items.Count > 2)
            {
                listPersonasIn.Items.RemoveAt(2);
            }

        }

        private void btnInM_Click(object sender, EventArgs e)
        {
            ContM++;
            listPersonasIn.Items.Insert(2, contM + " Mujeres.");

            listPersonasIn.Items.RemoveAt(3);
        }
    }
}
