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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCriaReg frm = new FormCriaReg();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddLocal frm = new FormAddLocal();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProcuraDoc frm = new FormProcuraDoc();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            conn.ConnectToMySql();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEdicaoDoc fe = new FormEdicaoDoc();
            fe.Show();
        }

        private void sermãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCriaReg frm = new FormCriaReg();
            frm.MdiParent = this;
            frm.Show();
        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdicaoDoc frm = new FormEdicaoDoc();
            frm.Show();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddLocal frm = new FormAddLocal();
            frm.Show();
        }
    }
}
