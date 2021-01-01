using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = from h in db.Histories
                       select h;
            foreach (History h2 in data)
                MessageBox.Show(h2.Date.ToString());
            dataGridView1.DataSource = data;   
        }

        private void test(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("thoat?", "thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel=true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
