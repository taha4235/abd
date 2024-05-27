namespace questiongame
{
    partial class result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 44);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Your Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "Time:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 154);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 3;
            label3.Text = "score:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 201);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 5;
            label4.Text = "Name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(86, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(237, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 254);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 7;
            label5.Text = "Quest:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 314);
            button1.Name = "button1";
            button1.Size = new Size(251, 44);
            button1.TabIndex = 9;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 386);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
    }
}