namespace CalculoDespesas
{
    partial class FormInicial
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonEMS = new System.Windows.Forms.Button();
            this.buttonRegisto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(72, 132);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonEMS
            // 
            this.buttonEMS.Location = new System.Drawing.Point(72, 85);
            this.buttonEMS.Name = "buttonEMS";
            this.buttonEMS.Size = new System.Drawing.Size(75, 23);
            this.buttonEMS.TabIndex = 1;
            this.buttonEMS.Text = "EMS";
            this.buttonEMS.UseVisualStyleBackColor = true;
            this.buttonEMS.Click += new System.EventHandler(this.buttonEMS_Click);
            // 
            // buttonRegisto
            // 
            this.buttonRegisto.Location = new System.Drawing.Point(72, 33);
            this.buttonRegisto.Name = "buttonRegisto";
            this.buttonRegisto.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisto.TabIndex = 2;
            this.buttonRegisto.Text = "Registo";
            this.buttonRegisto.UseVisualStyleBackColor = true;
            this.buttonRegisto.Click += new System.EventHandler(this.buttonRegisto_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 190);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRegisto);
            this.Controls.Add(this.buttonEMS);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonEMS;
        private System.Windows.Forms.Button buttonRegisto;
    }
}

