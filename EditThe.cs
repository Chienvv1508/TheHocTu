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
    public partial class EditThe : Form
    {
        private Topic tp1;
        public EditThe(Topic tp)
        {
            InitializeComponent();
            tp1 = tp;
        }

        private void EditThe_Load(object sender, EventArgs e)
        {
            label1.Text = tp1.TopicName;
            using(var context = new ProjectPrn211Context())
            {
                List<Card> cards = context.Cards.Where(x => x.Topic == tp1.TopicId && x.Cat == 2 ).ToList(); 
                foreach (var card in cards)
                {
                    dataGridView1.Rows.Add(card.CardText,card.CardMeaning, card.CardId, "Edit");
                }
                
            }
        }
        CRUDThe crud;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 3)
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn chỉnh sửa thẻ?","Chỉnh Sửa",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(rs == DialogResult.Yes)
                    {   using(var context = new ProjectPrn211Context())
                        { int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                            Card card = context.Cards.FirstOrDefault(x=> x.CardId == id && x.Cat == 2);
                            crud = new CRUDThe(card);
                            crud.Show();

                        }
                      

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
