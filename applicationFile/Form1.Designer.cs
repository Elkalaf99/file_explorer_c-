namespace applicationFile
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
            panel1 = new Panel();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            listBox2 = new ListBox();
            textBox2 = new TextBox();
            backButtn = new Button();
            deleteButtn = new Button();
            copyButtn = new Button();
            moveToRight = new Button();
            moveToLeft = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(65, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 314);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(16, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            //listBox1.QueryAccessibilityHelp += listBox1_QueryAccessibilityHelp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(505, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 314);
            panel2.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(26, 89);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(198, 184);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 0;
            //textBox2.TextChanged += textBox2_TextChanged;
            // 
            // backButtn
            // 
            backButtn.Location = new Point(542, 380);
            backButtn.Name = "backButtn";
            backButtn.Size = new Size(94, 29);
            backButtn.TabIndex = 2;
            backButtn.Text = "Back";
            backButtn.UseVisualStyleBackColor = true;
            backButtn.Click += backButtn_Click;
            // 
            // deleteButtn
            // 
            deleteButtn.Location = new Point(335, 380);
            deleteButtn.Name = "deleteButtn";
            deleteButtn.Size = new Size(94, 29);
            deleteButtn.TabIndex = 3;
            deleteButtn.Text = "Move";
            deleteButtn.UseVisualStyleBackColor = true;
            //deleteButtn.Click += button2_Click;
            // 
            // copyButtn
            // 
            copyButtn.Location = new Point(126, 380);
            copyButtn.Name = "copyButtn";
            copyButtn.Size = new Size(94, 29);
            copyButtn.TabIndex = 4;
            copyButtn.Text = "Copy";
            copyButtn.UseVisualStyleBackColor = true;
            copyButtn.Click += copyButtn_Click;
            // 
            // moveToRight
            // 
            moveToRight.Location = new Point(374, 222);
            moveToRight.Name = "moveToRight";
            moveToRight.Size = new Size(94, 29);
            moveToRight.TabIndex = 5;
            moveToRight.Text = ">>>>";
            moveToRight.UseVisualStyleBackColor = true;
            moveToRight.Click += moveToRight_Click;
            // 
            // moveToLeft
            // 
            moveToLeft.Location = new Point(374, 152);
            moveToLeft.Name = "moveToLeft";
            moveToLeft.Size = new Size(94, 29);
            moveToLeft.TabIndex = 6;
            moveToLeft.Text = "<<<<";
            moveToLeft.UseVisualStyleBackColor = true;
            moveToLeft.Click += moveToLeft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moveToLeft);
            Controls.Add(moveToRight);
            Controls.Add(backButtn);
            Controls.Add(deleteButtn);
            Controls.Add(copyButtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            //Load += Form1_Load;
            //Paint += Form1_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button copyButtn;
        private Button deleteButtn;
        private Button backButtn;
        private Button moveToRight;
        private Button moveToLeft;
    }
}
