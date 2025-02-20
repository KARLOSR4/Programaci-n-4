namespace Ejercicio_2
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
            this.combp = new System.Windows.Forms.ComboBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.lblp = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.btna = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combp);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.lblp);
            this.groupBox1.Controls.Add(this.lbla);
            this.groupBox1.Controls.Add(this.lbln);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combp
            // 
            this.combp.FormattingEnabled = true;
            this.combp.Items.AddRange(new object[] {
            "Mexico",
            "Estados Unidos",
            "Canada",
            "Peru",
            "Argentina",
            "Republica Dominicana",
            "Colombia",
            "Ecuador"});
            this.combp.Location = new System.Drawing.Point(444, 34);
            this.combp.Name = "combp";
            this.combp.Size = new System.Drawing.Size(133, 24);
            this.combp.TabIndex = 5;
            this.combp.Tag = "";
            this.combp.Text = "Seleccionar Pais";
            this.combp.SelectedIndexChanged += new System.EventHandler(this.combp_SelectedIndexChanged);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(135, 91);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 4;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(135, 36);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 3;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(366, 39);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(34, 16);
            this.lblp.TabIndex = 2;
            this.lblp.Text = "Pais";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(27, 91);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(57, 16);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Apellido";
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(27, 39);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(56, 16);
            this.lbln.TabIndex = 0;
            this.lbln.Text = "Nombre";
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.DeepPink;
            this.btna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btna.Location = new System.Drawing.Point(47, 214);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(104, 44);
            this.btna.TabIndex = 1;
            this.btna.Text = "Agregar";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnr
            // 
            this.btnr.BackColor = System.Drawing.Color.DeepPink;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnr.Location = new System.Drawing.Point(251, 214);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(103, 44);
            this.btnr.TabIndex = 2;
            this.btnr.Text = "Remover";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.C2,
            this.Colum3});
            this.dataGridView1.Location = new System.Drawing.Point(47, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Registro
            // 
            this.Registro.HeaderText = "Nombre";
            this.Registro.MinimumWidth = 6;
            this.Registro.Name = "Registro";
            this.Registro.Width = 125;
            // 
            // C2
            // 
            this.C2.HeaderText = "Apellido";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.Width = 125;
            // 
            // Colum3
            // 
            this.Colum3.HeaderText = "Pais";
            this.Colum3.MinimumWidth = 6;
            this.Colum3.Name = "Colum3";
            this.Colum3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.ComboBox combp;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum3;
    }
}

