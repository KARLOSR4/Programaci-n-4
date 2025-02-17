namespace Practica_2
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
            this.btnco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultadolbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtf = new System.Windows.Forms.TextBox();
            this.Convertir2 = new System.Windows.Forms.Button();
            this.result2 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnco
            // 
            this.btnco.BackColor = System.Drawing.Color.PeachPuff;
            this.btnco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnco.Location = new System.Drawing.Point(235, 75);
            this.btnco.Name = "btnco";
            this.btnco.Size = new System.Drawing.Size(97, 30);
            this.btnco.TabIndex = 0;
            this.btnco.Text = "Convertir";
            this.btnco.UseVisualStyleBackColor = false;
            this.btnco.Click += new System.EventHandler(this.btnco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsuis a Fahrenheit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblin
            // 
            this.lblin.Location = new System.Drawing.Point(18, 83);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(75, 22);
            this.lblin.TabIndex = 2;
            this.lblin.TextChanged += new System.EventHandler(this.lblin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Celsius";
            // 
            // Resultadolbl
            // 
            this.Resultadolbl.AutoSize = true;
            this.Resultadolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadolbl.ForeColor = System.Drawing.Color.White;
            this.Resultadolbl.Location = new System.Drawing.Point(436, 19);
            this.Resultadolbl.Name = "Resultadolbl";
            this.Resultadolbl.Size = new System.Drawing.Size(87, 20);
            this.Resultadolbl.TabIndex = 4;
            this.Resultadolbl.Text = "resultado";
            this.Resultadolbl.Click += new System.EventHandler(this.Resultadolbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "\"\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Farenehit a Celsuis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(18, 175);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 22);
            this.txtf.TabIndex = 7;
            this.txtf.TextChanged += new System.EventHandler(this.txtf_TextChanged);
            // 
            // Convertir2
            // 
            this.Convertir2.BackColor = System.Drawing.Color.PeachPuff;
            this.Convertir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Convertir2.Location = new System.Drawing.Point(235, 171);
            this.Convertir2.Name = "Convertir2";
            this.Convertir2.Size = new System.Drawing.Size(97, 30);
            this.Convertir2.TabIndex = 8;
            this.Convertir2.Text = "Convertir";
            this.Convertir2.UseVisualStyleBackColor = false;
            this.Convertir2.Click += new System.EventHandler(this.Convertir2_Click);
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.BackColor = System.Drawing.Color.Transparent;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.ForeColor = System.Drawing.Color.White;
            this.result2.Location = new System.Drawing.Point(445, 122);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(78, 20);
            this.result2.TabIndex = 9;
            this.result2.Text = "resultado";
            this.result2.Click += new System.EventHandler(this.result2_Click);
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Location = new System.Drawing.Point(472, 181);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(17, 16);
            this.result3.TabIndex = 10;
            this.result3.Text = "\"\"";
            this.result3.Click += new System.EventHandler(this.result3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(601, 260);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.Convertir2);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultadolbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultadolbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Button Convertir2;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result3;
    }
}

