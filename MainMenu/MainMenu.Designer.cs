namespace Design
{
    public partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.lblTitle = new System.Windows.Forms.Label();
			this.buttonPanel = new System.Windows.Forms.GroupBox();
			this.btnPractico4 = new System.Windows.Forms.Button();
			this.btnPractico3 = new System.Windows.Forms.Button();
			this.btnPractico2 = new System.Windows.Forms.Button();
			this.btnPractico1 = new System.Windows.Forms.Button();
			this.hourPanel = new System.Windows.Forms.Panel();
			this.lblHour = new System.Windows.Forms.Label();
			this.timerHour = new System.Windows.Forms.Timer(this.components);
			this.buttonPanel.SuspendLayout();
			this.hourPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Jersey 10", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(501, 34);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(262, 69);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "PRÁCTICOS";
			// 
			// buttonPanel
			// 
			this.buttonPanel.BackColor = System.Drawing.Color.DarkSalmon;
			this.buttonPanel.Controls.Add(this.hourPanel);
			this.buttonPanel.Controls.Add(this.btnPractico4);
			this.buttonPanel.Controls.Add(this.btnPractico3);
			this.buttonPanel.Controls.Add(this.btnPractico2);
			this.buttonPanel.Controls.Add(this.btnPractico1);
			this.buttonPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPanel.Font = new System.Drawing.Font("Jersey 10", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPanel.Location = new System.Drawing.Point(155, 146);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(955, 388);
			this.buttonPanel.TabIndex = 2;
			this.buttonPanel.TabStop = false;
			this.buttonPanel.Text = "Elija un práctico";
			// 
			// btnPractico4
			// 
			this.btnPractico4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPractico4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPractico4.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPractico4.Location = new System.Drawing.Point(717, 244);
			this.btnPractico4.Name = "btnPractico4";
			this.btnPractico4.Size = new System.Drawing.Size(102, 78);
			this.btnPractico4.TabIndex = 3;
			this.btnPractico4.Text = "Práctico 4";
			this.btnPractico4.UseVisualStyleBackColor = true;
			this.btnPractico4.Click += new System.EventHandler(this.btnPractico4_Click);
			// 
			// btnPractico3
			// 
			this.btnPractico3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPractico3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPractico3.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPractico3.Location = new System.Drawing.Point(717, 108);
			this.btnPractico3.Name = "btnPractico3";
			this.btnPractico3.Size = new System.Drawing.Size(102, 78);
			this.btnPractico3.TabIndex = 2;
			this.btnPractico3.Text = "Práctico 3";
			this.btnPractico3.UseVisualStyleBackColor = true;
			this.btnPractico3.Click += new System.EventHandler(this.btnPractico3_Click);
			// 
			// btnPractico2
			// 
			this.btnPractico2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPractico2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPractico2.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPractico2.Location = new System.Drawing.Point(170, 244);
			this.btnPractico2.Name = "btnPractico2";
			this.btnPractico2.Size = new System.Drawing.Size(102, 78);
			this.btnPractico2.TabIndex = 1;
			this.btnPractico2.Text = "Práctico 2";
			this.btnPractico2.UseVisualStyleBackColor = true;
			this.btnPractico2.Click += new System.EventHandler(this.btnPractico2_Click);
			// 
			// btnPractico1
			// 
			this.btnPractico1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPractico1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPractico1.Font = new System.Drawing.Font("Jersey 10", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPractico1.Location = new System.Drawing.Point(170, 108);
			this.btnPractico1.Name = "btnPractico1";
			this.btnPractico1.Size = new System.Drawing.Size(102, 78);
			this.btnPractico1.TabIndex = 0;
			this.btnPractico1.Text = "Práctico 1";
			this.btnPractico1.UseVisualStyleBackColor = true;
			this.btnPractico1.Click += new System.EventHandler(this.btnPractico1_Click);
			// 
			// hourPanel
			// 
			this.hourPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.hourPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.hourPanel.Controls.Add(this.lblHour);
			this.hourPanel.Location = new System.Drawing.Point(332, 158);
			this.hourPanel.Name = "hourPanel";
			this.hourPanel.Size = new System.Drawing.Size(291, 73);
			this.hourPanel.TabIndex = 4;
			// 
			// lblHour
			// 
			this.lblHour.AutoSize = true;
			this.lblHour.Font = new System.Drawing.Font("Jersey 10", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHour.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblHour.Location = new System.Drawing.Point(109, 14);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(0, 40);
			this.lblHour.TabIndex = 0;
			// 
			// timerHour
			// 
			this.timerHour.Enabled = true;
			this.timerHour.Interval = 1000;
			this.timerHour.Tick += new System.EventHandler(this.timerHour_Tick);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.buttonPanel);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Principal";
			this.buttonPanel.ResumeLayout(false);
			this.hourPanel.ResumeLayout(false);
			this.hourPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox buttonPanel;
        private System.Windows.Forms.Button btnPractico4;
        private System.Windows.Forms.Button btnPractico3;
        private System.Windows.Forms.Button btnPractico2;
        private System.Windows.Forms.Button btnPractico1;
		private System.Windows.Forms.Panel hourPanel;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.Timer timerHour;
	}
}

