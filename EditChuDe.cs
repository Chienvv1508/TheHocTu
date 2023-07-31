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
    public partial class EditChuDe : Form
    {
        private Topic tp1;
        public EditChuDe(Topic tp)
        {
            InitializeComponent();
            this.tp1 = tp;
          
        }

        private void EditChuDe_Load(object sender, EventArgs e)
        {
            textBox1.Text = tp1.TopicName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Vali.CheckTenChuDe(textBox1.Text))
            {
                Topic tp = new Topic();
                tp.TopicName = textBox1.Text;
                tp.Student = FormDangNhap.sst.StudentId;
                using (var context = new ProjectPrn211Context())
                {
                    var tpe = context.Topics.FirstOrDefault(x => x.TopicName.Equals(tp.TopicName));
                    if (tpe != null)
                    {
                        label2.Text = "Tên Chủ Đề Đã Tồn Tại";
                        label2.Visible = true;

                    }
                    else
                    {

                        tp = context.Topics.FirstOrDefault(x => x.TopicId == tp1.TopicId);
                        tp.TopicName = textBox1.Text;
                        context.SaveChanges();
                        Close();
                    }

                }

            }
            else
            {
                label2.Text = "Tên Chủ Đề Chứa Ký Tự Đặc Biệt";
                label2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   DialogResult rs = MessageBox.Show("Bạn có muốn xóa chủ đề","Xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                using(var context = new ProjectPrn211Context())
                {   // Xoa Log Xoa card loai 1 va 3
                    List<Card> cards  = context.Cards.Where(x => x.Topic == tp1.TopicId).ToList();
                    List<Log> logs;
                    foreach (var card in cards)
                    {
                     logs = context.Logs.Where(x => x.Card == card.CardId).ToList();
                     foreach(var log in logs)
                        {
                            context.Logs.Remove(log);
                        }
                        context.SaveChanges();

                        // Xoa card cat =1 va 3

                        if(card.Cat == 2 ||card.Cat == 3)
                        {
                            context.Cards.Remove(card);
                           

                            
                        }
                       

                        
                    }
                    context.SaveChanges();
                    List<Card> cards2 = context.Cards.Where(x => x.Topic == tp1.TopicId).ToList();
                    foreach (Card card in cards2)
                    {
                        // xoa img

                        List<Models.Image> images = context.Images.Where(x => x.Card == card.CardId).ToList();
                        foreach (var image in images)
                        {
                            if (File.Exists($"Images/{image.Image1}"))
                            {
                                // Xoá tệp tin ảnh nếu nó tồn tại
                                File.Delete($"Images/{image.Image1}");
                              
                            }
                           
                            context.Images.Remove(image);
                            
                        }
                        context.SaveChanges();


                        // xoa example

                        List<Example> examples = context.Examples.Where(x => x.Card == card.CardId).ToList();
                        foreach (var example in examples)
                        {
                            context.Examples.Remove(example);
                           
                        }
                        context.SaveChanges();
                       
                            context.Cards.Remove(card);
                        
                        
                        context.SaveChanges();
                    }
                    

                    // xoa topic
                    Topic tp2 = context.Topics.FirstOrDefault(x => x.TopicId == tp1.TopicId);

                    context.Remove(tp2);
                    context.SaveChanges();




                }
                Close();
            }

            // Xóa thẻ ==> xóa card ==> xóa log

            // Xóa card ==> xóa image ==> xóa những card where cat = 1 = 3;

            //==> xóa image, xóa example, xóa card, xoa topic

        }
        EditThe editThe;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
