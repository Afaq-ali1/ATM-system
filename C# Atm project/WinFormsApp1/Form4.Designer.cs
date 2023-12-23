namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button7 = new Button();
            cashWithdraw = new Button();
            button2 = new Button();
            button4 = new Button();
            balanceInquiry = new Button();
            button1 = new Button();
            button3 = new Button();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Dock = DockStyle.Top;
            button7.Font = new Font("Montserrat", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(0, 0);
            button7.MaximumSize = new Size(1500, 100);
            button7.MinimumSize = new Size(800, 80);
            button7.Name = "button7";
            button7.Size = new Size(1029, 80);
            button7.TabIndex = 12;
            button7.Text = "Please select from the options below";
            button7.UseVisualStyleBackColor = true;
            // 
            // cashWithdraw
            // 
            cashWithdraw.BackColor = SystemColors.ButtonFace;
            cashWithdraw.BackgroundImage = (Image)resources.GetObject("cashWithdraw.BackgroundImage");
            cashWithdraw.Cursor = Cursors.Hand;
            cashWithdraw.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashWithdraw.ForeColor = SystemColors.ButtonFace;
            cashWithdraw.Location = new Point(236, 115);
            cashWithdraw.Name = "cashWithdraw";
            cashWithdraw.Size = new Size(223, 59);
            cashWithdraw.TabIndex = 13;
            cashWithdraw.Text = "1000";
            cashWithdraw.UseVisualStyleBackColor = false;
            cashWithdraw.Click += cashWithdraw_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(552, 213);
            button2.Name = "button2";
            button2.Size = new Size(223, 59);
            button2.TabIndex = 14;
            button2.Text = "15000";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(235, 213);
            button4.Name = "button4";
            button4.Size = new Size(223, 59);
            button4.TabIndex = 15;
            button4.Text = "10000";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // balanceInquiry
            // 
            balanceInquiry.BackColor = Color.LightSlateGray;
            balanceInquiry.BackgroundImage = (Image)resources.GetObject("balanceInquiry.BackgroundImage");
            balanceInquiry.BackgroundImageLayout = ImageLayout.Stretch;
            balanceInquiry.Cursor = Cursors.Hand;
            balanceInquiry.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceInquiry.ForeColor = SystemColors.ButtonFace;
            balanceInquiry.Location = new Point(550, 115);
            balanceInquiry.Name = "balanceInquiry";
            balanceInquiry.Size = new Size(223, 59);
            balanceInquiry.TabIndex = 16;
            balanceInquiry.Text = "5000";
            balanceInquiry.UseVisualStyleBackColor = false;
            balanceInquiry.Click += balanceInquiry_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(232, 298);
            button1.Name = "button1";
            button1.Size = new Size(223, 59);
            button1.TabIndex = 17;
            button1.Text = "20000";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(552, 298);
            button3.Name = "button3";
            button3.Size = new Size(223, 59);
            button3.TabIndex = 18;
            button3.Text = "25000";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button_woc1
            // 
            button_woc1.BorderColor = Color.Silver;
            button_woc1.ButtonColor = Color.FromArgb(0, 71, 160);
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Century Gothic", 9.75F);
            button_woc1.ForeColor = SystemColors.ActiveCaption;
            button_woc1.Location = new Point(7, 436);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.FromArgb(0, 71, 160);
            button_woc1.OnHoverButtonColor = Color.Azure;
            button_woc1.OnHoverTextColor = Color.FromArgb(0, 71, 160);
            button_woc1.Size = new Size(99, 31);
            button_woc1.TabIndex = 19;
            button_woc1.Text = "Back";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = true;
            button_woc1.Click += button_woc1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 241, 254);
            ClientSize = new Size(1029, 522);
            Controls.Add(button_woc1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(balanceInquiry);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(cashWithdraw);
            Controls.Add(button7);
            Name = "Form4";
            Text = "Fast Balance";
            ResumeLayout(false);
        }

        #endregion
        private Button button7;
        private Button cashWithdraw;
        private Button button2;
        private Button button4;
        private Button balanceInquiry;
        private Button button1;
        private Button button3;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Label label4;
    }
}