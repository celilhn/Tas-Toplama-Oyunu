namespace Taş_Toplama_Oyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStok = new System.Windows.Forms.Label();
            this.lbl_ana_tas = new System.Windows.Forms.Label();
            this.lbl_oyuncu1_yantas = new System.Windows.Forms.Label();
            this.lbl_duvaroyuncu1 = new System.Windows.Forms.Label();
            this.lbl_duvar_oyuncu2 = new System.Windows.Forms.Label();
            this.lbl_oyuncu2_yantas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Oyuncu_Siralama = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stok_2 = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(130, 486);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(0, 13);
            this.lblStok.TabIndex = 184;
            // 
            // lbl_ana_tas
            // 
            this.lbl_ana_tas.AllowDrop = true;
            this.lbl_ana_tas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ana_tas.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ana_tas.Image")));
            this.lbl_ana_tas.Location = new System.Drawing.Point(439, 246);
            this.lbl_ana_tas.Name = "lbl_ana_tas";
            this.lbl_ana_tas.Size = new System.Drawing.Size(40, 40);
            this.lbl_ana_tas.TabIndex = 187;
            this.lbl_ana_tas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ana_tas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_ana_tas_MouseDown);
            // 
            // lbl_oyuncu1_yantas
            // 
            this.lbl_oyuncu1_yantas.AllowDrop = true;
            this.lbl_oyuncu1_yantas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_oyuncu1_yantas.Image = ((System.Drawing.Image)(resources.GetObject("lbl_oyuncu1_yantas.Image")));
            this.lbl_oyuncu1_yantas.Location = new System.Drawing.Point(108, 499);
            this.lbl_oyuncu1_yantas.Name = "lbl_oyuncu1_yantas";
            this.lbl_oyuncu1_yantas.Size = new System.Drawing.Size(40, 40);
            this.lbl_oyuncu1_yantas.TabIndex = 103;
            this.lbl_oyuncu1_yantas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_tas_MouseDown);
            // 
            // lbl_duvaroyuncu1
            // 
            this.lbl_duvaroyuncu1.AllowDrop = true;
            this.lbl_duvaroyuncu1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_duvaroyuncu1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_duvaroyuncu1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_duvaroyuncu1.Image")));
            this.lbl_duvaroyuncu1.Location = new System.Drawing.Point(154, 499);
            this.lbl_duvaroyuncu1.Name = "lbl_duvaroyuncu1";
            this.lbl_duvaroyuncu1.Size = new System.Drawing.Size(40, 40);
            this.lbl_duvaroyuncu1.TabIndex = 188;
            this.lbl_duvaroyuncu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_duvaroyuncu1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_duvar_MouseDown_1);
            // 
            // lbl_duvar_oyuncu2
            // 
            this.lbl_duvar_oyuncu2.AllowDrop = true;
            this.lbl_duvar_oyuncu2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_duvar_oyuncu2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_duvar_oyuncu2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_duvar_oyuncu2.Image")));
            this.lbl_duvar_oyuncu2.Location = new System.Drawing.Point(154, 35);
            this.lbl_duvar_oyuncu2.Name = "lbl_duvar_oyuncu2";
            this.lbl_duvar_oyuncu2.Size = new System.Drawing.Size(40, 40);
            this.lbl_duvar_oyuncu2.TabIndex = 191;
            this.lbl_duvar_oyuncu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_duvar_oyuncu2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_duvar_2_MouseDown);
            // 
            // lbl_oyuncu2_yantas
            // 
            this.lbl_oyuncu2_yantas.AllowDrop = true;
            this.lbl_oyuncu2_yantas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_oyuncu2_yantas.Image = ((System.Drawing.Image)(resources.GetObject("lbl_oyuncu2_yantas.Image")));
            this.lbl_oyuncu2_yantas.Location = new System.Drawing.Point(108, 35);
            this.lbl_oyuncu2_yantas.Name = "lbl_oyuncu2_yantas";
            this.lbl_oyuncu2_yantas.Size = new System.Drawing.Size(40, 40);
            this.lbl_oyuncu2_yantas.TabIndex = 189;
            this.lbl_oyuncu2_yantas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_tas_2_MouseDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 192;
            this.label4.Text = "Oyuncu 2";
            // 
            // lbl_Oyuncu_Siralama
            // 
            this.lbl_Oyuncu_Siralama.AutoSize = true;
            this.lbl_Oyuncu_Siralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Oyuncu_Siralama.Location = new System.Drawing.Point(277, 508);
            this.lbl_Oyuncu_Siralama.Name = "lbl_Oyuncu_Siralama";
            this.lbl_Oyuncu_Siralama.Size = new System.Drawing.Size(0, 18);
            this.lbl_Oyuncu_Siralama.TabIndex = 193;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PeachPuff;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 194;
            this.label6.Text = "Oyuncu 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(430, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 195;
            this.label1.Text = "ANA TAŞ";
            // 
            // lbl_stok_2
            // 
            this.lbl_stok_2.AutoSize = true;
            this.lbl_stok_2.Location = new System.Drawing.Point(118, 13);
            this.lbl_stok_2.Name = "lbl_stok_2";
            this.lbl_stok_2.Size = new System.Drawing.Size(0, 13);
            this.lbl_stok_2.TabIndex = 196;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level.ForeColor = System.Drawing.Color.Red;
            this.lbl_level.Location = new System.Drawing.Point(395, 51);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(80, 24);
            this.lbl_level.TabIndex = 197;
            this.lbl_level.Text = "LEVEL ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(499, 560);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.lbl_stok_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Oyuncu_Siralama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_duvar_oyuncu2);
            this.Controls.Add(this.lbl_oyuncu2_yantas);
            this.Controls.Add(this.lbl_duvaroyuncu1);
            this.Controls.Add(this.lbl_ana_tas);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lbl_oyuncu1_yantas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_oyuncu1_yantas;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lbl_ana_tas;
        private System.Windows.Forms.Label lbl_duvaroyuncu1;
        private System.Windows.Forms.Label lbl_duvar_oyuncu2;
        private System.Windows.Forms.Label lbl_oyuncu2_yantas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Oyuncu_Siralama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stok_2;
        private System.Windows.Forms.Label lbl_level;
    }
}

