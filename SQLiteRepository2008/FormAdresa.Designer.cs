namespace SQLiteRepository2008
{
    partial class FormAdresa
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
            this.btnDodajAdresu = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxDrzava = new System.Windows.Forms.TextBox();
            this.tbxPosKod = new System.Windows.Forms.TextBox();
            this.tbxGrad = new System.Windows.Forms.TextBox();
            this.tbxOpstina = new System.Windows.Forms.TextBox();
            this.nBrUlice = new System.Windows.Forms.NumericUpDown();
            this.nBrZgrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nBrUlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBrZgrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajAdresu
            // 
            this.btnDodajAdresu.Location = new System.Drawing.Point(293, 93);
            this.btnDodajAdresu.Name = "btnDodajAdresu";
            this.btnDodajAdresu.Size = new System.Drawing.Size(104, 23);
            this.btnDodajAdresu.TabIndex = 16;
            this.btnDodajAdresu.Text = "Dodaj Adresu";
            this.btnDodajAdresu.UseVisualStyleBackColor = true;
            this.btnDodajAdresu.Click += new System.EventHandler(this.btnDodajAdresu_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 174);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Drzava";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Postanski kod";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Grad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Opstina";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Broj ulice";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Broj zgrade";
            // 
            // tbxDrzava
            // 
            this.tbxDrzava.Location = new System.Drawing.Point(109, 174);
            this.tbxDrzava.Name = "tbxDrzava";
            this.tbxDrzava.Size = new System.Drawing.Size(100, 20);
            this.tbxDrzava.TabIndex = 6;
            // 
            // tbxPosKod
            // 
            this.tbxPosKod.Location = new System.Drawing.Point(109, 145);
            this.tbxPosKod.Name = "tbxPosKod";
            this.tbxPosKod.Size = new System.Drawing.Size(100, 20);
            this.tbxPosKod.TabIndex = 7;
            // 
            // tbxGrad
            // 
            this.tbxGrad.Location = new System.Drawing.Point(109, 118);
            this.tbxGrad.Name = "tbxGrad";
            this.tbxGrad.Size = new System.Drawing.Size(100, 20);
            this.tbxGrad.TabIndex = 8;
            // 
            // tbxOpstina
            // 
            this.tbxOpstina.Location = new System.Drawing.Point(109, 92);
            this.tbxOpstina.Name = "tbxOpstina";
            this.tbxOpstina.Size = new System.Drawing.Size(100, 20);
            this.tbxOpstina.TabIndex = 9;
            // 
            // nBrUlice
            // 
            this.nBrUlice.Location = new System.Drawing.Point(109, 59);
            this.nBrUlice.Name = "nBrUlice";
            this.nBrUlice.Size = new System.Drawing.Size(120, 20);
            this.nBrUlice.TabIndex = 4;
            // 
            // nBrZgrade
            // 
            this.nBrZgrade.Location = new System.Drawing.Point(109, 33);
            this.nBrZgrade.Name = "nBrZgrade";
            this.nBrZgrade.Size = new System.Drawing.Size(120, 20);
            this.nBrZgrade.TabIndex = 5;
            // 
            // FormAdresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 414);
            this.Controls.Add(this.btnDodajAdresu);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbxDrzava);
            this.Controls.Add(this.tbxPosKod);
            this.Controls.Add(this.tbxGrad);
            this.Controls.Add(this.tbxOpstina);
            this.Controls.Add(this.nBrUlice);
            this.Controls.Add(this.nBrZgrade);
            this.Name = "FormAdresa";
            this.Text = "FormAdresa";
            ((System.ComponentModel.ISupportInitialize)(this.nBrUlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBrZgrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajAdresu;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxDrzava;
        private System.Windows.Forms.TextBox tbxPosKod;
        private System.Windows.Forms.TextBox tbxGrad;
        private System.Windows.Forms.TextBox tbxOpstina;
        private System.Windows.Forms.NumericUpDown nBrUlice;
        private System.Windows.Forms.NumericUpDown nBrZgrade;
    }
}