using System;

namespace Dreiecksberechner_v1._0._2
{
    partial class Berechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berechneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblsa = new System.Windows.Forms.Label();
            this.txtbxsa = new System.Windows.Forms.TextBox();
            this.lblsb = new System.Windows.Forms.Label();
            this.lblsc = new System.Windows.Forms.Label();
            this.lblwa = new System.Windows.Forms.Label();
            this.lblwb = new System.Windows.Forms.Label();
            this.lblwg = new System.Windows.Forms.Label();
            this.txtbxsb = new System.Windows.Forms.TextBox();
            this.txtbxsc = new System.Windows.Forms.TextBox();
            this.txtbxwa = new System.Windows.Forms.TextBox();
            this.txtbxwb = new System.Windows.Forms.TextBox();
            this.txtbxwg = new System.Windows.Forms.TextBox();
            this.lblu = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.txtbxa = new System.Windows.Forms.TextBox();
            this.txtbxu = new System.Windows.Forms.TextBox();
            this.lblha = new System.Windows.Forms.Label();
            this.lblhb = new System.Windows.Forms.Label();
            this.lblhc = new System.Windows.Forms.Label();
            this.txtbxha = new System.Windows.Forms.TextBox();
            this.txtbxhb = new System.Windows.Forms.TextBox();
            this.txtbxhc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berechneToolStripMenuItem,
            this.endeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // berechneToolStripMenuItem
            // 
            this.berechneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.berechneToolStripMenuItem.Name = "berechneToolStripMenuItem";
            this.berechneToolStripMenuItem.Size = new System.Drawing.Size(137, 41);
            this.berechneToolStripMenuItem.Text = "Berechne";
            this.berechneToolStripMenuItem.Click += new System.EventHandler(this.berechneToolStripMenuItem_Click);
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(88, 41);
            this.endeToolStripMenuItem.Text = "Ende";
            this.endeToolStripMenuItem.Click += new System.EventHandler(this.endeToolStripMenuItem_Click);
            // 
            // lblsa
            // 
            this.lblsa.AutoSize = true;
            this.lblsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblsa.Location = new System.Drawing.Point(24, 100);
            this.lblsa.Name = "lblsa";
            this.lblsa.Size = new System.Drawing.Size(73, 25);
            this.lblsa.TabIndex = 1;
            this.lblsa.Text = "Seite a";
            // 
            // txtbxsa
            // 
            this.txtbxsa.Location = new System.Drawing.Point(206, 100);
            this.txtbxsa.Name = "txtbxsa";
            this.txtbxsa.Size = new System.Drawing.Size(100, 20);
            this.txtbxsa.TabIndex = 2;
            // 
            // lblsb
            // 
            this.lblsb.AutoSize = true;
            this.lblsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblsb.Location = new System.Drawing.Point(25, 125);
            this.lblsb.Name = "lblsb";
            this.lblsb.Size = new System.Drawing.Size(73, 25);
            this.lblsb.TabIndex = 3;
            this.lblsb.Text = "Seite b";
            // 
            // lblsc
            // 
            this.lblsc.AutoSize = true;
            this.lblsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblsc.Location = new System.Drawing.Point(25, 150);
            this.lblsc.Name = "lblsc";
            this.lblsc.Size = new System.Drawing.Size(72, 25);
            this.lblsc.TabIndex = 4;
            this.lblsc.Text = "Seite c";
            // 
            // lblwa
            // 
            this.lblwa.AutoSize = true;
            this.lblwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblwa.Location = new System.Drawing.Point(25, 200);
            this.lblwa.Name = "lblwa";
            this.lblwa.Size = new System.Drawing.Size(125, 25);
            this.lblwa.TabIndex = 5;
            this.lblwa.Text = "Winkel alpha";
            // 
            // lblwb
            // 
            this.lblwb.AutoSize = true;
            this.lblwb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblwb.Location = new System.Drawing.Point(25, 225);
            this.lblwb.Name = "lblwb";
            this.lblwb.Size = new System.Drawing.Size(115, 25);
            this.lblwb.TabIndex = 6;
            this.lblwb.Text = "Winkel beta";
            // 
            // lblwg
            // 
            this.lblwg.AutoSize = true;
            this.lblwg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblwg.Location = new System.Drawing.Point(24, 250);
            this.lblwg.Name = "lblwg";
            this.lblwg.Size = new System.Drawing.Size(142, 25);
            this.lblwg.TabIndex = 7;
            this.lblwg.Text = "Winkel gamma";
            // 
            // txtbxsb
            // 
            this.txtbxsb.Location = new System.Drawing.Point(206, 125);
            this.txtbxsb.Name = "txtbxsb";
            this.txtbxsb.Size = new System.Drawing.Size(100, 20);
            this.txtbxsb.TabIndex = 8;
            // 
            // txtbxsc
            // 
            this.txtbxsc.Location = new System.Drawing.Point(206, 150);
            this.txtbxsc.Name = "txtbxsc";
            this.txtbxsc.Size = new System.Drawing.Size(100, 20);
            this.txtbxsc.TabIndex = 9;
            // 
            // txtbxwa
            // 
            this.txtbxwa.Location = new System.Drawing.Point(206, 200);
            this.txtbxwa.Name = "txtbxwa";
            this.txtbxwa.Size = new System.Drawing.Size(100, 20);
            this.txtbxwa.TabIndex = 10;
            // 
            // txtbxwb
            // 
            this.txtbxwb.Location = new System.Drawing.Point(206, 225);
            this.txtbxwb.Name = "txtbxwb";
            this.txtbxwb.Size = new System.Drawing.Size(100, 20);
            this.txtbxwb.TabIndex = 11;
            // 
            // txtbxwg
            // 
            this.txtbxwg.Location = new System.Drawing.Point(206, 250);
            this.txtbxwg.Name = "txtbxwg";
            this.txtbxwg.Size = new System.Drawing.Size(100, 20);
            this.txtbxwg.TabIndex = 12;
            // 
            // lblu
            // 
            this.lblu.AutoSize = true;
            this.lblu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblu.Location = new System.Drawing.Point(25, 325);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(80, 25);
            this.lblu.TabIndex = 13;
            this.lblu.Text = "Umfang";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbla.Location = new System.Drawing.Point(25, 300);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(128, 25);
            this.lbla.TabIndex = 14;
            this.lbla.Text = "Flächeninhalt";
            // 
            // txtbxa
            // 
            this.txtbxa.Location = new System.Drawing.Point(206, 300);
            this.txtbxa.Name = "txtbxa";
            this.txtbxa.Size = new System.Drawing.Size(100, 20);
            this.txtbxa.TabIndex = 15;
            // 
            // txtbxu
            // 
            this.txtbxu.Location = new System.Drawing.Point(206, 325);
            this.txtbxu.Name = "txtbxu";
            this.txtbxu.Size = new System.Drawing.Size(100, 20);
            this.txtbxu.TabIndex = 16;
            // 
            // lblha
            // 
            this.lblha.AutoSize = true;
            this.lblha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblha.Location = new System.Drawing.Point(24, 375);
            this.lblha.Name = "lblha";
            this.lblha.Size = new System.Drawing.Size(107, 25);
            this.lblha.TabIndex = 17;
            this.lblha.Text = "Höhe auf a";
            // 
            // lblhb
            // 
            this.lblhb.AutoSize = true;
            this.lblhb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblhb.Location = new System.Drawing.Point(24, 400);
            this.lblhb.Name = "lblhb";
            this.lblhb.Size = new System.Drawing.Size(107, 25);
            this.lblhb.TabIndex = 18;
            this.lblhb.Text = "Höhe auf b";
            // 
            // lblhc
            // 
            this.lblhc.AutoSize = true;
            this.lblhc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblhc.Location = new System.Drawing.Point(24, 425);
            this.lblhc.Name = "lblhc";
            this.lblhc.Size = new System.Drawing.Size(106, 25);
            this.lblhc.TabIndex = 19;
            this.lblhc.Text = "Höhe auf c";
            // 
            // txtbxha
            // 
            this.txtbxha.Location = new System.Drawing.Point(206, 375);
            this.txtbxha.Name = "txtbxha";
            this.txtbxha.Size = new System.Drawing.Size(100, 20);
            this.txtbxha.TabIndex = 20;
            // 
            // txtbxhb
            // 
            this.txtbxhb.Location = new System.Drawing.Point(206, 400);
            this.txtbxhb.Name = "txtbxhb";
            this.txtbxhb.Size = new System.Drawing.Size(100, 20);
            this.txtbxhb.TabIndex = 21;
            // 
            // txtbxhc
            // 
            this.txtbxhc.Location = new System.Drawing.Point(206, 425);
            this.txtbxhc.Name = "txtbxhc";
            this.txtbxhc.Size = new System.Drawing.Size(100, 20);
            this.txtbxhc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gib die Seiten a, b und c an, um Winkel, Flächeninhalt, Umfang und Höhen auszurec" +
    "hnen";
            // 
            // picBox1
            // 
            this.picBox1.Image = global::Dreiecksberechner_v1._0._2.Properties.Resources.Dreieckpic;
            this.picBox1.InitialImage = null;
            this.picBox1.Location = new System.Drawing.Point(322, 100);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(554, 338);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox1.TabIndex = 24;
            this.picBox1.TabStop = false;
            // 
            // Berechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 461);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxhc);
            this.Controls.Add(this.txtbxhb);
            this.Controls.Add(this.txtbxha);
            this.Controls.Add(this.lblhc);
            this.Controls.Add(this.lblhb);
            this.Controls.Add(this.lblha);
            this.Controls.Add(this.txtbxu);
            this.Controls.Add(this.txtbxa);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblu);
            this.Controls.Add(this.txtbxwg);
            this.Controls.Add(this.txtbxwb);
            this.Controls.Add(this.txtbxwa);
            this.Controls.Add(this.txtbxsc);
            this.Controls.Add(this.txtbxsb);
            this.Controls.Add(this.lblwg);
            this.Controls.Add(this.lblwb);
            this.Controls.Add(this.lblwa);
            this.Controls.Add(this.lblsc);
            this.Controls.Add(this.lblsb);
            this.Controls.Add(this.txtbxsa);
            this.Controls.Add(this.lblsa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(259, 179);
            this.Name = "Berechner";
            this.Text = "Berechner";
            this.Load += new System.EventHandler(this.Berechner_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berechneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endeToolStripMenuItem;
        private System.Windows.Forms.Label lblsa;
        private System.Windows.Forms.TextBox txtbxsa;
        private System.Windows.Forms.Label lblsb;
        private System.Windows.Forms.Label lblsc;
        private System.Windows.Forms.Label lblwa;
        private System.Windows.Forms.Label lblwb;
        private System.Windows.Forms.Label lblwg;
        private System.Windows.Forms.TextBox txtbxsb;
        private System.Windows.Forms.TextBox txtbxsc;
        private System.Windows.Forms.TextBox txtbxwa;
        private System.Windows.Forms.TextBox txtbxwb;
        private System.Windows.Forms.TextBox txtbxwg;
        private System.Windows.Forms.Label lblu;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txtbxa;
        private System.Windows.Forms.TextBox txtbxu;
        private System.Windows.Forms.Label lblha;
        private System.Windows.Forms.Label lblhb;
        private System.Windows.Forms.Label lblhc;
        private System.Windows.Forms.TextBox txtbxha;
        private System.Windows.Forms.TextBox txtbxhb;
        private System.Windows.Forms.TextBox txtbxhc;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picBox1;
    }
}

