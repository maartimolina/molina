using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolina
{
    internal class clsNave
    {
        //Propiedades
        public int vida;
        public string nombre;
        int puntosDaños;
        public PictureBox imgNave;
        
        public void crearJugador()
        {
            vida = 100;
            nombre = "Jugador 1";
            puntosDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://cdna.artstation.com/p/assets/images/images/017/509/756/large/rutger-slopsema-galaga.jpg?1556264895";
        }
        public void crearEnemigo()
        {
            vida = 1000;
            nombre = "Enemigo";
            puntosDaños = 1;
        }
    }
}
