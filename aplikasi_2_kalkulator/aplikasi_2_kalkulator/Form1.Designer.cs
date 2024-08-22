namespace aplikasi_2_kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            label3 = new Label();
            txthasil = new TextBox();
            button_penjumlahan = new Button();
            button_dikurangi = new Button();
            button_perkalian = new Button();
            button_pembagian = new Button();
            button_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 59);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Angka 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 125);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Angka 2";
            // 
            // txtA
            // 
            txtA.Location = new Point(233, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 27);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(233, 125);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 27);
            txtB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 195);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Hasil";
            // 
            // txthasil
            // 
            txthasil.BackColor = SystemColors.ScrollBar;
            txthasil.BorderStyle = BorderStyle.FixedSingle;
            txthasil.Location = new Point(233, 188);
            txthasil.Name = "txthasil";
            txthasil.Size = new Size(200, 27);
            txthasil.TabIndex = 5;
            txthasil.TextChanged += txthasil_TextChanged;
            // 
            // button_penjumlahan
            // 
            button_penjumlahan.Location = new Point(120, 256);
            button_penjumlahan.Name = "button_penjumlahan";
            button_penjumlahan.Size = new Size(63, 58);
            button_penjumlahan.TabIndex = 6;
            button_penjumlahan.Text = "+";
            button_penjumlahan.UseVisualStyleBackColor = true;
            button_penjumlahan.Click += button1_Click;
            // 
            // button_dikurangi
            // 
            button_dikurangi.Location = new Point(206, 256);
            button_dikurangi.Name = "button_dikurangi";
            button_dikurangi.Size = new Size(63, 58);
            button_dikurangi.TabIndex = 7;
            button_dikurangi.Text = "-";
            button_dikurangi.UseVisualStyleBackColor = true;
            button_dikurangi.Click += button2_Click;
            // 
            // button_perkalian
            // 
            button_perkalian.Location = new Point(120, 320);
            button_perkalian.Name = "button_perkalian";
            button_perkalian.Size = new Size(63, 58);
            button_perkalian.TabIndex = 8;
            button_perkalian.Text = "X";
            button_perkalian.UseVisualStyleBackColor = true;
            button_perkalian.Click += button3_Click;
            // 
            // button_pembagian
            // 
            button_pembagian.Location = new Point(206, 320);
            button_pembagian.Name = "button_pembagian";
            button_pembagian.Size = new Size(63, 58);
            button_pembagian.TabIndex = 9;
            button_pembagian.Text = "/";
            button_pembagian.UseVisualStyleBackColor = true;
            button_pembagian.Click += button4_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(293, 256);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(113, 122);
            button_clear.TabIndex = 10;
            button_clear.Text = "C";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_clear);
            Controls.Add(button_pembagian);
            Controls.Add(button_perkalian);
            Controls.Add(button_dikurangi);
            Controls.Add(button_penjumlahan);
            Controls.Add(txthasil);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aplikasi Perhitungan";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private Label label3;
        private TextBox txthasil;
        private Button button_penjumlahan;
        private Button button_dikurangi;
        private Button button_perkalian;
        private Button button_pembagian;
        private Button button_clear;
    }
}