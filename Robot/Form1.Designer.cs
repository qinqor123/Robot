namespace Robot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ty1 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ty4 = new System.Windows.Forms.Label();
            this.tx4 = new System.Windows.Forms.Label();
            this.r4 = new System.Windows.Forms.Label();
            this.y4 = new System.Windows.Forms.Label();
            this.x4 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ty3 = new System.Windows.Forms.Label();
            this.tx3 = new System.Windows.Forms.Label();
            this.r3 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.Label();
            this.x3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ty2 = new System.Windows.Forms.Label();
            this.tx2 = new System.Windows.Forms.Label();
            this.r2 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnKordinat = new System.Windows.Forms.Button();
            this.BtnTiklama = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.Location = new System.Drawing.Point(469, 169);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(137, 117);
            this.BtnBaslat.TabIndex = 0;
            this.BtnBaslat.Text = "BAŞLAT       (Durmak İçin Proğrama Tıklayın)";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.button1_Click);

            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ty1);
            this.groupBox1.Controls.Add(this.tx1);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Controls.Add(this.y1);
            this.groupBox1.Controls.Add(this.x1);
            this.groupBox1.Location = new System.Drawing.Point(72, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birinci Parçacık";
            // 
            // ty1
            // 
            this.ty1.AutoSize = true;
            this.ty1.Location = new System.Drawing.Point(279, 24);
            this.ty1.Name = "ty1";
            this.ty1.Size = new System.Drawing.Size(14, 13);
            this.ty1.TabIndex = 0;
            this.ty1.Text = "Y";
            // 
            // tx1
            // 
            this.tx1.AutoSize = true;
            this.tx1.Location = new System.Drawing.Point(215, 24);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(14, 13);
            this.tx1.TabIndex = 0;
            this.tx1.Text = "X";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r1.Location = new System.Drawing.Point(145, 20);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(49, 24);
            this.r1.TabIndex = 0;
            this.r1.Text = "RGB";
            // 
            // y1
            // 
            this.y1.AutoSize = true;
            this.y1.Location = new System.Drawing.Point(81, 24);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(14, 13);
            this.y1.TabIndex = 0;
            this.y1.Text = "Y";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(18, 24);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(14, 13);
            this.x1.TabIndex = 0;
            this.x1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 274);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayarlamalar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ty4);
            this.groupBox5.Controls.Add(this.tx4);
            this.groupBox5.Controls.Add(this.r4);
            this.groupBox5.Controls.Add(this.y4);
            this.groupBox5.Controls.Add(this.x4);
            this.groupBox5.Location = new System.Drawing.Point(72, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 55);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dördüncü Parçacık";
            // 
            // ty4
            // 
            this.ty4.AutoSize = true;
            this.ty4.Location = new System.Drawing.Point(279, 21);
            this.ty4.Name = "ty4";
            this.ty4.Size = new System.Drawing.Size(14, 13);
            this.ty4.TabIndex = 0;
            this.ty4.Text = "Y";
            // 
            // tx4
            // 
            this.tx4.AutoSize = true;
            this.tx4.Location = new System.Drawing.Point(215, 21);
            this.tx4.Name = "tx4";
            this.tx4.Size = new System.Drawing.Size(14, 13);
            this.tx4.TabIndex = 0;
            this.tx4.Text = "X";
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r4.Location = new System.Drawing.Point(145, 16);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(49, 24);
            this.r4.TabIndex = 0;
            this.r4.Text = "RGB";
            // 
            // y4
            // 
            this.y4.AutoSize = true;
            this.y4.Location = new System.Drawing.Point(81, 24);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(14, 13);
            this.y4.TabIndex = 0;
            this.y4.Text = "Y";
            // 
            // x4
            // 
            this.x4.AutoSize = true;
            this.x4.Location = new System.Drawing.Point(18, 24);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(14, 13);
            this.x4.TabIndex = 0;
            this.x4.Text = "X";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(16, 222);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(47, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Aktif";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ty3);
            this.groupBox4.Controls.Add(this.tx3);
            this.groupBox4.Controls.Add(this.r3);
            this.groupBox4.Controls.Add(this.y3);
            this.groupBox4.Controls.Add(this.x3);
            this.groupBox4.Location = new System.Drawing.Point(72, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 55);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Üçüncü Parçacık";
            // 
            // ty3
            // 
            this.ty3.AutoSize = true;
            this.ty3.Location = new System.Drawing.Point(279, 21);
            this.ty3.Name = "ty3";
            this.ty3.Size = new System.Drawing.Size(14, 13);
            this.ty3.TabIndex = 0;
            this.ty3.Text = "Y";
            // 
            // tx3
            // 
            this.tx3.AutoSize = true;
            this.tx3.Location = new System.Drawing.Point(215, 21);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(14, 13);
            this.tx3.TabIndex = 0;
            this.tx3.Text = "X";
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r3.Location = new System.Drawing.Point(145, 16);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(49, 24);
            this.r3.TabIndex = 0;
            this.r3.Text = "RGB";
            // 
            // y3
            // 
            this.y3.AutoSize = true;
            this.y3.Location = new System.Drawing.Point(81, 24);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(14, 13);
            this.y3.TabIndex = 0;
            this.y3.Text = "Y";
            // 
            // x3
            // 
            this.x3.AutoSize = true;
            this.x3.Location = new System.Drawing.Point(18, 24);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(14, 13);
            this.x3.TabIndex = 0;
            this.x3.Text = "X";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Aktif";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ty2);
            this.groupBox3.Controls.Add(this.tx2);
            this.groupBox3.Controls.Add(this.r2);
            this.groupBox3.Controls.Add(this.y2);
            this.groupBox3.Controls.Add(this.x2);
            this.groupBox3.Location = new System.Drawing.Point(72, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 55);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İkinci Parçacık";
            // 
            // ty2
            // 
            this.ty2.AutoSize = true;
            this.ty2.Location = new System.Drawing.Point(279, 21);
            this.ty2.Name = "ty2";
            this.ty2.Size = new System.Drawing.Size(14, 13);
            this.ty2.TabIndex = 0;
            this.ty2.Text = "Y";
            // 
            // tx2
            // 
            this.tx2.AutoSize = true;
            this.tx2.Location = new System.Drawing.Point(215, 21);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(14, 13);
            this.tx2.TabIndex = 0;
            this.tx2.Text = "X";
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r2.Location = new System.Drawing.Point(145, 16);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(49, 24);
            this.r2.TabIndex = 0;
            this.r2.Text = "RGB";
            // 
            // y2
            // 
            this.y2.AutoSize = true;
            this.y2.Location = new System.Drawing.Point(81, 24);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(14, 13);
            this.y2.TabIndex = 0;
            this.y2.Text = "Y";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(18, 24);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(14, 13);
            this.x2.TabIndex = 0;
            this.x2.Text = "X";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Aktif";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // BtnIptal
            // 
            this.BtnIptal.Enabled = false;
            this.BtnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIptal.Location = new System.Drawing.Point(612, 12);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(103, 355);
            this.BtnIptal.TabIndex = 0;
            this.BtnIptal.Text = "DURDUR";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnKordinat
            // 
            this.BtnKordinat.Enabled = false;
            this.BtnKordinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKordinat.Location = new System.Drawing.Point(469, 12);
            this.BtnKordinat.Name = "BtnKordinat";
            this.BtnKordinat.Size = new System.Drawing.Size(137, 70);
            this.BtnKordinat.TabIndex = 0;
            this.BtnKordinat.Text = "Kontrol Kordinatı       (Basılı Tutup Gereken Yerde Bırakın)";
            this.BtnKordinat.UseVisualStyleBackColor = true;

            this.BtnKordinat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnKordinat_MouseDown);
            this.BtnKordinat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnKordinat_MouseUp);
            // 
            // BtnTiklama
            // 
            this.BtnTiklama.Enabled = false;
            this.BtnTiklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTiklama.Location = new System.Drawing.Point(469, 88);
            this.BtnTiklama.Name = "BtnTiklama";
            this.BtnTiklama.Size = new System.Drawing.Size(137, 75);
            this.BtnTiklama.TabIndex = 0;
            this.BtnTiklama.Text = "Tıklanacak Kordinat       (Basılı Tutup Gereken Yerde Bırakın)";
            this.BtnTiklama.UseVisualStyleBackColor = true;
            this.BtnTiklama.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnKordinat_MouseDown);
            this.BtnTiklama.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnTiklama_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(84, 292);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(438, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(528, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "500ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "HIZ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Yükle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnTiklama);
            this.Controls.Add(this.BtnKordinat);
            this.Controls.Add(this.BtnBaslat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomatik Tıklama Sistemi";
            this.TopMost = true;

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ty1;
        private System.Windows.Forms.Label tx1;
        private System.Windows.Forms.Label r1;
        private System.Windows.Forms.Label y1;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label ty4;
        private System.Windows.Forms.Label tx4;
        private System.Windows.Forms.Label r4;
        private System.Windows.Forms.Label y4;
        private System.Windows.Forms.Label x4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ty3;
        private System.Windows.Forms.Label tx3;
        private System.Windows.Forms.Label r3;
        private System.Windows.Forms.Label y3;
        private System.Windows.Forms.Label x3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ty2;
        private System.Windows.Forms.Label tx2;
        private System.Windows.Forms.Label r2;
        private System.Windows.Forms.Label y2;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnKordinat;
        private System.Windows.Forms.Button BtnTiklama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

