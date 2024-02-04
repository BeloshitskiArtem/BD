namespace WindowsFormsApplication4
{
    partial class FormMachine
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
            System.Windows.Forms.Label iD_номер_водителяLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label класс_автомобиляLabel;
            System.Windows.Forms.Label пТСLabel;
            System.Windows.Forms.Label страховка_автомобиляLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMachine));
            this.taxiDataSet = new WindowsFormsApplication4.taxiDataSet();
            this.транспортное_средствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспортное_средствоTableAdapter = new WindowsFormsApplication4.taxiDataSetTableAdapters.Транспортное_средствоTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication4.taxiDataSetTableAdapters.TableAdapterManager();
            this.транспортное_средствоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.транспортное_средствоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.регистрационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.iD_номер_водителяTextBox = new System.Windows.Forms.TextBox();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            this.класс_автомобиляComboBox = new System.Windows.Forms.ComboBox();
            this.OpenPhoto = new System.Windows.Forms.PictureBox();
            this.TwoPhoto = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.buttonTwoPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            регистрационный_номерLabel = new System.Windows.Forms.Label();
            iD_номер_водителяLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            класс_автомобиляLabel = new System.Windows.Forms.Label();
            пТСLabel = new System.Windows.Forms.Label();
            страховка_автомобиляLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingNavigator)).BeginInit();
            this.транспортное_средствоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // регистрационный_номерLabel
            // 
            регистрационный_номерLabel.AutoSize = true;
            регистрационный_номерLabel.Location = new System.Drawing.Point(12, 38);
            регистрационный_номерLabel.Name = "регистрационный_номерLabel";
            регистрационный_номерLabel.Size = new System.Drawing.Size(136, 13);
            регистрационный_номерLabel.TabIndex = 1;
            регистрационный_номерLabel.Text = "Регистрационный номер:";
            // 
            // iD_номер_водителяLabel
            // 
            iD_номер_водителяLabel.AutoSize = true;
            iD_номер_водителяLabel.Location = new System.Drawing.Point(12, 64);
            iD_номер_водителяLabel.Name = "iD_номер_водителяLabel";
            iD_номер_водителяLabel.Size = new System.Drawing.Size(106, 13);
            iD_номер_водителяLabel.TabIndex = 3;
            iD_номер_водителяLabel.Text = "ID номер водителя:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(12, 90);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 5;
            статусLabel.Text = "Статус:";
            // 
            // класс_автомобиляLabel
            // 
            класс_автомобиляLabel.AutoSize = true;
            класс_автомобиляLabel.Location = new System.Drawing.Point(12, 117);
            класс_автомобиляLabel.Name = "класс_автомобиляLabel";
            класс_автомобиляLabel.Size = new System.Drawing.Size(105, 13);
            класс_автомобиляLabel.TabIndex = 7;
            класс_автомобиляLabel.Text = "Класс автомобиля:";
            // 
            // пТСLabel
            // 
            пТСLabel.AutoSize = true;
            пТСLabel.Location = new System.Drawing.Point(9, 157);
            пТСLabel.Name = "пТСLabel";
            пТСLabel.Size = new System.Drawing.Size(32, 13);
            пТСLabel.TabIndex = 9;
            пТСLabel.Text = "ПТС:";
            // 
            // страховка_автомобиляLabel
            // 
            страховка_автомобиляLabel.AutoSize = true;
            страховка_автомобиляLabel.Location = new System.Drawing.Point(300, 160);
            страховка_автомобиляLabel.Name = "страховка_автомобиляLabel";
            страховка_автомобиляLabel.Size = new System.Drawing.Size(127, 13);
            страховка_автомобиляLabel.TabIndex = 11;
            страховка_автомобиляLabel.Text = "Страховка автомобиля:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // транспортное_средствоBindingSource
            // 
            this.транспортное_средствоBindingSource.DataMember = "Транспортное_средство";
            this.транспортное_средствоBindingSource.DataSource = this.taxiDataSet;
            // 
            // транспортное_средствоTableAdapter
            // 
            this.транспортное_средствоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication4.taxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.МаршрутTableAdapter = null;
            this.tableAdapterManager.Транспортное_средствоTableAdapter = this.транспортное_средствоTableAdapter;
            // 
            // транспортное_средствоBindingNavigator
            // 
            this.транспортное_средствоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.транспортное_средствоBindingNavigator.BindingSource = this.транспортное_средствоBindingSource;
            this.транспортное_средствоBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.транспортное_средствоBindingNavigator.CountItemFormat = "из {0}";
            this.транспортное_средствоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.транспортное_средствоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.транспортное_средствоBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.транспортное_средствоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.транспортное_средствоBindingNavigator.MoveFirstItem = null;
            this.транспортное_средствоBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.транспортное_средствоBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.транспортное_средствоBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.транспортное_средствоBindingNavigator.Name = "транспортное_средствоBindingNavigator";
            this.транспортное_средствоBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.транспортное_средствоBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.транспортное_средствоBindingNavigator.TabIndex = 0;
            this.транспортное_средствоBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
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
            // транспортное_средствоBindingNavigatorSaveItem
            // 
            this.транспортное_средствоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.транспортное_средствоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("транспортное_средствоBindingNavigatorSaveItem.Image")));
            this.транспортное_средствоBindingNavigatorSaveItem.Name = "транспортное_средствоBindingNavigatorSaveItem";
            this.транспортное_средствоBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.транспортное_средствоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.транспортное_средствоBindingNavigatorSaveItem.Click += new System.EventHandler(this.транспортное_средствоBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // регистрационный_номерTextBox
            // 
            this.регистрационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Регистрационный_номер", true));
            this.регистрационный_номерTextBox.Location = new System.Drawing.Point(154, 35);
            this.регистрационный_номерTextBox.Name = "регистрационный_номерTextBox";
            this.регистрационный_номерTextBox.Size = new System.Drawing.Size(121, 20);
            this.регистрационный_номерTextBox.TabIndex = 2;
            // 
            // iD_номер_водителяTextBox
            // 
            this.iD_номер_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "ID_номер_водителя", true));
            this.iD_номер_водителяTextBox.Location = new System.Drawing.Point(154, 61);
            this.iD_номер_водителяTextBox.Name = "iD_номер_водителяTextBox";
            this.iD_номер_водителяTextBox.Size = new System.Drawing.Size(121, 20);
            this.iD_номер_водителяTextBox.TabIndex = 4;
            // 
            // статусComboBox
            // 
            this.статусComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Статус", true));
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "Используется ",
            "Не используется",
            "Неисправно"});
            this.статусComboBox.Location = new System.Drawing.Point(154, 87);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(121, 21);
            this.статусComboBox.TabIndex = 6;
            // 
            // класс_автомобиляComboBox
            // 
            this.класс_автомобиляComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортное_средствоBindingSource, "Класс_автомобиля", true));
            this.класс_автомобиляComboBox.FormattingEnabled = true;
            this.класс_автомобиляComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Обычный",
            "Бизнес",
            "Люкс"});
            this.класс_автомобиляComboBox.Location = new System.Drawing.Point(154, 114);
            this.класс_автомобиляComboBox.Name = "класс_автомобиляComboBox";
            this.класс_автомобиляComboBox.Size = new System.Drawing.Size(121, 21);
            this.класс_автомобиляComboBox.TabIndex = 8;
            // 
            // OpenPhoto
            // 
            this.OpenPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.транспортное_средствоBindingSource, "ПТС", true));
            this.OpenPhoto.Location = new System.Drawing.Point(12, 176);
            this.OpenPhoto.Name = "OpenPhoto";
            this.OpenPhoto.Size = new System.Drawing.Size(248, 131);
            this.OpenPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenPhoto.TabIndex = 10;
            this.OpenPhoto.TabStop = false;
            // 
            // TwoPhoto
            // 
            this.TwoPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.транспортное_средствоBindingSource, "Страховка_автомобиля", true));
            this.TwoPhoto.Location = new System.Drawing.Point(303, 176);
            this.TwoPhoto.Name = "TwoPhoto";
            this.TwoPhoto.Size = new System.Drawing.Size(248, 131);
            this.TwoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TwoPhoto.TabIndex = 12;
            this.TwoPhoto.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(153, 147);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(107, 23);
            this.buttonOpenPhoto.TabIndex = 13;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // buttonTwoPhoto
            // 
            this.buttonTwoPhoto.Location = new System.Drawing.Point(448, 150);
            this.buttonTwoPhoto.Name = "buttonTwoPhoto";
            this.buttonTwoPhoto.Size = new System.Drawing.Size(103, 23);
            this.buttonTwoPhoto.TabIndex = 14;
            this.buttonTwoPhoto.Text = "Открыть фото";
            this.buttonTwoPhoto.UseVisualStyleBackColor = true;
            this.buttonTwoPhoto.Click += new System.EventHandler(this.buttonTwoPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 310);
            this.Controls.Add(this.buttonTwoPhoto);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(регистрационный_номерLabel);
            this.Controls.Add(this.регистрационный_номерTextBox);
            this.Controls.Add(iD_номер_водителяLabel);
            this.Controls.Add(this.iD_номер_водителяTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусComboBox);
            this.Controls.Add(класс_автомобиляLabel);
            this.Controls.Add(this.класс_автомобиляComboBox);
            this.Controls.Add(пТСLabel);
            this.Controls.Add(this.OpenPhoto);
            this.Controls.Add(страховка_автомобиляLabel);
            this.Controls.Add(this.TwoPhoto);
            this.Controls.Add(this.транспортное_средствоBindingNavigator);
            this.Name = "FormMachine";
            this.Text = "Список транспортных средств";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingNavigator)).EndInit();
            this.транспортное_средствоBindingNavigator.ResumeLayout(false);
            this.транспортное_средствоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource транспортное_средствоBindingSource;
        private taxiDataSetTableAdapters.Транспортное_средствоTableAdapter транспортное_средствоTableAdapter;
        private taxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator транспортное_средствоBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton транспортное_средствоBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox регистрационный_номерTextBox;
        private System.Windows.Forms.TextBox iD_номер_водителяTextBox;
        private System.Windows.Forms.PictureBox OpenPhoto;
        private System.Windows.Forms.PictureBox TwoPhoto;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.Button buttonTwoPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ComboBox статусComboBox;
        public System.Windows.Forms.ComboBox класс_автомобиляComboBox;








    }
}