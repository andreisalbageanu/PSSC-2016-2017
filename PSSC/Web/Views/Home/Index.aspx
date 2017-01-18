<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.Professor>>" %> 

    <asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

       Index

    </asp:Content> 

    <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
        

        <h2>Professori</h2> 



        <p>
    <%: Html.ActionLink("Create New", "CreateProfesor") %>
     
</p>

       
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Name) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.CNP) %>
        </th>
        
        <th></th>
    </tr>
   
        


        <% foreach (var item in Model) { %>

        

            <tr>

               

               

                <td>

                    <%= Html.Encode(item.CNP) %>

                </td>

                <td>

                    <%= Html.Encode(item.Name) %>

                </td>
                <td>
            <%: Html.ActionLink("Edit", "EditProfessor", new { id=item.Id }) %> |
          
            <%: Html.ActionLink("Delete", "DeleteProfessor", new { id=item.Id }) %>
        </td>
                

            </tr>

        

        <% } %> 

        </table> 

        

    </asp:Content> 