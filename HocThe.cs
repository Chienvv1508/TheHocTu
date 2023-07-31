using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPrn211.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectPrn211
{
    public partial class HocThe : Form
    {
        List<Card> cards;
        public HocThe(List<Card> cards1)
        {
            InitializeComponent();
            cards = cards1;
        }
        private void PrepareCards() {
          foreach(Card card in cards)
            {
                using(var context = new ProjectPrn211Context())
                {
                    if(card.Cat == 2)
                    {
                        card.ImageNavigation = context.Images.FirstOrDefault(x => x.ImageId == card.Image);

                    }else if(card.Cat == 1) {
                    
                        card.Images = context.Images.Where(x => x.Card == card.CardId).ToList();
                        card.Examples = context.Examples.Where(x => x.Card == card.CardId).ToList();

                    }
                    else
                    {
                        card.ExampleNavigation = context.Examples.FirstOrDefault(x => x.ExId == card.Example);
                    }

                }
            }
        
        
        }

        private void LoadMatTruoc1(Card card)
        {
           
            if (card != null)
            {
                if(card.Cat == 1)
                {
                    lblText.Text = card.CardText;
                    lblText.Visible = true;
                }
            }
        }
        private void LoadMatSau1(Card card)
        {
            if(card != null)
            {
                lblNghia.Text = card.CardMeaning;
                lblNghia.Visible = true;
                foreach(Example ex in card.Examples)
                {
                    dataGridView1.Rows.Add(ex.Ex);
                    dataGridView1.Visible = true;
                }
                foreach(Models.Image img in card.Images)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = System.Drawing.
                        Image.FromFile($"Images/{img.Image1}");
                    pictureBox.Width = 150;
                    pictureBox.Height = 100;

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(pictureBox);
                    flowLayoutPanel1.Visible = true;

                }
            }
        }
        private void LoadMatTruoc2(Card card)
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.Visible = false;
            if (card != null)
            {
                if (card.Cat == 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = System.Drawing.
                        Image.FromFile($"Images/{card.ImageNavigation.Image1}");
                    pictureBox.Width = 150;
                    pictureBox.Height = 100;

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel2.Controls.Add(pictureBox);
                    flowLayoutPanel2.Visible = true;

                }
            }
        }
        private void LoadMatSau2(Card card)
        {  if(card != null)
            {
                lblTextNguoc.Text = card.CardText;
                lblTextNguoc.Visible = true;
            }
           
        }

        private void LoadMatTruoc3(Card card)
        {
            lblViDu.Visible = false;
            if (card != null)
            {
                if (card.Cat == 3)
                {
                   lblViDu.Text = card.ExampleNavigation.Ex;
                    lblViDu.Visible = true;

                }
            }
        }
        private void LoadHoc(Card card)
        {
            if (card.Cat == 1)
                LoadMatTruoc1(card);
            else if (card.Cat == 2)
                LoadMatTruoc2(card);
            else 
                LoadMatTruoc3(card);

        }
        private void LoadDapAn(Card card)
        { if(card != null)
            {
                if (card.Cat == 1)
                    LoadMatSau1(card);
                else if (card.Cat == 2)
                    LoadMatSau2(card);
                else
                    LoadMatSau2(card);
            }

        }
        private void SetUp()
        {
            lblText.Visible = false;
            lblNghia.Visible = false;
            lblTextNguoc.Visible = false;
            lblViDu.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            btnDapAn.Visible = true;

        }
        Card aCard;
        private void HocTheLoad()
        {   if(cards.Count != 0)
            {
                label1.Visible = false;
                PrepareCards();
                foreach (Card card in cards)
                {   
                    LoadHoc(card);

                    cards.Remove(card);


                    aCard = card;

                    break;

                }

            }
            else
            {
                btnDapAn.Visible = false;
                label1.Visible = true;
            }
           
            
           
        }

        private void HocThe_Load(object sender, EventArgs e)
        {
         HocTheLoad();
            //  List<Card> cardHoc = new List<Card>();
            
        //    using(var context = new ProjectPrn211Context())
        //    {
        //        foreach(Log log in log1)
        //        {
        //            Card card = context.Cards.FirstOrDefault(x => x.CardId == log.Card);
        //            cardHoc.Add(card);
        //        }
        //        foreach (Card card1 in cardHoc)
        //        {
        //            if (card1.Cat == 2)
        //            {
        //                lblText.Text = card1.CardText;
        //                lblText.Visible = true;
        //            }
        //            else if (card1.Cat == 3)
        //            {
        //                card1.ExampleNavigation = context.Examples.FirstOrDefault(x => x.ExId == card1.Example);
        //                textBox1.Text = card1.ExampleNavigation.Ex;
        //                textBox1.Visible = true;
        //            }
        //            else
        //            {
        //                card1.ImageNavigation = context.Images.FirstOrDefault(x => x.ImageId == card1.Image);
        //                // Tạo một PictureBox để hiển thị ảnh
        //                PictureBox pictureBox = new PictureBox();
        //                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //                pictureBox.Image = System.Drawing.
        //                    Image.FromFile($"Images/{card1.ImageNavigation.Image1}");
        //                pictureBox.Width = 150;
        //                pictureBox.Height = 100;

        //                // Thêm PictureBox vào FlowLayoutPanel
        //                flowLayoutPanel2.Controls.Add(pictureBox);
        //                flowLayoutPanel2.Visible = true;
        //            }
        //            cardHoc.Remove(card1);
        //            break;
        //        }
        //        lblText.Visible = false;
        //        textBox1.Visible = false;
        //        flowLayoutPanel2.Visible = false;
        //    }
            
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            LoadDapAn(aCard);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            btnDapAn.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            Hoc(q);
            UpdateHoc();
            SetUp();
          
            cards.Add(aCard);
            HocTheLoad();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 2;
            Hoc(q);
            UpdateHoc();
            SetUp();
            cards.Add(aCard);
            HocTheLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int q = 4;
            Hoc(q);
            UpdateHoc();
            SetUp();
            HocTheLoad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int q = 5;
            Hoc(q);
            UpdateHoc();
            SetUp();
            HocTheLoad();
        }
        private void Hoc(int q)
        {
            if(q >= 3)
            {
                if (aCard.N == 0)
                {
                    aCard.I = 1;
                    aCard.Q = q;
                    aCard.DateLearn = DateTime.Today.AddDays(1);
                    

                }
                else if (aCard.N == 1)
                {
                    aCard.I = 6;
                    aCard.Q = q;
                    aCard.DateLearn = DateTime.Today.AddDays(6);

                }

                else {
                    aCard.I = (int)(aCard.I * aCard.Ef);
                    double d = aCard.I.HasValue ? aCard.I.Value : 0;
                    aCard.DateLearn = DateTime.Today.AddDays(d);
                }
                aCard.N++;


            }
            else
            {
                aCard.I = 0;
                aCard.N = 0;
                aCard.Q = q;

            }
            aCard.Ef = aCard.Ef + (0.1 - (5 - q) * (0.08 + (5 - q) * 0.02));
            if(aCard.Ef < 1.3)
            {
                aCard.Ef = 1.3;
            }
        }

        private void UpdateHoc()
        {
            using(var context  = new ProjectPrn211Context())
            {
                Card card = context.Cards.FirstOrDefault(x => x.CardId == aCard.CardId);
                card.I = aCard.I.HasValue ? aCard.I : 0;
                card.Ef = aCard.Ef.HasValue ? aCard.Ef : 0;
                card.N = aCard.N.HasValue ? aCard.N : 0;
                card.Q = aCard.Q.HasValue ? aCard.Q : 0;
                card.DateLearn = aCard.DateLearn;
                
                context.SaveChanges();
                AddLog(FormDangNhap.sst.StudentId);
                
            }
        }
        private void AddLog(int uId)
        {
            Log log = new Log();
            log.UserId = uId;
            log.Card = aCard.CardId;
            log.Action = 2;
            log.DateCreated = DateTime.Today;
            log.DateLearn = aCard.DateLearn;
            log.I = aCard.I.HasValue? aCard.I.Value : 0;
            log.Ef = aCard.Ef.HasValue ? aCard.Ef.Value : 0;
            log.N = aCard.N.HasValue ? aCard.N.Value : 0;
            log.Q = aCard.Q.HasValue ? aCard.Q.Value : 0;
            log.Status = 1;
            using (var context = new ProjectPrn211Context())
            {
                context.Add(log);
                context.SaveChanges();
            }

        }
    }
}
