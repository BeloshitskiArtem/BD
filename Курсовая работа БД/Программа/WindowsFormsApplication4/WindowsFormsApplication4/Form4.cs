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
    public partial class FormRoute : Form
    {
        public FormRoute()
        {
            InitializeComponent();
        }

        private void маршрутBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void FormRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.taxiDataSet.Маршрут);

        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        private static FormRoute f;
        public static FormRoute fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRoute();
                return f;
            }
        }

        string GetSelectedFieldName()
        {
            return
           маршрутDataGridView.Columns[маршрутDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                        маршрутBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                маршрутBindingSource.Filter = "";
            if (маршрутBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                маршрутBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
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
                indexPos = маршрутBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                маршрутBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких маршрутов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                маршрутBindingSource.Position = 0;
            }
        }

        //string classAvtoIsIntegerVal;
        private void маршрутDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ValueAvtoIsInteger(e);
            if (маршрутDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value == null)
                e.CellStyle.BackColor = Color.Gray;
            else
            {
                e.CellStyle.BackColor = Color.SkyBlue;
               // classAvtoIsIntegerVal = маршрутDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
            
                
        }

        /*private void ValueAvtoIsInteger(DataGridViewCellFormattingEventArgs e)
        {
            if ((string)FormMachine.fd.класс_автомобиляComboBox.SelectedItem == "Эконом")
                маршрутDataGridView.Rows[e.RowIndex].Cells["Цена, руб"].Value = 
                (double)маршрутDataGridView.Rows[e.RowIndex].Cells["Растояние, км"].Value * 1.0;

            else if ((string)FormMachine.fd.класс_автомобиляComboBox.SelectedItem == "Обычный")
                маршрутDataGridView.Rows[e.RowIndex].Cells["Цена, руб"].Value =
            (double)маршрутDataGridView.Rows[e.RowIndex].Cells["Растояние, км"].Value * 1.3;

            else if ((string)FormMachine.fd.класс_автомобиляComboBox.SelectedItem == "Бизнес")
                маршрутDataGridView.Rows[e.RowIndex].Cells["Цена, руб"].Value =
            (double)маршрутDataGridView.Rows[e.RowIndex].Cells["Растояние, км"].Value * 2.0;

            else if ((string)FormMachine.fd.класс_автомобиляComboBox.SelectedItem == "Люкс") //SelectedIndexChanged
                маршрутDataGridView.Rows[e.RowIndex].Cells["Цена, руб"].Value =
                    (double)маршрутDataGridView.Rows[e.RowIndex].Cells["Растояние, км"].Value * 3.0;
        }*/
        
    }
}
