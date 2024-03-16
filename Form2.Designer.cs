namespace AutoAds
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cb_accounts = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_create = new Button();
            logRichTextBox = new RichTextBox();
            label6 = new Label();
            time_picker = new DateTimePicker();
            date_picker = new DateTimePicker();
            cb_adsets = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            num_age_min = new NumericUpDown();
            num_age_max = new NumericUpDown();
            tb_budget = new TextBox();
            cb_city = new CheckBox();
            cb_bidAmount = new CheckBox();
            cb_reaction = new CheckBox();
            cb_adset_bubget = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_age_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age_max).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 472);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // cb_accounts
            // 
            cb_accounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_accounts.FormattingEnabled = true;
            cb_accounts.Items.AddRange(new object[] { "An Nhiên Vũ-499456767680453-106910751258003", "Đỗ Tấn Trung-252097926802492-106910751258003", "Nguyễn Dung-134254563345835-106910751258003", "Đức Minh-134791236867758-100364162904470", "The Most - 1531236347101924 - 106910751258003" });
            cb_accounts.Location = new Point(467, 23);
            cb_accounts.Name = "cb_accounts";
            cb_accounts.Size = new Size(268, 28);
            cb_accounts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Chọn tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 85);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 5;
            label2.Text = "Chọn độ tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(899, 87);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Đến:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 83);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngân sách:";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(554, 531);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(243, 51);
            btn_create.TabIndex = 10;
            btn_create.Text = "Tạo";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // logRichTextBox
            // 
            logRichTextBox.Location = new Point(12, 510);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new Size(320, 72);
            logRichTextBox.TabIndex = 12;
            logRichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 487);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 13;
            label6.Text = "Lỗi:";
            // 
            // time_picker
            // 
            time_picker.CustomFormat = "HH:mm";
            time_picker.Format = DateTimePickerFormat.Custom;
            time_picker.Location = new Point(467, 350);
            time_picker.Name = "time_picker";
            time_picker.ShowUpDown = true;
            time_picker.Size = new Size(72, 27);
            time_picker.TabIndex = 15;
            // 
            // date_picker
            // 
            date_picker.CustomFormat = "dd/MM/yyyy";
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(591, 350);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(119, 27);
            date_picker.TabIndex = 16;
            // 
            // cb_adsets
            // 
            cb_adsets.AutoSize = true;
            cb_adsets.Location = new Point(351, 147);
            cb_adsets.Name = "cb_adsets";
            cb_adsets.Size = new Size(216, 24);
            cb_adsets.TabIndex = 17;
            cb_adsets.Text = "Chia nhiều nhóm quảng cáo";
            cb_adsets.UseVisualStyleBackColor = true;
            cb_adsets.CheckedChanged += cb_adsets_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Enabled = false;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "18-24", "25-34", "35-44" });
            checkedListBox1.Location = new Point(351, 196);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 70);
            checkedListBox1.TabIndex = 18;
            // 
            // num_age_min
            // 
            num_age_min.Location = new Point(822, 80);
            num_age_min.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            num_age_min.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            num_age_min.Name = "num_age_min";
            num_age_min.Size = new Size(71, 27);
            num_age_min.TabIndex = 19;
            num_age_min.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // num_age_max
            // 
            num_age_max.Location = new Point(947, 80);
            num_age_max.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            num_age_max.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            num_age_max.Name = "num_age_max";
            num_age_max.Size = new Size(71, 27);
            num_age_max.TabIndex = 20;
            num_age_max.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // tb_budget
            // 
            tb_budget.Location = new Point(466, 80);
            tb_budget.Name = "tb_budget";
            tb_budget.Size = new Size(150, 27);
            tb_budget.TabIndex = 21;
            // 
            // cb_city
            // 
            cb_city.AutoSize = true;
            cb_city.Location = new Point(634, 196);
            cb_city.Name = "cb_city";
            cb_city.Size = new Size(118, 24);
            cb_city.TabIndex = 23;
            cb_city.Text = "51 thành phố";
            cb_city.UseVisualStyleBackColor = true;
            // 
            // cb_bidAmount
            // 
            cb_bidAmount.AutoSize = true;
            cb_bidAmount.Location = new Point(634, 242);
            cb_bidAmount.Name = "cb_bidAmount";
            cb_bidAmount.Size = new Size(144, 24);
            cb_bidAmount.TabIndex = 24;
            cb_bidAmount.Text = "Giới hạn giá thầu";
            cb_bidAmount.UseVisualStyleBackColor = true;
            // 
            // cb_reaction
            // 
            cb_reaction.AutoSize = true;
            cb_reaction.Location = new Point(832, 199);
            cb_reaction.Name = "cb_reaction";
            cb_reaction.Size = new Size(98, 24);
            cb_reaction.TabIndex = 25;
            cb_reaction.Text = "Tương tác";
            cb_reaction.UseVisualStyleBackColor = true;
            // 
            // cb_adset_bubget
            // 
            cb_adset_bubget.AutoSize = true;
            cb_adset_bubget.Location = new Point(832, 242);
            cb_adset_bubget.Name = "cb_adset_bubget";
            cb_adset_bubget.Size = new Size(216, 24);
            cb_adset_bubget.TabIndex = 26;
            cb_adset_bubget.Text = "Ngân sách nhóm quảng cáo";
            cb_adset_bubget.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1042, 594);
            Controls.Add(cb_adset_bubget);
            Controls.Add(cb_reaction);
            Controls.Add(cb_bidAmount);
            Controls.Add(cb_city);
            Controls.Add(tb_budget);
            Controls.Add(num_age_max);
            Controls.Add(num_age_min);
            Controls.Add(checkedListBox1);
            Controls.Add(cb_adsets);
            Controls.Add(date_picker);
            Controls.Add(time_picker);
            Controls.Add(label6);
            Controls.Add(logRichTextBox);
            Controls.Add(btn_create);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_accounts);
            Controls.Add(richTextBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)num_age_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age_max).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cb_accounts;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btn_create;
        private RichTextBox logRichTextBox;
        private Label label6;
        private DateTimePicker time_picker;
        private DateTimePicker date_picker;
        private CheckBox cb_adsets;
        private CheckedListBox checkedListBox1;
        private NumericUpDown num_age_min;
        private NumericUpDown num_age_max;
        private TextBox tb_budget;
        private CheckedListBox checkedListBox2;
        private CheckBox cb_city;
        private CheckBox cb_bidAmount;
        private CheckBox cb_reaction;
        private CheckBox cb_adset_bubget;
    }
}