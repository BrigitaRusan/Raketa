namespace Raketa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any 
        /// being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaBodovi = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.srce3 = new System.Windows.Forms.PictureBox();
            this.srce2 = new System.Windows.Forms.PictureBox();
            this.srce1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.brod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaBodovi
            // 
            this.labelaBodovi.AutoSize = true;
            this.labelaBodovi.BackColor = System.Drawing.Color.Firebrick;
            this.labelaBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi.ForeColor = System.Drawing.SystemColors.Window;
            this.labelaBodovi.Location = new System.Drawing.Point(332, 491);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(162, 38);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.AutoSize = true;
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.DarkGray;
            this.labelaRestartPoruka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaRestartPoruka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelaRestartPoruka.Location = new System.Drawing.Point(145, 245);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(236, 78);
            this.labelaRestartPoruka.TabIndex = 5;
            this.labelaRestartPoruka.Text = "Pritisnite R za\r\nponovnu igru.";
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Firebrick;
            this.labelaPauza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPauza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaPauza.Location = new System.Drawing.Point(133, 192);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(264, 38);
            this.labelaPauza.TabIndex = 6;
            this.labelaPauza.Text = "Igra je pauzirana!";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 19);
            this.progressBar1.TabIndex = 7;
            // 
            // srce3
            // 
            this.srce3.BackColor = System.Drawing.Color.Transparent;
            this.srce3.Image = global::Raketa.Properties.Resources.srce;
            this.srce3.Location = new System.Drawing.Point(94, 498);
            this.srce3.Name = "srce3";
            this.srce3.Size = new System.Drawing.Size(37, 31);
            this.srce3.TabIndex = 12;
            this.srce3.TabStop = false;
            // 
            // srce2
            // 
            this.srce2.BackColor = System.Drawing.Color.Transparent;
            this.srce2.Image = global::Raketa.Properties.Resources.srce;
            this.srce2.Location = new System.Drawing.Point(51, 498);
            this.srce2.Name = "srce2";
            this.srce2.Size = new System.Drawing.Size(37, 31);
            this.srce2.TabIndex = 11;
            this.srce2.TabStop = false;
            // 
            // srce1
            // 
            this.srce1.BackColor = System.Drawing.Color.Transparent;
            this.srce1.Image = global::Raketa.Properties.Resources.srce;
            this.srce1.Location = new System.Drawing.Point(8, 498);
            this.srce1.Name = "srce1";
            this.srce1.Size = new System.Drawing.Size(37, 31);
            this.srce1.TabIndex = 10;
            this.srce1.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.BackColor = System.Drawing.Color.Transparent;
            this.prepreka2.Image = global::Raketa.Properties.Resources.prepreka;
            this.prepreka2.Location = new System.Drawing.Point(389, 12);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(140, 50);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // prepreka1
            // 
            this.prepreka1.BackColor = System.Drawing.Color.Transparent;
            this.prepreka1.Image = global::Raketa.Properties.Resources.prepreka;
            this.prepreka1.Location = new System.Drawing.Point(-9, 262);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(140, 50);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Image = global::Raketa.Properties.Resources.brod;
            this.brod.Location = new System.Drawing.Point(235, 420);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(40, 60);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.srce3);
            this.Controls.Add(this.srce2);
            this.Controls.Add(this.srce1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.brod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaBodovi;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox srce1;
        private System.Windows.Forms.PictureBox srce2;
        private System.Windows.Forms.PictureBox srce3;
    }
}

