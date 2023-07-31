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

namespace ProjectPrn211
{
    public partial class Loc : Form
    {
        List<Models.Topic> topics;
        public Loc(List<Topic> tp1)
        {
            InitializeComponent();
            topics= tp1;
            
        }

        private void Loc_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "TopicName";
            comboBox1.ValueMember = "TopicId";
            comboBox1.DataSource = topics;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int topic = (int)comboBox1.SelectedValue;
            if(topic != 0)
            {
                Topic top = topics.FirstOrDefault(x => x.TopicId == topic);
                List<Card> cards = top.Cards.Where(x => x.CardText.Contains(textBox1.Text)).ToList();
                foreach(Card card in cards)
                {
                    dataGridView1.Rows.Add(card.CardId, card.CardText, card.CardMeaning, card.Ef, card.DateLearn,card.OrgId,card.Cat);

                }
            
            }
        }
    }
}
