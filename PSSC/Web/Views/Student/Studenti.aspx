<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.Student>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Studenti
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Studenti</h2>

<p>
    <%: Html.ActionLink("Create New", "CreateStudent") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.RegNo) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Name) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Credits) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.RegNo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Name) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Credits) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "EditStudent", new { id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "DeleteStudent", new { id=item.Id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
