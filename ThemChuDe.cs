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
    public partial class ThemChuDe : Form
    {    
        public ThemChuDe()
        {
            InitializeComponent();
          
        }

        private bool CheckExistChuDe(Topic tp)
        {
            if (Vali.CheckTenChuDe(tp.TopicName))
            {
                using (var context = new ProjectPrn211Context())
                {
                    var tpe = context.Topics.FirstOrDefault(x => x.TopicName.Equals(tp.TopicName) && FormDangNhap.sst.StudentId == x.Student);
                    if (tpe != null)
                    {
                        lblThonBao.Text = "Tên Chủ Đề Đã Tồn Tại";
                        lblThonBao.Visible = true;
                        return true;

                    }
                    else
                    {
                        lblThonBao.Visible = false;
                        return false;

                    }


                }
            }
            else
            {
                lblThonBao.Text = "Sai Định Dạng Tên Chủ Đề.";
                lblThonBao.Visible = true;
            }
           
                return true;

        }
        private void AddTopic(Topic topic)
        {
            if(!CheckExistChuDe(topic))
            {
                using(var context = new ProjectPrn211Context())
                {
                    context.Topics.Add(topic);
                    lblThonBao.Text = "Thêm Thành Công";
                    lblThonBao.ForeColor = Color.Blue;
                    lblThonBao.Visible = true;
                    context.SaveChanges();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        { Topic tp = new Topic();
            tp.TopicName = txtChuDe.Text;
            tp.Student = FormDangNhap.sst.StudentId;
            AddTopic(tp);

            


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
