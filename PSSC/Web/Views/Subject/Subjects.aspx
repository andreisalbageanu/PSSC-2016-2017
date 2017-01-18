<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.Subject>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Subjects
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Subjects</h2>

<p>
    <%: Html.ActionLink("Create New", "CreateSubject") %>
   
</p>


<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Name) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Credits) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Professor) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.EvaluationType) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.LaboratoryProportion) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.CourseHours) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Name) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Credits) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Professor) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.EvaluationType) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.LaboratoryProportion) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CourseHours) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "EditSubject", new { id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "DeleteSubject", new { id=item.Id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
