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
    public partial class ThemThe : Form
    {
        List<Topic> topics;
        public ThemThe(List<Topic> tp)
        {
            InitializeComponent();
            this.topics = tp;
        }

        private void ThemThe_Load(object sender, EventArgs e)
        {       

                List<Topic> tps = topics;
                comboBox1.DisplayMember= "TopicName";
                comboBox1.ValueMember = "TopicId";
                comboBox1.DataSource = tps;
            
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Chọn nhiều ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy danh sách các đường dẫn đến ảnh đã chọn
                    string[] selectedImagePaths = openFileDialog.FileNames;

                    // Hiển thị các ảnh đã chọn trong FlowLayoutPanel
                    ShowSelectedImages(selectedImagePaths);
                }
            }
        }
        private void ShowSelectedImages(string[] imagePaths)
        {
            // Xóa tất cả các Control con hiện có trong FlowLayoutPanel trước khi hiển thị các ảnh mới


            // Hiển thị các ảnh đã chọn trong FlowLayoutPanel
            foreach (string imagePath in imagePaths)
            {
                try
                {
                    // Tạo một PictureBox để hiển thị ảnh
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = System.Drawing.
                        Image.FromFile(imagePath);
                    pictureBox.Width = 150;
                    pictureBox.Height = 100;

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Click += pictureBox_Click;
                }
            }

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa bỏ ảnh này", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa PictureBox khỏi FlowLayoutPanel
                    flowLayoutPanel1.Controls.Remove(pictureBox);

                    // Giải phóng tài nguyên của PictureBox
                    pictureBox.Dispose();
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //check các trường
            if (txtTu.Text == "" || txtNghia.Text == "" || dataGridView1.Rows.Count == 0|| flowLayoutPanel1.Controls.Count == 0
                || Vali.CheckTu(txtTu.Text)== false|| Vali.CheckTu(txtNghia.Text) == false)
            {
                lblSaiDinhDang.Text = "Sai định dạng. Phải nhập tất cả các trường đúng định dạng";
                lblSaiDinhDang.Visible = true;
                lblThongBao.Visible = false;
            }
            else
            {   
                bool check = true;
                lblSaiDinhDang.Visible = false;
                // add card
                int topic = (int)comboBox1.SelectedValue;
                string tu = txtTu.Text;
                string nghia = txtNghia.Text;

                // example
                string[] exp = new string[dataGridView1.Rows.Count - 1];
                int i = 0;
                lblThongBao.Text = dataGridView1.Rows[0].Cells["Column1"].Value.ToString();  
                foreach (DataGridViewRow ex in dataGridView1.Rows)
                {
                    exp[i] = ex.Cells["Column1"].Value.ToString();
                   
                    if (i == exp.Length - 1)
                        break;

                    i++;
                }

               
               
                  

                    using (var context = new ProjectPrn211Context())
                    {
                        Card card = new Card();
                        card.CardText = tu;
                        card.CardMeaning = nghia;
                        card.Topic = topic;
                        card.Cat = 1;
                        card.I = 0;
                        card.Ef = 2.5;
                        card.Q = 0;
                        card.N = 0;
                        card.Status = 0;
                        card.DateLearn = DateTime.Today.Date;
                        context.Cards.Add(card);
                        


                        context.SaveChanges();
                    AddLog(FormDangNhap.sst.StudentId, card.CardId);
                    foreach (var exm in exp)
                    {
                        Example viDu = new Example();
                        viDu.Ex = exm;
                        viDu.Card = card.CardId;
                        context.Examples.Add(viDu);
                        context.SaveChanges();

                        // tạo card loai 3
                        Card card1 = new Card();
                        card1.CardText = tu;
                      
                        card1.Topic = topic;
                        card1.Cat = 3;
                        card1.Example = viDu.ExId;
                        
                        card1.I = 0;
                        card1.Ef = 2.5;
                        card1.Q = 0;
                        card1.N = 0;
                        card1.Status = 0;
                        card1.DateLearn = DateTime.Today.Date;
                        card1.OrgId = card.CardId;
                        context.Cards.Add(card1);
                        context.SaveChanges();
                        AddLog(FormDangNhap.sst.StudentId, card1.CardId);



                    }
                   
                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is PictureBox pictureBox)

                        {
                            
                            // Luu anh vao Images
                            PictureBox pic = (PictureBox)control;
                            System.Drawing.Image selectedImage = pic.Image;
                            Random ran = new Random();
                            string imageFileName = $"Anh{card.CardId}{ran.Next(1, 1000)}.jpg";
                            string destinationPath = Path.Combine("Images", imageFileName);
                            selectedImage.Save(destinationPath); // lay anh de luu vao duong dan


                            // luu anh
                            Models.Image img = new Models.Image();
                            img.Image1 = imageFileName;
                            img.Card = card.CardId;

                            context.Add(img);
                            context.SaveChanges();
                            // tao the loai 1
                            Card card1 = new Card();
                            card1.CardText = tu;

                            card1.Topic = topic;
                            card1.Cat = 2;
                            card1.Image = img.ImageId;
                            
                            card1.I = 0;
                            card1.Ef = 2.5;
                            card1.Q = 0;
                            card1.N = 0;
                            card1.Status = 0;
                            card1.DateLearn = DateTime.Today.Date;
                            card1.OrgId = card.CardId;
                            context.Cards.Add(card1);
                            context.SaveChanges();
                            AddLog(FormDangNhap.sst.StudentId, card1.CardId);





                        }
                    }
                   

                   

                    }



                lblThongBao.Text = "Thêm Thẻ Thành Công";
                lblThongBao.Visible = true;
               
            }
           
            

        }

        private void AddLog(int uId, int card)
        {
            Log log = new Log();
            log.UserId= uId;
            log.Card = card;
            log.Action = 1;
            log.DateCreated = DateTime.Today;
            log.DateLearn = DateTime.Today;
            log.I = 1;
            log.Ef = 2.5;
            log.N = 0;
            log.Q = 0;
            log.Status = 1;
            using (var context = new ProjectPrn211Context())
            {
                context.Add(log);
                context.SaveChanges();
            }

            }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}
