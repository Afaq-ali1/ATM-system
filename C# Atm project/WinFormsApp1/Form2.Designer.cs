namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cashWithdraw = new Button();
            button2 = new Button();
            balanceInquiry = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // cashWithdraw
            // 
            cashWithdraw.BackColor = SystemColors.ButtonFace;
            cashWithdraw.BackgroundImage = (Image)resources.GetObject("cashWithdraw.BackgroundImage");
            cashWithdraw.Cursor = Cursors.Hand;
            cashWithdraw.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashWithdraw.ForeColor = SystemColors.ButtonFace;
            cashWithdraw.Location = new Point(347, 111);
            cashWithdraw.Name = "cashWithdraw";
            cashWithdraw.Size = new Size(265, 59);
            cashWithdraw.TabIndex = 0;
            cashWithdraw.Text = "Cash Withdraw";
            cashWithdraw.UseVisualStyleBackColor = false;
            cashWithdraw.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(346, 194);
            button2.Name = "button2";
            button2.Size = new Size(265, 59);
            button2.TabIndex = 1;
            button2.Text = "Fast Cash";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // balanceInquiry
            // 
            balanceInquiry.BackColor = Color.LightSlateGray;
            balanceInquiry.BackgroundImage = (Image)resources.GetObject("balanceInquiry.BackgroundImage");
            balanceInquiry.BackgroundImageLayout = ImageLayout.Stretch;
            balanceInquiry.Cursor = Cursors.Hand;
            balanceInquiry.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceInquiry.ForeColor = SystemColors.ButtonFace;
            balanceInquiry.Location = new Point(345, 277);
            balanceInquiry.Name = "balanceInquiry";
            balanceInquiry.Size = new Size(265, 59);
            balanceInquiry.TabIndex = 2;
            balanceInquiry.Text = "Balance Inquiry";
            balanceInquiry.UseVisualStyleBackColor = false;
            balanceInquiry.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(346, 360);
            button4.Name = "button4";
            button4.Size = new Size(265, 59);
            button4.TabIndex = 3;
            button4.Text = "Cash Deposit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Dock = DockStyle.Top;
            button5.Font = new Font("Montserrat", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(0, 0);
            button5.MaximumSize = new Size(1500, 100);
            button5.MinimumSize = new Size(800, 80);
            button5.Name = "button5";
            button5.Size = new Size(1029, 80);
            button5.TabIndex = 10;
            button5.Text = "Please select from the options below";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 241, 254);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 522);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(balanceInquiry);
            Controls.Add(button2);
            Controls.Add(cashWithdraw);
            Name = "Form2";
            Text = "Home Page";
            ResumeLayout(false);
        }

        #endregion

        private Button cashWithdraw;
        private Button button2;
        private Button balanceInquiry;
        private Button button4;
        private Button button5;
    }
}