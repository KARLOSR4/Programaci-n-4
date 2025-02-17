namespace Practica1
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
            this.btns = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btnm = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblr = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btns
            // 
            this.btns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btns.Location = new System.Drawing.Point(0, 12);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(125, 52);
            this.btns.TabIndex = 0;
            this.btns.Text = "Suma";
            this.btns.UseVisualStyleBackColor = false;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnr
            // 
            this.btnr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnr.Location = new System.Drawing.Point(0, 70);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(125, 54);
            this.btnr.TabIndex = 1;
            this.btnr.Text = "Resta";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnm
            // 
            this.btnm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnm.Location = new System.Drawing.Point(0, 130);
            this.btnm.Name = "btnm";
            this.btnm.Size = new System.Drawing.Size(125, 56);
            this.btnm.TabIndex = 2;
            this.btnm.Text = "Multiplicacion";
            this.btnm.UseVisualStyleBackColor = false;
            this.btnm.Click += new System.EventHandler(this.btnm_Click);
            // 
            // btnd
            // 
            this.btnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd.Location = new System.Drawing.Point(0, 192);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(125, 52);
            this.btnd.TabIndex = 3;
            this.btnd.Text = "Division";
            this.btnd.UseVisualStyleBackColor = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(190, 113);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 4;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(378, 113);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 5;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(548, 116);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(17, 16);
            this.lblr.TabIndex = 6;
            this.lblr.Text = "\"\"";
            this.lblr.Click += new System.EventHandler(this.lblr_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(519, 70);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(84, 20);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "\"\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(646, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnm);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnm;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label1;
    }
}

