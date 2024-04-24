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
            MoverDisparos();
            //DetectarColisiones();
        }
        private void MoverDisparos()
        {
            for (int i = objNaveJugador.disparos.Count - 1; i >= 0; i--)
            {
                PictureBox disparo = objNaveJugador.disparos[i];
                disparo.Location = new Point(disparo.Location.X, disparo.Location.Y - 15); // Mover hacia arriba
                if (disparo.Location.Y < 0)
                {
                    disparo.Dispose(); // Eliminar si sale de la pantalla
                    objNaveJugador.disparos.RemoveAt(i); // Eliminar de la lista también
                }
            }
        }

        private void DetectarColisiones()
        {
            foreach (PictureBox disparo in objNaveJugador.disparos)
            {
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control != objNaveJugador.imgNave && control.Bounds.IntersectsWith(disparo.Bounds))
                    {
                        objNaveJugador.crearExplosion(control.Location); // Crear explosión en la posición del enemigo
                        disparo.Dispose(); // Eliminar el disparo
                        objNaveJugador.disparos.Remove(disparo); // Eliminar de la lista también
                        control.Dispose(); // Eliminar el enemigo
                        return; // Salir de la detección de colisiones para evitar excepciones de modificación de la colección
                    }
                }
            }
        }

    }
}
