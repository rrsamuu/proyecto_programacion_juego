namespace Proyecto_Programacion_lll
{
    partial class Perdedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perdedor));
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titulo.Location = new System.Drawing.Point(21, 60);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(663, 174);
            this.titulo.TabIndex = 23;
            this.titulo.Text = "¡...PERDISTE PORQUE TU NAVE SUFRIÓ VARIOS DAÑOS\r\nY EXPLOTÓ, PERO NO TE PREOCUPES " +
    "PORQUE PUEDES\r\nDEPOSITAR OTRO PESO DEL CAMBIO DE LA TORTILLA \r\nDEL QUE TE QUEDAS" +
    "...!\r\n\r\nADELANTE AMIGUITO :)\r\n";
            // 
            // Perdedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Programacion_lll.Properties.Resources.explosion2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(716, 295);
            this.Controls.Add(this.titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perdedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perdedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;

    }
}