﻿namespace Taksi_udruzenje.Forme
{
    partial class AzurirajTaxiForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datumIstekaReg = new System.Windows.Forms.DateTimePicker();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAzurirajVozaca = new System.Windows.Forms.Button();
            this.txbMarka = new System.Windows.Forms.TextBox();
            this.txtGodProizv = new System.Windows.Forms.TextBox();
            this.txbTip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datumIstekaReg);
            this.groupBox1.Controls.Add(this.txtRegOznaka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAzurirajVozaca);
            this.groupBox1.Controls.Add(this.txbMarka);
            this.groupBox1.Controls.Add(this.txtGodProizv);
            this.groupBox1.Controls.Add(this.txbTip);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o taxi vozilu";
            // 
            // datumIstekaReg
            // 
            this.datumIstekaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumIstekaReg.Location = new System.Drawing.Point(184, 179);
            this.datumIstekaReg.Name = "datumIstekaReg";
            this.datumIstekaReg.Size = new System.Drawing.Size(152, 22);
            this.datumIstekaReg.TabIndex = 15;
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(184, 37);
            this.txtRegOznaka.MaxLength = 8;
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(152, 22);
            this.txtRegOznaka.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reg. oznaka";
            // 
            // btnAzurirajVozaca
            // 
            this.btnAzurirajVozaca.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajVozaca.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajVozaca.Location = new System.Drawing.Point(218, 294);
            this.btnAzurirajVozaca.Name = "btnAzurirajVozaca";
            this.btnAzurirajVozaca.Size = new System.Drawing.Size(109, 37);
            this.btnAzurirajVozaca.TabIndex = 12;
            this.btnAzurirajVozaca.Text = "AZURIRAJ";
            this.btnAzurirajVozaca.UseVisualStyleBackColor = false;
            this.btnAzurirajVozaca.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txbMarka
            // 
            this.txbMarka.Location = new System.Drawing.Point(184, 140);
            this.txbMarka.Name = "txbMarka";
            this.txbMarka.Size = new System.Drawing.Size(152, 22);
            this.txbMarka.TabIndex = 9;
            // 
            // txtGodProizv
            // 
            this.txtGodProizv.Location = new System.Drawing.Point(184, 104);
            this.txtGodProizv.MaxLength = 4;
            this.txtGodProizv.Name = "txtGodProizv";
            this.txtGodProizv.Size = new System.Drawing.Size(152, 22);
            this.txtGodProizv.TabIndex = 6;
            // 
            // txbTip
            // 
            this.txbTip.Location = new System.Drawing.Point(184, 69);
            this.txbTip.Name = "txbTip";
            this.txbTip.Size = new System.Drawing.Size(152, 22);
            this.txbTip.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum isteka reg. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina proizvodnje :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka :";
            // 
            // AzurirajTaxiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(366, 370);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AzurirajTaxiForma";
            this.Text = "AZURIRANJE TAXI VOZILA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAzurirajVozaca;
        private System.Windows.Forms.TextBox txtGodProizv;
        private System.Windows.Forms.TextBox txbTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumIstekaReg;
        private System.Windows.Forms.TextBox txbMarka;
    }
}