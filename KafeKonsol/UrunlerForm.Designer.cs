namespace KafeKonsol
{
    partial class UrunlerForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 39);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyatı(tl)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(219, 39);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 29);
            numericUpDown1.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(381, 39);
            btnEkle.Margin = new Padding(4, 4, 4, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(97, 28);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat });
            dataGridView1.Location = new Point(13, 80);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(513, 466);
            dataGridView1.TabIndex = 5;
            // 
            // UrunAd
            // 
            UrunAd.HeaderText = "UrunAd";
            UrunAd.Name = "UrunAd";
            // 
            // BirimFiyat
            // 
            BirimFiyat.HeaderText = "BirimFiyat";
            BirimFiyat.Name = "BirimFiyat";
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 554);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UrunlerForm";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
    }
}