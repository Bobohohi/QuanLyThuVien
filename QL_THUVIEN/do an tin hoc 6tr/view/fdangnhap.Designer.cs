namespace do_an_tin_hoc_6tr
{
    partial class fdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdangnhap));
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btdangki = new System.Windows.Forms.Button();
            this.txdn = new System.Windows.Forms.TextBox();
            this.txmk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(597, 228);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(130, 30);
            this.btdangnhap.TabIndex = 0;
            this.btdangnhap.Text = "&Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdangki
            // 
            this.btdangki.Location = new System.Drawing.Point(597, 264);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(130, 30);
            this.btdangki.TabIndex = 1;
            this.btdangki.Text = "&Đăng Kí";
            this.btdangki.UseVisualStyleBackColor = true;
            this.btdangki.Click += new System.EventHandler(this.btdangki_Click);
            // 
            // txdn
            // 
            this.txdn.Location = new System.Drawing.Point(597, 116);
            this.txdn.Name = "txdn";
            this.txdn.Size = new System.Drawing.Size(238, 22);
            this.txdn.TabIndex = 2;
            this.txdn.TextChanged += new System.EventHandler(this.txdn_TextChanged);
            // 
            // txmk
            // 
            this.txmk.Location = new System.Drawing.Point(597, 162);
            this.txmk.Multiline = true;
            this.txmk.Name = "txmk";
            this.txmk.PasswordChar = '*';
            this.txmk.Size = new System.Drawing.Size(238, 22);
            this.txmk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(607, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đăng Nhập";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(597, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Hiện Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 376);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txmk);
            this.Controls.Add(this.txdn);
            this.Controls.Add(this.btdangki);
            this.Controls.Add(this.btdangnhap);
            this.Name = "fdangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btdangki;
        private System.Windows.Forms.TextBox txdn;
        private System.Windows.Forms.TextBox txmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

