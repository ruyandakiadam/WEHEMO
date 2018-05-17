<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="testreport.aspx.cs" Inherits="WeHeMo.Web.UI.testreport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="ui celled striped table">
        <thead>
            <tr>
               
                <th>Test Tarihi</th>
                <th>Açıklama</th>

            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="repeatTestReport" OnItemDataBound="repeatTestReport_ItemDataBound">
                <ItemTemplate>
                    <tr id="row" runat="server">
                        
                        <td id="testdate" runat="server"><%# Eval("TestDate") %></td>
                        <td id="description" runat="server"><%# Eval("Description") %></td>
                      
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
