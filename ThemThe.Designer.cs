namespace ProjectPrn211
{
    partial class ThemThe
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblVocal = new System.Windows.Forms.Label();
            this.lblNghia = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaiDinhDang = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Thẻ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChuDe
            // 
            this.lblChuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChuDe.Location = new System.Drawing.Point(40, 117);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(95, 19);
            this.lblChuDe.TabIndex = 1;
            this.lblChuDe.Text = "Chọn Chủ Đề: ";
            // 
            // lblVocal
            // 
            this.lblVocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVocal.Location = new System.Drawing.Point(40, 160);
            this.lblVocal.Name = "lblVocal";
            this.lblVocal.Size = new System.Drawing.Size(87, 15);
            this.lblVocal.TabIndex = 2;
            this.lblVocal.Text = "Từ: ";
            // 
            // lblNghia
            // 
            this.lblNghia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNghia.Location = new System.Drawing.Point(40, 210);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(87, 16);
            this.lblNghia.TabIndex = 3;
            this.lblNghia.Text = "Nghĩa: ";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(757, 566);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemAnh.Location = new System.Drawing.Point(27, 268);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(100, 36);
            this.btnThemAnh.TabIndex = 13;
            this.btnThemAnh.Text = "Chọn Ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 268);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 91);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(170, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(391, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ví Dụ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 370;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(170, 157);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(391, 23);
            this.txtTu.TabIndex = 18;
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(170, 207);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(391, 23);
            this.txtNghia.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ví Dụ";
            // 
            // lblSaiDinhDang
            // 
            this.lblSaiDinhDang.ForeColor = System.Drawing.Color.Red;
            this.lblSaiDinhDang.Location = new System.Drawing.Point(170, 74);
            this.lblSaiDinhDang.Name = "lblSaiDinhDang";
            this.lblSaiDinhDang.Size = new System.Drawing.Size(561, 23);
            this.lblSaiDinhDang.TabIndex = 21;
            this.lblSaiDinhDang.Text = "label3";
            this.lblSaiDinhDang.Visible = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongBao.Location = new System.Drawing.Point(170, 65);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(391, 32);
            this.lblThongBao.TabIndex = 22;
            this.lblThongBao.Text = "label4";
            this.lblThongBao.Visible = false;
            this.lblThongBao.Click += new System.EventHandler(this.lblThongBao_Click);
            // 
            // ThemThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 614);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblSaiDinhDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lblVocal);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.label1);
            this.Name = "ThemThe";
            this.Text = "ThemThe";
            this.Load += new System.EventHandler(this.ThemThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblChuDe;
        private Label lblVocal;
        private Label lblNghia;
        private Button btnLuu;
        private Button btnThemAnh;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private ComboBox comboBox1;
        private TextBox txtTu;
        private TextBox txtNghia;
        private Label label2;
        private Label lblSaiDinhDang;
        private Label lblThongBao;
    }
}