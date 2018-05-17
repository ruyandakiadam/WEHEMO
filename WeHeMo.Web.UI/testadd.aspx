<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="testadd.aspx.cs" Inherits="WeHeMo.Web.UI.testadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui container">
        <form class="ui form" runat="server">
            <div class="field" runat="server">
                <label>Url</label>
                <input runat="server" id="txturl" type="text" name="url" placeholder="Url"/>
            </div>
            <asp:Button OnClick="btnTestAdd" runat="server" ID="btntestadd" CssClass="ui positive button" Text="Test Ekle" />
        </form>
    </div>
</asp:Content>
