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
    public partial class FormMachine : Form
    {
        public FormMachine()
        {
            InitializeComponent();
        }

        private void транспортное_средствоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.транспортное_средствоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.taxiDataSet.Транспортное_средство);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Укажите файл для фото";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialog1.FileName;
                try
                {
                    OpenPhoto.Image = new
                   Bitmap(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";

        }
        private static FormMachine f;
        public static FormMachine fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMachine();
                return f;
            }
        }
            public void ShowForm()
            {
                Show();
                Activate();
            }

            private void buttonTwoPhoto_Click(object sender, EventArgs e)
            {
                openFileDialog1.Title = "Укажите файл для фото";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileImage = openFileDialog1.FileName;
                    try
                    {
                        TwoPhoto.Image = new
                       Bitmap(openFileDialog1.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else fileImage = "";
            }

            private void транспортное_средствоBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
            {
                this.Validate();
                this.транспортное_средствоBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            }

            //public double ClassIS(int id)
            //{
            //    if (статусComboBox.Value.ToString() == "Используется")
            //    return 0;
            //}
    }
}
