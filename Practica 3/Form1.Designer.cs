namespace Practica_3
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
            this.btna = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.lbltext1 = new System.Windows.Forms.Label();
            this.txtin = new System.Windows.Forms.TextBox();
            this.resulta = new System.Windows.Forms.Label();
            this.resultp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.Plum;
            this.btna.Location = new System.Drawing.Point(414, 79);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(132, 95);
            this.btna.TabIndex = 1;
            this.btna.Text = "Calcular Area";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnp
            // 
            this.btnp.BackColor = System.Drawing.Color.Plum;
            this.btnp.Location = new System.Drawing.Point(414, 264);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(132, 95);
            this.btnp.TabIndex = 2;
            this.btnp.Text = "Calcular Perimetro";
            this.btnp.UseVisualStyleBackColor = false;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext1.ForeColor = System.Drawing.Color.White;
            this.lbltext1.Location = new System.Drawing.Point(33, 145);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(326, 29);
            this.lbltext1.TabIndex = 3;
            this.lbltext1.Text = "Ingrese el radio del circulo";
            this.lbltext1.Click += new System.EventHandler(this.lbltext1_Click);
            // 
            // txtin
            // 
            this.txtin.Location = new System.Drawing.Point(80, 231);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(227, 22);
            this.txtin.TabIndex = 4;
            this.txtin.TextChanged += new System.EventHandler(this.txtin_TextChanged);
            // 
            // resulta
            // 
            this.resulta.AutoSize = true;
            this.resulta.BackColor = System.Drawing.Color.White;
            this.resulta.Location = new System.Drawing.Point(658, 115);
            this.resulta.Name = "resulta";
            this.resulta.Size = new System.Drawing.Size(17, 16);
            this.resulta.TabIndex = 5;
            this.resulta.Text = "\"\"";
            this.resulta.Click += new System.EventHandler(this.resulta_Click);
            // 
            // resultp
            // 
            this.resultp.AutoSize = true;
            this.resultp.BackColor = System.Drawing.Color.White;
            this.resultp.ForeColor = System.Drawing.Color.Black;
            this.resultp.Location = new System.Drawing.Point(661, 295);
            this.resultp.Name = "resultp";
            this.resultp.Size = new System.Drawing.Size(17, 16);
            this.resultp.TabIndex = 6;
            this.resultp.Text = "\"\"";
            this.resultp.Click += new System.EventHandler(this.resultp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultp);
            this.Controls.Add(this.resulta);
            this.Controls.Add(this.txtin);
            this.Controls.Add(this.lbltext1);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.btna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.Label resulta;
        private System.Windows.Forms.Label resultp;
    }
}

