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
		private string operacion = "";
		private double temp = 0;
		private string salida = "";

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

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            txtResultado2.Text = practico.ej3(numUser3.Value);

        }

        private void btnAccept3_Click(object sender, EventArgs e)
        {
            Practico4 practico = new Practico4();

            txtResultado3.Text = Convert.ToString(practico.ej4(numUser4.Value));


        }

        

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblHour.Text = DateTime.Now.ToShortTimeString();
		}

		private void btnCancel1_MouseEnter(object sender, EventArgs e)
		{
			btnCancel1.BackColor = Color.Red;
		}

		private void btnCancel1_MouseLeave(object sender, EventArgs e)
		{
			btnCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
		}

		private void btnNum0_Click(object sender, EventArgs e)
		{
			salida += "0";
			lblOperacion.Text = lblOperacion.Text + " 0";
		}

		private void btnComa_Click(object sender, EventArgs e)
		{
			salida += ",";
			lblOperacion.Text = lblOperacion.Text + ",";
		}

		private void btnNum1_Click(object sender, EventArgs e)
		{
			salida += "1";
			lblOperacion.Text = lblOperacion.Text + " 1";
		}

		private void btnNum2_Click(object sender, EventArgs e)
		{
			salida += "2";
			lblOperacion.Text = lblOperacion.Text + " 2";
		}

		private void btnNum3_Click(object sender, EventArgs e)
		{
			salida += "3";
			lblOperacion.Text = lblOperacion.Text + " 3";
		}

		private void btnNum4_Click(object sender, EventArgs e)
		{
			salida += "4";
			lblOperacion.Text = lblOperacion.Text + " 4";
		}

		private void btnNum5_Click(object sender, EventArgs e)
		{
			salida += "5";
			lblOperacion.Text = lblOperacion.Text + " 5";
		}

		private void btnNum6_Click(object sender, EventArgs e)
		{
			salida += "6";
			lblOperacion.Text = lblOperacion.Text + " 6";
		}

		private void btnNum7_Click(object sender, EventArgs e)
		{
			salida += "7";
			lblOperacion.Text = lblOperacion.Text + " 7";
		}

		private void btnNum8_Click(object sender, EventArgs e)
		{
			salida += "8";
			lblOperacion.Text = lblOperacion.Text + " 8";
		}

		private void btnNum9_Click(object sender, EventArgs e)
		{
			salida += "9";
			lblOperacion.Text = lblOperacion.Text + " 9";
		}

		private void btnMultiplicacion_Click(object sender, EventArgs e)
		{
			if(salida != "")
			{
				try
				{
					temp = double.Parse(salida);

					salida = "";

					operacion = "*";

				}
				catch (FormatException ex)
				{

					lblOperacion.Text = "Error: " + ex;
				}

			}
			lblOperacion.Text = temp.ToString() + " " + operacion;

			
		}

		private void btnResta_Click(object sender, EventArgs e)
		{
			if(salida != "")
			{
				try
				{
					temp = double.Parse(salida);

					salida = "";

					operacion = "-";

				}
				catch (FormatException)
				{

					lblOperacion.Text = "Error";
				}

			}

			lblOperacion.Text = temp.ToString() + " " + operacion;

			
		}

		private void btnSuma_Click(object sender, EventArgs e)
		{
			if(salida != "")
			{
				try
				{
					temp = double.Parse(salida);

					salida = "";

					operacion = "+";

				}
				catch (FormatException)
				{

					lblOperacion.Text = "Error";
				}

			}

			lblOperacion.Text = temp.ToString() + " " + operacion;
		}

		private void btnDivision_Click(object sender, EventArgs e)
		{
			if(salida != "")
			{
				try
				{
					temp = double.Parse(salida);

					salida = "";

					operacion = "/";

				}
				catch(FormatException)
				{

					lblOperacion.Text = "Error:";
				}
			}

			lblOperacion.Text = temp.ToString() + " " + operacion;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lblOperacion.Text = "";
			salida = "";
			temp = 0;

		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(salida))
				salida = temp.ToString();

			Practico4 practico = new Practico4();


			switch (operacion)
			{

				case "+":

					salida = practico.suma(salida, temp);
					lblOperacion.Text = salida;
					break;

				case "-":

					salida = practico.resta(salida, temp);
					lblOperacion.Text = salida;
					break;

				case "*":

					salida = practico.multiplicar(salida, temp);
					lblOperacion.Text = salida;
					break;

				case "/":

					salida = practico.dividir(salida, temp);
					lblOperacion.Text = salida;
					break;

			}
		}
	}
}
