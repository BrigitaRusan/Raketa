using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Raketa
{
    public partial class Form1 : Form
    {
        public static string GlobalnaBrod = "Brod";
        public static string GlobalnaRazina = "Srednja";
        public static Size velicinaGoriva = new Size(20, 20);
        public static Size velicinaKometa = new Size(40, 40);


        int tickCount = 0;
        public Form1()
        {
            InitializeComponent();

            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            PocetnePostavke();
            timer1.Start();
            DoubleBuffered = true;

            // mijenja izgled broda i razine
            PromijeniBrod();
            PromijeniRazinu();

        }

        Image pozadina = Properties.Resources.pozadina;
        Image zid = Properties.Resources.zid;
        float sirina, visina;
        float brzinaPozadine, brzinaZida, brzinaBroda;
        float[] koordPozadina, koordZid;
        bool lijevo, desno;
        bool krajIgre;

        private bool prepreka1Udesno = true;
        private bool prepreka2Ulijevo = true;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                progressBar1.Value = 1;
            }
        }


    private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !kretanje)
                kretanje = true;
            if (e.KeyCode == Keys.Left)
                lijevo = true;
            if (e.KeyCode == Keys.Right)
                desno = true;

            if (e.KeyCode == Keys.Escape)
            {
                progressBar1.Value = 1;
                GameOver();
                Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && kretanje)
                kretanje = false;
            if (e.KeyCode == Keys.Left)
                lijevo = false;
            if (e.KeyCode == Keys.Right)
                desno = false;
            if (e.KeyCode == Keys.R && krajIgre)
            {
                PocetnePostavke();
                timer1.Start();
            }


            // na pritisak gumba P pauzira igru
            if (e.KeyCode == Keys.P && labelaPauza.Visible)
                Form1_Activated(sender, e);
            else if (e.KeyCode == Keys.P && !labelaPauza.Visible)
                Form1_Deactivate(sender, e);
        }

        bool kretanje;
        int bodovi;
        int zivoti;

        void povecajBodove(int dobiveniBodovi)
        {
            bodovi += dobiveniBodovi;
            labelaBodovi.Text
                = "Bodovi: " + bodovi;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                timer1.Stop();
                if (kretanje || lijevo || desno)
                    kretanje = lijevo = desno = false;
                labelaPauza.Visible = true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                labelaPauza.Visible = false;
                timer1.Start();
            }
        }

        private void PocetnePostavke()
        {
            plusPet.Visible = false;
            brod.BringToFront();
            progressBar1.Value = 1000;
            labelaPauza.Visible = false;
            krajIgre = false;
            labelaRestartPoruka.Visible = false;
            plusPet.Visible = false;
            prepreka1.Location = new Point(10, 205);
            prepreka2.Location = new Point(280, 10);
            bodovi = 0;
            zivoti = 3;
            povecajBodove(0);
            lijevo = desno = false;
            kretanje = false;
            koordPozadina = new float[] { -visina, 0 };
            koordZid = new float[] { -visina, 0 };
            brzinaPozadine = 0.5f;
            brod.Location = new Point
                ((int)sirina / 2 - brod.Size.Width / 2,
                (int)visina - brod.Size.Height - 50);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            PomakniPozadinu();
            if (lijevo && !desno &&
                brod.Left - brzinaBroda >= 0.1 * sirina)
                brod.Left -= (int)brzinaBroda;
            if (desno && !lijevo &&
                brod.Right + brzinaBroda <= 0.9 * sirina)
                brod.Left += (int)brzinaBroda;
            if (kretanje)
            {
                prepreka1.Top += (int)brzinaZida;
                prepreka2.Top += (int)brzinaZida;

                if (prepreka1.Top > visina)
                {
                    povecajBodove(1);
                    prepreka1.Top = -prepreka1.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }
                if (prepreka2.Top > visina)
                {
                    povecajBodove(1);
                    prepreka2.Top = -prepreka2.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }
            }


            progressBar1.Value -= 1;

            if (random.Next() % 100 == 0)
                StvoriKomet();

            if (random.Next() % 100 == 0)
                StvoriGorivo();

            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x &&
                    (string)x.Tag == "komet")
                {
                    x.Top += (int)(kretanje ? (brzinaZida + brzinaBroda)
                        : brzinaZida);
                    if (x.Top > visina)
                    {
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }
                    if (kontrola is PictureBox && kontrola.Tag.ToString() == "komet")
                    {
                        ((PictureBox)kontrola).Size = velicinaKometa;
                    }
                }
            }

            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x && (string)x.Tag == "gorivo")
                {
                    x.Top += (int)(kretanje ? (brzinaZida + brzinaBroda)
                        : brzinaZida);
                    if (x.Top > visina)
                    {
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }
                    if (kontrola is PictureBox && kontrola.Tag.ToString() == "gorivo")
                    {
                        ((PictureBox)kontrola).Size = velicinaGoriva;
                    }
                }
            }


            Invalidate();

            if (progressBar1.Value == 0)
            {
                GameOver();
                return;
            }
            if (brod.Bounds.IntersectsWith(prepreka1.Bounds)
                || brod.Bounds.IntersectsWith(prepreka2.Bounds))
            {
                Pauziraj();
                return;
            }
            foreach (Control kontrola in Controls)
            {
                if (kontrola is PictureBox x && (string)x.Tag == "komet")
                {
                    if (brod.Bounds.IntersectsWith(x.Bounds))
                    {
                        Pauziraj();

                        //------ukloni komet ako se sudari------
                        x.Visible = false;
                        Controls.Remove(kontrola);
                        x.Dispose();
                        //-------------
                        return;
                    }
                }
            }
                foreach (Control kontrola in Controls)
                {
                    if (kontrola is PictureBox y && (string)y.Tag == "gorivo")
                    {
                        if (brod.Bounds.IntersectsWith(y.Bounds))
                        {

                            //------ukloni gorivo nakon sudara------
                            y.Visible = false;
                            Controls.Remove(kontrola);
                            y.Dispose();
                            povecajBodove(5);

                            plusPet.Visible = true;
                            await Task.Delay(1000); // Čeka 1 sekundu
                            plusPet.Visible = false;
                        //---------------------------------
                        return;
                        }
                    }
                }
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            brod.Visible = !brod.Visible;
            tickCount++;
            if (tickCount >= 6)
            {
                timerTitraj.Stop();
                tickCount = 0;
                Odblokiraj();
                timer1.Start();
            }
        }

        private void Pauziraj()
        {
            timer1.Stop();
            timerTitraj.Start();

        }
        private void Odblokiraj()
        {
            zivoti--;
            brojZivota();
            brod.Visible = true;
            brod.Location = new Point((int)sirina / 2 - brod.Size.Width / 2, (int)visina - brod.Size.Height -50);
            Point pozicijaPrepreke1 = prepreka1.Location;
            int y1 = pozicijaPrepreke1.Y;
            Point pozicijaPrepreke2 = prepreka2.Location;
            int y2 = pozicijaPrepreke2.Y;

            prepreka1.Location = new Point(10, y1-50);
            prepreka2.Location = new Point(280, y2 - 50);

        }
        private void GameOver()
        {
            timer1.Stop();
            krajIgre = true;
            labelaRestartPoruka.Visible = true;
            MessageBox.Show("Osvojeni bodovi: " + bodovi,
                "Igra je završila!");
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x && (string)x.Tag == "komet")
                {
                    x.Visible = false;
                    Controls.Remove(Controls[i]);
                    x.Dispose();
                }
            }
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox y && (string)y.Tag == "gorivo")
                {
                    y.Visible = false;
                    Controls.Remove(Controls[i]);
                    y.Dispose();
                }
            }
        }

        private void PomakniPozadinu()
        {
            for (int i = 0; i < 2; i++)
            {
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                if (koordZid[i] > visina)
                    koordZid[i] -= 2 * visina;
                if (kretanje)
                {
                    koordPozadina[i] += brzinaPozadine;
                    koordZid[i] += brzinaZida;
                }

                //----- pomicanje prepreki horizontalno---------

                int brzina = 3;

                if (prepreka1Udesno)
                    prepreka1.Left += brzina;
                else
                    prepreka1.Left -= brzina;

                if (prepreka2Ulijevo)
                    prepreka2.Left -= brzina;
                else
                    prepreka2.Left += brzina;

                if (prepreka1.Left + prepreka1.Width >= (0.5 * sirina) +20 || prepreka1.Left <= 0)
                {
                    // Ako prepreka1 dosegne sredinu ili lijevi rub, mijenjamo smjer
                    prepreka1Udesno = !prepreka1Udesno;
                }

                if (prepreka2.Left <= (0.5 * sirina) -20 || prepreka2.Right >= sirina)
                {
                    // Ako prepreka2 dosegne sredinu ili desni rub, mijenjamo smjer
                    prepreka2Ulijevo = !prepreka2Ulijevo;
                }
                //----------------------------------------

            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i],
                sirina, visina);
            }
            for (int i = 0; i < 2; ++i)
            {
                e.Graphics.DrawImage(zid, 0, koordZid[i],
                    0.1f * sirina, visina + 50);
                e.Graphics.DrawImage(zid, 0.9f * sirina, koordZid[i],
                    0.1f * sirina, visina + 50);
            }
        }

        Random random = new Random();

        private void StvoriKomet()
        {
            PictureBox komet = new PictureBox();
            komet.Size = new Size(20, 20);
            komet.Image = Raketa.Properties.Resources.komet;
            komet.BackColor = Color.Transparent;
            komet.Top = -komet.Height;
            komet.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - komet.Width));
            komet.Tag = "komet";

            Controls.Add(komet);
        }
        private void StvoriGorivo()
        {
            PictureBox gorivo = new PictureBox();
            gorivo.Size = new Size(20, 20);
            gorivo.Image = Raketa.Properties.Resources.gorivo;
            gorivo.BackColor = Color.Transparent;
            gorivo.Top = -gorivo.Height;
            gorivo.Left = (int)(0.1 * sirina + 1)
                + random.Next(0, (int)(0.8 * sirina - gorivo.Width));
            gorivo.Tag = "gorivo";
            Controls.Add(gorivo);
            gorivo.BringToFront();

        }

        private void PromijeniBrod()
        {
            if( GlobalnaBrod == "Raketa1")
                brod.Image = Raketa.Properties.Resources.raketa1;
            
            else if( GlobalnaBrod == "Raketa2")
                brod.Image = Raketa.Properties.Resources.raketa2;

            else if (GlobalnaBrod == "Brod")
                brod.Image = Raketa.Properties.Resources.brod;
        }
        private void PromijeniRazinu()
        {

            if (GlobalnaRazina == "Lagana")
            {
                brzinaZida = 4;
                brzinaBroda = 4;
                velicinaKometa = new Size(20,20);
                
            }
            else if (GlobalnaRazina == "Srednja")
            {
                brzinaZida = 7;
                brzinaBroda = 7;
                velicinaKometa = new Size(30, 30);
            }
            else if (GlobalnaRazina == "Teska")
            {
                brzinaZida = 10;
                brzinaBroda = 10;
                velicinaKometa = new Size(50, 50);
            }
        }

        private void brojZivota()
        {
            if( zivoti == 1)
            {
                srce1.Visible = true;
                srce2.Visible = false;
                srce3.Visible = false;
            }
            else if (zivoti == 2)
            {
                srce1.Visible = true;
                srce2.Visible = true;
                srce3.Visible = false;
            }
            else if (zivoti == 3)
            {
                srce1.Visible = srce2.Visible = srce3.Visible = true;
            }
            else {
                srce1.Visible = srce2.Visible = srce3.Visible = false;
            }
        }

    }
}
