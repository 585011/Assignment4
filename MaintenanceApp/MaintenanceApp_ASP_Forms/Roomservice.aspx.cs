using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaintenanceApp_ASP_Forms
{
    public partial class Roomservice : Page
    {
        Oblig4Entities data;
        List<Tasks> newTasks;
        List<Tasks> inProgTasks;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instantiate
            data = new Oblig4Entities();
            List<Tasks> tasks = data.Tasks.ToList().Select(t => t).Where(t => t.task.Equals("Roomservice")).ToList();
            newTasks = tasks.Select(t => t).Where(t => t.stat.Equals("New")).ToList();
            inProgTasks = tasks.Select(t => t).Where(t => t.stat.Equals("In progress")).ToList();

            // Lists
            if (!IsPostBack)
            {
                RefreshLists();
            }

            if (!DropDownList2.Items[0].Text.Equals("No tasks in progress"))
            {
                int taskID = inProgTasks.Find(t => (t.roomID + ", " + t.deskcomment).Equals(DropDownList2.SelectedValue)).serviceID;
                Label1.Text = data.Tasks.Find(taskID).servicecomment;
            }           
        }

        protected void RefreshLists ()
        {
            DropDownList1.Items.Clear();
            foreach (Tasks task in newTasks)
            {
                DropDownList1.Items.Add(task.roomID + ", " + task.deskcomment);
            }
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("No new tasks");
            }

            DropDownList2.Items.Clear();
            foreach (Tasks task in inProgTasks)
            {
                DropDownList2.Items.Add(task.roomID + ", " + task.deskcomment);
            }
            if (DropDownList2.Items.Count == 0)
            {
                DropDownList2.Items.Add("No tasks in progress");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!DropDownList1.Items[0].Text.Equals("No new tasks"))
            {
                int taskID = newTasks.Find(t => (t.roomID + ", " + t.deskcomment).Equals(DropDownList1.SelectedValue)).serviceID;
                data.Tasks.Find(taskID).stat = "In progress";
                data.Tasks.Find(taskID).servicecomment = TextBox1.Text;
                data.SaveChanges();
                RefreshLists();
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!DropDownList2.Items[0].Text.Equals("No tasks in progress"))
            {
                int taskID = inProgTasks.Find(t => (t.roomID + ", " + t.deskcomment).Equals(DropDownList2.SelectedValue)).serviceID;
                data.Tasks.Find(taskID).stat = "Completed";
                data.SaveChanges();
                RefreshLists();
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}