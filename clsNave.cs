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
        public List<PictureBox> disparos = new List<PictureBox>(); // Lista para almacenar los disparos
        public PictureBox explo;

        public void crearJugador()
        {
            vida = 100;
            nombre = "Jugador 1";
            puntosDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://steamuserimages-a.akamaihd.net/ugc/3336348870692605210/2DB65000D1AE5B34BCEC2E3E91A27537B3EFC057/?imw=268&imh=268&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";
            imgNave.Size = new Size(50, 50);
        }
        public void crearEnemigo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    vida = 1000;
                    nombre = "Enemigo1";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/67a42226734797.5635b665abaa4.gif";
                    break;
                case 2:
                    vida = 1000;
                    nombre = "Enemigo2";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://art.pixilart.com/5096bbb7736c227.gif";
                    break;
                case 3:
                    vida = 1000;
                    nombre = "Enemigo3";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://art.pixilart.com/5ce2059e8521.gif";
                    break;
                case 4:
                    vida = 1000;
                    nombre = "Enemigo4";
                    puntosDaños = 1;
                    imgEne = new PictureBox();
                    imgEne.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgEne.ImageLocation = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/f8c1a926734797.5635b665b810a.gif"; // Cambiar por la URL de la imagen correspondiente al enemigo 4
                    break;
                default:
                    break;
            }
        }
        public void disparar()
        {
            PictureBox disparo = new PictureBox();
            disparo.SizeMode = PictureBoxSizeMode.StretchImage;
            disparo.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
            disparo.Size = new Size(20, 20); // Tamaño del disparo
            disparo.Location = new Point(imgNave.Location.X + imgNave.Width / 2 - disparo.Width / 2, imgNave.Location.Y); // Posición inicial del disparo
            disparos.Add(disparo); // Agregar el disparo a la lista
            Form.ActiveForm.Controls.Add(disparo);

            PictureBox explo = new PictureBox();
            disparo.SizeMode = PictureBoxSizeMode.StretchImage;
            disparo.ImageLocation = "https://64.media.tumblr.com/be7d736a22463bab1d67e611d864b5bd/tumblr_mlhg9xoGMm1sn65iqo1_r1_500.gifv";

        }
    }
}
