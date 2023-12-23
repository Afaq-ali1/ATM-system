namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1 = new TextBox();
            label1 = new Label();
            button5 = new Button();
            button1 = new ePOSOne.btnProduct.Button_WOC();
            button2 = new ePOSOne.btnProduct.Button_WOC();
            panel1 = new Panel();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(228, 241, 254);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 9.75F);
            textBox1.ForeColor = Color.FromArgb(0, 71, 160);
            textBox1.Location = new Point(433, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 16);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(392, 135);
            label1.Name = "label1";
            label1.Size = new Size(233, 33);
            label1.TabIndex = 1;
            label1.Text = "Cash Withdrawal";
            label1.Click += label1_Click;
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
            button5.TabIndex = 11;
            button5.Text = "Please select from the options below";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BorderColor = Color.FromArgb(0, 71, 160);
            button1.ButtonColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(465, 234);
            button1.Name = "button1";
            button1.OnHoverBorderColor = Color.Azure;
            button1.OnHoverButtonColor = Color.FromArgb(0, 71, 160);
            button1.OnHoverTextColor = Color.Azure;
            button1.Size = new Size(99, 29);
            button1.TabIndex = 12;
            button1.Text = "Continue";
            button1.TextColor = Color.FromArgb(0, 71, 160);
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BorderColor = Color.Silver;
            button2.ButtonColor = Color.FromArgb(0, 71, 160);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(466, 270);
            button2.Name = "button2";
            button2.OnHoverBorderColor = Color.FromArgb(0, 71, 160);
            button2.OnHoverButtonColor = Color.Azure;
            button2.OnHoverTextColor = Color.FromArgb(0, 71, 160);
            button2.Size = new Size(99, 31);
            button2.TabIndex = 13;
            button2.Text = "Clear";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_woc1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Location = new Point(430, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 1);
            panel1.TabIndex = 14;
            // 
            // button_woc1
            // 
            button_woc1.BorderColor = Color.Silver;
            button_woc1.ButtonColor = Color.FromArgb(0, 71, 160);
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Century Gothic", 9.75F);
            button_woc1.ForeColor = SystemColors.ActiveCaption;
            button_woc1.Location = new Point(3, 418);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.FromArgb(0, 71, 160);
            button_woc1.OnHoverButtonColor = Color.Azure;
            button_woc1.OnHoverTextColor = Color.FromArgb(0, 71, 160);
            button_woc1.Size = new Size(99, 33);
            button_woc1.TabIndex = 15;
            button_woc1.Text = "Back";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = true;
            button_woc1.Click += button_woc1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(297, 240);
            label2.Name = "label2";
            label2.Size = new Size(163, 19);
            label2.TabIndex = 18;
            label2.Text = "Select OK to confirm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(189, 276);
            label3.Name = "label3";
            label3.Size = new Size(275, 19);
            label3.TabIndex = 19;
            label3.Text = "Select clear to re-enter the amount\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 241, 254);
            ClientSize = new Size(1029, 522);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_woc1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Cash withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
        private ePOSOne.btnProduct.Button_WOC button1;
        private ePOSOne.btnProduct.Button_WOC button2;
        private Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Label label4;
    }
}