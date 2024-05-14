using System.Windows.Forms;

namespace Design
{
    partial class WindowPractico2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpEjercicio4 = new System.Windows.Forms.TabPage();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.txtResultado3 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tbpEjercicio1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.numUser = new System.Windows.Forms.NumericUpDown();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.tbpEjercicio2 = new System.Windows.Forms.TabPage();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnAccept1 = new System.Windows.Forms.Button();
            this.numUser1 = new System.Windows.Forms.NumericUpDown();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.tbpEjercicio3 = new System.Windows.Forms.TabPage();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.numUser2 = new System.Windows.Forms.NumericUpDown();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAccept2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbpEjercicio4.SuspendLayout();
            this.tbcMenu.SuspendLayout();
            this.tbpEjercicio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser)).BeginInit();
            this.tbpEjercicio2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser1)).BeginInit();
            this.tbpEjercicio3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpEjercicio4
            // 
            this.tbpEjercicio4.BackColor = System.Drawing.Color.LightSalmon;
            this.tbpEjercicio4.Controls.Add(this.numericUpDown1);
            this.tbpEjercicio4.Controls.Add(this.button3);
            this.tbpEjercicio4.Controls.Add(this.button4);
            this.tbpEjercicio4.Controls.Add(this.lblSubtitle3);
            this.tbpEjercicio4.Controls.Add(this.txtResultado3);
            this.tbpEjercicio4.Location = new System.Drawing.Point(4, 32);
            this.tbpEjercicio4.Name = "tbpEjercicio4";
            this.tbpEjercicio4.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEjercicio4.Size = new System.Drawing.Size(1260, 586);
            this.tbpEjercicio4.TabIndex = 3;
            this.tbpEjercicio4.Text = "Ejercicio 4";
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Font = new System.Drawing.Font("Jersey 10", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle3.Location = new System.Drawing.Point(387, 34);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(479, 40);
            this.lblSubtitle3.TabIndex = 5;
            this.lblSubtitle3.Text = "Imprimir valores del 1 al 10 de 2 en 2";
            // 
            // txtResultado3
            // 
            this.txtResultado3.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtResultado3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado3.Location = new System.Drawing.Point(398, 235);
            this.txtResultado3.Multiline = true;
            this.txtResultado3.Name = "txtResultado3";
            this.txtResultado3.ReadOnly = true;
            this.txtResultado3.Size = new System.Drawing.Size(460, 217);
            this.txtResultado3.TabIndex = 4;
            this.txtResultado3.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Jersey 10", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(494, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 69);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PRÁCTICO 2";
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tbpEjercicio1);
            this.tbcMenu.Controls.Add(this.tbpEjercicio2);
            this.tbcMenu.Controls.Add(this.tbpEjercicio3);
            this.tbcMenu.Controls.Add(this.tbpEjercicio4);
            this.tbcMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcMenu.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMenu.HotTrack = true;
            this.tbcMenu.Location = new System.Drawing.Point(-2, 60);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(1268, 622);
            this.tbcMenu.TabIndex = 0;
            this.tbcMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcMenu_Selected);
            // 
            // tbpEjercicio1
            // 
            this.tbpEjercicio1.BackColor = System.Drawing.Color.LightSalmon;
            this.tbpEjercicio1.Controls.Add(this.btnCancel);
            this.tbpEjercicio1.Controls.Add(this.btnAccept);
            this.tbpEjercicio1.Controls.Add(this.numUser);
            this.tbpEjercicio1.Controls.Add(this.lblSubtitle);
            this.tbpEjercicio1.Controls.Add(this.txtResultado);
            this.tbpEjercicio1.Location = new System.Drawing.Point(4, 32);
            this.tbpEjercicio1.Name = "tbpEjercicio1";
            this.tbpEjercicio1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEjercicio1.Size = new System.Drawing.Size(1260, 586);
            this.tbpEjercicio1.TabIndex = 1;
            this.tbpEjercicio1.Text = "Ejercicio 1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(667, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Volver";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(496, 512);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(97, 31);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // numUser
            // 
            this.numUser.BackColor = System.Drawing.Color.DarkSalmon;
            this.numUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUser.Font = new System.Drawing.Font("Jersey 10", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUser.Location = new System.Drawing.Point(570, 128);
            this.numUser.Name = "numUser";
            this.numUser.Size = new System.Drawing.Size(120, 36);
            this.numUser.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Jersey 10", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(461, 35);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(339, 40);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "¿Es mayor de edad o no?";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Location = new System.Drawing.Point(400, 235);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(460, 217);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TabStop = false;
            // 
            // tbpEjercicio2
            // 
            this.tbpEjercicio2.BackColor = System.Drawing.Color.LightSalmon;
            this.tbpEjercicio2.Controls.Add(this.btnCancel1);
            this.tbpEjercicio2.Controls.Add(this.btnAccept1);
            this.tbpEjercicio2.Controls.Add(this.numUser1);
            this.tbpEjercicio2.Controls.Add(this.lblSubtitle1);
            this.tbpEjercicio2.Controls.Add(this.txtResultado1);
            this.tbpEjercicio2.Location = new System.Drawing.Point(4, 32);
            this.tbpEjercicio2.Name = "tbpEjercicio2";
            this.tbpEjercicio2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEjercicio2.Size = new System.Drawing.Size(1260, 586);
            this.tbpEjercicio2.TabIndex = 0;
            this.tbpEjercicio2.Text = "Ejercicio 2";
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel1.Location = new System.Drawing.Point(667, 512);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(97, 31);
            this.btnCancel1.TabIndex = 3;
            this.btnCancel1.Text = "Volver";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnAccept1
            // 
            this.btnAccept1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept1.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept1.Location = new System.Drawing.Point(496, 512);
            this.btnAccept1.Name = "btnAccept1";
            this.btnAccept1.Size = new System.Drawing.Size(97, 31);
            this.btnAccept1.TabIndex = 2;
            this.btnAccept1.Text = "Aceptar";
            this.btnAccept1.UseVisualStyleBackColor = false;
            this.btnAccept1.Click += new System.EventHandler(this.btnAccept1_Click);
            // 
            // numUser1
            // 
            this.numUser1.BackColor = System.Drawing.Color.DarkSalmon;
            this.numUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUser1.Font = new System.Drawing.Font("Jersey 10", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUser1.Location = new System.Drawing.Point(570, 128);
            this.numUser1.Name = "numUser1";
            this.numUser1.Size = new System.Drawing.Size(120, 36);
            this.numUser1.TabIndex = 1;
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.Font = new System.Drawing.Font("Jersey 10", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle1.Location = new System.Drawing.Point(532, 34);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Size = new System.Drawing.Size(197, 40);
            this.lblSubtitle1.TabIndex = 3;
            this.lblSubtitle1.Text = "¿Par o impar?";
            // 
            // txtResultado1
            // 
            this.txtResultado1.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtResultado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado1.Location = new System.Drawing.Point(400, 235);
            this.txtResultado1.Multiline = true;
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.ReadOnly = true;
            this.txtResultado1.Size = new System.Drawing.Size(460, 217);
            this.txtResultado1.TabIndex = 2;
            this.txtResultado1.TabStop = false;
            // 
            // tbpEjercicio3
            // 
            this.tbpEjercicio3.BackColor = System.Drawing.Color.LightSalmon;
            this.tbpEjercicio3.Controls.Add(this.btnCancel2);
            this.tbpEjercicio3.Controls.Add(this.btnAccept2);
            this.tbpEjercicio3.Controls.Add(this.numUser2);
            this.tbpEjercicio3.Controls.Add(this.lblSubtitle2);
            this.tbpEjercicio3.Controls.Add(this.txtResultado2);
            this.tbpEjercicio3.Location = new System.Drawing.Point(4, 32);
            this.tbpEjercicio3.Name = "tbpEjercicio3";
            this.tbpEjercicio3.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEjercicio3.Size = new System.Drawing.Size(1260, 586);
            this.tbpEjercicio3.TabIndex = 2;
            this.tbpEjercicio3.Text = "Ejercicio 3";
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Jersey 10", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.Location = new System.Drawing.Point(476, 34);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(309, 40);
            this.lblSubtitle2.TabIndex = 0;
            this.lblSubtitle2.Text = "Imprimir lista de pares";
            // 
            // txtResultado2
            // 
            this.txtResultado2.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtResultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado2.Location = new System.Drawing.Point(400, 235);
            this.txtResultado2.Multiline = true;
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.ReadOnly = true;
            this.txtResultado2.Size = new System.Drawing.Size(460, 217);
            this.txtResultado2.TabIndex = 0;
            this.txtResultado2.TabStop = false;
            // 
            // numUser2
            // 
            this.numUser2.BackColor = System.Drawing.Color.DarkSalmon;
            this.numUser2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUser2.Font = new System.Drawing.Font("Jersey 10", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUser2.Location = new System.Drawing.Point(570, 128);
            this.numUser2.Name = "numUser2";
            this.numUser2.Size = new System.Drawing.Size(120, 36);
            this.numUser2.TabIndex = 1;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel2.Location = new System.Drawing.Point(667, 512);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(97, 31);
            this.btnCancel2.TabIndex = 3;
            this.btnCancel2.Text = "Volver";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAccept2
            // 
            this.btnAccept2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAccept2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccept2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAccept2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept2.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept2.Location = new System.Drawing.Point(496, 512);
            this.btnAccept2.Name = "btnAccept2";
            this.btnAccept2.Size = new System.Drawing.Size(97, 31);
            this.btnAccept2.TabIndex = 2;
            this.btnAccept2.Text = "Aceptar";
            this.btnAccept2.UseVisualStyleBackColor = false;
            this.btnAccept2.Click += new System.EventHandler(this.btnAccept2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(667, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSalmon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(496, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnAccept3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DarkSalmon;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Jersey 10", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(570, 128);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown1.TabIndex = 1;
            // 
            // WindowPractico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbcMenu);
            this.MaximizeBox = false;
            this.Name = "WindowPractico2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowPractico2";
            this.tbpEjercicio4.ResumeLayout(false);
            this.tbpEjercicio4.PerformLayout();
            this.tbcMenu.ResumeLayout(false);
            this.tbpEjercicio1.ResumeLayout(false);
            this.tbpEjercicio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser)).EndInit();
            this.tbpEjercicio2.ResumeLayout(false);
            this.tbpEjercicio2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser1)).EndInit();
            this.tbpEjercicio3.ResumeLayout(false);
            this.tbpEjercicio3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tbpEjercicio4;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.TextBox txtResultado3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tbpEjercicio1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TabPage tbpEjercicio2;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.TabPage tbpEjercicio3;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.NumericUpDown numUser;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnAccept1;
        private System.Windows.Forms.NumericUpDown numUser1;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button4;
        private Button btnCancel2;
        private Button btnAccept2;
        private NumericUpDown numUser2;

        public TextBox TxtResultado { get => txtResultado; set => txtResultado = value; }
        public TextBox TxtResultado1 { get => txtResultado1; set => txtResultado1 = value; }
        public TextBox TxtResultado2 { get => txtResultado2; set => txtResultado2 = value; }
        public TextBox TxtResultado3 { get => txtResultado3; set => txtResultado3 = value; }
    }
}