using ProjectPrn211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrn211
{
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                FormDangNhap.home.Show();
                Close();
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            Student st = FormDangNhap.sst;
            bool check = true;
            if(!txtMatKhauCu.Text.Equals(st.PassWord) )
            {
                lblMatKhau.Visible= true;
                check = false;
            }
            else
            {
                lblMatKhau.Visible = false;
                if (!Vali.CheckUserName(txtMatKhau.Text))
                {
                    lbThongBaoMatKhau.Visible = true;
                    check = false;
                }
                else { lbThongBaoMatKhau.Visible = false;

                    if (!txtMatKhau.Text.Equals(txtNhapLai.Text))
                    {
                        lblNhapLai.Visible = true;
                        check = false;
                    }
                    else
                        lblNhapLai.Visible = false;

                }
                if (!Vali.CheckName(txtHoTen.Text))
                {
                    lblHoTen.Visible = true;
                    check = false;
                }
                else lblHoTen.Visible = false;
                
            }
            if (check)
            {
                using(var context = new ProjectPrn211Context())
                {
                    st = context.Students.FirstOrDefault(x => x.UserName.Equals(st.UserName));
                    st.PassWord = txtMatKhau.Text;
                    st.StudentName = txtHoTen.Text;
                    FormDangNhap.sst = st;
                    context.SaveChanges();
                }
                label1.Text = "Thay Đổi Thành Công";
                label1.Visible = true;
            }
        }

        private void EditInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = FormDangNhap.sst.StudentName;
        }
    }
}
