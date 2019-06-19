<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataAccess.aspx.cs" Inherits="WebFormUI.DataAccess" %>

<!DOCTYPE html>

<html lang="en">

<head runat="server">
    <title>Login V3</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="FrontEndTolling/images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/fonts/iconic/css/material-design-iconic-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/css/util.css">
    <link rel="stylesheet" type="text/css" href="FrontEndTolling/css/main.css">
    <!--===============================================================================================-->
</head>

<body>
    <div class="limiter">
        <div class="container-login100" style="background-image: url('FrontEndTolling/images/bg-01.jpg');">
            <div class="wrap-login100">
                <form class="login100-form validate-form" id="Form1" runat="server">
                    <div class="wrap-exit100">
                         <span class="login100-form-exit">
                            <button runat="server" id="btnExit" onserverclick="btnExit_Click">
                                <i class="zmdi zmdi-close"></i>
                            </button>
                        </span>
                        <span class="login100-form-back">
                            <button runat="server" id="btnBack" onserverclick="btnBack_Click">
                                <i class="zmdi zmdi-arrow-left"></i>
                            </button>
                        </span>
                        <span class="login100-user-title">Hoş Geldin
                            <asp:Label ID="lblUserTitle" Text="" runat="server"> </asp:Label>
                        </span>
                    </div>
                    <div class="wrap-form100">
                        <span class="login100-form-logo">
                            <i class="zmdi zmdi-remote-control-alt"></i>
                        </span>
                        <span class="login100-form-title p-b-34 p-t-27">Menus
                        </span>
                        <div class="container-login100-form-btn p-b-34 p-t-27">
                            <span class="login100-form-btn">
                                <asp:Button ID="btnInsert" Text="Ekle" runat="server" CssClass="Btn-reset100" OnClick="btnInsert_Click" />
                            </span>
                        </div>
                        <div class="container-login100-form-btn p-b-34 p-t-27">
                            <span class="login100-form-btn">
                                <asp:Button ID="btnViewBtn" Text="Görüntüle" runat="server" CssClass="Btn-reset100" OnClick="btnView_Click" />
                            </span>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/animsition/js/animsition.min.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/bootstrap/js/popper.js"></script>
    <script src="FrontEndTolling/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/daterangepicker/moment.min.js"></script>
    <script src="FrontEndTolling/vendor/daterangepicker/daterangepicker.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/vendor/countdowntime/countdowntime.js"></script>
    <!--===============================================================================================-->
    <script src="FrontEndTolling/js/main.js"></script>
</body>

</html>
