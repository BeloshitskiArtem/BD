namespace WindowsFormsApplication4
{
    partial class FormWorkerAndAvtoList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label регистрационный_номерLabel;
            System.Windows.Forms.Label iD_номер_водителяLabel1;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label класс_автомобиляLabel;
            System.Windows.Forms.Label пТСLabel;
            System.Windows.Forms.Label страховка_автомобиляLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label статус_активностиLabel;
            System.Windows.Forms.Label ф_И_О_Label;
            System.Windows.Forms.Label iD_номер_водителяLabel;
            System.Windows.Forms.Label контактLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkerAndAvtoList));
            this.taxiDataSet = new WindowsFormsApplication4.taxiDataSet();
            this.водительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.водительTableAdapter = new WindowsFormsApplication4.taxiDataSetTableAdapters.ВодительTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication4.taxiDataSetTableAdapters.TableAdapterManager();
            this.заказTableAdapter = new WindowsFormsApplication4.taxiDataSetTableAdapters.ЗаказTableAdapter();
            this.транспортное_средствоTableAdapter = new WindowsFormsApplication4.taxiDataSetTableAdapters.Транспортное_средствоTableAdapter();
            this.водительBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.водительBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.all_dishes_Button = new System.Windows.Forms.Button();
            this.транспортное_средствоbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.транспортное_средствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.регистрационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.iD_номер_водителяTextBox1 = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.класс_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.пТСPictureBox = new System.Windows.Forms.PictureBox();
            this.страховка_автомобиляPictureBox = new System.Windows.Forms.PictureBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.статус_активностиCheckBox = new System.Windows.Forms.CheckBox();
            this.ф_И_О_TextBox = new System.Windows.Forms.TextBox();
            this.iD_номер_водителяTextBox = new System.Windows.Forms.TextBox();
            this.контактLabel1 = new System.Windows.Forms.Label();
            регистрационный_номерLabel = new System.Windows.Forms.Label();
            iD_номер_водителяLabel1 = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            класс_автомобиляLabel = new System.Windows.Forms.Label();
            пТСLabel = new System.Windows.Forms.Label();
            страховка_автомобиляLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            статус_активностиLabel = new System.Windows.Forms.Label();
            ф_И_О_Label = new System.Windows.Forms.Label();
            iD_номер_водителяLabel = new System.Windows.Forms.Label();
            контактLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingNavigator)).BeginInit();
            this.водительBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоbindingNavigator)).BeginInit();
            this.транспортное_средствоbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховка_автомобиляPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // регистрационный_номерLabel
            // 
            регистрационный_номерLabel.AutoSize = true;
            регистрационный_номерLabel.Location = new System.Drawing.Point(6, 50);
            регистрационный_номерLabel.Name = "регистрационный_номерLabel";
            регистрационный_номерLabel.Size = new System.Drawing.Size(136, 13);
            регистрационный_номерLabel.TabIndex = 0;
            регистрационный_номерLabel.Text = "Регистрационный номер:";
            // 
            // iD_номер_водителяLabel1
            // 
            iD_номер_водителяLabel1.AutoSize = true;
            iD_номер_водителяLabel1.Location = new System.Drawing.Point(6, 76);
            iD_номер_водителяLabel1.Name = "iD_номер_водителяLabel1";
            iD_номер_водителяLabel1.Size = new System.Drawing.Size(106, 13);
            iD_номер_водителяLabel1.TabIndex = 2;
            iD_номер_водителяLabel1.Text = "ID номер водителя:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(6, 102);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 4;
            статусLabel.Text = "Статус:";
            // 
            // класс_автомобиляLabel
            // 
            класс_автомобиляLabel.AutoSize = true;
            класс_автомобиляLabel.Location = new System.Drawing.Point(6, 128);
            класс_автомобиляLabel.Name = "класс_автомобиляLabel";
            класс_автомобиляLabel.Size = new System.Drawing.Size(105, 13);
            класс_автомобиляLabel.TabIndex = 6;
            класс_автомобиляLabel.Text = "Класс автомобиля:";
            // 
            // пТСLabel
            // 
            пТСLabel.AutoSize = true;
            пТСLabel.Location = new System.Drawing.Point(6, 151);
            пТСLabel.Name = "пТСLabel";
            пТСLabel.Size = new System.Drawing.Size(32, 13);
            пТСLabel.TabIndex = 8;
            пТСLabel.Text = "ПТС:";
            // 
            // страховка_автомобиляLabel
            // 
            страховка_автомобиляLabel.AutoSize = true;
            страховка_автомобиляLabel.Location = new System.Drawing.Point(275, 151);
            страховка_автомобиляLabel.Name = "страховка_автомобиляLabel";
            страховка_автомобиляLabel.Size = new System.Drawing.Size(127, 13);
            страховка_автомобиляLabel.TabIndex = 10;
            страховка_автомобиляLabel.Text = "Страховка автомобиля:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 125);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // статус_активностиLabel
            // 
            статус_активностиLabel.AutoSize = true;
            статус_активностиLabel.Location = new System.Drawing.Point(12, 97);
            статус_активностиLabel.Name = "статус_активностиLabel";
            статус_активностиLabel.Size = new System.Drawing.Size(105, 13);
            статус_активностиLabel.TabIndex = 5;
            статус_активностиLabel.Text = "Статус активности:";
            // 
            // ф_И_О_Label
            // 
            ф_И_О_Label.AutoSize = true;
            ф_И_О_Label.Location = new System.Drawing.Point(12, 69);
            ф_И_О_Label.Name = "ф_И_О_Label";
            ф_И_О_Label.Size = new System.Drawing.Size(46, 13);
            ф_И_О_Label.TabIndex = 3;
            ф_И_О_Label.Text = "Ф И О :";
            // 
            // iD_номер_водителяLabel
            // 
            iD_номер_водителяLabel.AutoSize = true;
            iD_номер_водителяLabel.Location = new System.Drawing.Point(12, 43);
            iD_номер_водителяLabel.Name = "iD_номер_водителяLabel";
            iD_номер_водителяLabel.Size = new System.Drawing.Size(106, 13);
            iD_номер_водителяLabel.TabIndex = 1;
            iD_номер_водителяLabel.Text = "ID номер водителя:";
            // 
            // контактLabel
            // 
            контактLabel.AutoSize = true;
            контактLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            контактLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            контактLabel.Location = new System.Drawing.Point(245, 115);
            контактLabel.Name = "контактLabel";
            контактLabel.Size = new System.Drawing.Size(75, 17);
            контактLabel.TabIndex = 12;
            контактLabel.Text = "Контакт:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // водительBindingSource
            // 
            this.водительBindingSource.DataMember = "Водитель";
            this.водительBindingSource.DataSource = this.taxiDataSet;
            // 
            // водительTableAdapter
            // 
            this.водительTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication4.taxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = this.водительTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.МаршрутTableAdapter = null;
            this.tableAdapterManager.Транспортное_средствоTableAdapter = this.транспортное_средствоTableAdapter;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // транспортное_средствоTableAdapter
            // 
            this.транспортное_средствоTableAdapter.ClearBeforeFill = true;
            // 
            // водительBindingNavigator
            // 
            this.водительBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.водительBindingNavigator.BindingSource = this.водительBindingSource;
            this.водительBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.водительBindingNavigator.CountItemFormat = "из  {0}";
            this.водительBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.водительBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.водительBindingNavigatorSaveItem});
            this.водительBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.водительBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.водительBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.водительBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.водительBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.водительBindingNavigator.Name = "водительBindingNavigator";
            this.водительBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.водительBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.водительBindingNavigator.TabIndex = 0;
            this.водительBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "из  {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // водительBindingNavigatorSaveItem
            // 
            this.водительBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.водительBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("водительBindingNavigatorSaveItem.Image")));
            this.водительBindingNavigatorSaveItem.Name = "водительBindingNavigatorSaveItem";
            this.водительBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.водительBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.водительBindingNavigatorSaveItem.Click += new System.EventHandler(this.водительBindingNavigatorSaveItem_Click);
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "FK_Заказ_Водитель";
            this.заказBindingSource.DataSource = this.водительBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.all_dishes_Button);
            this.groupBox2.Controls.Add(this.транспортное_средствоbindingNavigator);
            this.groupBox2.Controls.Add(регистрационный_номерLabel);
            this.groupBox2.Controls.Add(this.регистрационный_номерTextBox);
            this.groupBox2.Controls.Add(iD_номер_водителяLabel1);
            this.groupBox2.Controls.Add(this.iD_номер_водителяTextBox1);
            this.groupBox2.Controls.Add(статусLabel);
            this.groupBox2.Controls.Add(this.статусTextBox);
            this.groupBox2.Controls.Add(класс_автомобиляLabel);
            this.groupBox2.Controls.Add(this.класс_автомобиляTextBox);
            this.groupBox2.Controls.Add(пТСLabel);
            this.groupBox2.Controls.Add(this.пТСPictureBox);
            this.groupBox2.Controls.Add(страховка_автомобиляLabel);
            this.groupBox2.Controls.Add(this.страховка_автомобиляPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 210);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Транспортные средства";
            // 
            // all_dishes_Button
            // 
            this.all_dishes_Button.Location = new System.Drawing.Point(278, 50);
            this.all_dishes_Button.Name = "all_dishes_Button";
            this.all_dishes_Button.Size = new System.Drawing.Size(124, 23);
            this.all_dishes_Button.TabIndex = 14;
            this.all_dishes_Button.Text = "Все водители";
            this.all_dishes_Button.UseVisualStyleBackColor = true;
            this.all_dishes_Button.Click += new System.EventHandler(this.all_dishes_Button_Click);
            // 
            // транспортное_средствоbindingNavigator
            // 
            this.транспортное_средствоbindingNavigator.AddNewItem = this.toolStripButton8;
            this.транспортное_средствоbindingNavigator.BindingSource = this.транспортное_средствоBindingSource;
            this.транспортное_средствоbindingNavigator.CountItem = this.toolStripLabel2;
            this.транспортное_средствоbindingNavigator.CountItemFormat = "из  {0}";
            this.транспортное_средствоbindingNavigator.DeleteItem = this.toolStripButton9;
            this.транспортное_средствоbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.транспортное_средствоbindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.транспортное_средствоbindingNavigator.MoveFirstItem = this.toolStripButton10;
            this.транспортное_средствоbindingNavigator.MoveLastItem = this.toolStripButton13;
            this.транспортное_средствоbindingNavigator.MoveNextItem = this.toolStripButton12;
            this.транспортное_средствоbindingNavigator.MovePreviousItem = this.toolStripButton11;
            this.транспортное_средствоbindingNavigator.Name = "транспортное_средствоbindingNavigator";
            this.транспортное_средствоbindingNavigator.PositionItem = this.toolStripTextBox2;
            this.транспортное_средствоbindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.транспортное_средствоbindingNavigator.TabIndex = 12;
            this.транспортное_средствоbindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Добавить";
            // 
            // транспортное_средствоBindingSource
            // 
            this.транспортное_средствоBindingSource.DataMember = "FK_Транспортное_средство_Водитель";
            this.транспортное_средствоBindingSource.DataSource = this.водительBindingSource;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "из  {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Сохранить данные";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // регистрационный_номерTextBox
            // 
            this.регистрационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Регистрационный_номер", true));
            this.регистрационный_номерTextBox.Location = new System.Drawing.Point(148, 47);
            this.регистрационный_номерTextBox.Name = "регистрационный_номерTextBox";
            this.регистрационный_номерTextBox.Size = new System.Drawing.Size(100, 20);
            this.регистрационный_номерTextBox.TabIndex = 1;
            // 
            // iD_номер_водителяTextBox1
            // 
            this.iD_номер_водителяTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "ID_номер_водителя", true));
            this.iD_номер_водителяTextBox1.Location = new System.Drawing.Point(148, 73);
            this.iD_номер_водителяTextBox1.Name = "iD_номер_водителяTextBox1";
            this.iD_номер_водителяTextBox1.Size = new System.Drawing.Size(100, 20);
            this.iD_номер_водителяTextBox1.TabIndex = 3;
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(148, 99);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(100, 20);
            this.статусTextBox.TabIndex = 5;
            // 
            // класс_автомобиляTextBox
            // 
            this.класс_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Класс_автомобиля", true));
            this.класс_автомобиляTextBox.Location = new System.Drawing.Point(148, 125);
            this.класс_автомобиляTextBox.Name = "класс_автомобиляTextBox";
            this.класс_автомобиляTextBox.Size = new System.Drawing.Size(100, 20);
            this.класс_автомобиляTextBox.TabIndex = 7;
            // 
            // пТСPictureBox
            // 
            this.пТСPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.транспортное_средствоBindingSource, "ПТС", true));
            this.пТСPictureBox.Location = new System.Drawing.Point(148, 151);
            this.пТСPictureBox.Name = "пТСPictureBox";
            this.пТСPictureBox.Size = new System.Drawing.Size(100, 50);
            this.пТСPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.пТСPictureBox.TabIndex = 9;
            this.пТСPictureBox.TabStop = false;
            // 
            // страховка_автомобиляPictureBox
            // 
            this.страховка_автомобиляPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.транспортное_средствоBindingSource, "Страховка_автомобиля", true));
            this.страховка_автомобиляPictureBox.Location = new System.Drawing.Point(417, 151);
            this.страховка_автомобиляPictureBox.Name = "страховка_автомобиляPictureBox";
            this.страховка_автомобиляPictureBox.Size = new System.Drawing.Size(100, 50);
            this.страховка_автомобиляPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.страховка_автомобиляPictureBox.TabIndex = 11;
            this.страховка_автомобиляPictureBox.TabStop = false;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(124, 122);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(104, 20);
            this.телефонTextBox.TabIndex = 8;
            // 
            // статус_активностиCheckBox
            // 
            this.статус_активностиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.водительBindingSource, "Статус_активности", true));
            this.статус_активностиCheckBox.Location = new System.Drawing.Point(124, 92);
            this.статус_активностиCheckBox.Name = "статус_активностиCheckBox";
            this.статус_активностиCheckBox.Size = new System.Drawing.Size(104, 24);
            this.статус_активностиCheckBox.TabIndex = 6;
            this.статус_активностиCheckBox.Text = "checkBox1";
            this.статус_активностиCheckBox.UseVisualStyleBackColor = true;
            // 
            // ф_И_О_TextBox
            // 
            this.ф_И_О_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Ф_И_О_", true));
            this.ф_И_О_TextBox.Location = new System.Drawing.Point(124, 66);
            this.ф_И_О_TextBox.Name = "ф_И_О_TextBox";
            this.ф_И_О_TextBox.Size = new System.Drawing.Size(104, 20);
            this.ф_И_О_TextBox.TabIndex = 4;
            // 
            // iD_номер_водителяTextBox
            // 
            this.iD_номер_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "ID_номер_водителя", true));
            this.iD_номер_водителяTextBox.Location = new System.Drawing.Point(124, 40);
            this.iD_номер_водителяTextBox.Name = "iD_номер_водителяTextBox";
            this.iD_номер_водителяTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_номер_водителяTextBox.TabIndex = 2;
            // 
            // контактLabel1
            // 
            this.контактLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Контакт", true));
            this.контактLabel1.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.контактLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.контактLabel1.Location = new System.Drawing.Point(302, 115);
            this.контактLabel1.Name = "контактLabel1";
            this.контактLabel1.Size = new System.Drawing.Size(342, 23);
            this.контактLabel1.TabIndex = 13;
            this.контактLabel1.Text = "label1";
            // 
            // FormWorkerAndAvtoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 359);
            this.Controls.Add(контактLabel);
            this.Controls.Add(this.контактLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(iD_номер_водителяLabel);
            this.Controls.Add(this.iD_номер_водителяTextBox);
            this.Controls.Add(ф_И_О_Label);
            this.Controls.Add(this.ф_И_О_TextBox);
            this.Controls.Add(статус_активностиLabel);
            this.Controls.Add(this.статус_активностиCheckBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.водительBindingNavigator);
            this.Name = "FormWorkerAndAvtoList";
            this.Text = "Транспортные средства";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingNavigator)).EndInit();
            this.водительBindingNavigator.ResumeLayout(false);
            this.водительBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоbindingNavigator)).EndInit();
            this.транспортное_средствоbindingNavigator.ResumeLayout(false);
            this.транспортное_средствоbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховка_автомобиляPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taxiDataSet taxiDataSet;
        private taxiDataSetTableAdapters.ВодительTableAdapter водительTableAdapter;
        private taxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator водительBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton водительBindingNavigatorSaveItem;
        private taxiDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private taxiDataSetTableAdapters.Транспортное_средствоTableAdapter транспортное_средствоTableAdapter;
        private System.Windows.Forms.BindingSource транспортное_средствоBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator транспортное_средствоbindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.TextBox регистрационный_номерTextBox;
        private System.Windows.Forms.TextBox iD_номер_водителяTextBox1;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.TextBox класс_автомобиляTextBox;
        private System.Windows.Forms.PictureBox пТСPictureBox;
        private System.Windows.Forms.PictureBox страховка_автомобиляPictureBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.CheckBox статус_активностиCheckBox;
        private System.Windows.Forms.TextBox ф_И_О_TextBox;
        private System.Windows.Forms.TextBox iD_номер_водителяTextBox;
        private System.Windows.Forms.Label контактLabel1;
        private System.Windows.Forms.BindingSource водительBindingSource;
        private System.Windows.Forms.Button all_dishes_Button;
    }
}