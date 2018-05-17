<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="WeHeMo.Web.UI.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui container">
    <form class="ui form" runat="server">
  <div class="field">
    <label>İsim</label>
    <input runat="server" id="txtname" type="text" name="name" placeholder="İsim"/>
  </div>
  <div class="field">
    <label>E-mail</label>
    <input runat="server" id="txtemail" type="text" name="email" placeholder="E-mail"/>
  </div>
 <div class="field">
    <label>Şifre</label>
    <input runat="server" type="password" id="txtpassword" name="email" placeholder="Şifre"/>
  </div>
  <asp:Button OnClick="btnUpdateClick" runat="server" ID="btnupdate" CssClass="positive ui button" Text="Güncelle" />
</form>
    </div>

</asp:Content>
