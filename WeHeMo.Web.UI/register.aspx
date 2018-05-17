<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WeHeMo.Web.UI.register" %>

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

            <form class="ui form" runat="server">
                <div class="field">
                    <label>İsim</label>
                    <input runat="server" type="text" id="txt_name" name="name" placeholder="İsim" />
                </div>
                <div class="field">
                    <label>E-mail</label>
                    <input runat="server" type="text" id="txt_email" name="email" placeholder="E-mail" />
                </div>
                <div class="field">
                    <label>E-mail</label>
                    <input runat="server" type="password" id="txt_password" name="pass" placeholder="Şifre" />
                </div>
                <asp:Button OnClick="btnregisterclick" runat="server" ID="btnregister" CssClass="ui button green" Text="Kayıt Ol" />
            </form>

        </div>
    </div>
    <script src="scripts/jquery-3.1.1.min.js"></script>
    <script src="scripts/semantic.min.js"></script>


</body>
</html>
