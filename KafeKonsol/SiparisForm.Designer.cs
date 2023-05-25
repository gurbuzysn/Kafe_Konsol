namespace KafeKonsol
{
    partial class SiparisForm
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
            label1 = new Label();
            cboUrun = new ComboBox();
            nudAdet = new NumericUpDown();
            btnEkle = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnMasaTasi = new Button();
            label3 = new Label();
            cboMasaNo = new NumericUpDown();
            label4 = new Label();
            btnOdemeAl = new Button();
            btnIptal = new Button();
            btnAnaSayfayaDon = new Button();
            lblOdemeTutari = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboMasaNo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // cboUrun
            // 
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(13, 34);
            cboUrun.Margin = new Padding(4);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(154, 29);
            cboUrun.TabIndex = 1;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(197, 35);
            nudAdet.Margin = new Padding(4);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(90, 29);
            nudAdet.TabIndex = 2;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(304, 35);
            btnEkle.Margin = new Padding(4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 33);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(13, 72);
            dgvDetaylar.Margin = new Padding(4);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(477, 402);
            dgvDetaylar.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            Column2.HeaderText = "Fiyat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 0;
            label2.Text = "Adet";
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(717, 37);
            btnMasaTasi.Margin = new Padding(4);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(120, 32);
            btnMasaTasi.TabIndex = 3;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(584, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 0;
            label3.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.Location = new Point(584, 40);
            cboMasaNo.Margin = new Padding(5, 6, 5, 6);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(124, 29);
            cboMasaNo.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(583, 318);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 5;
            label4.Text = "Ödeme Tutarı:";
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.ForestGreen;
            btnOdemeAl.ForeColor = Color.White;
            btnOdemeAl.Location = new Point(681, 368);
            btnOdemeAl.Margin = new Padding(4);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(156, 46);
            btnOdemeAl.TabIndex = 3;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.BackColor = Color.Maroon;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(518, 368);
            btnIptal.Margin = new Padding(4);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(155, 46);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "SİPARİŞ İPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnaSayfayaDon.BackColor = Color.Gold;
            btnAnaSayfayaDon.Location = new Point(518, 422);
            btnAnaSayfayaDon.Margin = new Padding(4);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(319, 52);
            btnAnaSayfayaDon.TabIndex = 3;
            btnAnaSayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(734, 318);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(33, 25);
            lblOdemeTutari.TabIndex = 5;
            lblOdemeTutari.Text = "0tl";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Arial Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.White;
            lblMasaNo.Location = new Point(518, 75);
            lblMasaNo.Margin = new Padding(4, 0, 4, 0);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(319, 220);
            lblMasaNo.TabIndex = 0;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 483);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label4);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnMasaTasi);
            Controls.Add(btnIptal);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnEkle);
            Controls.Add(cboMasaNo);
            Controls.Add(nudAdet);
            Controls.Add(label3);
            Controls.Add(cboUrun);
            Controls.Add(lblMasaNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(866, 522);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboMasaNo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnEkle;
        private DataGridView dgvDetaylar;
        private Label label2;
        private Button btnMasaTasi;
        private Label label3;
        private NumericUpDown cboMasaNo;
        private Label label4;
        private Button btnOdemeAl;
        private Button btnIptal;
        private Button btnAnaSayfayaDon;
        private Label lblOdemeTutari;
        private Label lblMasaNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}