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
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private static FormSQL f;
        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed)
                    f = new FormSQL();
                return f;
            }
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источникомданных

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.taxiConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результатазапроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonDriver_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Водитель WHERE Водитель.Статус_активности = 'True'");
        }

        private void radioButtonOrder_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT ID_номер_заказа, Пунккт_отправления, Пункт_назначения, ID_Номер_водителя, ID_номер_клиента, Статус FROM Заказ WHERE Заказ.Статус = 'Завершен'");
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT * FROM Клиент");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            string sqlSelect = "";
            if (radioButtonAllDriver.Checked)
            {
                sqlSelect = @"SELECT w.ID_номер_водителя, [Ф.И.О.], sum(d.[Цена_поездки, руб]) AS Прибыль
                FROM Водитель w, Заказ s, Маршрут d
                WHERE (w.ID_номер_водителя = s.ID_Номер_водителя) 
                AND (d.Пункт_отправления = s.Пунккт_отправления)
                AND (d.Пункт_назначения = s.Пункт_назначения)
				GROUP BY w.ID_номер_водителя, [Ф.И.О.]";
                textBoxWorker.Text = "";
            }
            else if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }

            if (radioButtonDet_OnlyEnd.Checked)
                sqlSelect = @"SELECT w.ID_номер_водителя, [Ф.И.О.], sum(d.[Цена_поездки, руб]) AS Прибыль
                FROM Водитель w, Заказ s, Маршрут d
                WHERE (w.[Ф.И.О.] = '@last_name') AND
				(w.ID_номер_водителя = s.ID_Номер_водителя) 
                AND (s.Статус = 'Завершен') 
                AND (d.Пункт_отправления = s.Пунккт_отправления)
                AND (d.Пункт_назначения = s.Пункт_назначения)
				GROUP BY w.ID_номер_водителя, [Ф.И.О.]";

            else
                if (radioButtonDet_All.Checked)
                    sqlSelect = @"SELECT w.ID_номер_водителя, [Ф.И.О.], sum(d.[Цена_поездки, руб]) AS Прибыль
                FROM Водитель w, Заказ s, Маршрут d
                WHERE (w.[Ф.И.О.] = '@last_name') AND
				(w.ID_номер_водителя = s.ID_Номер_водителя)  
                AND (d.Пункт_отправления = s.Пунккт_отправления)
                AND (d.Пункт_назначения = s.Пункт_назначения)
				GROUP BY w.ID_номер_водителя, [Ф.И.О.]";

            if (checkBoxMore.Checked)
                sqlSelect += "HAVING Sum(d.[Цена_поездки, руб]) >@amount";

            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Sum(d.[Цена_поездки, руб]) desc";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.taxiConnectionString);
            SqlCommand command = connection.CreateCommand();
            sqlSelect = sqlSelect.Replace("@last_name", textBoxWorker.Text);
            command.CommandText = sqlSelect;
            //command.Parameters.AddWithValue("@last_name", textBoxWorker.Text +"%");

            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть заданачислом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
                sqlSelect = @"select * from Заказ t1
                        where @number in
                        (SELECT t2.[Ф.И.О.]
                        FROM Водитель t2
                        WHERE t2.ID_номер_водителя = t1.ID_Номер_водителя)";

            else
                if (radioButtonNoCorrelated.Checked)
                    sqlSelect = @"select 
                        (select t2.[Ф.И.О.] FROM Водитель t2
                        WHERE t2.[Ф.И.О.] like @number) as Фамилия, t1.*
                        from Заказ t1
                        where t1.ID_Номер_водителя in 
                        (select t2.ID_номер_водителя
                        FROM Водитель t2
                        WHERE t2.[Ф.И.О.] like @number)";
                else
                {
                    MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.taxiConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;

            try
            {
                if (radioButtonCorrelated.Checked)
                {
                    command.Parameters.Add("@number", SqlDbType.Char).Value = textBoxNumber.Text;
                }
                else
                    command.Parameters.Add("@number", SqlDbType.Char).Value = '%' + textBoxNumber.Text + '%';
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;

            if (table.Rows.Count == 0)
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogDish.Title = "Укажите файл для фото";
            if (openFileDialogDish.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogDish.FileName;
                try
                {
                    pictureBoxPhoto_dish.Load(openFileDialogDish.FileName);
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

        void InsertDish()
        {
            if ((String.IsNullOrEmpty(регистрационный_номерTextBox.Text) || (String.IsNullOrEmpty(iD_номер_водителяTextBox.Text))))
            {
                MessageBox.Show("Обязательно введите регистрационный номер и ID номер водителя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
            {
                MessageBox.Show("Некоректное значение номера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string reg_number = регистрационный_номерTextBox.Text;

            if (String.IsNullOrEmpty(iD_номер_водителяTextBox.Text))
            {
                MessageBox.Show("Некоректное значение id водителя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = iD_номер_водителяTextBox.Text;

            string sqlInsert = @"INSERT INTO Транспортное_средство(Регистрационный_номер, ID_номер_водителя, Статус,
                    Класс_автомобиля, ПТС)
                    VALUES (@reg_number, @id, @statys, @class, @PhotoPTS)";

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.taxiConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@reg_number", регистрационный_номерTextBox.Text);
            //или другим способом, если необходимо явное указание типа данных
            //command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = textBoxType_dish.Text;
            //command.Parameters.AddWithValue("@Price", price);
            //command.Parameters.AddWithValue("@Weight", weight);

            if (!String.IsNullOrEmpty(статусComboBox.Text))
                command.Parameters.AddWithValue("@statys", статусComboBox.Text);
            else
                command.Parameters.AddWithValue("@statys", DBNull.Value);

            if (!String.IsNullOrEmpty(класс_автомобиляComboBox.Text))
                command.Parameters.AddWithValue("@class", класс_автомобиляComboBox.Text);
            else
                command.Parameters.AddWithValue("@class", DBNull.Value);

            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@PhotoPTS", File.ReadAllBytes(fileImage));
            else
            {
                command.Parameters.Add("@PhotoPTS", SqlDbType.VarBinary);
                command.Parameters["@PhotoPTS"].Value = DBNull.Value;
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }

        void UpdateDish()
        {
            if (String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
            {
                MessageBox.Show("Обязательно введите регистрационный номер и ID номер водителя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
            {
                MessageBox.Show("Некоректное значение номера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string reg_number = регистрационный_номерTextBox.Text;

            if (String.IsNullOrEmpty(iD_номер_водителяTextBox.Text))
            {
                MessageBox.Show("Некоректное значение id водителя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = iD_номер_водителяTextBox.Text;

            string sqlUpdate = "UPDATE Транспортное_средство SET {0} WHERE Регистрационный_номер=@reg_number";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.taxiConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            string sqlValues = "";
            if (!String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
                sqlValues += "Регистрационный_номер=@reg_number,";

            if (!String.IsNullOrEmpty(iD_номер_водителяTextBox.Text))
                sqlValues += "ID_номер_водителя=@id,";

            if (!String.IsNullOrEmpty(статусComboBox.Text))
                sqlValues += "Статус=@statys,";

            if (!String.IsNullOrEmpty(класс_автомобиляComboBox.Text))
                sqlValues += "Класс_автомобиля=@class,";

            if (!String.IsNullOrEmpty(fileImage))
                sqlValues += "ПТС=@PhotoPTS,";

            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
            command.CommandText = String.Format(sqlUpdate, sqlValues);

            //или другим способом, если необходимо явное указание типа данных
            if (!String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
                command.Parameters.Add("@reg_number", SqlDbType.NVarChar).Value = регистрационный_номерTextBox.Text;
            
            if (!String.IsNullOrEmpty(iD_номер_водителяTextBox.Text))
                command.Parameters.AddWithValue("@id", iD_номер_водителяTextBox.Text);

            if (!String.IsNullOrEmpty(статусComboBox.Text))
                command.Parameters.AddWithValue("@statys", статусComboBox.Text);

            if (!String.IsNullOrEmpty(класс_автомобиляComboBox.Text))
                command.Parameters.AddWithValue("@class", класс_автомобиляComboBox.Text);
            
            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@PhotoPTS", File.ReadAllBytes(fileImage));           
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }

        void DeleteDish()
        {
            if (String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
            {
                MessageBox.Show("Обязательно введите регистрационный номер и ID номер водителя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(регистрационный_номерTextBox.Text))
            {
                MessageBox.Show("Некоректное значение номера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string reg_number = регистрационный_номерTextBox.Text;

            string sqlDelete = @"DELETE FROM Транспортное_средство WHERE Регистрационный_номер=@reg_number";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.taxiConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@reg_number", reg_number);
            try
             {
                command.ExecuteNonQuery();
             }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectDishes_Click(this, EventArgs.Empty);
        }
        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_dish.Checked)
                InsertDish();
            else
                if (radioButtonUpdate_dish.Checked)
                    UpdateDish();
                else
                    if (radioButtonDelete_dish.Checked)
                        DeleteDish();
                    else
                        MessageBox.Show("Вы не выбрали действие", "Внимание",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radioButtonDelete_dish_CheckedChanged(object sender, EventArgs e)
        {
            panelDish.Visible = !radioButtonDelete_dish.Checked;
        }

        private void buttonSelectDishes_Click(object sender, EventArgs e)
        {
            dataGridViewDish.DataSource = FillDataGridView("SELECT * FROM Транспортное_средство");
            DataGridViewImageColumn column =
            (DataGridViewImageColumn)dataGridViewDish.Columns["ПТС"];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
