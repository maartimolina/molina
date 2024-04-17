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
            objNaveJugador = new clsNave();


            objNaveJugador.crearJugador();
            objNaveJugador.imgNave.Location = new Point(300, 600);
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

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            int limiteDerecho = this.Width - objNaveJugador.imgNave.Width; // Límite derecho del formulario
            int limiteInferior = this.Height - objNaveJugador.imgNave.Height; // Límite inferior del formulario

            if (e.KeyCode == Keys.Right)
            {
                if (objNaveJugador.imgNave.Location.X < limiteDerecho)
                {
                    objNaveJugador.imgNave.Location = new Point(
                        objNaveJugador.imgNave.Location.X + 5,
                        objNaveJugador.imgNave.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (objNaveJugador.imgNave.Location.X > 0)
                {
                    objNaveJugador.imgNave.Location = new Point(
                        objNaveJugador.imgNave.Location.X - 5,
                        objNaveJugador.imgNave.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (objNaveJugador.imgNave.Location.Y < limiteInferior)
                {
                    objNaveJugador.imgNave.Location = new Point(
                        objNaveJugador.imgNave.Location.X,
                        objNaveJugador.imgNave.Location.Y + 5);
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (objNaveJugador.imgNave.Location.Y > 0)
                {
                    objNaveJugador.imgNave.Location = new Point(
                        objNaveJugador.imgNave.Location.X,
                        objNaveJugador.imgNave.Location.Y - 5);
                }
            }
        }
    }
}
