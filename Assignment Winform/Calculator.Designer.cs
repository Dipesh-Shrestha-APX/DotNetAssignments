namespace Inheritance_Form
{
    partial class Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(327, 19);
            label1.Name = "label1";
            label1.Size = new Size(335, 51);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 124);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 1;
            label2.Text = "Num 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 195);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Num 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 290);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 3;
            label4.Text = "Result:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 39);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 39);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(220, 287);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(215, 39);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(500, 124);
            button1.Name = "button1";
            button1.Size = new Size(162, 46);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(713, 121);
            button2.Name = "button2";
            button2.Size = new Size(162, 46);
            button2.TabIndex = 8;
            button2.Text = "Subtract";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(500, 204);
            button3.Name = "button3";
            button3.Size = new Size(162, 46);
            button3.TabIndex = 9;
            button3.Text = "Multiply";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Fuchsia;
            button4.Location = new Point(713, 204);
            button4.Name = "button4";
            button4.Size = new Size(162, 46);
            button4.TabIndex = 10;
            button4.Text = "Divide";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkTurquoise;
            button5.Location = new Point(599, 276);
            button5.Name = "button5";
            button5.Size = new Size(162, 46);
            button5.TabIndex = 11;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 478);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}