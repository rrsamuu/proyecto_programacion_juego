using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programacion_lll
{
    public partial class Form1 : Form
    {
        //Variables globales
        public int contador;
        public int puntaje;
        public int intentos;
        public int i, j;

        public Form1()
        {
            InitializeComponent();
            //Forma de usar el teclado
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void tiempojuego_Tick(object sender, EventArgs e)
        {
            //Posiciones aleatorias de la naves enemigas
            Random rnd = new Random();
            int a = rnd.Next(50, 400);
            int b = rnd.Next(50, 400);
            int c = rnd.Next(50, 400);
            contador = contador + 1;

            //Si las naves estan menos de la posicion del avion van ir avanzando hasta traspasar la ventana
            //Y si rebasan toman un nuevo lugar aleatorio
            if((sp2.Left < 999) && (sp22.Left < 999) && (sp222.Left < 999))
            {
                sp2.Left = sp2.Left + 40;
                sp22.Left = sp22.Left + 40;
                sp222.Left = sp222.Left + 40;

            }
            else
            {
                sp2.Visible = true;
                sp22.Visible = true;
                sp222.Visible = true;

                sp2.Location = new Point (0, a);
                sp22.Location = new Point (0, b);
                sp222.Location = new Point (0 , c);
            }
            //Si el laser toca una nave enemiga se va ir sumando los puntos
            if(lasser.Bounds.IntersectsWith(sp2.Bounds))
            {
                sp2.Visible = false;
                puntaje = puntaje + 10;
                Puntuacion.Text = "Puntaje: " + puntaje;
            }

            if (lasser.Bounds.IntersectsWith(sp22.Bounds))
            {
                sp22.Visible = false;
                puntaje = puntaje + 10;
                Puntuacion.Text = "Puntaje: " + puntaje;
            }

            if (lasser.Bounds.IntersectsWith(sp222.Bounds))
            {
                sp222.Visible = false;
                puntaje = puntaje + 10;
                Puntuacion.Text = "Puntaje: " + puntaje;
            }

            //Si una nave enemiga toca el avion se va ir tomando los intentos
            //Hasta llegar a 3 intentos y se pierde
            if(sp2.Visible == true)
            {
                if(sp2.Bounds.IntersectsWith(Juego.Bounds))
                {
                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if(intentos>3)
                    {
                        label1.Visible = false;
                        tiempojuego.Stop();
                        Perdedor open = new Perdedor();
                        open.Show();

                        sp2.Visible = false;
                        sp22.Visible = false;
                        sp222.Visible = false;

                        lasser.Visible = false;

                        Juego.Visible = false;

                        label1.Visible = true;
                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(742, 216);
                        sp2.Location = new Point(0, a);
                        sp22.Location = new Point(0, b);
                        sp222.Location = new Point(0, c);
                    }
                }
            }

            if (sp22.Visible == true)
            {
                if (sp22.Bounds.IntersectsWith(Juego.Bounds))
                {
                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if (intentos > 3)
                    {
                        label1.Visible = false;
                        tiempojuego.Stop();
                        Perdedor open = new Perdedor();
                        open.Show();

                        sp2.Visible = false;
                        sp22.Visible = false;
                        sp222.Visible = false;

                        lasser.Visible = false;

                        Juego.Visible = false;

                        label1.Visible = true;
                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(742, 216);
                        sp2.Location = new Point(0, a);
                        sp22.Location = new Point(0, b);
                        sp222.Location = new Point(0, c);
                    }
                }
            }

            if (sp222.Visible == true)
            {
                if (sp222.Bounds.IntersectsWith(Juego.Bounds))
                {
                    intentos = intentos + 1;
                    label1.Text = "Intentos: 0" + intentos;
                    if (intentos > 3)
                    {
                        label1.Visible = false;
                        tiempojuego.Stop();
                        Perdedor open = new Perdedor();
                        open.Show();

                        sp2.Visible = false;
                        sp22.Visible = false;
                        sp222.Visible = false;

                        lasser.Visible = false;

                        Juego.Visible = false;

                        label1.Visible = true;
                        label1.Text = "Intentos: 01";
                    }
                    else
                    {
                        Juego.Location = new System.Drawing.Point(742, 216);
                        sp2.Location = new Point(0, a);
                        sp22.Location = new Point(0, b);
                        sp222.Location = new Point(0, c);
                    }
                }
            }
        }

        private void laser_Tick(object sender, EventArgs e)
        {
            //El laser va ir retrocediendo a la izquierda
            lasser.Visible = true;
            lasser.Left = lasser.Left - 250;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando inicie el programa
            tiempojuego.Stop();
            titulo.Visible = true;
            pausaToolStripMenuItem.Enabled = false;
            inicarJuegoToolStripMenuItem.Enabled = false;
            salirToolStripMenuItem.Enabled = false;
            instruccionesToolStripMenuItem.Enabled = true;
            PAUSA.Visible = false;
            sp2.Visible = false;
            sp22.Visible = false;
            sp222.Visible = false;

            Juego.Visible = false;

            label1.Visible = false;
            Puntuacion.Visible = false;

            lasser.Visible = false;
            

            
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuando se seleccione se detendra el juego
            tiempojuego.Stop();
            laser.Stop();
            PAUSA.Visible = true;
            
            
        }

        private void reanudarToolStripMenuItem_Click(object sender, EventArgs e){

            //Cuando se seleccione se reanudara el juego
            tiempojuego.Enabled = true;
            laser.Enabled = true;
            PAUSA.Visible = false;
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuando se seleccione se cerrara el juego
            Application.Exit();
        }

        private void inicarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuando se seleccione iniciara el juego
            titulo.Visible = false;
            pausaToolStripMenuItem.Enabled = true;
            Juego.Location = new Point(742, 216);
            Juego.Visible = true;
            label1.Visible = true;
            Puntuacion.Visible = true;

            sp2.Visible = true;
            sp22.Visible = true;
            sp222.Visible = true;

            this.sp2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.sp22.SizeMode = PictureBoxSizeMode.StretchImage;
            this.sp222.SizeMode = PictureBoxSizeMode.StretchImage;

            Random ran = new Random();
            int a = ran.Next(50, 400);
            int b = ran.Next(50, 400);
            int c = ran.Next(50, 400);
            sp2.Location = new Point(0, a);
            sp22.Location = new Point(0, b);
            sp222.Location = new Point(0 ,c);

            intentos = 1;
            tiempojuego.Start();

            puntaje = 0;
            Puntuacion.Text = "Puntaje: 0";

        }

        private void Form1_KeyDown (object sender, KeyEventArgs e)
        {
            //Utilizacion de las flechas del teclado
            int x = Juego.Location.X;
            int y = Juego.Location.Y;

            /*if(e.KeyCode == Keys.Right)
            { x += 10; }
            if(e.KeyCode == Keys.Left)
            { x -= 10; }*/
            if(e.KeyCode == Keys.Up)
            { y -= 30; }
            if(e.KeyCode == Keys.Down)
            { y += 30; }

            Juego.Location = new System.Drawing.Point(x, y);
            i = x;
            j = y;

            //Condicion cuando se oprima "space" se lanzara el laser
            if(e.KeyCode == Keys.Space)
            {
                //Posicion de laser
                lasser.Location = new System.Drawing.Point(i, j+36);
                laser.Start();
            }
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuando se selecciones mostrara la instrucciones
            Instrucciones open = new Instrucciones();
            open.Show(this);

            pausaToolStripMenuItem.Enabled = true;
            inicarJuegoToolStripMenuItem.Enabled = true;
            salirToolStripMenuItem.Enabled = true;
            
        }
    }
}
