namespace CheckMachineLine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtuser = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            txtPwd = new TextBox();
            label4 = new Label();
            txtDb = new TextBox();
            pictureBox1 = new PictureBox();
            txtLog = new TextBox();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtLog);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(9, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 650);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(19, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 183);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cơ bản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "IP Máy Soi";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(4, 84);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(168, 23);
            txtuser.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 13;
            label3.Text = "Pass";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(285, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(106, 154);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(204, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Thêm vào";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(4, 146);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(168, 23);
            txtPwd.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(23, 320);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 16;
            label4.Text = "Server API  Status";
            // 
            // txtDb
            // 
            txtDb.Location = new Point(19, 341);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(410, 23);
            txtDb.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(5, 429);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(439, 205);
            txtLog.TabIndex = 8;
            txtLog.TextChanged += txtLog_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(19, 370);
            button2.Name = "button2";
            button2.Size = new Size(282, 53);
            button2.TabIndex = 7;
            button2.Text = "Kiểm Tra và Duy trì  kết nối";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(460, 673);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Phần Mềm Đảm Bảo Kêt Nối";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtLog;
        private TextBox txtuser;
        private Label label1;
        private Label label3;
        private TextBox txtPwd;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtDb;
    }
}
