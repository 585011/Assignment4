using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.modelDataSet.Rooms);
            // TODO: This line of code loads data into the 'modelDataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.modelDataSet.Bookings);

        }

        private void bookingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingsBindingSource.EndEdit();
            //TableAdapterManager.UpdateAll(this.modelDataSet);
            tableAdapterManager.UpdateAll(this.modelDataSet);

            ModelDataSet.BookingsRow dbrow;

            dbrow = modelDataSet.Bookings.NewBookingsRow();
            dbrow.bookingID = bookingsBindingSource.Count+1;
            dbrow.roomID = int.Parse(roomIDTextBox1.Text);
            dbrow.username = usernameTextBox1.Text;
            dbrow.bookingfrom = bookingfromDateTimePicker.Value;
            dbrow.bookingto = bookingtoDateTimePicker.Value;
            this.modelDataSet.Bookings.Rows.Add(dbrow);
            this.bookingsTableAdapter.Update(this.modelDataSet.Bookings);

            //bookingsTableAdapter.Update(modelDataSet)
            //var bid = bookingIDTextBox1.Text;
            //object bid2 = { bid, roomIDTextBox1.Text, usernameTextBox1.Text, bookingfromDateTimePicker.Value, bookingtoDateTimePicker.Value, null };
            //this.bookingsBindingSource.AddNew(bid, roomIDTextBox1.Text, usernameTextBox1.Text, bookingfromDateTimePicker.Value, bookingtoDateTimePicker.Value, null);

        }

        private void bookingIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bookingsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void roomIDTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ModelDataSet.BookingsRow dbrow;


            bookingsDataGridView.UpdateCellValue(6, bookingsBindingSource.Count);
        }
    }
}
