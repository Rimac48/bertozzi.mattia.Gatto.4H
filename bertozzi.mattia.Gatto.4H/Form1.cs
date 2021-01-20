using bertozzi.mattia.Gatto._4H.Models;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace bertozzi.mattia.Gatto._4H
{
    public partial class frmMain : Form
    {
        // foglio di quaderno 20 cm x 30 cm
        const int LATO_X = 200;
        const int LATO_Y = 300;

        const int MARGINE_SINISTRO = 100;
        const int MARGINE_DESTRO = 100;
        const int MARGINE_SUPERIORE = 100;
        const int MARGINE_INFERIORE = 100;

        //crea i margini del foglio come un foglio di quaderno 20x30 cm
        const int LATO_X_FORM = (MARGINE_SINISTRO + LATO_X + MARGINE_DESTRO);
        const int LATO_Y_FORM = (MARGINE_SUPERIORE + LATO_Y + MARGINE_INFERIORE);


        public frmMain()
        {
            InitializeComponent();

            // blocco il form alle dimensioni fissate (okkio!! tiene conto anche della banda superiore e laterale)
            this.MinimumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
            this.MaximumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
        }

        private int X(double x)
        {
            int xLogico = 0;
            xLogico = (int)(x) + MARGINE_SINISTRO;
            return xLogico;
        }

        private int Y(double y)
        {
            int yLogico = 0;
            yLogico = ((int)(y) + MARGINE_SUPERIORE);
            return yLogico;
        }

        private void btnGatto_Click(object sender, EventArgs e)
        {
            int i = 0;
            Graphics dc = this.CreateGraphics();
            Pen BluePen = new Pen(Color.Blue, 1);
            Pen BlackPen = new Pen(Color.Black, 1);

            //disegna il bordo del foglio 20 x 30 cm
            dc.DrawRectangle(BluePen, MARGINE_SINISTRO + 0, MARGINE_SUPERIORE + 0, LATO_X, LATO_Y);

            Punto[] p = new Punto[30];

            //Punti per creazione gatto
            p[0] = new Punto(40, 110);
            p[1] = new Punto(40, 130);
            p[2] = new Punto(50, 140);
            p[3] = new Punto(50, 150);
            p[4] = new Punto(40, 160);
            p[5] = new Punto(50, 160);
            p[6] = new Punto(60, 160);
            p[7] = new Punto(70, 150);
            p[8] = new Punto(90, 150);
            p[9] = new Punto(100, 160);
            p[10] = new Punto(100, 150);
            p[11] = new Punto(110, 160);
            p[12] = new Punto(110, 150);
            p[13] = new Punto(100, 140);
            p[14] = new Punto(100, 130);
            p[15] = new Punto(110, 130);
            p[16] = new Punto(120, 140);
            p[17] = new Punto(120, 130);
            p[18] = new Punto(110, 120);
            p[19] = new Punto(100, 120);
            p[20] = new Punto(90, 130);
            p[21] = new Punto(70, 130);
            p[22] = new Punto(70, 110);
            p[23] = new Punto(60, 120);
            p[24] = new Punto(50, 120);

            //Punti x Dettagli
            p[25] = new Punto(60, 140);//per mento
            p[26] = new Punto(60, 150);//per zampe
            //per sedere collego 13 con 20

            //per Mento
            dc.DrawLine(BlackPen, X(p[2].X), Y(p[2].Y), X(p[25].X), Y(p[25].Y));
            dc.DrawLine(BlackPen, X(p[25].X), Y(p[25].Y), X(p[21].X), Y(p[21].Y));

            dc.DrawLine(BlackPen, X(p[5].X), Y(p[5].Y), X(p[26].X), Y(p[26].Y));//per Zampe
            dc.DrawLine(BlackPen, X(p[13].X), Y(p[13].Y), X(p[20].X), Y(p[20].Y));//per Sedere

            //creazione TESTA
            //for (i = 0; i < 8; i++)
            //{
            //    int j = i + 1;
            //    if (j == 8) j = 0;
            //    dc.DrawLine(BlackPen, X(p[i].X), Y(p[i].Y), X(p[j].X), Y(p[j].Y));
            //}

            ////creazione CORPO
            //for (i = 9; i < 25; i++)
            //{
            //    int j = i + 1;
            //    if (j == 25) j = 0;
            //    dc.DrawLine(BlackPen, X(p[i].X), Y(p[i].Y), X(p[j].X), Y(p[j].Y));
            //}

            //STAMPA GATTO
            for (i = 0; i < 25; i++)
            {
                int j = i + 1;
                if (j == 25) j = 0;
                dc.DrawLine(BlackPen, X(p[i].X), Y(p[i].Y), X(p[j].X), Y(p[j].Y));

                //in questo modo collega l'ultimo punto al primo
                if(i==24)
                {
                    dc.DrawLine(BlackPen, X(p[i].X), Y(p[i].Y), X(p[0].X), Y(p[0].Y));
                }
                //in questo modo stampo la riga della zampa posteriore
                if(i==8)
                {
                    dc.DrawLine(BlackPen, X(p[i].X), Y(p[i].Y), X(p[10].X), Y(p[10].Y));
                }
            }



            // linea diagonale per vedere lo spazio attorno al foglio
            //dc.DrawLine(BluePen, X(0), Y(0), X(LATO_X), Y(LATO_Y));
            //dc.DrawLine(BluePen, X(0), Y(LATO_Y), X(LATO_X), Y(0));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}