namespace pryMolina
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirma
            // 
            this.btnFirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirma.BackgroundImage")));
            this.btnFirma.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFirma.Location = new System.Drawing.Point(1, 2);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(170, 122);
            this.btnFirma.TabIndex = 0;
            this.btnFirma.Text = "Firma";
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJuego.BackgroundImage")));
            this.btnJuego.Location = new System.Drawing.Point(177, 2);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(170, 122);
            this.btnJuego.TabIndex = 1;
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 129);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.btnFirma);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFirma;
        private Button btnJuego;
    }
}