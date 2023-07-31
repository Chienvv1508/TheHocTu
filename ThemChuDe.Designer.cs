namespace ProjectPrn211
{
    partial class ThemChuDe
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
            this.lblChuDe = new System.Windows.Forms.Label();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThonBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChuDe
            // 
            this.lblChuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChuDe.Location = new System.Drawing.Point(37, 9);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(100, 23);
            this.lblChuDe.TabIndex = 0;
            this.lblChuDe.Text = "Tên Chủ Đề: ";
            this.lblChuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChuDe
            // 
            this.txtChuDe.Location = new System.Drawing.Point(37, 71);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(390, 23);
            this.txtChuDe.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(237, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(380, 130);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 33);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblThonBao
            // 
            this.lblThonBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThonBao.ForeColor = System.Drawing.Color.Red;
            this.lblThonBao.Location = new System.Drawing.Point(37, 45);
            this.lblThonBao.Name = "lblThonBao";
            this.lblThonBao.Size = new System.Drawing.Size(390, 23);
            this.lblThonBao.TabIndex = 3;
            this.lblThonBao.Text = "label1";
            this.lblThonBao.Visible = false;
            // 
            // ThemChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 175);
            this.Controls.Add(this.lblThonBao);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtChuDe);
            this.Controls.Add(this.lblChuDe);
            this.Name = "ThemChuDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemChuDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblChuDe;
        private TextBox txtChuDe;
        private Button btnThem;
        private Button btnHuy;
        private Label lblThonBao;
    }
}