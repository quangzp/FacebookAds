namespace AutoAds
{
    partial class TokenForm
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Token";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(238, 176);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 1;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TokenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 244);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TokenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TokenForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
    }
}