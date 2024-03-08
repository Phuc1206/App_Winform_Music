using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;
using System.IO;

namespace AP09NXuânPhúc
{
    public partial class Fr3irrKlang09 : Form
    {
        public Fr3irrKlang09()
        {
            InitializeComponent();
        }
        ISoundEngine fn = new ISoundEngine();
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKLang 
        string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\Audio Files\\";
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        //để lấy thư mục cha sử dụng System.IO.Path.GetDirectoryName(Application.StartupPath)

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            fn.SoundVolume = 100;
            fn.Play2D(audiopath + "Piano.wav", true);
            MessageBox.Show("OK");
        }
    }
}
