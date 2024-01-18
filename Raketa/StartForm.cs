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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbPokreni_Click(object sender, EventArgs e)
        {
            Form1 formaZaIgru = new Form1();
            Visible = false;
            formaZaIgru.ShowDialog();
            Visible = true;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void gumbPostavke_Click(object sender, EventArgs e)
        {
            Form2 formaZaPostavke = new Form2();
            Visible = false;
            formaZaPostavke.ShowDialog();
            Visible = true;
        }
    }
}
