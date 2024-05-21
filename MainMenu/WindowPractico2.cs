﻿using System;
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

        private void btnAccept3_Click(object sender, EventArgs e)
        {

            Practico2 practico = new Practico2();

           practico.ej4(numUser3.Value);

        }
    }
}
