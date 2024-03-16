namespace AutoAds
{
    partial class ExportExcel
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
            dataGridView1 = new DataGridView();
            select = new DataGridViewCheckBoxColumn();
            name = new DataGridViewTextBoxColumn();
            result = new DataGridViewTextBoxColumn();
            cpm = new DataGridViewTextBoxColumn();
            spend = new DataGridViewTextBoxColumn();
            acc = new DataGridViewTextBoxColumn();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cb_acc_page = new ComboBox();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            check_list_acc = new CheckedListBox();
            btn_search = new Button();
            label3 = new Label();
            label4 = new Label();
            tb_tien = new TextBox();
            tb_data = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { select, name, result, cpm, spend, acc });
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 342);
            dataGridView1.TabIndex = 4;
            // 
            // select
            // 
            select.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            select.HeaderText = "Select";
            select.MinimumWidth = 6;
            select.Name = "select";
            select.Width = 55;
            // 
            // name
            // 
            name.HeaderText = "Tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // result
            // 
            result.HeaderText = "Số kết quả";
            result.MinimumWidth = 6;
            result.Name = "result";
            result.ReadOnly = true;
            // 
            // cpm
            // 
            cpm.HeaderText = "Chi phí mỗi kết quả";
            cpm.MinimumWidth = 6;
            cpm.Name = "cpm";
            cpm.ReadOnly = true;
            // 
            // spend
            // 
            spend.HeaderText = "Số tiền đã chi";
            spend.MinimumWidth = 6;
            spend.Name = "spend";
            spend.ReadOnly = true;
            // 
            // acc
            // 
            acc.HeaderText = "Tài khoản";
            acc.MinimumWidth = 6;
            acc.Name = "acc";
            acc.ReadOnly = true;
            // 
            // dtp_start
            // 
            dtp_start.CustomFormat = "dd/MM/yyyy";
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.Location = new Point(111, 86);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(131, 27);
            dtp_start.TabIndex = 1;
            // 
            // dtp_end
            // 
            dtp_end.CustomFormat = "dd/MM/yyyy";
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.Location = new Point(111, 134);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(131, 27);
            dtp_end.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày:";
            // 
            // cb_acc_page
            // 
            cb_acc_page.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_acc_page.FormattingEnabled = true;
            cb_acc_page.Location = new Point(111, 22);
            cb_acc_page.Name = "cb_acc_page";
            cb_acc_page.Size = new Size(131, 28);
            cb_acc_page.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 530);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 19);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 10;
            progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(check_list_acc);
            groupBox1.Location = new Point(286, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 149);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản";
            // 
            // check_list_acc
            // 
            check_list_acc.CheckOnClick = true;
            check_list_acc.Dock = DockStyle.Fill;
            check_list_acc.FormattingEnabled = true;
            check_list_acc.Items.AddRange(new object[] { "An Nhiên Vũ-499456767680453", "Đỗ Tấn Trung-252097926802492", "Nguyễn Dung-134254563345835", "Đức Minh-134791236867758", "Phạm Ngọc Khánh-255871387" });
            check_list_acc.Location = new Point(3, 23);
            check_list_acc.Name = "check_list_acc";
            check_list_acc.Size = new Size(257, 123);
            check_list_acc.TabIndex = 0;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(574, 134);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(98, 40);
            btn_search.TabIndex = 12;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 35);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 13;
            label3.Text = "Tổng tiền ads";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 86);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "Tổng data";
            // 
            // tb_tien
            // 
            tb_tien.Location = new Point(678, 35);
            tb_tien.Name = "tb_tien";
            tb_tien.Size = new Size(99, 27);
            tb_tien.TabIndex = 15;
            // 
            // tb_data
            // 
            tb_data.Location = new Point(678, 86);
            tb_data.Name = "tb_data";
            tb_data.Size = new Size(99, 27);
            tb_data.TabIndex = 16;
            // 
            // ExportExcel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(tb_data);
            Controls.Add(tb_tien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_search);
            Controls.Add(groupBox1);
            Controls.Add(progressBar1);
            Controls.Add(cb_acc_page);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(dataGridView1);
            Name = "ExportExcel";
            Text = "ExportExcel";
            Load += ExportExcel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private Label label1;
        private Label label2;
        private ComboBox cb_acc_page;
        private ProgressBar progressBar1;
        private DataGridViewCheckBoxColumn select;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn result;
        private DataGridViewTextBoxColumn cpm;
        private DataGridViewTextBoxColumn spend;
        private DataGridViewTextBoxColumn acc;
        private GroupBox groupBox1;
        private CheckedListBox check_list_acc;
        private Button btn_search;
        private Label label3;
        private Label label4;
        private TextBox tb_tien;
        private TextBox tb_data;
    }
}