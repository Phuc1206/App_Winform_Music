namespace AP09NXuânPhúc
{
    partial class fr2WMP09
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr2WMP09));
            this.groupBoxAudioInfo = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.aUDIOFILESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aP09NXPhucDataSet = new AP09NXuânPhúc.AP09NXPhucDataSet();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtms = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbExt = new System.Windows.Forms.Label();
            this.lbKB = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbms = new System.Windows.Forms.Label();
            this.lbAuFileInfo = new System.Windows.Forms.Label();
            this.lbAuFileSelect = new System.Windows.Forms.Label();
            this.listBoxAuFile = new System.Windows.Forms.ListBox();
            this.GroupBoxAudioTest = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.aUDIOFILESTableAdapter = new AP09NXuânPhúc.AP09NXPhucDataSetTableAdapters.AUDIOFILESTableAdapter();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAudioInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP09NXPhucDataSet)).BeginInit();
            this.GroupBoxAudioTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAudioInfo
            // 
            this.groupBoxAudioInfo.Controls.Add(this.txtDesc);
            this.groupBoxAudioInfo.Controls.Add(this.txtLength);
            this.groupBoxAudioInfo.Controls.Add(this.txtExt);
            this.groupBoxAudioInfo.Controls.Add(this.txtSize);
            this.groupBoxAudioInfo.Controls.Add(this.txtPath);
            this.groupBoxAudioInfo.Controls.Add(this.txtTen);
            this.groupBoxAudioInfo.Controls.Add(this.txtms);
            this.groupBoxAudioInfo.Controls.Add(this.lbDesc);
            this.groupBoxAudioInfo.Controls.Add(this.lbs);
            this.groupBoxAudioInfo.Controls.Add(this.lbLength);
            this.groupBoxAudioInfo.Controls.Add(this.lbExt);
            this.groupBoxAudioInfo.Controls.Add(this.lbKB);
            this.groupBoxAudioInfo.Controls.Add(this.lbSize);
            this.groupBoxAudioInfo.Controls.Add(this.lbPath);
            this.groupBoxAudioInfo.Controls.Add(this.lbTen);
            this.groupBoxAudioInfo.Controls.Add(this.lbms);
            this.groupBoxAudioInfo.Controls.Add(this.lbAuFileInfo);
            this.groupBoxAudioInfo.Controls.Add(this.lbAuFileSelect);
            this.groupBoxAudioInfo.Controls.Add(this.listBoxAuFile);
            this.groupBoxAudioInfo.Location = new System.Drawing.Point(12, 28);
            this.groupBoxAudioInfo.Name = "groupBoxAudioInfo";
            this.groupBoxAudioInfo.Size = new System.Drawing.Size(498, 311);
            this.groupBoxAudioInfo.TabIndex = 1;
            this.groupBoxAudioInfo.TabStop = false;
            this.groupBoxAudioInfo.Text = "QUẢN LÝ THÔNG TIN FILES ÂM THANH";
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "description", true));
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(189, 246);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(296, 53);
            this.txtDesc.TabIndex = 8;
            // 
            // aUDIOFILESBindingSource
            // 
            this.aUDIOFILESBindingSource.DataMember = "AUDIOFILES";
            this.aUDIOFILESBindingSource.DataSource = this.aP09NXPhucDataSet;
            // 
            // aP09NXPhucDataSet
            // 
            this.aP09NXPhucDataSet.DataSetName = "AP09NXPhucDataSet";
            this.aP09NXPhucDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLength
            // 
            this.txtLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "length", true));
            this.txtLength.Enabled = false;
            this.txtLength.Location = new System.Drawing.Point(298, 201);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(133, 20);
            this.txtLength.TabIndex = 7;
            // 
            // txtExt
            // 
            this.txtExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "ext", true));
            this.txtExt.Enabled = false;
            this.txtExt.Location = new System.Drawing.Point(298, 166);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(187, 20);
            this.txtExt.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "size", true));
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(298, 138);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(144, 20);
            this.txtSize.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filepath", true));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(298, 105);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(187, 20);
            this.txtPath.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filename", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(298, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtms
            // 
            this.txtms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "ms", true));
            this.txtms.Enabled = false;
            this.txtms.Location = new System.Drawing.Point(298, 45);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(187, 20);
            this.txtms.TabIndex = 2;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(255, 230);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(37, 13);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Mô tả:";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Location = new System.Drawing.Point(440, 204);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(40, 13);
            this.lbs.TabIndex = 0;
            this.lbs.Text = "s (giây)";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(238, 204);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(54, 13);
            this.lbLength.TabIndex = 0;
            this.lbLength.Text = "Chiều dài:";
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.Location = new System.Drawing.Point(186, 169);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(106, 13);
            this.lbExt.TabIndex = 0;
            this.lbExt.Text = "Phần mở rộng (Ext..):";
            // 
            // lbKB
            // 
            this.lbKB.AutoSize = true;
            this.lbKB.Location = new System.Drawing.Point(448, 141);
            this.lbKB.Name = "lbKB";
            this.lbKB.Size = new System.Drawing.Size(32, 13);
            this.lbKB.TabIndex = 0;
            this.lbKB.Text = "KB(s)";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(229, 141);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(63, 13);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Kích thước:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(199, 108);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(93, 13);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Đường dẫn (path):";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(253, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(45, 13);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên file:";
            // 
            // lbms
            // 
            this.lbms.AutoSize = true;
            this.lbms.Location = new System.Drawing.Point(253, 48);
            this.lbms.Name = "lbms";
            this.lbms.Size = new System.Drawing.Size(39, 13);
            this.lbms.TabIndex = 0;
            this.lbms.Text = "Mã số:";
            // 
            // lbAuFileInfo
            // 
            this.lbAuFileInfo.AutoSize = true;
            this.lbAuFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuFileInfo.Location = new System.Drawing.Point(222, 23);
            this.lbAuFileInfo.Name = "lbAuFileInfo";
            this.lbAuFileInfo.Size = new System.Drawing.Size(199, 13);
            this.lbAuFileInfo.TabIndex = 0;
            this.lbAuFileInfo.Text = "Thông tin chi tiết về file âm thanh";
            // 
            // lbAuFileSelect
            // 
            this.lbAuFileSelect.AutoSize = true;
            this.lbAuFileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuFileSelect.Location = new System.Drawing.Point(8, 23);
            this.lbAuFileSelect.Name = "lbAuFileSelect";
            this.lbAuFileSelect.Size = new System.Drawing.Size(113, 13);
            this.lbAuFileSelect.TabIndex = 0;
            this.lbAuFileSelect.Text = "Chọn file âm thanh";
            // 
            // listBoxAuFile
            // 
            this.listBoxAuFile.DataSource = this.aUDIOFILESBindingSource;
            this.listBoxAuFile.DisplayMember = "filename";
            this.listBoxAuFile.FormattingEnabled = true;
            this.listBoxAuFile.Location = new System.Drawing.Point(5, 48);
            this.listBoxAuFile.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAuFile.Name = "listBoxAuFile";
            this.listBoxAuFile.Size = new System.Drawing.Size(163, 251);
            this.listBoxAuFile.TabIndex = 1;
            this.listBoxAuFile.ValueMember = "filepath";
            // 
            // GroupBoxAudioTest
            // 
            this.GroupBoxAudioTest.Controls.Add(this.axWindowsMediaPlayer1);
            this.GroupBoxAudioTest.Controls.Add(this.btnSlow);
            this.GroupBoxAudioTest.Controls.Add(this.btnFast);
            this.GroupBoxAudioTest.Controls.Add(this.btnStop);
            this.GroupBoxAudioTest.Controls.Add(this.btnPause);
            this.GroupBoxAudioTest.Controls.Add(this.btnLast);
            this.GroupBoxAudioTest.Controls.Add(this.btnNext);
            this.GroupBoxAudioTest.Controls.Add(this.btnPre);
            this.GroupBoxAudioTest.Controls.Add(this.btnFirst);
            this.GroupBoxAudioTest.Controls.Add(this.btnPlay);
            this.GroupBoxAudioTest.Location = new System.Drawing.Point(542, 28);
            this.GroupBoxAudioTest.Name = "GroupBoxAudioTest";
            this.GroupBoxAudioTest.Size = new System.Drawing.Size(389, 311);
            this.GroupBoxAudioTest.TabIndex = 9;
            this.GroupBoxAudioTest.TabStop = false;
            this.GroupBoxAudioTest.Text = "KIỂM (NGHE THỬ: TEST) FILES ÂM THANH";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.aUDIOFILESBindingSource, "filepath", true));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 23);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(377, 220);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(326, 250);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(57, 23);
            this.btnSlow.TabIndex = 14;
            this.btnSlow.Text = "Slower";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(253, 250);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(52, 23);
            this.btnFast.TabIndex = 13;
            this.btnFast.Text = "Faster";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(172, 250);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(94, 250);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(54, 23);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(303, 279);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(80, 23);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = "Last Track";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(202, 279);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next Track";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(102, 279);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(80, 23);
            this.btnPre.TabIndex = 16;
            this.btnPre.Text = "Previous Track";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(16, 279);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(80, 23);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "First Track";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(16, 250);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // aUDIOFILESTableAdapter
            // 
            this.aUDIOFILESTableAdapter.ClearBeforeFill = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(20, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(858, 18);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "09 Nguyễn Xuân Phúc: QUẢN LÝ FILEs ÂM THANH dùng THƯ VIỆN WMPLib.dll của MS. WIND" +
    "OWS";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(23, 377);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Nạp file mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(142, 377);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(126, 23);
            this.btnModify.TabIndex = 21;
            this.btnModify.Text = "Sửa thông tin file";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(310, 377);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(91, 23);
            this.btnRecord.TabIndex = 22;
            this.btnRecord.Text = "Ghi âm file mới";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa file";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(579, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Đóng form, về màn hình chính";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(795, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Thoát App";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fr2WMP09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.GroupBoxAudioTest);
            this.Controls.Add(this.groupBoxAudioInfo);
            this.Name = "fr2WMP09";
            this.Text = "09 Nguyễn Xuân Phúc: QUẢN LÝ FILEs ÂM THANH dùng THƯ VIỆN WMPLib.dll của MS. WIND" +
    "OWS";
            this.Load += new System.EventHandler(this.fr2WMP09_Load);
            this.groupBoxAudioInfo.ResumeLayout(false);
            this.groupBoxAudioInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP09NXPhucDataSet)).EndInit();
            this.GroupBoxAudioTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAudioInfo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbExt;
        private System.Windows.Forms.Label lbKB;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbms;
        private System.Windows.Forms.Label lbAuFileInfo;
        private System.Windows.Forms.Label lbAuFileSelect;
        private System.Windows.Forms.ListBox listBoxAuFile;
        private System.Windows.Forms.GroupBox GroupBoxAudioTest;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AP09NXPhucDataSet aP09NXPhucDataSet;
        private System.Windows.Forms.BindingSource aUDIOFILESBindingSource;
        private AP09NXPhucDataSetTableAdapters.AUDIOFILESTableAdapter aUDIOFILESTableAdapter;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}