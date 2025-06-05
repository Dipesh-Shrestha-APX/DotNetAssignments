using System;
using System.Windows.Forms;

namespace Inheritance_Form
{
    public partial class Form1 : Form
    {
        private Register register;
        private Login login;
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            if (login == null || login.IsDisposed)
            {
                login = new Login();
                login.TopLevel = false; // Corrected: should be false to embed in panel
                login.FormBorderStyle = FormBorderStyle.None;
                login.Dock = DockStyle.Fill;
            }

            panel3.Controls.Add(login);
            login.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();

            if (register == null || register.IsDisposed)
            {
                register = new Register();
                register.TopLevel = false; // Corrected: should be false to embed in panel
                register.FormBorderStyle = FormBorderStyle.None;
                register.Dock = DockStyle.Fill;
            }

            panel3.Controls.Add(register);
            register.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            if (calculator == null || calculator.IsDisposed)
            {
                calculator = new Calculator();
                calculator.TopLevel = false; // Corrected: should be false to embed in panel
                calculator.FormBorderStyle = FormBorderStyle.None;
                calculator.Dock = DockStyle.Fill;
            }

            panel3.Controls.Add(calculator);
            calculator.Show();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
