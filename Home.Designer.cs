namespace ProjectPrn211
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThemChuDe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoc = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.btnChuDe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 448);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(83, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(738, 221);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Chủ Đề";
            this.Column1.Name = "Column1";
            this.Column1.Width = 139;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hoàn Thành";
            this.Column2.Name = "Column2";
            this.Column2.Width = 139;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Từ Cần Học";
            this.Column3.Name = "Column3";
            this.Column3.Width = 139;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng Từ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 139;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edit";
            this.Column5.Name = "Column5";
            this.Column5.Width = 139;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnThemChuDe);
            this.panel3.Location = new System.Drawing.Point(3, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnThemChuDe
            // 
            this.btnThemChuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemChuDe.Location = new System.Drawing.Point(371, 3);
            this.btnThemChuDe.Name = "btnThemChuDe";
            this.btnThemChuDe.Size = new System.Drawing.Size(127, 37);
            this.btnThemChuDe.TabIndex = 0;
            this.btnThemChuDe.Text = "Thêm Chủ Đề";
            this.btnThemChuDe.UseVisualStyleBackColor = true;
            this.btnThemChuDe.Click += new System.EventHandler(this.btnThemChuDe_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(774, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(714, 21);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(54, 47);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoc);
            this.panel2.Controls.Add(this.btnLoc);
            this.panel2.Controls.Add(this.btnThemThe);
            this.panel2.Controls.Add(this.btnChuDe);
            this.panel2.Location = new System.Drawing.Point(164, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 60);
            this.panel2.TabIndex = 0;
            // 
            // btnHoc
            // 
            this.btnHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoc.Location = new System.Drawing.Point(354, 2);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(103, 54);
            this.btnHoc.TabIndex = 0;
            this.btnHoc.Text = "Từ Cần Học";
            this.btnHoc.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoc.Location = new System.Drawing.Point(245, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(103, 54);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThemThe
            // 
            this.btnThemThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemThe.Location = new System.Drawing.Point(136, 2);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(103, 54);
            this.btnThemThe.TabIndex = 0;
            this.btnThemThe.Text = "Thêm Thẻ";
            this.btnThemThe.UseVisualStyleBackColor = true;
            this.btnThemThe.Click += new System.EventHandler(this.btnThemThe_Click);
            // 
            // btnChuDe
            // 
            this.btnChuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChuDe.Location = new System.Drawing.Point(27, 2);
            this.btnChuDe.Name = "btnChuDe";
            this.btnChuDe.Size = new System.Drawing.Size(103, 54);
            this.btnChuDe.TabIndex = 0;
            this.btnChuDe.Text = "Chủ Đề";
            this.btnChuDe.UseVisualStyleBackColor = true;
            this.btnChuDe.Click += new System.EventHandler(this.Home_Load_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Panel panel2;
        private Button btnLoc;
        private Button btnThemThe;
        private Button btnChuDe;
        private Button btnHoc;
        private Label lblName;
        private Panel panel3;
        private Button btnThemChuDe;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}