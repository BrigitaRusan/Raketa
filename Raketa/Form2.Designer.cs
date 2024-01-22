namespace Raketa
{
    partial class Form2
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
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gumbPovratak = new System.Windows.Forms.Button();
            this.slikaBrod = new System.Windows.Forms.PictureBox();
            this.slikaRaketa1 = new System.Windows.Forms.PictureBox();
            this.slikaRaketa2 = new System.Windows.Forms.PictureBox();
            this.gumbRaketa1 = new System.Windows.Forms.Button();
            this.gumbBrod = new System.Windows.Forms.Button();
            this.gumbRaketa2 = new System.Windows.Forms.Button();
            this.Odabir = new System.Windows.Forms.Label();
            this.Razina = new System.Windows.Forms.Label();
            this.razinaLagana = new System.Windows.Forms.Button();
            this.razinaSrednja = new System.Windows.Forms.Button();
            this.razinaTeska = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slikaBrod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaRaketa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaRaketa2)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbPovratak
            // 
            this.gumbPovratak.BackColor = System.Drawing.Color.DarkGray;
            this.gumbPovratak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPovratak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gumbPovratak.Location = new System.Drawing.Point(106, 434);
            this.gumbPovratak.Name = "gumbPovratak";
            this.gumbPovratak.Size = new System.Drawing.Size(200, 50);
            this.gumbPovratak.TabIndex = 1;
            this.gumbPovratak.Text = "Povratak";
            this.gumbPovratak.UseVisualStyleBackColor = false;
            this.gumbPovratak.Click += new System.EventHandler(this.gumbPovratak_Click);
            // 
            // slikaBrod
            // 
            this.slikaBrod.BackColor = System.Drawing.Color.Transparent;
            this.slikaBrod.Image = global::Raketa.Properties.Resources.brod;
            this.slikaBrod.Location = new System.Drawing.Point(168, 66);
            this.slikaBrod.Name = "slikaBrod";
            this.slikaBrod.Size = new System.Drawing.Size(80, 100);
            this.slikaBrod.TabIndex = 2;
            this.slikaBrod.TabStop = false;
            // 
            // slikaRaketa1
            // 
            this.slikaRaketa1.BackColor = System.Drawing.Color.Transparent;
            this.slikaRaketa1.Image = global::Raketa.Properties.Resources.raketa1;
            this.slikaRaketa1.Location = new System.Drawing.Point(22, 66);
            this.slikaRaketa1.Name = "slikaRaketa1";
            this.slikaRaketa1.Size = new System.Drawing.Size(100, 100);
            this.slikaRaketa1.TabIndex = 3;
            this.slikaRaketa1.TabStop = false;
            // 
            // slikaRaketa2
            // 
            this.slikaRaketa2.BackColor = System.Drawing.Color.Transparent;
            this.slikaRaketa2.Image = global::Raketa.Properties.Resources.raketa2;
            this.slikaRaketa2.Location = new System.Drawing.Point(264, 66);
            this.slikaRaketa2.Name = "slikaRaketa2";
            this.slikaRaketa2.Size = new System.Drawing.Size(100, 100);
            this.slikaRaketa2.TabIndex = 4;
            this.slikaRaketa2.TabStop = false;
            // 
            // gumbRaketa1
            // 
            this.gumbRaketa1.BackColor = System.Drawing.Color.DarkGray;
            this.gumbRaketa1.Location = new System.Drawing.Point(32, 204);
            this.gumbRaketa1.Name = "gumbRaketa1";
            this.gumbRaketa1.Size = new System.Drawing.Size(90, 40);
            this.gumbRaketa1.TabIndex = 5;
            this.gumbRaketa1.Text = "Debeljuco";
            this.gumbRaketa1.UseVisualStyleBackColor = false;
            this.gumbRaketa1.Click += new System.EventHandler(this.gumbRaketa1_Click);
            // 
            // gumbBrod
            // 
            this.gumbBrod.BackColor = System.Drawing.Color.DarkGray;
            this.gumbBrod.Location = new System.Drawing.Point(158, 204);
            this.gumbBrod.Name = "gumbBrod";
            this.gumbBrod.Size = new System.Drawing.Size(90, 40);
            this.gumbBrod.TabIndex = 6;
            this.gumbBrod.Text = "Brzi";
            this.gumbBrod.UseVisualStyleBackColor = false;
            this.gumbBrod.Click += new System.EventHandler(this.gumbBrod_Click);
            // 
            // gumbRaketa2
            // 
            this.gumbRaketa2.BackColor = System.Drawing.Color.DarkGray;
            this.gumbRaketa2.Location = new System.Drawing.Point(274, 204);
            this.gumbRaketa2.Name = "gumbRaketa2";
            this.gumbRaketa2.Size = new System.Drawing.Size(90, 40);
            this.gumbRaketa2.TabIndex = 7;
            this.gumbRaketa2.Text = "Svemirski";
            this.gumbRaketa2.UseVisualStyleBackColor = false;
            this.gumbRaketa2.Click += new System.EventHandler(this.gumbRaketa2_Click);
            // 
            // Odabir
            // 
            this.Odabir.AutoSize = true;
            this.Odabir.BackColor = System.Drawing.Color.Transparent;
            this.Odabir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odabir.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Odabir.Location = new System.Drawing.Point(19, 27);
            this.Odabir.Name = "Odabir";
            this.Odabir.Size = new System.Drawing.Size(114, 16);
            this.Odabir.TabIndex = 8;
            this.Odabir.Text = "Odaberi raketu:";
            // 
            // Razina
            // 
            this.Razina.AutoSize = true;
            this.Razina.BackColor = System.Drawing.Color.Transparent;
            this.Razina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Razina.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Razina.Location = new System.Drawing.Point(19, 270);
            this.Razina.Name = "Razina";
            this.Razina.Size = new System.Drawing.Size(112, 16);
            this.Razina.TabIndex = 9;
            this.Razina.Text = "Odaberi razinu:";
            // 
            // razinaLagana
            // 
            this.razinaLagana.BackColor = System.Drawing.Color.DarkGray;
            this.razinaLagana.Location = new System.Drawing.Point(32, 320);
            this.razinaLagana.Name = "razinaLagana";
            this.razinaLagana.Size = new System.Drawing.Size(90, 40);
            this.razinaLagana.TabIndex = 10;
            this.razinaLagana.Text = "Lagana";
            this.razinaLagana.UseVisualStyleBackColor = false;
            this.razinaLagana.Click += new System.EventHandler(this.razinaLagana_Click);
            // 
            // razinaSrednja
            // 
            this.razinaSrednja.BackColor = System.Drawing.Color.DarkGray;
            this.razinaSrednja.Location = new System.Drawing.Point(158, 320);
            this.razinaSrednja.Name = "razinaSrednja";
            this.razinaSrednja.Size = new System.Drawing.Size(90, 40);
            this.razinaSrednja.TabIndex = 11;
            this.razinaSrednja.Text = "Srednja";
            this.razinaSrednja.UseVisualStyleBackColor = false;
            this.razinaSrednja.Click += new System.EventHandler(this.razinaSrednja_Click);
            // 
            // razinaTeska
            // 
            this.razinaTeska.BackColor = System.Drawing.Color.DarkGray;
            this.razinaTeska.Location = new System.Drawing.Point(274, 320);
            this.razinaTeska.Name = "razinaTeska";
            this.razinaTeska.Size = new System.Drawing.Size(90, 40);
            this.razinaTeska.TabIndex = 12;
            this.razinaTeska.Text = "Teška";
            this.razinaTeska.UseVisualStyleBackColor = false;
            this.razinaTeska.Click += new System.EventHandler(this.razinaTeska_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Raketa.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(418, 530);
            this.Controls.Add(this.razinaTeska);
            this.Controls.Add(this.razinaSrednja);
            this.Controls.Add(this.razinaLagana);
            this.Controls.Add(this.Razina);
            this.Controls.Add(this.Odabir);
            this.Controls.Add(this.gumbRaketa2);
            this.Controls.Add(this.gumbBrod);
            this.Controls.Add(this.gumbRaketa1);
            this.Controls.Add(this.slikaRaketa2);
            this.Controls.Add(this.slikaRaketa1);
            this.Controls.Add(this.slikaBrod);
            this.Controls.Add(this.gumbPovratak);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.slikaBrod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaRaketa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaRaketa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button gumbPovratak;
        private System.Windows.Forms.PictureBox slikaBrod;
        private System.Windows.Forms.PictureBox slikaRaketa1;
        private System.Windows.Forms.PictureBox slikaRaketa2;
        private System.Windows.Forms.Button gumbRaketa1;
        private System.Windows.Forms.Button gumbBrod;
        private System.Windows.Forms.Button gumbRaketa2;
        private System.Windows.Forms.Label Odabir;
        private System.Windows.Forms.Label Razina;
        private System.Windows.Forms.Button razinaLagana;
        private System.Windows.Forms.Button razinaSrednja;
        private System.Windows.Forms.Button razinaTeska;
    }
}

