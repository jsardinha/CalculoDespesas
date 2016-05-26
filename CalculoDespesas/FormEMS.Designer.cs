namespace CalculoDespesas
{
    partial class FormEMS
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
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.Location = new System.Drawing.Point(93, 193);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(75, 23);
            this.buttonRetroceder.TabIndex = 0;
            this.buttonRetroceder.Text = "Retroceder";
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Click += new System.EventHandler(this.buttonRetroceder_Click);
            // 
            // FormEMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonRetroceder);
            this.Name = "FormEMS";
            this.Text = "EMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRetroceder;
    }
}