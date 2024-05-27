namespace questiongame
{
    partial class game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button7 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            menuStrip1 = new MenuStrip();
            loginAsNewUserToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Timer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 57);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Score:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(107, 31);
            label3.Name = "label3";
            label3.Size = new Size(25, 19);
            label3.TabIndex = 2;
            label3.Text = "20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 60);
            label4.Name = "label4";
            label4.Size = new Size(17, 19);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(602, 12);
            button1.Name = "button1";
            button1.Size = new Size(170, 36);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(119, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(543, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(119, 220);
            button2.Name = "button2";
            button2.Size = new Size(170, 45);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(492, 220);
            button3.Name = "button3";
            button3.Size = new Size(170, 45);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(492, 285);
            button4.Name = "button4";
            button4.Size = new Size(170, 45);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(119, 285);
            button5.Name = "button5";
            button5.Size = new Size(170, 45);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(322, 31);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 10;
            label5.Text = "Quiz Game";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.ForeColor = Color.White;
            button7.Location = new Point(602, 51);
            button7.Name = "button7";
            button7.Size = new Size(170, 36);
            button7.TabIndex = 13;
            button7.Text = "restart";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(692, 185);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "blue";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(692, 210);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "red";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginAsNewUserToolStripMenuItem, logOutToolStripMenuItem, eToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginAsNewUserToolStripMenuItem
            // 
            loginAsNewUserToolStripMenuItem.Name = "loginAsNewUserToolStripMenuItem";
            loginAsNewUserToolStripMenuItem.Size = new Size(118, 20);
            loginAsNewUserToolStripMenuItem.Text = "Login As New User";
            loginAsNewUserToolStripMenuItem.Click += loginAsNewUserToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(60, 20);
            logOutToolStripMenuItem.Text = "Log out";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(38, 20);
            eToolStripMenuItem.Text = "Exit";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(12, 335);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Your Result";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 359);
            Controls.Add(linkLabel1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions quiz game";
            Load += game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginAsNewUserToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private LinkLabel linkLabel1;
    }
}