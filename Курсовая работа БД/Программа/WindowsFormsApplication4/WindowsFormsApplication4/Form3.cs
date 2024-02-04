using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.taxiDataSet.Клиент);

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)клиентBindingSource.Current)["ID_номер_клиента"];
            else
                return -1;
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            клиентBindingSource.Position = 0;
            Show();
            Activate();
        }
        private static FormClient f;
        public static FormClient fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormClient();
                return f;
            }
        }

        string GetSelectedFieldName()
        {
            return
           клиентDataGridView.Columns[клиентDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }


        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = клиентBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                клиентBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких клиентов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                клиентBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        клиентBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                клиентBindingSource.Filter = "";
            if (клиентBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                клиентBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void клиентDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (клиентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value == null)
                e.CellStyle.BackColor = Color.Gray;
            else
                e.CellStyle.BackColor = Color.SkyBlue;
        }

        private void FormClient_Shown(object sender, EventArgs e)
        {
            клиентBindingSource.Position = клиентBindingSource.Find("ID_номер_клиента", idCurrent);
        }

    }
}
