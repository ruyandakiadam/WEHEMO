<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WeHeMo.Web.Form._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="ui celled striped table">
        <thead>
            <tr>
                <th>Guid</th>
                <th>Url</th>
                <th>Staus</th>
                <th>Description</th>
                <th>Test Date</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="repeatTestList" OnItemDataBound="repeatTestList_ItemDataBound">
                <ItemTemplate>
                    <tr id="row" runat="server">
                        <td id="guid" runat="server"><%# Eval("Guid") %></td>
                        <td id="url" runat="server"><%# Eval("Url") %></td>
                        <td id="status" runat="server"><%# Eval("Status") %></td>
                        <td id="description" runat="server"><%# Eval("Description") %></td>
                        <td id="testdate" runat="server"><%# Eval("TestDate") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
