namespace WindowsFormsApplication4
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label регистрационный_номерLabel;
            System.Windows.Forms.Label iD_номер_водителяLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label класс_автомобиляLabel;
            System.Windows.Forms.Label пТСLabel;
            this.tabPageDML = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonDriver = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonAllDriver = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_All = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_OnlyEnd = new System.Windows.Forms.RadioButton();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewDish = new System.Windows.Forms.DataGridView();
            this.panelDish = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto_dish = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.iD_номер_водителяTextBox = new System.Windows.Forms.TextBox();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            this.класс_автомобиляComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonSelectDishes = new System.Windows.Forms.Button();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDelete_dish = new System.Windows.Forms.RadioButton();
            this.регистрационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonUpdate_dish = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_dish = new System.Windows.Forms.RadioButton();
            this.openFileDialogDish = new System.Windows.Forms.OpenFileDialog();
            регистрационный_номерLabel = new System.Windows.Forms.Label();
            iD_номер_водителяLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            класс_автомобиляLabel = new System.Windows.Forms.Label();
            пТСLabel = new System.Windows.Forms.Label();
            this.tabPageDML.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            this.panelDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_dish)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // регистрационный_номерLabel
            // 
            регистрационный_номерLabel.AutoSize = true;
            регистрационный_номерLabel.Location = new System.Drawing.Point(6, 56);
            регистрационный_номерLabel.Name = "регистрационный_номерLabel";
            регистрационный_номерLabel.Size = new System.Drawing.Size(106, 26);
            регистрационный_номерLabel.TabIndex = 15;
            регистрационный_номерLabel.Text = "Регистрационный \r\nномер автомобиля:";
            // 
            // iD_номер_водителяLabel
            // 
            iD_номер_водителяLabel.AutoSize = true;
            iD_номер_водителяLabel.Location = new System.Drawing.Point(12, 13);
            iD_номер_водителяLabel.Name = "iD_номер_водителяLabel";
            iD_номер_водителяLabel.Size = new System.Drawing.Size(106, 13);
            iD_номер_водителяLabel.TabIndex = 17;
            iD_номер_водителяLabel.Text = "ID номер водителя:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(12, 39);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 19;
            статусLabel.Text = "Статус:";
            // 
            // класс_автомобиляLabel
            // 
            класс_автомобиляLabel.AutoSize = true;
            класс_автомобиляLabel.Location = new System.Drawing.Point(12, 66);
            класс_автомобиляLabel.Name = "класс_автомобиляLabel";
            класс_автомобиляLabel.Size = new System.Drawing.Size(105, 13);
            класс_автомобиляLabel.TabIndex = 21;
            класс_автомобиляLabel.Text = "Класс автомобиля:";
            // 
            // пТСLabel
            // 
            пТСLabel.AutoSize = true;
            пТСLabel.Location = new System.Drawing.Point(12, 100);
            пТСLabel.Name = "пТСLabel";
            пТСLabel.Size = new System.Drawing.Size(32, 13);
            пТСLabel.TabIndex = 23;
            пТСLabel.Text = "ПТС:";
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.tabPagePrimer);
            this.tabPageDML.Controls.Add(this.tabPageSelect);
            this.tabPageDML.Controls.Add(this.tabPage1);
            this.tabPageDML.Controls.Add(this.tabPage2);
            this.tabPageDML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageDML.Location = new System.Drawing.Point(0, 0);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.SelectedIndex = 0;
            this.tabPageDML.Size = new System.Drawing.Size(592, 436);
            this.tabPageDML.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(584, 410);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(578, 354);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonClient);
            this.groupBoxSelect.Controls.Add(this.radioButtonOrder);
            this.groupBoxSelect.Controls.Add(this.radioButtonDriver);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(578, 50);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(195, 19);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(69, 17);
            this.radioButtonClient.TabIndex = 2;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Клиенты";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // radioButtonOrder
            // 
            this.radioButtonOrder.AutoSize = true;
            this.radioButtonOrder.Location = new System.Drawing.Point(103, 19);
            this.radioButtonOrder.Name = "radioButtonOrder";
            this.radioButtonOrder.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrder.TabIndex = 1;
            this.radioButtonOrder.TabStop = true;
            this.radioButtonOrder.Text = "Заказы";
            this.radioButtonOrder.UseVisualStyleBackColor = true;
            this.radioButtonOrder.CheckedChanged += new System.EventHandler(this.radioButtonOrder_CheckedChanged);
            // 
            // radioButtonDriver
            // 
            this.radioButtonDriver.AutoSize = true;
            this.radioButtonDriver.Location = new System.Drawing.Point(3, 19);
            this.radioButtonDriver.Name = "radioButtonDriver";
            this.radioButtonDriver.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDriver.TabIndex = 0;
            this.radioButtonDriver.TabStop = true;
            this.radioButtonDriver.Text = "Водители";
            this.radioButtonDriver.UseVisualStyleBackColor = true;
            this.radioButtonDriver.CheckedChanged += new System.EventHandler(this.radioButtonDriver_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(584, 410);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 149);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(578, 258);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(578, 150);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_select
            // 
            this.buttonF_select.BackColor = System.Drawing.Color.White;
            this.buttonF_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonF_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF_select.Location = new System.Drawing.Point(132, 121);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(162, 23);
            this.buttonF_select.TabIndex = 1;
            this.buttonF_select.Text = "Прибыль сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = false;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(4, 82);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(252, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(150, 56);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(144, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(4, 56);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(150, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonAllDriver);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_All);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_OnlyEnd);
            this.groupBoxDet.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxDet.Location = new System.Drawing.Point(345, 16);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(230, 131);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли сотрудников";
            // 
            // radioButtonAllDriver
            // 
            this.radioButtonAllDriver.AutoSize = true;
            this.radioButtonAllDriver.Location = new System.Drawing.Point(6, 94);
            this.radioButtonAllDriver.Name = "radioButtonAllDriver";
            this.radioButtonAllDriver.Size = new System.Drawing.Size(124, 30);
            this.radioButtonAllDriver.TabIndex = 2;
            this.radioButtonAllDriver.TabStop = true;
            this.radioButtonAllDriver.Text = "Показать прибыль \r\nвсех водителей";
            this.radioButtonAllDriver.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_All
            // 
            this.radioButtonDet_All.AutoSize = true;
            this.radioButtonDet_All.Location = new System.Drawing.Point(6, 58);
            this.radioButtonDet_All.Name = "radioButtonDet_All";
            this.radioButtonDet_All.Size = new System.Drawing.Size(216, 30);
            this.radioButtonDet_All.TabIndex = 1;
            this.radioButtonDet_All.TabStop = true;
            this.radioButtonDet_All.Text = "Прибыль водителя по ВСЕМ заказам\r\n(по выполняющимся тоже)";
            this.radioButtonDet_All.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_OnlyEnd
            // 
            this.radioButtonDet_OnlyEnd.AutoSize = true;
            this.radioButtonDet_OnlyEnd.Location = new System.Drawing.Point(12, 19);
            this.radioButtonDet_OnlyEnd.Name = "radioButtonDet_OnlyEnd";
            this.radioButtonDet_OnlyEnd.Size = new System.Drawing.Size(162, 30);
            this.radioButtonDet_OnlyEnd.TabIndex = 0;
            this.radioButtonDet_OnlyEnd.TabStop = true;
            this.radioButtonDet_OnlyEnd.Text = "Прибыль водителя только \r\nпо завершённым заказам";
            this.radioButtonDet_OnlyEnd.UseVisualStyleBackColor = true;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(106, 26);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(188, 20);
            this.textBoxWorker.TabIndex = 1;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(3, 26);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(104, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Ф.И.О. сотрудника";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSubquery);
            this.tabPage1.Controls.Add(this.groupBoxSubquery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 410);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Примеры подзапросов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 112);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(578, 295);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(578, 109);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(397, 61);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(162, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(146, 63);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(228, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(37, 63);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Ф.И.О. водителя";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(282, 29);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(40, 29);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewDish);
            this.tabPage2.Controls.Add(this.panelDish);
            this.tabPage2.Controls.Add(this.groupBoxDML);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 410);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Запросы изменения данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDish
            // 
            this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDish.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDish.Location = new System.Drawing.Point(3, 257);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.Size = new System.Drawing.Size(578, 150);
            this.dataGridViewDish.TabIndex = 6;
            // 
            // panelDish
            // 
            this.panelDish.Controls.Add(this.pictureBoxPhoto_dish);
            this.panelDish.Controls.Add(this.buttonOpenPhoto);
            this.panelDish.Controls.Add(iD_номер_водителяLabel);
            this.panelDish.Controls.Add(this.iD_номер_водителяTextBox);
            this.panelDish.Controls.Add(статусLabel);
            this.panelDish.Controls.Add(this.статусComboBox);
            this.panelDish.Controls.Add(класс_автомобиляLabel);
            this.panelDish.Controls.Add(this.класс_автомобиляComboBox);
            this.panelDish.Controls.Add(пТСLabel);
            this.panelDish.Location = new System.Drawing.Point(3, 105);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(572, 146);
            this.panelDish.TabIndex = 5;
            // 
            // pictureBoxPhoto_dish
            // 
            this.pictureBoxPhoto_dish.Location = new System.Drawing.Point(315, 3);
            this.pictureBoxPhoto_dish.Name = "pictureBoxPhoto_dish";
            this.pictureBoxPhoto_dish.Size = new System.Drawing.Size(254, 140);
            this.pictureBoxPhoto_dish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto_dish.TabIndex = 28;
            this.pictureBoxPhoto_dish.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(78, 95);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(107, 23);
            this.buttonOpenPhoto.TabIndex = 27;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // iD_номер_водителяTextBox
            // 
            this.iD_номер_водителяTextBox.Location = new System.Drawing.Point(154, 10);
            this.iD_номер_водителяTextBox.Name = "iD_номер_водителяTextBox";
            this.iD_номер_водителяTextBox.Size = new System.Drawing.Size(121, 20);
            this.iD_номер_водителяTextBox.TabIndex = 18;
            // 
            // статусComboBox
            // 
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "Используется ",
            "Не используется",
            "Неисправно"});
            this.статусComboBox.Location = new System.Drawing.Point(154, 36);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(121, 21);
            this.статусComboBox.TabIndex = 20;
            // 
            // класс_автомобиляComboBox
            // 
            this.класс_автомобиляComboBox.FormattingEnabled = true;
            this.класс_автомобиляComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Обычный",
            "Бизнес",
            "Люкс"});
            this.класс_автомобиляComboBox.Location = new System.Drawing.Point(154, 63);
            this.класс_автомобиляComboBox.Name = "класс_автомобиляComboBox";
            this.класс_автомобиляComboBox.Size = new System.Drawing.Size(121, 21);
            this.класс_автомобиляComboBox.TabIndex = 22;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonSelectDishes);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(регистрационный_номерLabel);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_dish);
            this.groupBoxDML.Controls.Add(this.регистрационный_номерTextBox);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_dish);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_dish);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(578, 96);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonSelectDishes
            // 
            this.buttonSelectDishes.Location = new System.Drawing.Point(411, 59);
            this.buttonSelectDishes.Name = "buttonSelectDishes";
            this.buttonSelectDishes.Size = new System.Drawing.Size(143, 23);
            this.buttonSelectDishes.TabIndex = 6;
            this.buttonSelectDishes.Text = "Показать список авто";
            this.buttonSelectDishes.UseVisualStyleBackColor = true;
            this.buttonSelectDishes.Click += new System.EventHandler(this.buttonSelectDishes_Click);
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(250, 56);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(135, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // radioButtonDelete_dish
            // 
            this.radioButtonDelete_dish.AutoSize = true;
            this.radioButtonDelete_dish.Location = new System.Drawing.Point(411, 12);
            this.radioButtonDelete_dish.Name = "radioButtonDelete_dish";
            this.radioButtonDelete_dish.Size = new System.Drawing.Size(156, 43);
            this.radioButtonDelete_dish.TabIndex = 2;
            this.radioButtonDelete_dish.Text = "Удалить данные по  по \r\nТранспортному средству \r\nс заданным кодом";
            this.radioButtonDelete_dish.UseVisualStyleBackColor = true;
            this.radioButtonDelete_dish.CheckedChanged += new System.EventHandler(this.radioButtonDelete_dish_CheckedChanged);
            // 
            // регистрационный_номерTextBox
            // 
            this.регистрационный_номерTextBox.Location = new System.Drawing.Point(113, 59);
            this.регистрационный_номерTextBox.Name = "регистрационный_номерTextBox";
            this.регистрационный_номерTextBox.Size = new System.Drawing.Size(121, 20);
            this.регистрационный_номерTextBox.TabIndex = 16;
            // 
            // radioButtonUpdate_dish
            // 
            this.radioButtonUpdate_dish.AutoSize = true;
            this.radioButtonUpdate_dish.Location = new System.Drawing.Point(207, 12);
            this.radioButtonUpdate_dish.Name = "radioButtonUpdate_dish";
            this.radioButtonUpdate_dish.Size = new System.Drawing.Size(156, 43);
            this.radioButtonUpdate_dish.TabIndex = 1;
            this.radioButtonUpdate_dish.Text = "Изменить данные по \r\nТранспортному средству \r\nс заданным номером";
            this.radioButtonUpdate_dish.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_dish
            // 
            this.radioButtonInsert_dish.AutoSize = true;
            this.radioButtonInsert_dish.Location = new System.Drawing.Point(6, 19);
            this.radioButtonInsert_dish.Name = "radioButtonInsert_dish";
            this.radioButtonInsert_dish.Size = new System.Drawing.Size(153, 30);
            this.radioButtonInsert_dish.TabIndex = 0;
            this.radioButtonInsert_dish.Text = "Добавить данные по \r\nТранспортному средству";
            this.radioButtonInsert_dish.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDish
            // 
            this.openFileDialogDish.FileName = "openFileDialog1";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 436);
            this.Controls.Add(this.tabPageDML);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabPageDML.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            this.panelDish.ResumeLayout(false);
            this.panelDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_dish)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageDML;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.RadioButton radioButtonOrder;
        private System.Windows.Forms.RadioButton radioButtonDriver;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_All;
        private System.Windows.Forms.RadioButton radioButtonDet_OnlyEnd;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.RadioButton radioButtonAllDriver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelDish;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonDelete_dish;
        private System.Windows.Forms.RadioButton radioButtonUpdate_dish;
        private System.Windows.Forms.RadioButton radioButtonInsert_dish;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.TextBox регистрационный_номерTextBox;
        private System.Windows.Forms.TextBox iD_номер_водителяTextBox;
        public System.Windows.Forms.ComboBox статусComboBox;
        public System.Windows.Forms.ComboBox класс_автомобиляComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogDish;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_dish;
        private System.Windows.Forms.DataGridView dataGridViewDish;
        private System.Windows.Forms.Button buttonSelectDishes;
        private System.Windows.Forms.Button buttonExecuteDML;
    }
}