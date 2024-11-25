namespace do_an_tin_hoc_6tr.view
{
    partial class cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txntk = new System.Windows.Forms.TextBox();
            this.txnmk = new System.Windows.Forms.TextBox();
            this.txnlmk = new System.Windows.Forms.TextBox();
            this.btdangki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(170, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Kí Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Mặt Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // txntk
            // 
            this.txntk.Location = new System.Drawing.Point(288, 142);
            this.txntk.Name = "txntk";
            this.txntk.Size = new System.Drawing.Size(220, 22);
            this.txntk.TabIndex = 4;
            // 
            // txnmk
            // 
            this.txnmk.Location = new System.Drawing.Point(288, 183);
            this.txnmk.Name = "txnmk";
            this.txnmk.PasswordChar = '*';
            this.txnmk.Size = new System.Drawing.Size(220, 22);
            this.txnmk.TabIndex = 5;
            // 
            // txnlmk
            // 
            this.txnlmk.Location = new System.Drawing.Point(288, 220);
            this.txnlmk.Name = "txnlmk";
            this.txnlmk.PasswordChar = '*';
            this.txnlmk.Size = new System.Drawing.Size(220, 22);
            this.txnlmk.TabIndex = 6;
            // 
            // btdangki
            // 
            this.btdangki.Location = new System.Drawing.Point(413, 270);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(95, 32);
            this.btdangki.TabIndex = 7;
            this.btdangki.Text = "Đăng Kí";
            this.btdangki.UseVisualStyleBackColor = true;
            this.btdangki.Click += new System.EventHandler(this.btdangki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btdangki);
            this.Controls.Add(this.txnlmk);
            this.Controls.Add(this.txnmk);
            this.Controls.Add(this.txntk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cs";
            this.Text = "Đăng Kí ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txntk;
        private System.Windows.Forms.TextBox txnmk;
        private System.Windows.Forms.TextBox txnlmk;
        private System.Windows.Forms.Button btdangki;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
