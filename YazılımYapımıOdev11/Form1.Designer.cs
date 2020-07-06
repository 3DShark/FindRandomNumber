namespace YazılımYapımıOdev11
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.randomSayi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ciftSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hedefSayiLabel = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.manuelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hedefText = new System.Windows.Forms.TextBox();
            this.ciftText = new System.Windows.Forms.TextBox();
            this.besText = new System.Windows.Forms.TextBox();
            this.dortText = new System.Windows.Forms.TextBox();
            this.ucText = new System.Windows.Forms.TextBox();
            this.ikinciText = new System.Windows.Forms.TextBox();
            this.birinciText = new System.Windows.Forms.TextBox();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 244);
            this.listBox1.TabIndex = 0;
            // 
            // randomSayi
            // 
            this.randomSayi.Location = new System.Drawing.Point(13, 278);
            this.randomSayi.Name = "randomSayi";
            this.randomSayi.Size = new System.Drawing.Size(119, 45);
            this.randomSayi.TabIndex = 1;
            this.randomSayi.Text = "Random Sayı Oluştur";
            this.randomSayi.UseVisualStyleBackColor = true;
            this.randomSayi.Click += new System.EventHandler(this.randomSayi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çift Haneli Sayı";
            // 
            // ciftSayi
            // 
            this.ciftSayi.AutoSize = true;
            this.ciftSayi.Location = new System.Drawing.Point(213, 47);
            this.ciftSayi.Name = "ciftSayi";
            this.ciftSayi.Size = new System.Drawing.Size(0, 17);
            this.ciftSayi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hedef Sayı";
            // 
            // hedefSayiLabel
            // 
            this.hedefSayiLabel.AutoSize = true;
            this.hedefSayiLabel.Location = new System.Drawing.Point(216, 145);
            this.hedefSayiLabel.Name = "hedefSayiLabel";
            this.hedefSayiLabel.Size = new System.Drawing.Size(0, 17);
            this.hedefSayiLabel.TabIndex = 5;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(464, 278);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(100, 45);
            this.hesapla.TabIndex = 6;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çözüm Yolu:";
            // 
            // sonucLabel
            // 
            this.sonucLabel.AutoSize = true;
            this.sonucLabel.Location = new System.Drawing.Point(461, 145);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(0, 17);
            this.sonucLabel.TabIndex = 8;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Location = new System.Drawing.Point(401, 13);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(205, 21);
            this.randomRadioButton.TabIndex = 9;
            this.randomRadioButton.Text = "Random Sayılarla İşlem Yap";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            this.randomRadioButton.CheckedChanged += new System.EventHandler(this.randomRadioButton_CheckedChanged);
            // 
            // manuelRadioButton
            // 
            this.manuelRadioButton.AutoSize = true;
            this.manuelRadioButton.Checked = true;
            this.manuelRadioButton.Location = new System.Drawing.Point(401, 47);
            this.manuelRadioButton.Name = "manuelRadioButton";
            this.manuelRadioButton.Size = new System.Drawing.Size(241, 21);
            this.manuelRadioButton.TabIndex = 9;
            this.manuelRadioButton.TabStop = true;
            this.manuelRadioButton.Text = "Kendi Girdiğin Sayılarla İşlem Yap";
            this.manuelRadioButton.UseVisualStyleBackColor = true;
            this.manuelRadioButton.CheckedChanged += new System.EventHandler(this.manuelRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hedefText);
            this.groupBox1.Controls.Add(this.ciftText);
            this.groupBox1.Controls.Add(this.besText);
            this.groupBox1.Controls.Add(this.dortText);
            this.groupBox1.Controls.Add(this.ucText);
            this.groupBox1.Controls.Add(this.ikinciText);
            this.groupBox1.Controls.Add(this.birinciText);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hedef Sayı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Çift Haneli Sayı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "5.Sayı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "4.Sayı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "3.Sayı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "2.Sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "1.Sayı";
            // 
            // hedefText
            // 
            this.hedefText.Location = new System.Drawing.Point(149, 224);
            this.hedefText.Name = "hedefText";
            this.hedefText.Size = new System.Drawing.Size(100, 22);
            this.hedefText.TabIndex = 0;
            // 
            // ciftText
            // 
            this.ciftText.Location = new System.Drawing.Point(149, 192);
            this.ciftText.Name = "ciftText";
            this.ciftText.Size = new System.Drawing.Size(100, 22);
            this.ciftText.TabIndex = 0;
            // 
            // besText
            // 
            this.besText.Location = new System.Drawing.Point(149, 163);
            this.besText.Name = "besText";
            this.besText.Size = new System.Drawing.Size(100, 22);
            this.besText.TabIndex = 0;
            // 
            // dortText
            // 
            this.dortText.Location = new System.Drawing.Point(149, 133);
            this.dortText.Name = "dortText";
            this.dortText.Size = new System.Drawing.Size(100, 22);
            this.dortText.TabIndex = 0;
            // 
            // ucText
            // 
            this.ucText.Location = new System.Drawing.Point(149, 101);
            this.ucText.Name = "ucText";
            this.ucText.Size = new System.Drawing.Size(100, 22);
            this.ucText.TabIndex = 0;
            // 
            // ikinciText
            // 
            this.ikinciText.Location = new System.Drawing.Point(149, 68);
            this.ikinciText.Name = "ikinciText";
            this.ikinciText.Size = new System.Drawing.Size(100, 22);
            this.ikinciText.TabIndex = 0;
            // 
            // birinciText
            // 
            this.birinciText.Location = new System.Drawing.Point(149, 34);
            this.birinciText.Name = "birinciText";
            this.birinciText.Size = new System.Drawing.Size(100, 22);
            this.birinciText.TabIndex = 0;
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Location = new System.Drawing.Point(652, 278);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(91, 50);
            this.TemizleBtn.TabIndex = 11;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = true;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.TemizleBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manuelRadioButton);
            this.Controls.Add(this.randomRadioButton);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.hedefSayiLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciftSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomSayi);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button randomSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ciftSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hedefSayiLabel;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.RadioButton manuelRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birinciText;
        private System.Windows.Forms.TextBox hedefText;
        private System.Windows.Forms.TextBox ciftText;
        private System.Windows.Forms.TextBox besText;
        private System.Windows.Forms.TextBox dortText;
        private System.Windows.Forms.TextBox ucText;
        private System.Windows.Forms.TextBox ikinciText;
        private System.Windows.Forms.Button TemizleBtn;
    }
}

