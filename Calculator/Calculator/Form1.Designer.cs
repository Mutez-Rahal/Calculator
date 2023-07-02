namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sonuc = new System.Windows.Forms.Label();
            this.islem = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.virgul = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sonuc
            // 
            this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(0, 67);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(358, 86);
            this.sonuc.TabIndex = 0;
            this.sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // islem
            // 
            this.islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem.ForeColor = System.Drawing.Color.Gray;
            this.islem.Location = new System.Drawing.Point(8, 44);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(100, 23);
            this.islem.TabIndex = 1;
            this.islem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.square.Location = new System.Drawing.Point(11, 156);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 80);
            this.square.TabIndex = 2;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // sifirla
            // 
            this.sifirla.AutoSize = true;
            this.sifirla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sifirla.FlatAppearance.BorderSize = 0;
            this.sifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla.Location = new System.Drawing.Point(100, 156);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(80, 80);
            this.sifirla.TabIndex = 3;
            this.sifirla.Text = "CE";
            this.sifirla.UseVisualStyleBackColor = false;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // sil
            // 
            this.sil.AutoSize = true;
            this.sil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(189, 156);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(80, 80);
            this.sil.TabIndex = 4;
            this.sil.Text = "⌫";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // bolme
            // 
            this.bolme.AutoSize = true;
            this.bolme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bolme.FlatAppearance.BorderSize = 0;
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme.Location = new System.Drawing.Point(278, 156);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(80, 80);
            this.bolme.TabIndex = 5;
            this.bolme.Text = "÷";
            this.bolme.UseVisualStyleBackColor = false;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(11, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(100, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 7;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(189, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 8;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // carpma
            // 
            this.carpma.AutoSize = true;
            this.carpma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.carpma.FlatAppearance.BorderSize = 0;
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.Location = new System.Drawing.Point(278, 242);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(80, 80);
            this.carpma.TabIndex = 9;
            this.carpma.Text = "x";
            this.carpma.UseVisualStyleBackColor = false;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(11, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 10;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(100, 328);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 80);
            this.button10.TabIndex = 11;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(189, 328);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 80);
            this.button11.TabIndex = 12;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // cikarma
            // 
            this.cikarma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cikarma.FlatAppearance.BorderSize = 0;
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarma.Location = new System.Drawing.Point(278, 328);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(80, 80);
            this.cikarma.TabIndex = 13;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = false;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(11, 414);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 80);
            this.button13.TabIndex = 14;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(100, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 80);
            this.button14.TabIndex = 15;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(189, 414);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 80);
            this.button15.TabIndex = 16;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // toplama
            // 
            this.toplama.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toplama.FlatAppearance.BorderSize = 0;
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(278, 414);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(80, 80);
            this.toplama.TabIndex = 17;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = false;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // virgul
            // 
            this.virgul.FlatAppearance.BorderSize = 0;
            this.virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.virgul.Location = new System.Drawing.Point(11, 500);
            this.virgul.Name = "virgul";
            this.virgul.Size = new System.Drawing.Size(80, 80);
            this.virgul.TabIndex = 18;
            this.virgul.Text = ",";
            this.virgul.UseVisualStyleBackColor = true;
            this.virgul.Click += new System.EventHandler(this.virgul_Click);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(100, 500);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 80);
            this.button18.TabIndex = 19;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.sayiYazdir);
            // 
            // esittir
            // 
            this.esittir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.esittir.FlatAppearance.BorderSize = 0;
            this.esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir.Location = new System.Drawing.Point(189, 500);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(169, 80);
            this.esittir.TabIndex = 20;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = false;
            this.esittir.Click += new System.EventHandler(this.esittir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 593);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.virgul);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.square);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.sonuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Label islem;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button virgul;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button esittir;
    }
}

