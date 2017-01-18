<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Situation>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    EditSituation
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>EditSituation</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Situation</legend>

        <%: Html.HiddenFor(model => model.Id) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.StudentName) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.StudentName) %>
            <%: Html.ValidationMessageFor(model => model.StudentName) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.SubjectName) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.SubjectName) %>
            <%: Html.ValidationMessageFor(model => model.SubjectName) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ExamGrade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ExamGrade) %>
            <%: Html.ValidationMessageFor(model => model.ExamGrade) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ActivityGrade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ActivityGrade) %>
            <%: Html.ValidationMessageFor(model => model.ActivityGrade) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Professor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Professor) %>
            <%: Html.ValidationMessageFor(model => model.Professor) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ExamAverage) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ExamAverage) %>
            <%: Html.ValidationMessageFor(model => model.ExamAverage) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Situatie") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
