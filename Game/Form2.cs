using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Load_Form2(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            button4.Visible = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            listBox1.Visible = true;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dongchuongtrinh(sender, e as FormClosingEventArgs);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            listBox1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void Dongchuongtrinh(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Bạn có muốn thoát chương trình hay không ?", "Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != button3 && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == button3 && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dongchuongtrinh(sender, e as FormClosingEventArgs);
        }
    }
}
