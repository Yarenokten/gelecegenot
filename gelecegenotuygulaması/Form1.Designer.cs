namespace gelecegenotuygulaması
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
            this.btn_comments = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_homepage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_comments
            // 
            this.btn_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btn_comments.Location = new System.Drawing.Point(73, 417);
            this.btn_comments.Name = "btn_comments";
            this.btn_comments.Size = new System.Drawing.Size(227, 45);
            this.btn_comments.TabIndex = 7;
            this.btn_comments.Text = "YORUMLARIMIZ";
            this.btn_comments.UseVisualStyleBackColor = false;
            this.btn_comments.Click += new System.EventHandler(this.btn_comments_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btn_signup.Location = new System.Drawing.Point(73, 271);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(227, 45);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "KAYIT OL";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btn_home.Location = new System.Drawing.Point(73, 341);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(227, 45);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "ANASAYFA";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btn_login.Location = new System.Drawing.Point(73, 205);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(227, 45);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "GİRİŞ YAP";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_homepage
            // 
            this.lbl_homepage.AutoSize = true;
            this.lbl_homepage.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homepage.Location = new System.Drawing.Point(445, 9);
            this.lbl_homepage.Name = "lbl_homepage";
            this.lbl_homepage.Size = new System.Drawing.Size(689, 57);
            this.lbl_homepage.TabIndex = 4;
            this.lbl_homepage.Text = "To   The   Future   Me!         ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(464, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = " Fotoğraf ve belge ekleme gibi birçok özelliği kolayca kullanabilirsiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(909, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zamandan Tasarruf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(468, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(705, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Silmediğiniz taktirde  yazmış olduğunuz mektuplarınızı daha sonra tekrar okuyabil" +
    "irsiniz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_signup);
            this.panel1.Controls.Add(this.btn_comments);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 557);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_log_in_50;
            this.pictureBox2.Location = new System.Drawing.Point(12, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_sign_up_48;
            this.pictureBox3.Location = new System.Drawing.Point(12, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gelecegenotuygulaması.Properties.Resources.icons8_customer_100;
            this.pictureBox1.Location = new System.Drawing.Point(95, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 119);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_comments_50;
            this.pictureBox5.Location = new System.Drawing.Point(12, 411);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 51);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_home_page_50;
            this.pictureBox4.Location = new System.Drawing.Point(12, 335);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 51);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_letter_100;
            this.pictureBox9.Location = new System.Drawing.Point(334, 402);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(102, 102);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_time_100;
            this.pictureBox8.Location = new System.Drawing.Point(1095, 280);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(102, 102);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::gelecegenotuygulaması.Properties.Resources.icons8_skill_100;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(334, 160);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 103);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1209, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lbl_homepage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Geleceğe Not Bırakalım";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_comments;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_homepage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

