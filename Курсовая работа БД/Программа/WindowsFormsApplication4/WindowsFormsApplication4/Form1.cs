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
    public partial class FormDishesList : Form
    {
        public FormDishesList()
        {
            InitializeComponent();
        }

        private void водительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void FormDishesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.taxiDataSet.Водитель);

        }

        private static FormDishesList f;
        public static FormDishesList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDishesList();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            водительBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void водительDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (водительDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value == null)
            {
                e.CellStyle.BackColor = Color.Gray;
            }
            else
            {
                if (водительDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value.Equals(true)) 
                    e.CellStyle.BackColor = Color.LightGreen;
                else
                    if (водительDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value.Equals(false))
                        e.CellStyle.BackColor = Color.SkyBlue;
            }     
        }

        string GetSelectedFieldName()
        {
            return
           водительDataGridView.Columns[водительDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                indexPos =
               водительBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                водительBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                водительBindingSource.Position = 0;
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
                        водительBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                водительBindingSource.Filter = "";
            if (водительBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                водительBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public int ShowSelectForm(int idDish, out decimal price)
        {
            idCurrent = idDish;
            ShowDialog();
            price = (int)((DataRowView)водительBindingSource.Current)["ID_номер_водителя"];
            return (int)((DataRowView)водительBindingSource.Current)["ID_номер_водителя"];
        }

        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)водительBindingSource.Current)["ID_номер_водителя"];
            else
                return -1;
        }

        private void FormDishesList_Shown(object sender, EventArgs e)
        {
            водительBindingSource.Position = водительBindingSource.Find("ID_номер_водителя", idCurrent);
        }
    }
}
