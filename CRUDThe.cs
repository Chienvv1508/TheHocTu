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
    public partial class CRUDThe : Form
    {
        private Card card1;
        public CRUDThe(Card card)
        {
            InitializeComponent();
            card1 = card;
        }

        private void CRUDThe_Load(object sender, EventArgs e)
        {
            textBox1.Text = card1.CardText;
            textBox2.Text = card1.CardMeaning;
            using(var context = new ProjectPrn211Context())
            {
                List<Example> examples = context.Examples.Where(x => x.Card == card1.CardId).ToList();
                foreach (var example in examples)
                {
                    dataGridView1.Rows.Add(example.Ex);
                }

                List<Models.Image> li = context.Images.Where(x => x.Card == card1.CardId).ToList();
                List<String> imagePaths = li.Select(x => x.Image1).ToList();
                ShowImage(imagePaths);

            }
        }
        private void ShowImage(List<string> imagePaths)
        {
            if(imagePaths != null)
            {
                foreach(var imagePath in imagePaths)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = System.Drawing.
                        Image.FromFile($"Images/{imagePath}");
                    pictureBox.Width = 150;
                    pictureBox.Height = 100;

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        pictureBox.Click += pictureBox_Click;
                    }
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

        private void button1_Click(object sender, EventArgs e)
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
                    List<string> imagePaths = selectedImagePaths.ToList();

                    // Hiển thị các ảnh đã chọn trong FlowLayoutPanel
                    ShowImage2(imagePaths);
                }
            }
        }
        private void ShowImage2(List<string> imagePaths)
        {
            if (imagePaths != null)
            {
                foreach (var imagePath in imagePaths)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = System.Drawing.
                        Image.FromFile(imagePath);
                    pictureBox.Width = 150;
                    pictureBox.Height = 100;

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        pictureBox.Click += pictureBox_Click;
                    }
                }

            }
        }
    }
}
