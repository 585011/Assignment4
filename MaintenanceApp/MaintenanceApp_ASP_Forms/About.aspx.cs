using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaintenanceApp_ASP_Forms
{
    public partial class About : Page
    {
        
        Oblig4Entities data;
        List<Tasks> newTasks;
        List<Tasks> inProgTasks;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instantiate
            data = new Oblig4Entities();
            List<Tasks> tasks = data.Tasks.ToList().Select(t => t).Where(t => t.task.Equals("Cleaning")).ToList();
            newTasks = tasks.Select(t => t).Where(t => t.stat.Equals("New")).ToList();
            inProgTasks = tasks.Select(t => t).Where(t => t.stat.Equals("In progress")).ToList();

            // Lists
            if (!IsPostBack)
            {
                RefreshLists();
            }

            if (!DropDownListInProgressTasks.Items[0].Text.Equals("No tasks in progress"))
            {
                int taskID = inProgTasks.Find(t => (t.roomID + ", desk comment: " + t.deskcomment).Equals(DropDownListInProgressTasks.SelectedValue)).serviceID;
                ServiceComment.Text = data.Tasks.Find(taskID).servicecomment;
            }
            
        }
        protected void RefreshLists()
        {
            DropDownListNewTasks.Items.Clear();
            foreach (Tasks task in newTasks)
            {
                DropDownListNewTasks.Items.Add(task.roomID + ", desk comment: " + task.deskcomment);
            }
            if (DropDownListNewTasks.Items.Count == 0)
            {
                DropDownListNewTasks.Items.Add("No new tasks");
            }

            DropDownListInProgressTasks.Items.Clear();
            foreach (Tasks task in inProgTasks)
            {
                DropDownListInProgressTasks.Items.Add(task.roomID + ", desk comment: " + task.deskcomment);
            }
            if (DropDownListInProgressTasks.Items.Count == 0)
            {
                DropDownListInProgressTasks.Items.Add("No tasks in progress");
            }
        }

        protected void StartTaskBtn_Click(object sender, EventArgs e)
        {
            if (!DropDownListNewTasks.Items[0].Text.Equals("No new tasks"))
            {
                int taskID = newTasks.Find(t => (t.roomID + ", desk comment: " + t.deskcomment).Equals(DropDownListNewTasks.SelectedValue)).serviceID;
                data.Tasks.Find(taskID).stat = "In progress";
                data.Tasks.Find(taskID).servicecomment = TextBox1.Text;
                data.SaveChanges();
                RefreshLists();
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void CompleteTaskBtn_Click(object sender, EventArgs e)
        {
            if (!DropDownListInProgressTasks.Items[0].Text.Equals("No tasks in progress"))
            {
                int taskID = inProgTasks.Find(t => (t.roomID + ", " + t.deskcomment).Equals(DropDownListInProgressTasks.SelectedValue)).serviceID;
                data.Tasks.Find(taskID).stat = "Completed";
                data.SaveChanges();
                RefreshLists();
                Response.Redirect(Request.RawUrl);
            }
        }
    }

}