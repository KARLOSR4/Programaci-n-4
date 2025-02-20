namespace Practica_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btne = new System.Windows.Forms.Button();
            this.txtalum = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txts);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.txtalum);
            this.groupBox1.Controls.Add(this.btne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbla);
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Calificaciones";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(22, 49);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(52, 16);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "2 Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "3 Parcial";
            // 
            // btne
            // 
            this.btne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btne.Location = new System.Drawing.Point(125, 141);
            this.btne.Name = "btne";
            this.btne.Size = new System.Drawing.Size(99, 37);
            this.btne.TabIndex = 4;
            this.btne.Text = "Evaluar";
            this.btne.UseVisualStyleBackColor = false;
            this.btne.Click += new System.EventHandler(this.btne_Click);
            // 
            // txtalum
            // 
            this.txtalum.Location = new System.Drawing.Point(100, 49);
            this.txtalum.Name = "txtalum";
            this.txtalum.Size = new System.Drawing.Size(154, 22);
            this.txtalum.TabIndex = 5;
            this.txtalum.TextChanged += new System.EventHandler(this.txtalum_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(504, 15);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(77, 22);
            this.txt1.TabIndex = 6;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(506, 74);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(75, 22);
            this.txts.TabIndex = 7;
            this.txts.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(506, 141);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(75, 22);
            this.txt3.TabIndex = 8;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(27, 247);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(747, 175);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtalum;
        private System.Windows.Forms.Button btne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.DataGridView dgv;
    }
}

