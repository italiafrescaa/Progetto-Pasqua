using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07._04._2023_Progetto_Pasqua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lst_result.Visible = false;

            dgv_board.ColumnCount = 11;
            dgv_board.RowCount = 11;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            CSharedTree sharedtree = new CSharedTree();
            sharedtree.write += e_Write;

            Thread anselmo = new Thread(new CAnselmo(sharedtree).Start);
            Thread tecla = new Thread(new CTecla(sharedtree).Start);

            anselmo.Start();
            tecla.Start();

            anselmo.Join();
            tecla.Join();
        }

        private void chk_log_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_log.Checked)
            {
                lst_result.Visible = true;
            }
            else
            {
                lst_result.Visible = false;
            }
        }

        private void e_Write(object sender, TextEventArgs e)
        {
            ListViewItem temp = new ListViewItem();

            temp.ForeColor = Color.FromName(e.Color);
            temp.Text = e.Text;

            lst_result.Items.Insert(lst_result.Items.Count, temp);
            lst_result.EnsureVisible(0);
        }
    }
}
