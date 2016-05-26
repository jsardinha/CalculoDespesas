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
            this.SuspendLayout();
            // 
            // buttonRetrocede
            // 
            this.buttonRetrocede.Location = new System.Drawing.Point(96, 200);
            this.buttonRetrocede.Name = "buttonRetrocede";
            this.buttonRetrocede.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrocede.TabIndex = 0;
            this.buttonRetrocede.Text = "Retroceder";
            this.buttonRetrocede.UseVisualStyleBackColor = true;
            this.buttonRetrocede.Click += new System.EventHandler(this.buttonRetrocede_Click);
            // 
            // FormRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonRetrocede);
            this.Name = "FormRegisto";
            this.Text = "Registo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRetrocede;
    }
}