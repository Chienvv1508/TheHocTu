using ProjectPrn211.Models;

namespace ProjectPrn211
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        public static Home home;
        public static Student sst = new Student();  // Tạo biến static để lưu lại thông tin đăng nhập

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            dangKy.FormClosed += Home_FormClosed;
            this.Hide();
        }

        // lay Student
        // check validate Student
        // check database
        // check mat khau
        // cho này tư duy không phải là đi ngược mà là trường hợp ngoại lê
        
        // check user  ==> validate trước  ==> chạy kết nối với ==> trả về true or false  ==> vào trang
        // home
        // check pass


        private bool CheckAuthor(Student st)
        {
            if (Vali.CheckUserName(st.UserName))
            {
                lblTaiKhoan.Visible = false;
            
                using (var context = new ProjectPrn211Context())
                {
                    Student st1 = context.Students.FirstOrDefault(x => x.UserName == st.UserName);
                    if (st1 != null)
                    {
                        lblTaiKhoan.Visible = false;
                        if (st1.PassWord.Equals(st.PassWord))
                        {
                            lblMatKhau.Visible = false;
                            sst = st1;
                            return true;
                        }
                        else
                        {
                            lblMatKhau.Visible = true;
                        }

                    }
                    else
                        lblTaiKhoan.Visible = true;

                }
               

            }
            else lblTaiKhoan.Visible = true;
            return false;
        }
        private void HomeShow()
        {
            home = new Home();
            this.Hide();
            home.Show();

            home.FormClosed += Home_FormClosed;

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.UserName = txtTaiKhoan.Text;
            st.PassWord = txtMatKhau.Text;
            if (CheckAuthor(st))
            {
                
                HomeShow();
            }
            
            
          
        }

        // Từ FormDangNhap mở ra 2 form là form Home và form đăng ký ==> khi thao tác với form xong ==>
        // cập nhập lại form đăng nhập. ==> cần có 1 sự kiện sử lý việc này và sự kiện này cần phải được 
        // xử lý bên trong Form đăng nhập ==> khai báo và đăng ký bên này.
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi Form2 bị đóng, hiển thị lại Form1
            sst = null;
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            this.Show();
        }
    }
}