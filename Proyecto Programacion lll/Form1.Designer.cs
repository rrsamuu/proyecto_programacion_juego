namespace Proyecto_Programacion_lll
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reanudarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempojuego = new System.Windows.Forms.Timer(this.components);
            this.laser = new System.Windows.Forms.Timer(this.components);
            this.Juego = new System.Windows.Forms.PictureBox();
            this.sp2 = new System.Windows.Forms.PictureBox();
            this.sp22 = new System.Windows.Forms.PictureBox();
            this.lasser = new System.Windows.Forms.PictureBox();
            this.Puntuacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sp222 = new System.Windows.Forms.PictureBox();
            this.PAUSA = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Juego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp222)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicarJuegoToolStripMenuItem,
            this.instruccionesToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicarJuegoToolStripMenuItem
            // 
            this.inicarJuegoToolStripMenuItem.Name = "inicarJuegoToolStripMenuItem";
            this.inicarJuegoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.inicarJuegoToolStripMenuItem.Text = "Inicar Juego";
            this.inicarJuegoToolStripMenuItem.Click += new System.EventHandler(this.inicarJuegoToolStripMenuItem_Click);
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reanudarToolStripMenuItem});
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pausaToolStripMenuItem.Text = "Pausa";
            this.pausaToolStripMenuItem.Click += new System.EventHandler(this.pausaToolStripMenuItem_Click);
            // 
            // reanudarToolStripMenuItem
            // 
            this.reanudarToolStripMenuItem.Name = "reanudarToolStripMenuItem";
            this.reanudarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reanudarToolStripMenuItem.Text = "Reanudar";
            this.reanudarToolStripMenuItem.Click += new System.EventHandler(this.reanudarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tiempojuego
            // 
            this.tiempojuego.Tick += new System.EventHandler(this.tiempojuego_Tick);
            // 
            // laser
            // 
            this.laser.Tick += new System.EventHandler(this.laser_Tick);
            // 
            // Juego
            // 
            this.Juego.BackColor = System.Drawing.Color.Transparent;
            this.Juego.Image = global::Proyecto_Programacion_lll.Properties.Resources.juego;
            this.Juego.Location = new System.Drawing.Point(742, 216);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(258, 114);
            this.Juego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Juego.TabIndex = 1;
            this.Juego.TabStop = false;
            // 
            // sp2
            // 
            this.sp2.BackColor = System.Drawing.Color.Transparent;
            this.sp2.Image = global::Proyecto_Programacion_lll.Properties.Resources.SuperEtendard;
            this.sp2.Location = new System.Drawing.Point(13, 82);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(215, 63);
            this.sp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp2.TabIndex = 2;
            this.sp2.TabStop = false;
            // 
            // sp22
            // 
            this.sp22.BackColor = System.Drawing.Color.Transparent;
            this.sp22.Image = global::Proyecto_Programacion_lll.Properties.Resources.aviones_proyec;
            this.sp22.Location = new System.Drawing.Point(11, 193);
            this.sp22.Name = "sp22";
            this.sp22.Size = new System.Drawing.Size(215, 63);
            this.sp22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp22.TabIndex = 3;
            this.sp22.TabStop = false;
            // 
            // lasser
            // 
            this.lasser.BackColor = System.Drawing.Color.Transparent;
            this.lasser.Image = global::Proyecto_Programacion_lll.Properties.Resources.lasser;
            this.lasser.Location = new System.Drawing.Point(903, 265);
            this.lasser.Name = "lasser";
            this.lasser.Size = new System.Drawing.Size(97, 39);
            this.lasser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lasser.TabIndex = 6;
            this.lasser.TabStop = false;
            // 
            // Puntuacion
            // 
            this.Puntuacion.AutoSize = true;
            this.Puntuacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.Puntuacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntuacion.Location = new System.Drawing.Point(7, 50);
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Size = new System.Drawing.Size(76, 20);
            this.Puntuacion.TabIndex = 19;
            this.Puntuacion.Text = "Puntaje:0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Intentos:01";
            // 
            // sp222
            // 
            this.sp222.BackColor = System.Drawing.Color.Transparent;
            this.sp222.Image = global::Proyecto_Programacion_lll.Properties.Resources.ESTE;
            this.sp222.Location = new System.Drawing.Point(11, 317);
            this.sp222.Name = "sp222";
            this.sp222.Size = new System.Drawing.Size(215, 63);
            this.sp222.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp222.TabIndex = 4;
            this.sp222.TabStop = false;
            // 
            // PAUSA
            // 
            this.PAUSA.AutoSize = true;
            this.PAUSA.BackColor = System.Drawing.Color.Transparent;
            this.PAUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAUSA.ForeColor = System.Drawing.Color.Orange;
            this.PAUSA.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PAUSA.Location = new System.Drawing.Point(323, 250);
            this.PAUSA.Name = "PAUSA";
            this.PAUSA.Size = new System.Drawing.Size(370, 108);
            this.PAUSA.TabIndex = 20;
            this.PAUSA.Text = "PAUSA";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titulo.Location = new System.Drawing.Point(300, 176);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(423, 114);
            this.titulo.TabIndex = 21;
            this.titulo.Text = "PLANE FIRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proyecto_Programacion_lll.Properties.Resources._105769faba63136;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.PAUSA);
            this.Controls.Add(this.Puntuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lasser);
            this.Controls.Add(this.sp222);
            this.Controls.Add(this.sp22);
            this.Controls.Add(this.sp2);
            this.Controls.Add(this.Juego);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plane Fire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Juego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp222)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicarJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reanudarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer tiempojuego;
        private System.Windows.Forms.Timer laser;
        private System.Windows.Forms.PictureBox Juego;
        private System.Windows.Forms.PictureBox sp2;
        private System.Windows.Forms.PictureBox sp22;
        private System.Windows.Forms.PictureBox lasser;
        private System.Windows.Forms.Label Puntuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox sp222;
        private System.Windows.Forms.Label PAUSA;
        private System.Windows.Forms.Label titulo;
    }
}

