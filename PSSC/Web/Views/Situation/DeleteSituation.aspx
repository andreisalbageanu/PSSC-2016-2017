<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Situation>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    DeleteSituation
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>DeleteSituation</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Situation</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.StudentName) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StudentName) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.SubjectName) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.SubjectName) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ExamGrade) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ExamGrade) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ActivityGrade) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ActivityGrade) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Professor) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Professor) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ExamAverage) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ExamAverage) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Situatie") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
