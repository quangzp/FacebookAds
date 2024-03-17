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
            btn_create = new Button();
            logRichTextBox = new RichTextBox();
            label6 = new Label();
            panel1 = new Panel();
            cb_pages = new ComboBox();
            label3 = new Label();
            cb_adset_bubget = new CheckBox();
            cb_reaction = new CheckBox();
            cb_bidAmount = new CheckBox();
            cb_city = new CheckBox();
            tb_budget = new TextBox();
            num_age_max = new NumericUpDown();
            num_age_min = new NumericUpDown();
            checkedListBox1 = new CheckedListBox();
            cb_adsets = new CheckBox();
            date_picker = new DateTimePicker();
            time_picker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_accounts = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_age_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age_min).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(437, 472);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btn_create
            // 
            btn_create.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            logRichTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logRichTextBox.Location = new Point(12, 510);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new Size(320, 72);
            logRichTextBox.TabIndex = 12;
            logRichTextBox.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(12, 487);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 13;
            label6.Text = "Lỗi:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cb_pages);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cb_adset_bubget);
            panel1.Controls.Add(cb_reaction);
            panel1.Controls.Add(cb_bidAmount);
            panel1.Controls.Add(cb_city);
            panel1.Controls.Add(tb_budget);
            panel1.Controls.Add(num_age_max);
            panel1.Controls.Add(num_age_min);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(cb_adsets);
            panel1.Controls.Add(date_picker);
            panel1.Controls.Add(time_picker);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cb_accounts);
            panel1.Location = new Point(331, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 472);
            panel1.TabIndex = 14;
            // 
            // cb_pages
            // 
            cb_pages.Anchor = AnchorStyles.Top;
            cb_pages.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pages.FormattingEnabled = true;
            cb_pages.Location = new Point(477, 13);
            cb_pages.Name = "cb_pages";
            cb_pages.Size = new Size(196, 28);
            cb_pages.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(387, 19);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 43;
            label3.Text = "Chọn page:";
            // 
            // cb_adset_bubget
            // 
            cb_adset_bubget.Anchor = AnchorStyles.Top;
            cb_adset_bubget.AutoSize = true;
            cb_adset_bubget.Location = new Point(488, 278);
            cb_adset_bubget.Name = "cb_adset_bubget";
            cb_adset_bubget.Size = new Size(216, 24);
            cb_adset_bubget.TabIndex = 42;
            cb_adset_bubget.Text = "Ngân sách nhóm quảng cáo";
            cb_adset_bubget.UseVisualStyleBackColor = true;
            // 
            // cb_reaction
            // 
            cb_reaction.Anchor = AnchorStyles.Top;
            cb_reaction.AutoSize = true;
            cb_reaction.Location = new Point(488, 235);
            cb_reaction.Name = "cb_reaction";
            cb_reaction.Size = new Size(98, 24);
            cb_reaction.TabIndex = 41;
            cb_reaction.Text = "Tương tác";
            cb_reaction.UseVisualStyleBackColor = true;
            // 
            // cb_bidAmount
            // 
            cb_bidAmount.Anchor = AnchorStyles.Top;
            cb_bidAmount.AutoSize = true;
            cb_bidAmount.Location = new Point(290, 278);
            cb_bidAmount.Name = "cb_bidAmount";
            cb_bidAmount.Size = new Size(144, 24);
            cb_bidAmount.TabIndex = 40;
            cb_bidAmount.Text = "Giới hạn giá thầu";
            cb_bidAmount.UseVisualStyleBackColor = true;
            // 
            // cb_city
            // 
            cb_city.Anchor = AnchorStyles.Top;
            cb_city.AutoSize = true;
            cb_city.Location = new Point(290, 232);
            cb_city.Name = "cb_city";
            cb_city.Size = new Size(118, 24);
            cb_city.TabIndex = 39;
            cb_city.Text = "51 thành phố";
            cb_city.UseVisualStyleBackColor = true;
            // 
            // tb_budget
            // 
            tb_budget.Anchor = AnchorStyles.Top;
            tb_budget.Location = new Point(140, 60);
            tb_budget.Name = "tb_budget";
            tb_budget.Size = new Size(150, 27);
            tb_budget.TabIndex = 38;
            // 
            // num_age_max
            // 
            num_age_max.Anchor = AnchorStyles.Top;
            num_age_max.Location = new Point(265, 102);
            num_age_max.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            num_age_max.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            num_age_max.Name = "num_age_max";
            num_age_max.Size = new Size(71, 27);
            num_age_max.TabIndex = 37;
            num_age_max.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // num_age_min
            // 
            num_age_min.Anchor = AnchorStyles.Top;
            num_age_min.Location = new Point(140, 102);
            num_age_min.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            num_age_min.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            num_age_min.Name = "num_age_min";
            num_age_min.Size = new Size(71, 27);
            num_age_min.TabIndex = 36;
            num_age_min.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Enabled = false;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "18-24", "25-34", "35-44" });
            checkedListBox1.Location = new Point(7, 232);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 70);
            checkedListBox1.TabIndex = 35;
            // 
            // cb_adsets
            // 
            cb_adsets.Anchor = AnchorStyles.Top;
            cb_adsets.AutoSize = true;
            cb_adsets.Location = new Point(7, 183);
            cb_adsets.Name = "cb_adsets";
            cb_adsets.Size = new Size(216, 24);
            cb_adsets.TabIndex = 34;
            cb_adsets.Text = "Chia nhiều nhóm quảng cáo";
            cb_adsets.UseVisualStyleBackColor = true;
            // 
            // date_picker
            // 
            date_picker.Anchor = AnchorStyles.Top;
            date_picker.CustomFormat = "dd/MM/yyyy";
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(247, 386);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(119, 27);
            date_picker.TabIndex = 33;
            // 
            // time_picker
            // 
            time_picker.Anchor = AnchorStyles.Top;
            time_picker.CustomFormat = "HH:mm";
            time_picker.Format = DateTimePickerFormat.Custom;
            time_picker.Location = new Point(123, 386);
            time_picker.Name = "time_picker";
            time_picker.ShowUpDown = true;
            time_picker.Size = new Size(72, 27);
            time_picker.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(12, 63);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 31;
            label5.Text = "Ngân sách:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(217, 109);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 30;
            label4.Text = "Đến:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(11, 107);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 29;
            label2.Text = "Chọn độ tuổi";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 28;
            label1.Text = "Chọn tài khoản:";
            // 
            // cb_accounts
            // 
            cb_accounts.Anchor = AnchorStyles.Top;
            cb_accounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_accounts.FormattingEnabled = true;
            cb_accounts.Location = new Point(140, 16);
            cb_accounts.Name = "cb_accounts";
            cb_accounts.Size = new Size(196, 28);
            cb_accounts.TabIndex = 27;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1042, 594);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(logRichTextBox);
            Controls.Add(btn_create);
            Controls.Add(richTextBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_age_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age_min).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_create;
        private RichTextBox logRichTextBox;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private CheckBox cb_adset_bubget;
        private CheckBox cb_reaction;
        private CheckBox cb_bidAmount;
        private CheckBox cb_city;
        private TextBox tb_budget;
        private NumericUpDown num_age_max;
        private NumericUpDown num_age_min;
        private CheckedListBox checkedListBox1;
        private CheckBox cb_adsets;
        private DateTimePicker date_picker;
        private DateTimePicker time_picker;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cb_accounts;
        private ComboBox cb_pages;
    }
}