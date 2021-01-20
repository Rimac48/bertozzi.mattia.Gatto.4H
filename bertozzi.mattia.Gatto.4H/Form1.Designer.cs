namespace bertozzi.mattia.Gatto._4H
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGatto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGatto
            // 
            this.btnGatto.Location = new System.Drawing.Point(12, 12);
            this.btnGatto.Name = "btnGatto";
            this.btnGatto.Size = new System.Drawing.Size(126, 62);
            this.btnGatto.TabIndex = 0;
            this.btnGatto.Text = "Genera gatto";
            this.btnGatto.UseVisualStyleBackColor = true;
            this.btnGatto.Click += new System.EventHandler(this.btnGatto_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGatto);
            this.Name = "frmMain";
            this.Text = "Generatore di Gatti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGatto;
    }
}

