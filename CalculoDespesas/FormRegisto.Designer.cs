namespace CalculoDespesas
{
    partial class FormRegisto
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
            this.buttonRetrocede = new System.Windows.Forms.Button();
            this.peso = new System.Windows.Forms.NumericUpDown();
            this.valor = new System.Windows.Forms.NumericUpDown();
            this.labelrm = new System.Windows.Forms.Label();
            this.labelrmc = new System.Windows.Forms.Label();
            this.labelrp = new System.Windows.Forms.Label();
            this.labelrs = new System.Windows.Forms.Label();
            this.labelrsc = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetrocede
            // 
            this.buttonRetrocede.Location = new System.Drawing.Point(10, 150);
            this.buttonRetrocede.Name = "buttonRetrocede";
            this.buttonRetrocede.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrocede.TabIndex = 0;
            this.buttonRetrocede.Text = "Retroceder";
            this.buttonRetrocede.UseVisualStyleBackColor = true;
            this.buttonRetrocede.Click += new System.EventHandler(this.buttonRetrocede_Click);
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(10, 16);
            this.peso.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.peso.Name = "peso";
            this.peso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peso.Size = new System.Drawing.Size(60, 20);
            this.peso.TabIndex = 1;
            this.peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valor
            // 
            this.valor.DecimalPlaces = 2;
            this.valor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valor.Location = new System.Drawing.Point(10, 49);
            this.valor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(60, 20);
            this.valor.TabIndex = 2;
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor.Value = new decimal(new int[] {
            500000,
            0,
            0,
            131072});
            this.valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
            // 
            // labelrm
            // 
            this.labelrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrm.Location = new System.Drawing.Point(314, 14);
            this.labelrm.Name = "labelrm";
            this.labelrm.Size = new System.Drawing.Size(40, 15);
            this.labelrm.TabIndex = 3;
            this.labelrm.Text = "rm";
            this.labelrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelrmc
            // 
            this.labelrmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrmc.Location = new System.Drawing.Point(314, 38);
            this.labelrmc.Name = "labelrmc";
            this.labelrmc.Size = new System.Drawing.Size(40, 15);
            this.labelrmc.TabIndex = 4;
            this.labelrmc.Text = "rmc";
            this.labelrmc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelrp
            // 
            this.labelrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrp.Location = new System.Drawing.Point(314, 62);
            this.labelrp.Name = "labelrp";
            this.labelrp.Size = new System.Drawing.Size(40, 15);
            this.labelrp.TabIndex = 5;
            this.labelrp.Text = "rp";
            this.labelrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelrs
            // 
            this.labelrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrs.Location = new System.Drawing.Point(314, 86);
            this.labelrs.Name = "labelrs";
            this.labelrs.Size = new System.Drawing.Size(40, 15);
            this.labelrs.TabIndex = 6;
            this.labelrs.Text = "rs";
            this.labelrs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelrsc
            // 
            this.labelrsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrsc.Location = new System.Drawing.Point(314, 110);
            this.labelrsc.Name = "labelrsc";
            this.labelrsc.Size = new System.Drawing.Size(40, 15);
            this.labelrsc.TabIndex = 7;
            this.labelrsc.Text = "rsc";
            this.labelrsc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(279, 150);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpa
            // 
            this.buttonLimpa.Location = new System.Drawing.Point(115, 150);
            this.buttonLimpa.Name = "buttonLimpa";
            this.buttonLimpa.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpa.TabIndex = 9;
            this.buttonLimpa.Text = "Limpa";
            this.buttonLimpa.UseVisualStyleBackColor = true;
            this.buttonLimpa.Click += new System.EventHandler(this.buttonLimpa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "gramas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Euros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Registo em mão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registo em mão à cobrança";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registo pessoal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Registo com seguro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registo com seguro à cobrança";
            // 
            // FormRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 190);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLimpa);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelrsc);
            this.Controls.Add(this.labelrs);
            this.Controls.Add(this.labelrp);
            this.Controls.Add(this.labelrmc);
            this.Controls.Add(this.labelrm);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.buttonRetrocede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisto";
            this.Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)(this.peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetrocede;
        private System.Windows.Forms.NumericUpDown peso;
        private System.Windows.Forms.NumericUpDown valor;
        private System.Windows.Forms.Label labelrm;
        private System.Windows.Forms.Label labelrmc;
        private System.Windows.Forms.Label labelrp;
        private System.Windows.Forms.Label labelrs;
        private System.Windows.Forms.Label labelrsc;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}