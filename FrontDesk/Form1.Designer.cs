namespace FrontDesk
{
    partial class Form1
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
            System.Windows.Forms.Label bookingIDLabel;
            System.Windows.Forms.Label roomIDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label bookingfromLabel;
            System.Windows.Forms.Label bookingtoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oblig4DataSet = new FrontDesk.Oblig4DataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new FrontDesk.Oblig4DataSetTableAdapters.BookingsTableAdapter();
            this.tableAdapterManager = new FrontDesk.Oblig4DataSetTableAdapters.TableAdapterManager();
            this.bookingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDTextBox = new System.Windows.Forms.TextBox();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.bookingfromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookingtoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkedinCheckBox = new System.Windows.Forms.CheckBox();
            this.checkedoutCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new FrontDesk.Oblig4DataSetTableAdapters.RoomsTableAdapter();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            bookingIDLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            bookingfromLabel = new System.Windows.Forms.Label();
            bookingtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oblig4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingNavigator)).BeginInit();
            this.bookingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingIDLabel
            // 
            bookingIDLabel.AutoSize = true;
            bookingIDLabel.Location = new System.Drawing.Point(90, 59);
            bookingIDLabel.Name = "bookingIDLabel";
            bookingIDLabel.Size = new System.Drawing.Size(90, 20);
            bookingIDLabel.TabIndex = 2;
            bookingIDLabel.Text = "booking ID:";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new System.Drawing.Point(90, 91);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(70, 20);
            roomIDLabel.TabIndex = 4;
            roomIDLabel.Text = "room ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(90, 123);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(84, 20);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "username:";
            // 
            // bookingfromLabel
            // 
            bookingfromLabel.AutoSize = true;
            bookingfromLabel.Location = new System.Drawing.Point(90, 156);
            bookingfromLabel.Name = "bookingfromLabel";
            bookingfromLabel.Size = new System.Drawing.Size(101, 20);
            bookingfromLabel.TabIndex = 8;
            bookingfromLabel.Text = "bookingfrom:";
            // 
            // bookingtoLabel
            // 
            bookingtoLabel.AutoSize = true;
            bookingtoLabel.Location = new System.Drawing.Point(90, 188);
            bookingtoLabel.Name = "bookingtoLabel";
            bookingtoLabel.Size = new System.Drawing.Size(83, 20);
            bookingtoLabel.TabIndex = 10;
            bookingtoLabel.Text = "bookingto:";
            // 
            // oblig4DataSet
            // 
            this.oblig4DataSet.DataSetName = "Oblig4DataSet";
            this.oblig4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.oblig4DataSet;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingsTableAdapter = this.bookingsTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrontDesk.Oblig4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingsBindingNavigator
            // 
            this.bookingsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookingsBindingNavigator.BindingSource = this.bookingsBindingSource;
            this.bookingsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookingsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookingsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bookingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookingsBindingNavigatorSaveItem});
            this.bookingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookingsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingsBindingNavigator.Name = "bookingsBindingNavigator";
            this.bookingsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingsBindingNavigator.Size = new System.Drawing.Size(1354, 33);
            this.bookingsBindingNavigator.TabIndex = 0;
            this.bookingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bookingsBindingNavigatorSaveItem
            // 
            this.bookingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingsBindingNavigatorSaveItem.Image")));
            this.bookingsBindingNavigatorSaveItem.Name = "bookingsBindingNavigatorSaveItem";
            this.bookingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.bookingsBindingNavigatorSaveItem.Text = "Save Data";
            this.bookingsBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingsBindingNavigatorSaveItem_Click);
            // 
            // bookingsDataGridView
            // 
            this.bookingsDataGridView.AutoGenerateColumns = false;
            this.bookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bookingsDataGridView.DataSource = this.bookingsBindingSource;
            this.bookingsDataGridView.Location = new System.Drawing.Point(79, 287);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.RowHeadersWidth = 62;
            this.bookingsDataGridView.RowTemplate.Height = 28;
            this.bookingsDataGridView.Size = new System.Drawing.Size(1230, 339);
            this.bookingsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bookingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "bookingID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "roomID";
            this.dataGridViewTextBoxColumn2.HeaderText = "roomID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn3.HeaderText = "username";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bookingfrom";
            this.dataGridViewTextBoxColumn4.HeaderText = "bookingfrom";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bookingto";
            this.dataGridViewTextBoxColumn5.HeaderText = "bookingto";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "checkedin";
            this.dataGridViewTextBoxColumn6.HeaderText = "checkedin";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "checkedout";
            this.dataGridViewTextBoxColumn7.HeaderText = "checkedout";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // bookingIDTextBox
            // 
            this.bookingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "bookingID", true));
            this.bookingIDTextBox.Location = new System.Drawing.Point(197, 56);
            this.bookingIDTextBox.Name = "bookingIDTextBox";
            this.bookingIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.bookingIDTextBox.TabIndex = 3;
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "roomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(197, 88);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.roomIDTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(197, 120);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 26);
            this.usernameTextBox.TabIndex = 7;
            // 
            // bookingfromDateTimePicker
            // 
            this.bookingfromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingsBindingSource, "bookingfrom", true));
            this.bookingfromDateTimePicker.Location = new System.Drawing.Point(197, 152);
            this.bookingfromDateTimePicker.Name = "bookingfromDateTimePicker";
            this.bookingfromDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.bookingfromDateTimePicker.TabIndex = 9;
            // 
            // bookingtoDateTimePicker
            // 
            this.bookingtoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingsBindingSource, "bookingto", true));
            this.bookingtoDateTimePicker.Location = new System.Drawing.Point(197, 184);
            this.bookingtoDateTimePicker.Name = "bookingtoDateTimePicker";
            this.bookingtoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.bookingtoDateTimePicker.TabIndex = 11;
            // 
            // checkedinCheckBox
            // 
            this.checkedinCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bookingsBindingSource, "checkedin", true));
            this.checkedinCheckBox.Location = new System.Drawing.Point(94, 217);
            this.checkedinCheckBox.Name = "checkedinCheckBox";
            this.checkedinCheckBox.Size = new System.Drawing.Size(138, 24);
            this.checkedinCheckBox.TabIndex = 13;
            this.checkedinCheckBox.Text = "Checked In";
            this.checkedinCheckBox.UseVisualStyleBackColor = true;
            this.checkedinCheckBox.CheckStateChanged += new System.EventHandler(this.checkedinCheckBox_CheckStateChanged);
            this.checkedinCheckBox.Click += new System.EventHandler(this.checkedinCheckBox_Click);
            // 
            // checkedoutCheckBox
            // 
            this.checkedoutCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bookingsBindingSource, "checkedout", true));
            this.checkedoutCheckBox.Location = new System.Drawing.Point(94, 247);
            this.checkedoutCheckBox.Name = "checkedoutCheckBox";
            this.checkedoutCheckBox.Size = new System.Drawing.Size(138, 24);
            this.checkedoutCheckBox.TabIndex = 15;
            this.checkedoutCheckBox.Text = "Checked Out";
            this.checkedoutCheckBox.UseVisualStyleBackColor = true;
            this.checkedoutCheckBox.CheckStateChanged += new System.EventHandler(this.checkedoutCheckBox_CheckStateChanged);
            this.checkedoutCheckBox.Click += new System.EventHandler(this.checkedoutCheckBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.oblig4DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.Booked});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Location = new System.Drawing.Point(712, 12);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.RowHeadersWidth = 62;
            this.roomsDataGridView.RowTemplate.Height = 28;
            this.roomsDataGridView.Size = new System.Drawing.Size(585, 220);
            this.roomsDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "roomID";
            this.dataGridViewTextBoxColumn8.HeaderText = "roomID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // Booked
            // 
            this.Booked.HeaderText = "Booked";
            this.Booked.MinimumWidth = 8;
            this.Booked.Name = "Booked";
            this.Booked.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Maintenance";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maintenance",
            "Roomservice",
            "Cleaning"});
            this.comboBox1.Location = new System.Drawing.Point(433, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 653);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roomsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(bookingIDLabel);
            this.Controls.Add(this.bookingIDTextBox);
            this.Controls.Add(roomIDLabel);
            this.Controls.Add(this.roomIDTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(bookingfromLabel);
            this.Controls.Add(this.bookingfromDateTimePicker);
            this.Controls.Add(bookingtoLabel);
            this.Controls.Add(this.bookingtoDateTimePicker);
            this.Controls.Add(this.checkedinCheckBox);
            this.Controls.Add(this.checkedoutCheckBox);
            this.Controls.Add(this.bookingsDataGridView);
            this.Controls.Add(this.bookingsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oblig4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingNavigator)).EndInit();
            this.bookingsBindingNavigator.ResumeLayout(false);
            this.bookingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oblig4DataSet oblig4DataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private Oblig4DataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private Oblig4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookingsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookingsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bookingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox bookingIDTextBox;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.DateTimePicker bookingfromDateTimePicker;
        private System.Windows.Forms.DateTimePicker bookingtoDateTimePicker;
        private System.Windows.Forms.CheckBox checkedinCheckBox;
        private System.Windows.Forms.CheckBox checkedoutCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Oblig4DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booked;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

