using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa
{
    public partial class Form2 : Form
    {
        public static bool zvuk = true;
        public Form2()
        {
            InitializeComponent();
            InicijalizirajPostavke();
        }
        public static void playSimpleSound()
        {
            string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Raketa/Resources/zvuk.wav");
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.zvuk);
            if (zvuk)
                simpleSound.Play();
            else
                simpleSound.Stop();
        }
        private void gumbPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetButtonSelected(Button button)
        {
            gumbBrod.BackColor = SystemColors.Control;
            gumbRaketa1.BackColor = SystemColors.Control;
            gumbRaketa2.BackColor = SystemColors.Control;

            button.BackColor = Color.DimGray;
            button.Focus();
        }
        private void SetLevelSelected(Button button)
        {
           razinaLagana.BackColor = SystemColors.Control;
           razinaSrednja.BackColor = SystemColors.Control;
           razinaTeska.BackColor = SystemColors.Control;

            button.BackColor = Color.DimGray;
            button.Focus();
        }
        private void SetZvuk(Button button)
        {
            gumbZvukOff.BackColor = SystemColors.Control;
            gumbZvukOn.BackColor = SystemColors.Control;

            button.BackColor = Color.DimGray;
            button.Focus();

        }
        private void gumbRaketa1_Click(object sender, EventArgs e)
        {
            SetButtonSelected(gumbRaketa1);
            Form1.GlobalnaBrod = "Raketa1";
        }

        private void gumbRaketa2_Click(object sender, EventArgs e)
        {
            SetButtonSelected(gumbRaketa2);
            Form1.GlobalnaBrod = "Raketa2";
        }

        private void gumbBrod_Click(object sender, EventArgs e)
        {
            SetButtonSelected(gumbBrod);
            Form1.GlobalnaBrod = "Brod";
        }

        private void razinaSrednja_Click(object sender, EventArgs e)
        {
            SetLevelSelected(razinaSrednja);
            Form1.GlobalnaRazina = "Srednja";
        }

        private void razinaLagana_Click(object sender, EventArgs e)
        {
            SetLevelSelected(razinaLagana);
            Form1.GlobalnaRazina = "Lagana";
        }

        private void razinaTeska_Click(object sender, EventArgs e)
        {
            SetLevelSelected(razinaTeska);
            Form1.GlobalnaRazina = "Teska";
        }

        private void InicijalizirajPostavke()
        {
            if (Form1.GlobalnaBrod == "Brod")
                SetButtonSelected(gumbBrod);
         
            else if(Form1.GlobalnaBrod == "Raketa1")
                SetButtonSelected(gumbRaketa1);
            
            else if (Form1.GlobalnaBrod == "Raketa2")
                SetButtonSelected(gumbRaketa2);

            if (Form1.GlobalnaRazina == "Lagana")
                SetLevelSelected(razinaLagana);

            else if (Form1.GlobalnaRazina == "Srednja")
                SetLevelSelected(razinaSrednja);
            else if (Form1.GlobalnaRazina == "Teska")
                SetLevelSelected(razinaTeska);

            if (zvuk == true)
                SetZvuk(gumbZvukOn);
            else
                SetZvuk(gumbZvukOff);
        }

        private void gumbZvukOn_Click(object sender, EventArgs e)
        {
            SetZvuk(gumbZvukOn);
            zvuk = true;
            playSimpleSound();
        }

        private void gumbZvukOff_Click(object sender, EventArgs e)
        {
            SetZvuk(gumbZvukOff);
            zvuk = false;
            playSimpleSound();
        }
    }
}
