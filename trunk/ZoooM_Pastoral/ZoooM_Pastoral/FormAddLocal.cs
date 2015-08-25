using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pers_Pastoral;

namespace ZoooM_Pastoral
{
    public partial class FormAddLocal : Form
    {
        public FormAddLocal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect PERS = new Connect();
            PERS.ConnectToMySql();
            PERS.SalvarLocal(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}
