using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SautinSoft;

namespace ZoooM_Pastoral
{
    public partial class FormCriaReg : Form
    {
        public static string local;

        public FormCriaReg()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProcuraLocal frm = new FormProcuraLocal();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEdicaoDoc frm = new FormEdicaoDoc();
            frm.Show();
        }
    }
}
