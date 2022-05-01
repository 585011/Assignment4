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
            bookedRooms();

        }

        private void bookingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oblig4DataSet);
            // Sjekk om ditta funka på dei andre metodane ^

            //this.Invalidate();
            this.Refresh();
            
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

                
                //this.checkedinCheckBox.CheckState = CheckState.Checked;
                //MessageBox.Show(checkedinCheckBox.CheckState.ToString());



                //book.checkedin.Value = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                //bookList.Find(b => b.bookingID.Equals(nn)).checkedin.Value.;

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
                db.SaveChanges();


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

            //if (checkedinCheckBox.Checked)
            //{
            //    //MessageBox.Show(checkedinCheckBox.CheckState.ToString());
            //    checkedinCheckBox.Checked = true;
            //    this.Invalidate();
            //} else
            //{
            //    checkedinCheckBox.Checked = false;
            //    this.Invalidate();
            //}
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
            //int rowIndex = (n-1);


            this.Refresh();
            
        }
    }
}
