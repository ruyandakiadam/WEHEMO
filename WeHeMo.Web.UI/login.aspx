<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WeHeMo.Web.UI.login" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link href="content/semantic.min.css" rel="stylesheet" />
</head>
<body>
    <div class="ui container">
        <div class="ui center aligned container" style="margin-top: 10px;">
        <div class="ui introduction">
            <h2 class="ui center aligned icon header red">
                <i class="send icon"></i>
                WeHeMo
            </h2>
        </div>
    </div>
        <div class="ui segment" style="margin-top: 20px">
            <div class="ui warning message" runat="server" id="warning" style="display: none">
                <i class="close icon"></i>
                <span runat="server" id="lblMessage"></span>
            </div>
            <form class="ui form" runat="server">
                <div class="field">
                    <label>Email</label>
                    <input runat="server" id="txtEmail" type="text" name="email" placeholder="Email" />
                </div>
                <div class="field">
                    <label>Password</label>
                    <input type="password" runat="server" id="txtpassword" name="password" placeholder="Password" />
                </div>

                <asp:Button OnClick="btnSendClick" runat="server" ID="btnSend" CssClass="ui positive button" Text="Giriş" />
                <div class="item">
                    <hr style="color: aqua" />
                    <p>Hala üye değil misin?</p>
                    <asp:Button OnClick="btnRegisterClick" runat="server" ID="btnrgstr" CssClass="negative ui button" Text="Kayıt ol" />
                    <i class="add user icon"></i>
                </div>
            </form>
        </div>
    </div>
    <script src="scripts/jquery-3.1.1.min.js"></script>
    <script src="scripts/semantic.min.js"></script>


</body>
</html>
