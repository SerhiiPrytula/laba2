using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_XOR_Click(object sender, EventArgs e)
        {
            if (textBox_P.Text != "" && textBox_Key.Text != "") {
                string strP = textBox_P.Text;
                int intP = Convert.ToInt32(strP, 16);
                string strKey = textBox_Key.Text;
                int intKey = Convert.ToInt32(strKey, 16);

                int intC = intP ^ intKey;
                string strC = Convert.ToString(intC, 16);
                textBox_C.Text = strC;

                label7.Text = Convert.ToString(intC, 2);
                label8.Text = Convert.ToString(intC, 10);
                label9.Text = Convert.ToString(intC, 16);

                textBox1_c.Text = strC;
                textBox2_key.Text = strKey;
                textBox3_p.Text = strP;
            }
            else
            {
                MessageBox.Show("Помилка: Введіть змінні Р та key");
            }

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox1_c.Text = "";
            textBox2_key.Text = "";
            textBox3_p.Text = "";

            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
