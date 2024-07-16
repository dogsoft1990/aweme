namespace aweme_algorithm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 415);
            button1.Name = "button1";
            button1.Size = new Size(208, 23);
            button1.TabIndex = 0;
            button1.Text = "X-Medusa（PB--ID13算法类型）";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "body_MD5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Query_SM3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(475, 58);
            textBox1.TabIndex = 3;
            textBox1.Text = "39 86 63 6F C6 C1 29 60 83 BD 1A 75 1E 61 95 07";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 146);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(475, 58);
            textBox2.TabIndex = 4;
            textBox2.Text = "2B 72 8E 1F 2D AA 59 57 2F 5E FF 0B 69 CC 43 BF5B A4 06 4A 74 94 F9 74 74 65 C2 7A A0 6C F7 98";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 230);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 5;
            label3.Text = "time";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 250);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(475, 58);
            textBox3.TabIndex = 6;
            textBox3.Text = "CA DB 6E 66 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 332);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 7;
            label4.Text = "type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 342);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(475, 58);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "IOS 抖音算法工具29.0.0---30.3.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}