<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WeHeMo.Web.UI._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script>
                    function send() {
                        var id = document.getElementById("guidtest").textContent;
                        window.location = "testreport.apsx?test=id";

                    }
                </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table class="ui celled striped table">
        <thead>
            <tr>
                <th style="display:none">Guid</th>
                <th>Url</th>
                <th>Status Code</th>
                <th>Status</th>
                <th>Test Tarihi</th>
                <th>Rapor</th>
                <th>Sil</th>
            </tr>
        </thead>    <!-- <td id="buton" ><asp:Button runat="server" ID="btn"  SkinID='<%# Eval("Id") %>' Text="Kayıt Ol"/> </td> -->
        <tbody >  <!--<td id="delete" runat="server"><a href="default.aspx?id=<%# Eval("Id") %>"><i class="remove icon" style="color:darkred" ></i></a></td> -->
            <asp:Repeater runat="server" ID="repeatTestList" OnItemDataBound="repeatTestList_ItemDataBound">
               
                <ItemTemplate runat="server">
                    <tr id="row" runat="server">
                       <td id="guidtest"  style="display:none" ><%# Eval("Id") %></td>
                        <td id="url"><%# Eval("Url") %></td>
                        <td id="statuscode" ><%# Eval("Code") %></td>
                        <td id="description" ><%# Eval("Status") %></td>
                        <td id="testdate"><%# Eval("Date") %></td> 
                        <td id="report" > <a href="testreport.aspx?id=<%# Eval("Id") %>"><i class="calendar icon"  style="color:skyblue"></i></a></td>
                        <td><asp:LinkButton ID="delete" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="delete_Click"><i class="remove icon" style="color:darkred" ></i></asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    </form>
</asp:Content>
