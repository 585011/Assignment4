namespace WindowsFormsApp1
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
            System.Windows.Forms.Label bookingIDLabel1;
            System.Windows.Forms.Label roomIDLabel1;
            System.Windows.Forms.Label usernameLabel1;
            System.Windows.Forms.Label bookingfromLabel1;
            System.Windows.Forms.Label bookingtoLabel1;
            System.Windows.Forms.Label checkedinLabel1;
            System.Windows.Forms.Label checkedoutLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modelDataSet = new WindowsFormsApp1.ModelDataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp1.ModelDataSetTableAdapters.BookingsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ModelDataSetTableAdapters.TableAdapterManager();
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
            this.bookingIDTextBox1 = new System.Windows.Forms.TextBox();
            this.roomIDTextBox1 = new System.Windows.Forms.TextBox();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.bookingfromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookingtoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkedinCheckBox1 = new System.Windows.Forms.CheckBox();
            this.checkedoutCheckBox1 = new System.Windows.Forms.CheckBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new WindowsFormsApp1.ModelDataSetTableAdapters.RoomsTableAdapter();
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bookingIDLabel1 = new System.Windows.Forms.Label();
            roomIDLabel1 = new System.Windows.Forms.Label();
            usernameLabel1 = new System.Windows.Forms.Label();
            bookingfromLabel1 = new System.Windows.Forms.Label();
            bookingtoLabel1 = new System.Windows.Forms.Label();
            checkedinLabel1 = new System.Windows.Forms.Label();
            checkedoutLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingNavigator)).BeginInit();
            this.bookingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingIDLabel1
            // 
            bookingIDLabel1.AutoSize = true;
            bookingIDLabel1.Location = new System.Drawing.Point(48, 59);
            bookingIDLabel1.Name = "bookingIDLabel1";
            bookingIDLabel1.Size = new System.Drawing.Size(90, 20);
            bookingIDLabel1.TabIndex = 15;
            bookingIDLabel1.Text = "booking ID:";
            // 
            // roomIDLabel1
            // 
            roomIDLabel1.AutoSize = true;
            roomIDLabel1.Location = new System.Drawing.Point(48, 91);
            roomIDLabel1.Name = "roomIDLabel1";
            roomIDLabel1.Size = new System.Drawing.Size(70, 20);
            roomIDLabel1.TabIndex = 17;
            roomIDLabel1.Text = "room ID:";
            // 
            // usernameLabel1
            // 
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new System.Drawing.Point(48, 123);
            usernameLabel1.Name = "usernameLabel1";
            usernameLabel1.Size = new System.Drawing.Size(84, 20);
            usernameLabel1.TabIndex = 19;
            usernameLabel1.Text = "username:";
            // 
            // bookingfromLabel1
            // 
            bookingfromLabel1.AutoSize = true;
            bookingfromLabel1.Location = new System.Drawing.Point(48, 156);
            bookingfromLabel1.Name = "bookingfromLabel1";
            bookingfromLabel1.Size = new System.Drawing.Size(101, 20);
            bookingfromLabel1.TabIndex = 21;
            bookingfromLabel1.Text = "bookingfrom:";
            // 
            // bookingtoLabel1
            // 
            bookingtoLabel1.AutoSize = true;
            bookingtoLabel1.Location = new System.Drawing.Point(48, 188);
            bookingtoLabel1.Name = "bookingtoLabel1";
            bookingtoLabel1.Size = new System.Drawing.Size(83, 20);
            bookingtoLabel1.TabIndex = 23;
            bookingtoLabel1.Text = "bookingto:";
            // 
            // checkedinLabel1
            // 
            checkedinLabel1.AutoSize = true;
            checkedinLabel1.Location = new System.Drawing.Point(48, 221);
            checkedinLabel1.Name = "checkedinLabel1";
            checkedinLabel1.Size = new System.Drawing.Size(85, 20);
            checkedinLabel1.TabIndex = 25;
            checkedinLabel1.Text = "checkedin:";
            // 
            // checkedoutLabel1
            // 
            checkedoutLabel1.AutoSize = true;
            checkedoutLabel1.Location = new System.Drawing.Point(48, 252);
            checkedoutLabel1.Name = "checkedoutLabel1";
            checkedoutLabel1.Size = new System.Drawing.Size(96, 20);
            checkedoutLabel1.TabIndex = 27;
            checkedoutLabel1.Text = "checkedout:";
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.modelDataSet;
            this.bookingsBindingSource.CurrentChanged += new System.EventHandler(this.bookingsBindingSource_CurrentChanged);
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.bookingsBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.bookingsBindingNavigator.TabIndex = 0;
            this.bookingsBindingNavigator.Text = "bindingNavigator1";
            this.bookingsBindingNavigator.RefreshItems += new System.EventHandler(this.bookingsBindingNavigator_RefreshItems);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // bookingIDTextBox1
            // 
            this.bookingIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "bookingID", true));
            this.bookingIDTextBox1.Location = new System.Drawing.Point(155, 56);
            this.bookingIDTextBox1.Name = "bookingIDTextBox1";
            this.bookingIDTextBox1.Size = new System.Drawing.Size(200, 26);
            this.bookingIDTextBox1.TabIndex = 16;
            // 
            // roomIDTextBox1
            // 
            this.roomIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "roomID", true));
            this.roomIDTextBox1.Location = new System.Drawing.Point(155, 88);
            this.roomIDTextBox1.Name = "roomIDTextBox1";
            this.roomIDTextBox1.Size = new System.Drawing.Size(200, 26);
            this.roomIDTextBox1.TabIndex = 18;
            this.roomIDTextBox1.TextChanged += new System.EventHandler(this.roomIDTextBox1_TextChanged);
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "username", true));
            this.usernameTextBox1.Location = new System.Drawing.Point(155, 120);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(200, 26);
            this.usernameTextBox1.TabIndex = 20;
            // 
            // bookingfromDateTimePicker
            // 
            this.bookingfromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingsBindingSource, "bookingfrom", true));
            this.bookingfromDateTimePicker.Location = new System.Drawing.Point(155, 152);
            this.bookingfromDateTimePicker.Name = "bookingfromDateTimePicker";
            this.bookingfromDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.bookingfromDateTimePicker.TabIndex = 22;
            // 
            // bookingtoDateTimePicker
            // 
            this.bookingtoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingsBindingSource, "bookingto", true));
            this.bookingtoDateTimePicker.Location = new System.Drawing.Point(155, 184);
            this.bookingtoDateTimePicker.Name = "bookingtoDateTimePicker";
            this.bookingtoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.bookingtoDateTimePicker.TabIndex = 24;
            // 
            // checkedinCheckBox1
            // 
            this.checkedinCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bookingsBindingSource, "checkedin", true));
            this.checkedinCheckBox1.Location = new System.Drawing.Point(155, 216);
            this.checkedinCheckBox1.Name = "checkedinCheckBox1";
            this.checkedinCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.checkedinCheckBox1.TabIndex = 26;
            this.checkedinCheckBox1.Text = "checkBox1";
            this.checkedinCheckBox1.UseVisualStyleBackColor = true;
            this.checkedinCheckBox1.CheckedChanged += new System.EventHandler(this.checkedinCheckBox1_CheckedChanged);
            // 
            // checkedoutCheckBox1
            // 
            this.checkedoutCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bookingsBindingSource, "checkedout", true));
            this.checkedoutCheckBox1.Location = new System.Drawing.Point(155, 247);
            this.checkedoutCheckBox1.Name = "checkedoutCheckBox1";
            this.checkedoutCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.checkedoutCheckBox1.TabIndex = 28;
            this.checkedoutCheckBox1.Text = "checkBox1";
            this.checkedoutCheckBox1.UseVisualStyleBackColor = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.modelDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
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
            this.bookingsDataGridView.Location = new System.Drawing.Point(12, 296);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.RowHeadersWidth = 62;
            this.bookingsDataGridView.RowTemplate.Height = 28;
            this.bookingsDataGridView.Size = new System.Drawing.Size(1109, 220);
            this.bookingsDataGridView.TabIndex = 28;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.bookingsDataGridView);
            this.Controls.Add(bookingIDLabel1);
            this.Controls.Add(this.bookingIDTextBox1);
            this.Controls.Add(roomIDLabel1);
            this.Controls.Add(this.roomIDTextBox1);
            this.Controls.Add(usernameLabel1);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(bookingfromLabel1);
            this.Controls.Add(this.bookingfromDateTimePicker);
            this.Controls.Add(bookingtoLabel1);
            this.Controls.Add(this.bookingtoDateTimePicker);
            this.Controls.Add(checkedinLabel1);
            this.Controls.Add(this.checkedinCheckBox1);
            this.Controls.Add(checkedoutLabel1);
            this.Controls.Add(this.checkedoutCheckBox1);
            this.Controls.Add(this.bookingsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingNavigator)).EndInit();
            this.bookingsBindingNavigator.ResumeLayout(false);
            this.bookingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private ModelDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox bookingIDTextBox1;
        private System.Windows.Forms.TextBox roomIDTextBox1;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.DateTimePicker bookingfromDateTimePicker;
        private System.Windows.Forms.DateTimePicker bookingtoDateTimePicker;
        private System.Windows.Forms.CheckBox checkedinCheckBox1;
        private System.Windows.Forms.CheckBox checkedoutCheckBox1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private ModelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridView bookingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

