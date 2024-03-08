﻿    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.Policy;
    using System.Text;
    using AxWMPLib;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
    using System.IO;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

    namespace AP09NXuânPhúc
    {
        public partial class fr2WMP09 : Form
        {
            string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\Audio Files\\";
            public fr2WMP09()
            {
                InitializeComponent();
            }

        private void fr2WMP09_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aP09NXPhucDataSet.AUDIOFILES' table. You can move, or remove it, as needed.
                this.aUDIOFILESTableAdapter.Fill(this.aP09NXPhucDataSet.AUDIOFILES);
            }
            catch (System.Exception ex){ MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play(); //chạy (play) file âm thanh hiện tại trên WMP
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); // tạm dừng (pause) audio file hiện đang play trên WMP
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();// Dừng (Stop) audio file hiện đang play trên WMP
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = 0;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex > 0) listBoxAuFile.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1; //nếu đang là Track ĐẦU (0) thì chuyển XUỐNG Track CUỐI CÙNG(vi trí vị trí cuối: count - 1)            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex < listBoxAuFile.Items.Count - 1)
                listBoxAuFile.SelectedIndex++;
            else listBoxAuFile.SelectedIndex = 0;
        }
        static DialogResult ch = DialogResult.No; //BIẾN TOÀN CỤC Giữ nút lệnh NSD đã chọn khi Chọn file âm thanh dùng OpenFileDialog: Y = đồng ý chọn file, N = ko đồng ý(sẽ chọn lại, hoặc ko chọn)
                                                  //bắt buộc static = Sau khi ra khỏi thủ tục vẫn giữ lại giá trị KO bị hủy vùng nhó

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtms.Enabled = !txtms.Enabled;
            txtDesc.Enabled = !txtDesc.Enabled;
            btnModify.Enabled = !btnModify.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            btnFast.Enabled = !btnFast.Enabled;
            btnSlow.Enabled = !btnSlow.Enabled;
            btnFirst.Enabled = !btnFirst.Enabled;
            btnLast.Enabled = !btnLast.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            btnPre.Enabled = !btnPre.Enabled;
            if (btnNew.Text == "Nạp file mới")
            //bắt đầu nập file âm thanh = NSD chọn file & nập thông tin ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
            {//Mở OpenFilesDialog lên cho NSD chọn file âm thanh / PC
                ch = openFileDialog1.ShowDialog();
                //biến toàn cục ch đã khai báo phía trên, giữ lại nút lệnh (Y|N) mà NSD đã chọn để xử lý trong ...else..  
                txtms.Text = "Quý vị phải nhập mã số file vào đây";
                txtDesc.Text = ""; // Xóa thống để NSD nhập mlo6 tả mới
                btnNew.Text = "Lưu file âm thanh"; //Đổi nhãn (.Text) thahh2 "Lưu...": tự nhập
            }
            else//Sau khi NSD chọn file & nhập thông tin xong => Lưu file âm thanh vào thư mục App\AudioFiles và cập nhật thông tin file âm thanh vào DB
             if (ch == DialogResult.OK)//NSD đã đồng ý nạp file âm thanh đã chọn từ OpenFileDialog
            {
                string tenfile = System.IO.Path.GetFileName(openFileDialog1.FileName);
                //tên file âm thanh mà NSD đã chọn


                //[1] COPY FILE ÂM THANH ĐÃ CHỌN VÀO THƯ MỤC ~\\AudioFiles
                try
                {
                    System.IO.File.Copy(openFileDialog1.FileName, audiopath + tenfile, true);
                    //[1 TRONG 2 CÂU LỆNH QUANG TRỌNG]      //openFileDialog1.FileName = Full path của file nguồn || 
                    //System.IO.Path.GetFileName(...) lấy tên của path || true = chồng lên nêu trong thư mục đã có sẵn file
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh:" + ex.Message); }

                //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                if (txtms.Text != "" && txtms.Text != "Quý vị phải nhập mã số file vào đây")
                //NSD bắt buộc nhập mã số file âm thanh thì mới lưu được.
                {
                    try
                    {
                        aUDIOFILESTableAdapter.Insert(txtms.Text.Trim(), tenfile, audiopath + tenfile, 0, "", 0, txtDesc.Text);
                        //NẠP THÔNG TIN FILE ÂM THANH VÀO DB [1 TRONG 2 CÂU LỆNH QUANG TRỌNG]
                    }
                    catch (System.Exception ex)
                    { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                }
                else MessageBox.Show("Không được để trống mã file");
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.aP09NXPhucDataSet.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }

                btnNew.Text = "Nạp file mới";
                //Trả lại nhãn ban đầu ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
            }//NSD OK              
        }//Lưu file//btnNew = NẠP FILE ÂM THANH


        private void btnModify_Click(object sender, EventArgs e)
        {
            txtDesc.Enabled = !txtDesc.Enabled;
            btnNew.Enabled = !btnNew.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            btnFast.Enabled = !btnFast.Enabled;
            btnSlow.Enabled = !btnSlow.Enabled;
            btnFirst.Enabled = !btnFirst.Enabled;
            btnLast.Enabled = !btnLast.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            btnPre.Enabled = !btnPre.Enabled;
            if (btnModify.Text == "Sửa thông tin files")
            //bắt đầu Sửa thông tin file âm thanh trong các TextBox ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]
            {//Thông báo nhắc NSD cách sủa thông tin
                MessageBox.Show("Quý vị sửa mô tả file trong TextBox Mô tả phía trên,Không sửa được các thông thin khác."); //thông báo hướng dẫn NSD cách sửa thông tin file


                btnModify.Text = "Lưu sau sửa"; //Đổi nhãn (.Text) thành2 "Lưu...": tự nhập
            }
            else//Sau khi NSD sửa thông tin xong =>Lưu thông tin file âm thanh sau sửa vào DB
            {
                try
                {
                    aUDIOFILESTableAdapter.Update(txtDesc.Text, txtms.Text.Trim());
                    //Lưu THÔNG TIN FILE ÂM THANH sau Sửa VÀO DB [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.aP09NXPhucDataSet.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                //B5: Đổi nhãn thành ban đầu
                btnModify.Text = "Sửa thông tin files";
                //Trả lại nhãn ban đầu ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]                
            }//else Lưu thông tin file vào DB
        }//btnModify// SỬA THÔNG TIN FILE ÂM THANH

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Thiệt xóa file âm thanh: " + txtms.Text.Trim()
                                     + " _ " + txtTen.Text.Trim() + " không(Y/N)?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //B2: XÓA Khi NSD Y
            if (ch == DialogResult.Yes)//NSD đồng ý Xóa
            {
                try
                {
                    aUDIOFILESTableAdapter.Delete(txtms.Text.Trim());//XÓA FILE ÂM THANH [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                //B3: Tải các file sau xóa lên ListBox = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.aP09NXPhucDataSet.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
            }//If NSD Y
        }//btnDelete// XÓA FILE ÂM THAN

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn đóng trang này không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Hỏi xác nhận NSD có thực sự muốn đóng Form hay không?, Kết quả NSD chọn nút nào [Yes, No] được lưu giữ trong biến ch thuộc kiểu DialogResult
            if (ch == DialogResult.Yes)//NSD đồng ý đóng Form, để về màn hình chính
            {
                this.Close();
                // Đóng Form này từ con trỏ This = CÂU LỆNH QUANG TRỌNG NHẤT (chỉ viết đúng 1 câu lệnh là OK)
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn THOÁT CHƯƠNG TRÌNH này không (Y/N)?",
                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Hỏi xác nhận NSD có thực sự muốn THOÁT APP không?, Kết quả NSD chọn nút nào [Yes, No] được lưu giữ trong biến ch thuộc kiểu DialogResult
            if (ch == DialogResult.Yes)//NSD đồng ý THOÁT APP
            {
                Application.Exit(); //THOÁT APP = CÂU LỆNH QUANG TRỌNG NHẤT (chỉ viết đúng 1 câu lệnh là OK)
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1;
        }
    }//thủ tục Exit

}
    






