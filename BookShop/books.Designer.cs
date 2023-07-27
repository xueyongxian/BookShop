
namespace BookShop
{
    partial class books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Bcattb2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.bianji = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.baoc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BqtyTb = new System.Windows.Forms.TextBox();
            this.BcatTB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BauthorTb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtitleTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Panel();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Bprice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(57, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "账号管理";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(451, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 28);
            this.button5.TabIndex = 26;
            this.button5.Text = "跟新";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Bcattb2
            // 
            this.Bcattb2.Font = new System.Drawing.Font("宋体", 12F);
            this.Bcattb2.FormattingEnabled = true;
            this.Bcattb2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Bcattb2.Location = new System.Drawing.Point(297, 321);
            this.Bcattb2.Name = "Bcattb2";
            this.Bcattb2.Size = new System.Drawing.Size(126, 28);
            this.Bcattb2.TabIndex = 25;
            this.Bcattb2.Text = "类型";
            this.Bcattb2.SelectedIndexChanged += new System.EventHandler(this.catcbsearchcb_SelectedIndexChanged);
            this.Bcattb2.SelectionChangeCommitted += new System.EventHandler(this.catcbsearchcb_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.CadetBlue;
            this.label13.Location = new System.Drawing.Point(291, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 33);
            this.label13.TabIndex = 24;
            this.label13.Text = "书籍清单";
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BookDGV.GridColor = System.Drawing.Color.MistyRose;
            this.BookDGV.Location = new System.Drawing.Point(13, 355);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.RowHeadersVisible = false;
            this.BookDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.BookDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.BookDGV.RowTemplate.Height = 27;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(771, 208);
            this.BookDGV.TabIndex = 23;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // bianji
            // 
            this.bianji.BackColor = System.Drawing.Color.Green;
            this.bianji.Location = new System.Drawing.Point(236, 201);
            this.bianji.Name = "bianji";
            this.bianji.Size = new System.Drawing.Size(113, 38);
            this.bianji.TabIndex = 22;
            this.bianji.Text = "编辑";
            this.bianji.UseVisualStyleBackColor = false;
            this.bianji.Click += new System.EventHandler(this.bianji_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Green;
            this.delete.Location = new System.Drawing.Point(370, 202);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 38);
            this.delete.TabIndex = 21;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // re
            // 
            this.re.BackColor = System.Drawing.Color.Green;
            this.re.Location = new System.Drawing.Point(500, 202);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(113, 38);
            this.re.TabIndex = 20;
            this.re.Text = "重置";
            this.re.UseVisualStyleBackColor = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // baoc
            // 
            this.baoc.BackColor = System.Drawing.Color.Green;
            this.baoc.Location = new System.Drawing.Point(91, 201);
            this.baoc.Name = "baoc";
            this.baoc.Size = new System.Drawing.Size(113, 38);
            this.baoc.TabIndex = 19;
            this.baoc.Text = "保存";
            this.baoc.UseVisualStyleBackColor = false;
            this.baoc.Click += new System.EventHandler(this.baoc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(613, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "价格";
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PriceTb.Location = new System.Drawing.Point(608, 159);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(104, 30);
            this.PriceTb.TabIndex = 17;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Green;
            this.pictureBox6.Image = global::BookShop.Properties.Resources.点;
            this.pictureBox6.Location = new System.Drawing.Point(18, 274);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Green;
            this.pictureBox5.Image = global::BookShop.Properties.Resources.点;
            this.pictureBox5.Location = new System.Drawing.Point(18, 227);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Image = global::BookShop.Properties.Resources.点;
            this.pictureBox4.Location = new System.Drawing.Point(18, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(57, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "图书";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(57, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "书店";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(481, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "数量";
            // 
            // BqtyTb
            // 
            this.BqtyTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqtyTb.Location = new System.Drawing.Point(476, 159);
            this.BqtyTb.Name = "BqtyTb";
            this.BqtyTb.Size = new System.Drawing.Size(97, 30);
            this.BqtyTb.TabIndex = 15;
            // 
            // BcatTB
            // 
            this.BcatTB.AutoCompleteCustomSource.AddRange(new string[] {
            "儿童",
            "文学",
            "玄乎"});
            this.BcatTB.Font = new System.Drawing.Font("宋体", 12F);
            this.BcatTB.FormattingEnabled = true;
            this.BcatTB.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.BcatTB.Location = new System.Drawing.Point(297, 161);
            this.BcatTB.Name = "BcatTB";
            this.BcatTB.Size = new System.Drawing.Size(126, 28);
            this.BcatTB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(160, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "作者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(57, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "用户";
            // 
            // BauthorTb
            // 
            this.BauthorTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BauthorTb.Location = new System.Drawing.Point(155, 159);
            this.BauthorTb.Name = "BauthorTb";
            this.BauthorTb.Size = new System.Drawing.Size(115, 30);
            this.BauthorTb.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookShop.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(293, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "图书类型";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 585);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.OldLace;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(57, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 33);
            this.label10.TabIndex = 19;
            this.label10.Text = "退出";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Green;
            this.pictureBox3.Image = global::BookShop.Properties.Resources.点;
            this.pictureBox3.Location = new System.Drawing.Point(18, 129);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(777, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "书名";
            // 
            // BtitleTb
            // 
            this.BtitleTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtitleTb.Location = new System.Drawing.Point(22, 159);
            this.BtitleTb.Name = "BtitleTb";
            this.BtitleTb.Size = new System.Drawing.Size(106, 30);
            this.BtitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookShop.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(209, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(184, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "书店管理系统";
            // 
            // Bprice
            // 
            this.Bprice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Bprice.Controls.Add(this.button5);
            this.Bprice.Controls.Add(this.Bcattb2);
            this.Bprice.Controls.Add(this.label13);
            this.Bprice.Controls.Add(this.BookDGV);
            this.Bprice.Controls.Add(this.bianji);
            this.Bprice.Controls.Add(this.delete);
            this.Bprice.Controls.Add(this.re);
            this.Bprice.Controls.Add(this.baoc);
            this.Bprice.Controls.Add(this.label12);
            this.Bprice.Controls.Add(this.PriceTb);
            this.Bprice.Controls.Add(this.label11);
            this.Bprice.Controls.Add(this.BqtyTb);
            this.Bprice.Controls.Add(this.BcatTB);
            this.Bprice.Controls.Add(this.label4);
            this.Bprice.Controls.Add(this.BauthorTb);
            this.Bprice.Controls.Add(this.label3);
            this.Bprice.Controls.Add(this.label7);
            this.Bprice.Controls.Add(this.label2);
            this.Bprice.Controls.Add(this.BtitleTb);
            this.Bprice.Controls.Add(this.pictureBox1);
            this.Bprice.Controls.Add(this.label1);
            this.Bprice.Location = new System.Drawing.Point(211, 12);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(839, 585);
            this.Bprice.TabIndex = 5;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bid";
            this.Column6.HeaderText = "编号";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Btitle";
            this.Column1.HeaderText = "书籍名称";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Bauthor";
            this.Column2.HeaderText = "作者";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Bcat";
            this.Column3.HeaderText = "类型";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Bqty";
            this.Column4.HeaderText = "数量";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Bprice";
            this.Column5.HeaderText = "价格";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bprice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "books";
            this.Text = "books";
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Bprice.ResumeLayout(false);
            this.Bprice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Bcattb2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Button bianji;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button re;
        private System.Windows.Forms.Button baoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BqtyTb;
        private System.Windows.Forms.ComboBox BcatTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BauthorTb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BtitleTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Bprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}