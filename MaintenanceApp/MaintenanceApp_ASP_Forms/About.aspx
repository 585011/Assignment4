<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MaintenanceApp_ASP_Forms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div><b>List of new tasks:</b></div>
    <asp:DropDownList ID="DropDownListNewTasks" runat="server"/>
    <br />
    <br />
    <div>Add a comment:&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="16px"/> </div>
    <asp:Button ID="StartTaskBtn" runat="server" OnClick="StartTaskBtn_Click" Text="Start the task" />
    <br />
    <br />
     <div><b>List of tasks in progress:</b></div>
    <asp:DropDownList ID="DropDownListInProgressTasks" runat="server"/>
    <br />
    <br />
    <p>Service comment for this task:&nbsp; <asp:Label ID="ServiceComment" runat="server" Text="Label"/></p>
     <br />
    <asp:Button ID="CompleteTaskBtn" runat="server" OnClick="CompleteTaskBtn_Click" Text="Complete the task" />
     <br />
</asp:Content>
