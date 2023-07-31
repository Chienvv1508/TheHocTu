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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
// Kiểm tra tồn tài tên chưa trả về string

        

        private bool CheckExist(string name)

        {
            if (Vali.CheckUserName(name))
            {
                lblThongBaoUserName.Visible = false;
                using (var context = new ProjectPrn211Context())
                {
                    Student st = context.Students.FirstOrDefault(x => x.UserName == name);
                    
                    if (st == null)
                    {
                        lblTrung.Visible = false;
                        return false;
                    }
                    lblTrung.Visible = true;
                }
            }
            else lblThongBaoUserName.Visible = true;
            return true;
        }
     

        private bool CheckValidStudent(Student st)
        {
            if (st != null)
            {
                if (!CheckExist(st.UserName))
                {  
                    if(Vali.CheckUserName(st.PassWord))
                    {
                        lbThongBaoMatKhau.Visible = false;
                        if (st.PassWord.Equals(txtNhapLai.Text))
                        {   lblNhapLai.Visible= false;
                            if (Vali.CheckName(st.StudentName))
                            {
                                lblHoTen.Visible = false;
                                return true;
                            }else lblHoTen.Visible = true;

                        }
                        else lblNhapLai.Visible = true;

                    }else lbThongBaoMatKhau.Visible = true;

                }
               

            }
            return false;
        }

        private void AddStudent(Student st)
        {
            if (CheckValidStudent(st))
            {
                using(var context = new ProjectPrn211Context())
                {
                    try
                    {
                        context.Students.Add(st);
                        context.SaveChanges();
                        lblThanhCong.Visible = true;
                    }
                    catch(Exception e)
                    {
                        
                    }
                    
                }
            }
           
        }
//
 // Validate các trường output trả về 1 đối tượng input là 


// add vào dbset    output là void  input là: đối tượng output là thông báo
// luu
// hien thong bao

// công việc ở đây là phép tính nhân: tuy lâu nhưng hiệu quả



        private void button1_Click(object sender, EventArgs e)
        {  Student st = new Student();
            st.StudentName = txtHoTen.Text;   // tư duy tạo đối tượng cơ bản vậy thôi.
            st.UserName = txtTenDangNhap.Text;
            st.PassWord = txtMatKhau.Text;

            AddStudent(st);
            


        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
