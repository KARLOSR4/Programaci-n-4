namespace Pokedex
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btne = new System.Windows.Forms.Button();
            this.lbld = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(912, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(477, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Right";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnr
            // 
            this.btnr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnr.Location = new System.Drawing.Point(406, 350);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(54, 24);
            this.btnr.TabIndex = 2;
            this.btnr.Text = "Left";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btne
            // 
            this.btne.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btne.Location = new System.Drawing.Point(634, 376);
            this.btne.Name = "btne";
            this.btne.Size = new System.Drawing.Size(183, 46);
            this.btne.TabIndex = 3;
            this.btne.Text = "Iniciar Pokedex";
            this.btne.UseVisualStyleBackColor = false;
            this.btne.Click += new System.EventHandler(this.btne_Click);
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbld.Location = new System.Drawing.Point(517, 9);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(61, 16);
            this.lbld.TabIndex = 4;
            this.lbld.Text = "Pokedex";
            this.lbld.Click += new System.EventHandler(this.lbld_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(139, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.btne);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btne;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}