<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Subject>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CreateSubject
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>CreateSubject</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Subject</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Credits) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Credits) %>
            <%: Html.ValidationMessageFor(model => model.Credits) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Professor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Professor) %>
            <%: Html.ValidationMessageFor(model => model.Professor) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.EvaluationType) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.EvaluationType) %>
            <%: Html.ValidationMessageFor(model => model.EvaluationType) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.LaboratoryProportion) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.LaboratoryProportion) %>
            <%: Html.ValidationMessageFor(model => model.LaboratoryProportion) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CourseHours) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CourseHours) %>
            <%: Html.ValidationMessageFor(model => model.CourseHours) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Subjects") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
