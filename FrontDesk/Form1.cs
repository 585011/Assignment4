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
        public Form1()
        {
            InitializeComponent();
            db = new Oblig4Entities();
            bookList = db.Bookings.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oblig4DataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.oblig4DataSet.Bookings);

        }

        private void bookingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oblig4DataSet);

        }

        private void checkedinCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            Oblig4Entities db = new Oblig4Entities();
            List<Bookings> bookList = db.Bookings.ToList();

            if (checkedinCheckBox.CheckState == System.Windows.Forms.CheckState.Checked) 
            {
                int nn = int.Parse(bookingIDTextBox.Text);
                int book = bookList.Find(b => (b.bookingID.Equals(nn))).bookingID;
                db.Bookings.Find(book).checkedin = DateTime.Now;
                db.SaveChanges();
                checkedinCheckBox.Checked = true;

                //book.checkedin.Value = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                //bookList.Find(b => b.bookingID.Equals(nn)).checkedin.Value.;
            }
        }

        private void checkedoutCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            Oblig4Entities db = new Oblig4Entities();
            List<Bookings> bookList = db.Bookings.ToList();

            if (checkedoutCheckBox.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                int nn = int.Parse(bookingIDTextBox.Text);
                int book = bookList.Find(b => (b.bookingID.Equals(nn))).bookingID;
                db.Bookings.Find(book).checkedout = DateTime.Now;
                db.SaveChanges();

                //book.checkedin.Value = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                //bookList.Find(b => b.bookingID.Equals(nn)).checkedin.Value.;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
