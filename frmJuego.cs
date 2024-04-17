using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolina
{
    public partial class frmJuego : Form
    {
        clsNave objNaveJugador;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void frmJuego_Load_1(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();


            objNaveJugador.crearJugador();
            objNaveJugador.imgNave.Location = new Point(200, 200);

            
            objNaveJugador.imgNave.BackColor = Color.White;

            objNaveJugador.imgNave.BringToFront();
            Controls.Add(objNaveJugador.imgNave);

            Random rnd = new Random();
            List<Point> posiciones = new List<Point>(); // Lista para almacenar las posiciones de los enemigos

            for (int i = 0; i < 4; i++)
            {
                Point posicion;
                do
                {
                    int x = rnd.Next(0, this.Width - 50); // Generar posición x aleatoria dentro del ancho del formulario
                    int y = rnd.Next(0, this.Height / 2); // Generar posición y aleatoria en la mitad superior del formulario
                    posicion = new Point(x, y);
                } while (posiciones.Any(p => Math.Abs(p.X - posicion.X) < 50 && Math.Abs(p.Y - posicion.Y) < 50)); // Verificar que la nueva posición no esté muy cerca de ninguna posición existente

                posiciones.Add(posicion);

                objNaveJugador.crearEnemigo(i + 1); // Se pasa el tipo de enemigo como parámetro (1, 2, 3 o 4)
                PictureBox imgEnemigo = new PictureBox();
                imgEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
                imgEnemigo.ImageLocation = objNaveJugador.imgEne.ImageLocation;
                imgEnemigo.Location = posicion;
                Controls.Add(imgEnemigo);
            }
        }

        private void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
        {
            int limiteDerecho = this.ClientSize.Width - objNaveJugador.imgNave.Width; // Límite derecho del formulario

            if (e.KeyCode == Keys.Right && objNaveJugador.imgNave.Location.X < limiteDerecho)
            {
                objNaveJugador.imgNave.Location = new Point(
                    Math.Min(objNaveJugador.imgNave.Location.X + 5, limiteDerecho),
                    this.ClientSize.Height - objNaveJugador.imgNave.Height); // Mantener la nave en la parte inferior
            }
            else if (e.KeyCode == Keys.Left && objNaveJugador.imgNave.Location.X > 0)
            {
                objNaveJugador.imgNave.Location = new Point(
                    Math.Max(objNaveJugador.imgNave.Location.X - 5, 0),
                    this.ClientSize.Height - objNaveJugador.imgNave.Height); // Mantener la nave en la parte inferior
            }

            if (e.KeyCode == Keys.Space) // Tecla de espacio para disparar
            {
                objNaveJugador.disparar(); // Disparar desde la nave del jugador
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.disparar();
            PictureBox disparos = new PictureBox();
            PictureBox explo = new PictureBox();
            Controls.Add(disparos);

            if(disparos.Location.Y >0)
            {
                if(disparos.Bounds.IntersectsWith(explo.Bounds))
                {
                    disparos.Dispose();


                }
                else
                {
                    disparos.Location= new Point(disparos.Location.X, disparos.Location.Y - 15);
                }
            }
        }
    }
}
