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
        public PictureBox imgEne;

        public void crearJugador()
        {
            vida = 100;
            nombre = "Jugador 1";
            puntosDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://gifdb.com/images/high/galaga-ship-gyaraga-art-48fvhsarxw0j2oku.webp";
        }
        public void crearEnemigo()
        {
            //Enemigo 1
            vida = 1000;
            nombre = "Enemigo";
            puntosDaños = 1;
            imgEne= new PictureBox();
            imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEne.ImageLocation = "https://gifdb.com/images/high/galaga-boss-game-sticker-te0hoq27fvtgnpv6.webp";

            //Enemigo 2
            vida = 1000;
            nombre = "Enemigo2";
            puntosDaños = 1;
            imgEne = new PictureBox();
            imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEne.ImageLocation = "https://art.pixilart.com/5096bbb7736c227.gif";

            //Enemigo 3
            vida = 1000;
            nombre = "Enemigo3";
            puntosDaños = 1;
            imgEne = new PictureBox();
            imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEne.ImageLocation = "https://art.pixilart.com/5ce2059e8521.gif";
        }
    }
}
