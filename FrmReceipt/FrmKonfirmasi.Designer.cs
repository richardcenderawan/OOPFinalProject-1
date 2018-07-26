namespace FrmReceipt
{
    partial class FrmKonfirmasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotHrg = new System.Windows.Forms.TextBox();
            this.tbKmblian = new System.Windows.Forms.TextBox();
            this.tbByr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPemesanan = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tbPPNPersen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiscPersen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoMember = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiscJlh = new System.Windows.Forms.TextBox();
            this.tbPPNJlh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(11, 327);
            this.lblTotalItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(77, 16);
            this.lblTotalItem.TabIndex = 4;
            this.lblTotalItem.Text = "{Total Item}";
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(144, 623);
            this.btnKonfirmasi.Margin = new System.Windows.Forms.Padding(2);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(84, 33);
            this.btnKonfirmasi.TabIndex = 5;
            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(257, 623);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(84, 33);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Location = new System.Drawing.Point(257, 524);
            this.lblTotalBayar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(78, 16);
            this.lblTotalBayar.TabIndex = 7;
            this.lblTotalBayar.Text = "Total Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 556);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bayar ";
            // 
            // tbTotHrg
            // 
            this.tbTotHrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotHrg.Location = new System.Drawing.Point(367, 524);
            this.tbTotHrg.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotHrg.Name = "tbTotHrg";
            this.tbTotHrg.ReadOnly = true;
            this.tbTotHrg.Size = new System.Drawing.Size(92, 22);
            this.tbTotHrg.TabIndex = 9;
            // 
            // tbKmblian
            // 
            this.tbKmblian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKmblian.Location = new System.Drawing.Point(367, 588);
            this.tbKmblian.Margin = new System.Windows.Forms.Padding(2);
            this.tbKmblian.Name = "tbKmblian";
            this.tbKmblian.ReadOnly = true;
            this.tbKmblian.Size = new System.Drawing.Size(92, 22);
            this.tbKmblian.TabIndex = 10;
            // 
            // tbByr
            // 
            this.tbByr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbByr.Location = new System.Drawing.Point(367, 556);
            this.tbByr.Margin = new System.Windows.Forms.Padding(2);
            this.tbByr.Name = "tbByr";
            this.tbByr.Size = new System.Drawing.Size(92, 22);
            this.tbByr.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 588);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kembalian";
            // 
            // lblPemesanan
            // 
            this.lblPemesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPemesanan.FormattingEnabled = true;
            this.lblPemesanan.ItemHeight = 16;
            this.lblPemesanan.Location = new System.Drawing.Point(9, 97);
            this.lblPemesanan.Margin = new System.Windows.Forms.Padding(2);
            this.lblPemesanan.Name = "lblPemesanan";
            this.lblPemesanan.Size = new System.Drawing.Size(451, 176);
            this.lblPemesanan.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "\t\t     \tRESTAURANT ",
            "\t\t\tJL. ASIA No. 300 ",
            "\t\t\t    MEDAN\t",
            "=========================================================="});
            this.listBox2.Location = new System.Drawing.Point(-1, 1);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(466, 64);
            this.listBox2.TabIndex = 14;
            // 
            // tbPPNPersen
            // 
            this.tbPPNPersen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPPNPersen.Location = new System.Drawing.Point(367, 464);
            this.tbPPNPersen.Margin = new System.Windows.Forms.Padding(2);
            this.tbPPNPersen.Name = "tbPPNPersen";
            this.tbPPNPersen.ReadOnly = true;
            this.tbPPNPersen.Size = new System.Drawing.Size(92, 22);
            this.tbPPNPersen.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 467);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "PPN";
            // 
            // tbDiscPersen
            // 
            this.tbDiscPersen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscPersen.Location = new System.Drawing.Point(367, 407);
            this.tbDiscPersen.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiscPersen.Name = "tbDiscPersen";
            this.tbDiscPersen.ReadOnly = true;
            this.tbDiscPersen.Size = new System.Drawing.Size(92, 22);
            this.tbDiscPersen.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 408);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Discount";
            // 
            // lblNoMember
            // 
            this.lblNoMember.AutoSize = true;
            this.lblNoMember.Location = new System.Drawing.Point(5, 67);
            this.lblNoMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoMember.Name = "lblNoMember";
            this.lblNoMember.Size = new System.Drawing.Size(89, 16);
            this.lblNoMember.TabIndex = 19;
            this.lblNoMember.Text = "{No Member}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "{Total Harga}";
            // 
            // tbDiscJlh
            // 
            this.tbDiscJlh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDiscJlh.Location = new System.Drawing.Point(367, 436);
            this.tbDiscJlh.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiscJlh.Name = "tbDiscJlh";
            this.tbDiscJlh.ReadOnly = true;
            this.tbDiscJlh.Size = new System.Drawing.Size(92, 22);
            this.tbDiscJlh.TabIndex = 21;
            // 
            // tbPPNJlh
            // 
            this.tbPPNJlh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPPNJlh.Location = new System.Drawing.Point(367, 492);
            this.tbPPNJlh.Margin = new System.Windows.Forms.Padding(2);
            this.tbPPNJlh.Name = "tbPPNJlh";
            this.tbPPNJlh.ReadOnly = true;
            this.tbPPNJlh.Size = new System.Drawing.Size(92, 22);
            this.tbPPNJlh.TabIndex = 22;
            // 
            // FrmKonfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 670);
            this.Controls.Add(this.tbPPNJlh);
            this.Controls.Add(this.tbDiscJlh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoMember);
            this.Controls.Add(this.tbDiscPersen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPPNPersen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbByr);
            this.Controls.Add(this.tbKmblian);
            this.Controls.Add(this.tbTotHrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalBayar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKonfirmasi";
            this.Text = "FrmKonfirmasi";
            this.Load += new System.EventHandler(this.FrmKonfirmasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotHrg;
        private System.Windows.Forms.TextBox tbKmblian;
        private System.Windows.Forms.TextBox tbByr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lblPemesanan;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox tbPPNPersen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiscPersen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiscJlh;
        private System.Windows.Forms.TextBox tbPPNJlh;
    }
}