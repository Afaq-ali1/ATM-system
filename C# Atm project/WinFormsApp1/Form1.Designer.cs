namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new ePOSOne.btnProduct.Button_WOC();
            button5 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(20, 15, 70);
            label1.Location = new Point(389, 171);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 0;
            label1.Text = "Enter Your 4 digit Pin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(228, 241, 254);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(450, 247);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 15);
            textBox1.TabIndex = 0;
            textBox1.Text = "\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BorderColor = Color.FromArgb(228, 241, 254);
            button1.ButtonColor = Color.FromArgb(0, 71, 160);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 71, 160);
            button1.Location = new Point(467, 270);
            button1.Name = "button1";
            button1.OnHoverBorderColor = Color.FromArgb(0, 71, 160);
            button1.OnHoverButtonColor = Color.FromArgb(228, 241, 254);
            button1.OnHoverTextColor = Color.FromArgb(0, 71, 160);
            button1.Size = new Size(95, 29);
            button1.TabIndex = 1;
            button1.Text = "Continue";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Dock = DockStyle.Top;
            button5.Font = new Font("Montserrat", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(238, 252, 245);
            button5.Location = new Point(0, 0);
            button5.MaximumSize = new Size(1500, 100);
            button5.MinimumSize = new Size(800, 80);
            button5.Name = "button5";
            button5.Size = new Size(1029, 80);
            button5.TabIndex = 11;
            button5.Text = "Welcome to ATM";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Location = new Point(428, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 1);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(428, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 241, 254);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 522);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 241, 254);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ePOSOne.btnProduct.Button_WOC button1;
        private Button button5;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
