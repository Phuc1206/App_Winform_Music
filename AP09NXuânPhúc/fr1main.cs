using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP09NXuânPhúc
{
    public partial class frMain09 : Form
    {
        public frMain09()
        {
            InitializeComponent();
        }
        /// <summary>
        /// TỰ ĐỘNG CHẠY (RUN) KHI FORM NÀY ĐƯỢC TẢI LÊN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fr1Main09_Load(object sender, EventArgs e)
        {
            //timer1_Tick(sender, e);
        }

        /// <summary>
        /// NHẢY ĐỒNG HỒ / STATUS = DƯỚI, PHẢI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// THOÁT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fr2WMP09 fr=new fr2WMP09();
            fr.ShowDialog();
        }

        private void frMain09_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýÂmThanhDùngThưViệnIrrKlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr3irrKlang09 fr = new Fr3irrKlang09();
            fr.ShowDialog();
        }

        private void chuyểnÂmTrầmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        //public partial class fr1MainTT : Form
        //namespace APsttHoTen
    }
}
