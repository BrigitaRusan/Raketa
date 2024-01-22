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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InicijalizirajPostavke();
        }

        private void gumbPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void SetButtonSelected(Button button)
        {
            // Reset all buttons' back color
            gumbBrod.BackColor = SystemColors.Control;
            gumbRaketa1.BackColor = SystemColors.Control;
            gumbRaketa2.BackColor = SystemColors.Control;

            // Set the selected button's back color
            button.BackColor = Color.Gray;

            // Set focus to the selected button
            button.Focus();
        }
        private void SetLevelSelected(Button button)
        {
            // Reset all buttons' back color
           razinaLagana.BackColor = SystemColors.Control;
           razinaSrednja.BackColor = SystemColors.Control;
           razinaTeska.BackColor = SystemColors.Control;

            // Set the selected button's back color
            button.BackColor = Color.Gray;

            // Set focus to the selected button
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

        private void Form2_Load_1(object sender, EventArgs e)
        {

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
        }


    }
}
