<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WeHeMo.Web.Form.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui warning message">
        <i class="close icon"></i>
        <span runat="server" id="lblMessage"></span>
    </div>
    <form class="ui form" runat="server">
        <div class="field">
            <label>Email</label>
            <input runat="server" value="muhackgames@gmail.com" id="txtEmail" type="text" name="txtEmail" placeholder="Email">
        </div>
        <div class="field">
            <label>Şifre</label>
            <input runat="server" id="txtPassword" value="123" type="password" name="txtPassword" placeholder="Password">
        </div>
        <asp:Button OnClick="btnSend_Click" runat="server" ID="btnSend" CssClass="ui button" Text="Giriş Yap" />
    </form>
</asp:Content>
