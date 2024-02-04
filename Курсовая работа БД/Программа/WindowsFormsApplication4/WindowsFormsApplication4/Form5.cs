using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.taxiDataSet.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.taxiDataSet.Заказ);

        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            заказBindingSource.Position = 0;
            Show();
            Activate();
        }
        private static FormOrder f;
        public static FormOrder fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrder();
                return f;
            }
        }

        private void заказDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
                ((заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value == null) ||
                 (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == ""))
                    e.CellStyle.BackColor = Color.Gray; 
             else
             {
                if
                    (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "Завершен")
                    e.CellStyle.BackColor = Color.LightGreen;
                else
                    e.CellStyle.BackColor = Color.SkyBlue;
             }
        }

        private void заказBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);
        }

        string GetSelectedFieldName()
        {
            return
           заказDataGridView.Columns[заказDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
               заказBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                заказBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких заказов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                заказBindingSource.Position = 0;
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
                        заказBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                заказBindingSource.Filter = "";
            if (заказBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                заказBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)заказBindingSource.Current)["ID_номер_водителя"];
            else
                return -1;
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormOrder_Shown(object sender, EventArgs e)
        {
            заказBindingSource.Position = заказBindingSource.Find("ID_номер_водителя", idCurrent); 
        }

        private void водителиButton_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)["ID_номер_водителя"].ToString() != "")
            {
                id = (int)(((DataRowView)заказBindingSource.Current)["ID_номер_водителя"]);
            }
            id = FormDishesList.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)заказBindingSource.Current)["ID_номер_водителя"] = id;
                заказBindingSource.EndEdit();
            }
        }

        private void Клиентыbutton_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)["ID_номер_клиента"].ToString() != "")
            {
                id = (int)(((DataRowView)заказBindingSource.Current)["ID_номер_клиента"]);
            }
            id = FormClient.fd.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)заказBindingSource.Current)["ID_номер_клиента"] = id;
                заказBindingSource.EndEdit();
            }
        }

        private void заказDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "ID_номер_водителя", true) == 0)
            {
                decimal price = 0;
                int idDishCurrent = -1;

                int.TryParse((((DataRowView)заказBindingSource.Current)["ID_номер_водителя"]).ToString(), out idDishCurrent);
                int idDish = FormDishesList.fw.ShowSelectForm(idDishCurrent, out price);
                MessageBox.Show("ID номер водителя = " + idDish.ToString());
                ((DataRowView)заказBindingSource.Current)["ID_номер_водителя"] = idDish;
                ((DataRowView)заказBindingSource.Current)["ID_номер_водителя"] = price;
                заказBindingSource.EndEdit();
                //заказTableAdapter.Update(this.taxiDataSet);
                водительTableAdapter.Fill(this.taxiDataSet.Водитель);
            }
        }
    }
}
