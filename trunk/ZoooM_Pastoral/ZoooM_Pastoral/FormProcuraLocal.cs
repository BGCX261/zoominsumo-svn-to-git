using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pers_Pastoral;
using System.Data.Common;

namespace ZoooM_Pastoral
{
    public partial class FormProcuraLocal : Form
    {
        public FormProcuraLocal()
        {
            InitializeComponent();

            Connect con = new Connect();

            con.ConnectToMySql();

            dataGridView1.DataSource = con.SelecionaTodosLocais();
            dataGridView1.DataMember = "ZM_LOCAL";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddLocal frm = new FormAddLocal();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCriaReg.local = dataGridView1[2, 2].ToString();
        }
    }
}
