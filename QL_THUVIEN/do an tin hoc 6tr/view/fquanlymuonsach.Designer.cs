namespace do_an_tin_hoc_6tr
{
    partial class fquanlymuonsach
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
            this.dtvmuonsach = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtvtrasach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1234 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvmuonsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvtrasach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvmuonsach
            // 
            this.dtvmuonsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvmuonsach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtvmuonsach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvmuonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvmuonsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.da,
            this.Column123,
            this.Column12,
            this.Column13});
            this.dtvmuonsach.Location = new System.Drawing.Point(58, 126);
            this.dtvmuonsach.Name = "dtvmuonsach";
            this.dtvmuonsach.RowHeadersWidth = 51;
            this.dtvmuonsach.RowTemplate.Height = 24;
            this.dtvmuonsach.Size = new System.Drawing.Size(693, 194);
            this.dtvmuonsach.TabIndex = 0;
            this.dtvmuonsach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvmuonsach_RowEnter);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Stendg";
            this.Column11.HeaderText = "Tên";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // da
            // 
            this.da.DataPropertyName = "Smadg";
            this.da.HeaderText = "Mã";
            this.da.MinimumWidth = 6;
            this.da.Name = "da";
            // 
            // Column123
            // 
            this.Column123.DataPropertyName = "Sten";
            this.Column123.HeaderText = "Sách";
            this.Column123.MinimumWidth = 6;
            this.Column123.Name = "Column123";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Ngaymuon";
            this.Column12.HeaderText = "Ngày Mượn";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Ngaytra";
            this.Column13.HeaderText = "Ngày Trả";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đọc Giả Mượn Sách";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(614, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thực Hiện Trả Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvtrasach
            // 
            this.dtvtrasach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvtrasach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtvtrasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvtrasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1234,
            this.dataGridViewTextBoxColumn5});
            this.dtvtrasach.Location = new System.Drawing.Point(58, 408);
            this.dtvtrasach.Name = "dtvtrasach";
            this.dtvtrasach.RowHeadersWidth = 51;
            this.dtvtrasach.RowTemplate.Height = 24;
            this.dtvtrasach.Size = new System.Drawing.Size(693, 194);
            this.dtvtrasach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(51, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Sách Đã Trả";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(802, 569);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(103, 33);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stendg";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Smadg";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sten";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sách";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column1234
            // 
            this.Column1234.DataPropertyName = "Sma";
            this.Column1234.HeaderText = "Mã Sách";
            this.Column1234.MinimumWidth = 6;
            this.Column1234.Name = "Column1234";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ngaytra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Trả";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form3
            // 
            this.BackgroundImage = global::do_an_tin_hoc_6tr.Properties.Resources._737474;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(934, 614);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvtrasach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtvmuonsach);
            this.Name = "Form3";
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvmuonsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvtrasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvmuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dtvmuonsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn da;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column123;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView dtvtrasach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1234;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}