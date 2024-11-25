namespace do_an_tin_hoc_6tr.view
{
    partial class fdanhsachdocgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdanhsachdocgia));
            this.dtvdg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btxoadg = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdocgia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvdg)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvdg
            // 
            this.dtvdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtvdg.Location = new System.Drawing.Point(42, 205);
            this.dtvdg.Name = "dtvdg";
            this.dtvdg.RowHeadersWidth = 51;
            this.dtvdg.RowTemplate.Height = 24;
            this.dtvdg.Size = new System.Drawing.Size(841, 233);
            this.dtvdg.TabIndex = 0;
            this.dtvdg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvdg_CellContentClick);
            this.dtvdg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvdg_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sten";
            this.Column1.HeaderText = "Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sma";
            this.Column2.HeaderText = "Mã Số";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ssdt";
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sdc";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sngaysinh";
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sgioitinh";
            this.Column7.HeaderText = "Giới Tính";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Đọc Giả";
            // 
            // btxoadg
            // 
            this.btxoadg.Location = new System.Drawing.Point(780, 109);
            this.btxoadg.Name = "btxoadg";
            this.btxoadg.Size = new System.Drawing.Size(103, 33);
            this.btxoadg.TabIndex = 3;
            this.btxoadg.Text = "Xóa ĐG";
            this.btxoadg.UseVisualStyleBackColor = true;
            this.btxoadg.Click += new System.EventHandler(this.btxoadg_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(780, 148);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(103, 33);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đọc Giả :";
            // 
            // lbdocgia
            // 
            this.lbdocgia.AutoSize = true;
            this.lbdocgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbdocgia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdocgia.Location = new System.Drawing.Point(136, 171);
            this.lbdocgia.Name = "lbdocgia";
            this.lbdocgia.Size = new System.Drawing.Size(0, 16);
            this.lbdocgia.TabIndex = 7;
            // 
            // fdanhsachdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.lbdocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btxoadg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvdg);
            this.Name = "fdanhsachdocgia";
            this.Text = "Danh Sách Đọc Giả";
            this.Load += new System.EventHandler(this.fdanhsachdocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btxoadg;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdocgia;
    }
}