namespace Practica_4
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.MaskedTextBox();
            this.lblun = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(69, 224);
            this.txtp.Name = "txtp";
            this.txtp.PasswordChar = '*';
            this.txtp.Size = new System.Drawing.Size(138, 22);
            this.txtp.TabIndex = 1;
            this.txtp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtp_MaskInputRejected);
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(82, 108);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(102, 25);
            this.lblun.TabIndex = 2;
            this.lblun.Text = "Username";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(86, 183);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(98, 25);
            this.lblpw.TabIndex = 3;
            this.lblpw.Text = "Password";
            this.lblpw.Click += new System.EventHandler(this.lblpw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Practica_4.Properties.Resources.icono;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnl
            // 
            this.btnl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnl.Location = new System.Drawing.Point(87, 275);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(98, 31);
            this.btnl.TabIndex = 5;
            this.btnl.Text = "Sign up";
            this.btnl.UseVisualStyleBackColor = false;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 330);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox txtp;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnl;
    }
}

