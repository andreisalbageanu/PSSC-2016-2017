<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.Situation>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Situatie
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Situatie</h2>

<p>
    <%: Html.ActionLink("Create New", "CreateSituation") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.StudentName) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.SubjectName) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.ExamGrade) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.ActivityGrade) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Professor) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.ExamAverage) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.StudentName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.SubjectName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ExamGrade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ActivityGrade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Professor) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ExamAverage) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "EditSituation", new { id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "DeleteSituation", new { id=item.Id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
