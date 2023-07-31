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
    public partial class Hoc : Form
    {
        private Topic tp1;
        List<Card> theCanHoc;
        List<Card> cards;
        public Hoc(Topic tp, List<Card> cards1)
        {
            InitializeComponent();
            tp1 = tp;
            
            this.cards = cards1;
        }
        public List<Log> log;

        private List<Card> TuCanHoc(Topic tp)
        {
            List<Card> cards = new List<Card>();
            if (tp != null)
            {
                DateTime dt = DateTime.Today.Date;
                cards = tp.Cards.Where(x => x.DateLearn == dt).ToList();

            }
            return cards;
        }
        private void Hoc_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using(var context = new ProjectPrn211Context())
            {
                tp1 = context.Topics.FirstOrDefault( x=> x.TopicId == tp1.TopicId);
                tp1.Cards = context.Cards.Where(x=> x.Topic == tp1.TopicId).ToList();
            }
            theCanHoc = TuCanHoc(tp1);
            label1.Text = tp1.TopicName;
            label2.Text = "Tổng số thẻ: ";
            label4.Text = "" + cards.Count;
            label3.Text = "Số từ cần hoc: ";
            label5.Text ="" + theCanHoc.Count;
            if(theCanHoc.Count == 0)
            {
                button1.Enabled = false;
                label6.Visible = false;
               
                dataGridView1.Visible = false;
               
            }

            else
            {
                button1.Enabled = true;
                label6.Visible = true;
               
                dataGridView1.Visible = true;
             
                label6.Text = "Từ Cần Học";
            

            }
               
            foreach (Card ca in theCanHoc)
            {
               using(var context = new ProjectPrn211Context())
                {
                    ca.CatNavigation = context.Categories.FirstOrDefault(x => x.CatId == ca.Cat);
                }

                dataGridView1.Rows.Add(ca.CardId,ca.CardText, ca.CardMeaning, ca.CatNavigation.CatName,Math.Round((decimal)ca.Ef,2));
            }

            
        }
       
        HocThe hocThe;

        private void button1_Click(object sender, EventArgs e)
        {
            hocThe = new HocThe(theCanHoc);
            hocThe.FormClosed += Hoc_Load;
            hocThe.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
