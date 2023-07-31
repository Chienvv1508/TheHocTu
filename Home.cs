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
    public partial class Home : Form
    {
        public EditInfo edI;
        public Home()
        {
            InitializeComponent();
        }


        private void pic_Click(object sender, EventArgs e)
        {
            edI = new EditInfo();
            edI.FormClosed += Home_Load;
            edI.Show();
            this.Hide();

      
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
      

        private void Home_Load(object sender, EventArgs e)
        {
            lblName.Text = FormDangNhap.sst.StudentName;
            
        }
        

        /// <summary>
        /// Việc đầu tiên với Home là mình cần load ra tên ==> rất may đã có biến static giải quyết
        /// Việc thứ 2 cần hiện lên các topic của user này theo thứ tự đảo ngược.
        /// những thứ cần đưa lên datagridview là
        /// tên topic, topic id, tổng thẻ, cần học, phần trăm hoàn thành, edit
        /// 
        /// 
        /// tên topic và topic id của người này khá dễ
        /// tổng thẻ trong topic có list các card ==> ok
        /// Cần học trong 1 list các thẻ duyệt từng thẻ nếu là ngày hôm nay chưa học thì thêm vào list mới
        /// trong thẻ có list logs ==> chọn log mới nhất
        /// 
        /// 
        /// phần trăm hoàn thành: được tính theo 100% - số từ có EF>= 3 ==> lấy được log rồi hiển thị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        

        
        private List<Topic> GetTopics()
        {
            List<Topic> topics = new List<Topic>();
            
            using(var context = new ProjectPrn211Context())
            {   
                topics = context.Topics.Where(x => x.Student == FormDangNhap.sst.StudentId).OrderByDescending(x => x.TopicId).ToList();
                foreach(var topic in topics)
                {
                    topic.Cards = context.Cards.Where(x => x.Topic == topic.TopicId).ToList();
                }

            }
            return topics;
        }

        private List<Card> ListCard(Topic tp)
        {   List<Card> cards = new List<Card>();
            if(tp!= null)
            {
                cards = tp.Cards.ToList();
            }
            return cards;
        }
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
        private List<Card> TuDaHoanThanh(Topic tp)
        {
            List<Card> cards = new List<Card>();
            if (tp != null)
            {
                
                cards = tp.Cards.Where(x => x.Ef >= 3).ToList();

            }
            return cards;

        }
        List<Topic> topics;

        List<Card> cards;
        List<Card> theCanHoc;
        List<Card> theDaHoanThanh;
        private void Home_Load_1(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();
            lblName.Text = FormDangNhap.sst.StudentName;

            topics = GetTopics();
           
            double phaTram = 0;
            foreach (Topic topic in topics)
            {
                cards = ListCard(topic);
               
                theCanHoc = TuCanHoc(topic);
                theDaHoanThanh = TuDaHoanThanh(topic);
                if(cards.Count != 0)
                {
                    phaTram = (theDaHoanThanh.Count * 100.0) / cards.Count;
                }
                dataGridView1.Rows.Add(topic.TopicName,phaTram,theCanHoc.Count,cards.Count,"Edit",topic.TopicId);
            }
            this.Show();

        }
       

        ThemChuDe themChuDe;
      

        private void btnThemChuDe_Click(object sender, EventArgs e)
        {
           
            themChuDe = new ThemChuDe();
            themChuDe.FormClosed += Home_Load_1;
            themChuDe.Show();

        }
         public ThemThe themThe;
       
        private void btnThemThe_Click(object sender, EventArgs e)
        {   
           if(topics.Count > 0)
            {
                themThe = new ThemThe(topics);
                themThe.FormClosing += Home_Load_1;
                this.Hide();
                themThe.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải thêm chủ đề trước.");
            }
            

        }
        EditChuDe edit;
        Hoc hoc;
        EditThe editThe;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex< dataGridView1.RowCount -1)
            {
                int targetColumnIndex = 4; // Thay đổi số 2 bằng chỉ số cột bạn quan tâm
                                           // Thay đổi số 3 bằng chỉ số hàng bạn quan tâm
                Topic tp = new Topic();

                if (e.ColumnIndex == targetColumnIndex)
                {
                    // Xử lý hành động khi người dùng nhấp vào cell cụ thể
                    // Ví dụ: Hiển thị thông báo
                    
                    using(var context = new ProjectPrn211Context())
                    {
                        tp = context.Topics.FirstOrDefault(x => x.TopicId == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    }
                    edit = new EditChuDe(tp);
                    edit.FormClosed += Home_Load_1;
                    edit.Show();
                }
                else if(e.ColumnIndex != 6)
                {
                    using (var context = new ProjectPrn211Context())
                    {
                        tp = context.Topics.FirstOrDefault(x => x.TopicId == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()));
                        tp.Cards = context.Cards.Where(x => x.Topic == tp.TopicId).ToList();
                    }
                    hoc = new Hoc(tp,tp.Cards.ToList());
                    hoc.FormClosed += Home_Load_1;
                    this.Hide();
                    hoc.Show();
                }
               
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc loc = new Loc(topics);
            this.Hide();
            loc.FormClosed += Home_Load_1;
            loc.Show();
        }
    }
}
