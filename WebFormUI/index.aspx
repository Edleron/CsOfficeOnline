﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFormUI.index" %>

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
                <div class="wrap-exit100">
                    <span class="login100-form-exit">
                        <i class="zmdi zmdi-close"></i>
                    </span>
                </div>
                <div class="wrap-form100">
                    <form class="login100-form validate-form" id="Form1" runat="server">
                        <span class="login100-form-logo">
                            <i class="zmdi zmdi-remote-control-alt"></i>
                        </span>
                        <span class="login100-form-title p-b-34 p-t-27">Log in
                        </span>
                        <div class="wrap-input100 validate-input" data-validate="Enter username">
                            <input class="input100" type="text" name="txtUserName" placeholder="Username">
                            <span class="focus-input100" data-placeholder="&#xf207;"></span>
                        </div>
                        <div class="wrap-input100 validate-input" data-validate="Enter password">
                            <input class="input100" type="password" name="txtPass" placeholder="Password">
                            <span class="focus-input100" data-placeholder="&#xf191;"></span>
                        </div>
                        <div class="container-login100-form-btn">
                            <span class="login100-form-btn">
                                <asp:Button ID="btnLogin" Text="Login" runat="server" CssClass="Btn-reset100" OnClick="btnLogin_Click" />
                            </span>
                        </div>
                        <!--
                        <div class="container-login100-form-btn">
                            <span class="login100-form-btn">
                                <button>Login</button>
                            </span>
                        </div>
                         -->
                        <div class="text-center p-t-90">
                            <div id="txt1" runat="server">
                                Hatalı Şifre yada Parola !
                            </div>
                            <!--                                
                            <a class="txt1" href="#">
                                Forgot Password?
                            </a>
                            -->
                        </div>
                    </form>
                </div>
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

