namespace AutoAds
{
    partial class Main
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
            btn_auto = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_create_camp = new Button();
            btn_refresh = new Button();
            btn_report = new Button();
            checked_list_acc = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_auto
            // 
            btn_auto.Anchor = AnchorStyles.Top;
            btn_auto.BackColor = Color.Chartreuse;
            btn_auto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_auto.Location = new Point(526, 12);
            btn_auto.Name = "btn_auto";
            btn_auto.Size = new Size(128, 49);
            btn_auto.TabIndex = 0;
            btn_auto.Text = "Run";
            btn_auto.UseVisualStyleBackColor = false;
            btn_auto.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 45);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1184, 509);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // btn_create_camp
            // 
            btn_create_camp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_create_camp.Location = new Point(917, 16);
            btn_create_camp.Name = "btn_create_camp";
            btn_create_camp.Size = new Size(128, 37);
            btn_create_camp.TabIndex = 5;
            btn_create_camp.Text = "Tạo chiến dịch";
            btn_create_camp.UseVisualStyleBackColor = true;
            btn_create_camp.Click += button3_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(226, 16);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(65, 29);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_report
            // 
            btn_report.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_report.Location = new Point(1071, 16);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(125, 37);
            btn_report.TabIndex = 7;
            btn_report.Text = "Xuất báo cáo";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // checked_list_acc
            // 
            checked_list_acc.CheckOnClick = true;
            checked_list_acc.FormattingEnabled = true;
            checked_list_acc.Location = new Point(226, 68);
            checked_list_acc.Name = "checked_list_acc";
            checked_list_acc.Size = new Size(345, 114);
            checked_list_acc.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 725);
            Controls.Add(checked_list_acc);
            Controls.Add(btn_report);
            Controls.Add(btn_refresh);
            Controls.Add(btn_create_camp);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btn_auto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FACEBOOK ADS TOOLS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btn_auto;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_create_camp;
        private Button btn_refresh;
        private Button btn_report;
        private CheckedListBox checked_list_acc;
    }
}