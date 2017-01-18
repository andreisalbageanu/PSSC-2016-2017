<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Student>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    DeleteStudent
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>DeleteStudent</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Student</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.RegNo) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RegNo) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Name) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Name) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Credits) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Credits) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Studenti") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
