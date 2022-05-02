using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDesk
{
    public partial class Form1 : Form
    {
        Oblig4Entities db;
        List<Bookings> bookList;
        List<Rooms> roomsList;
        List<Tasks> taskList;
        public Form1()
        {
            InitializeComponent();
            this.checkedinCheckBox.CausesValidation = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oblig4DataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.oblig4DataSet.Rooms);
            // TODO: This line of code loads data into the 'oblig4DataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.oblig4DataSet.Bookings);
            db = new Oblig4Entities();
            bookList = db.Bookings.ToList();
            roomsList = db.Rooms.ToList();
            taskList = db.Tasks.ToList();
            bookedRooms();

        }

        private void bookingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oblig4DataSet);
            // Sjekk om ditta funka på dei andre metodane ^

            SetDataGridView();
            if (textBox1.Text.Length != 0)
            {
                createTask();
            }
            db.SaveChanges();
            
        }

        private void checkedinCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //Oblig4Entities db = new Oblig4Entities();
            //List<Bookings> bookList = db.Bookings.ToList();

            if (checkedinCheckBox.CheckState.Equals(CheckState.Checked))
            {

                int nn = int.Parse(bookingIDTextBox.Text);
                int book = bookList.Find(b => (b.bookingID.Equals(nn))).bookingID;
                db.Bookings.Find(book).checkedin = DateTime.Now;
                db.SaveChanges();

                

            }
            else
            {
                //MessageBox.Show(checkedinCheckBox.CheckState.ToString());
                return;
            }
            //this.Refresh();
        }

        private void checkedoutCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //Oblig4Entities db = new Oblig4Entities();
            //List<Bookings> bookList = db.Bookings.ToList();

            if (checkedoutCheckBox.CheckState.Equals(CheckState.Checked))
            {
                int nn = int.Parse(bookingIDTextBox.Text);
                int book = bookList.Find(b => (b.bookingID.Equals(nn))).bookingID;
                db.Bookings.Find(book).checkedout = DateTime.Now;
                


                //book.checkedin.Value = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                //bookList.Find(b => b.bookingID.Equals(nn)).checkedin.Value.;
            }
            else
            {

                return;
            }
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedinCheckBox_Click(object sender, EventArgs e)
        {

        }


        public void SetDataGridView()
        {
            bookingsDataGridView.AutoGenerateColumns = false;
            bookingsDataGridView.DataSource = db.Bookings.ToList<Bookings>();
            
            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.DataSource = db.Rooms.ToList<Rooms>();
            bookedRooms();
        }


        private void checkedoutCheckBox_Click(object sender, EventArgs e)
        {

        }
        private void bookedRooms()
        {
            int n = 0;
                    bookList.ForEach(x =>
                    {
                        if (roomsList.Any(y => y.roomID == x.roomID))
                        {
                            int xx = (int)x.roomID;
                            roomsDataGridView.Rows[xx-1].Cells["Booked"].Value = "Booked from: " + x.bookingfrom + ", To: " + x.bookingto;
                        }
                    });

            this.Refresh();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void createTask()
        {
            Tasks task = new Tasks();

            string text = textBox1.Text;
            task.roomID = Convert.ToInt32(roomIDTextBox.Text);
            task.task = comboBox1.SelectedItem.ToString();
            task.stat = "New";
            task.deskcomment = text;
            task.servicecomment = null;

            db.Tasks.Add(task);
        }
    }
}
