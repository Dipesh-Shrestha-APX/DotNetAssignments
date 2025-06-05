using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inheritance_Form
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.Text.Trim();
            string district = comboBox2.Text.Trim();
            bool hasSkill = checkedListBox1.CheckedItems.Count > 0;

            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(province) || string.IsNullOrEmpty(district) || !hasSkill)
            {
                MessageBox.Show("Please fill all the fields properly and select at least one skill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reg welcomeForm = new Reg();
                welcomeForm.Show();
                this.Hide();
            }

        }

       
    }
}
