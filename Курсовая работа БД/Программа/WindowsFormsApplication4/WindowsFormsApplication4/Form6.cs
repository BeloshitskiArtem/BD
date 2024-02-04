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
    public partial class FormWorkerAndAvtoList : Form
    {
        public FormWorkerAndAvtoList()
        {
            InitializeComponent();
        }

        private void водительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.водительBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiDataSet); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.taxiDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.taxiDataSet.Водитель);

            taxiDataSet.Водитель.Columns["Телефон"].DefaultValue = "(999) 999-99-99";
            taxiDataSet.Водитель.Columns["Статус_активности"].DefaultValue = false;

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            { 
                this.Validate();
                this.транспортное_средствоBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        static FormWorkerAndAvtoList f;
        static public FormWorkerAndAvtoList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormWorkerAndAvtoList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            //водителиButton.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)транспортное_средствоBindingSource.Current)["ID_номер_водителя"];
            else
                return -1;
        }


        private void all_dishes_Button_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)транспортное_средствоBindingSource.Current)["ID_номер_водителя"].ToString() != "")
            {
                id = (int)(((DataRowView)транспортное_средствоBindingSource.Current)["ID_номер_водителя"]);
            }
            id = FormDishesList.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)транспортное_средствоBindingSource.Current)["ID_номер_водителя"] = id;
                водительBindingSource.EndEdit();
            }
        }

        private void заказыbutton_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)водительBindingSource.Current)["ID_номер_водителя"].ToString() != "")
            {
                id = (int)(((DataRowView)водительBindingSource.Current)["ID_номер_водителя"]);
            }
            id = FormOrder.fd.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)водительBindingSource.Current)["ID_номер_водителя"] = id;
                водительBindingSource.EndEdit();
                водительTableAdapter.Fill(this.taxiDataSet.Водитель);
            }
        }
    }
}
