using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4.Properties;

namespace WindowsFormsApplication4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes;

                Settings.Default.Save();

        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("(C)ТУСУР,КСУП,Белошицкий Арём Павлович,580-1,2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormDishesList.fw.ShowForm();
        }

        private void транспортныеСреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMachine.fd.ShowForm();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormClient.fd.ShowForm();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormRoute.fd.ShowForm();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FormOrder.fd.ShowForm();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkerAndAvtoList.fw.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}
