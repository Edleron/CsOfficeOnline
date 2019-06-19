<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewExpences.aspx.cs" Inherits="WebFormUI.ViewExpences" %>

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
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <!--===============================================================================================-->
    <link href="//cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/build/css/bootstrap-datetimepicker.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" media="screen" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css">
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
                        <span class="login100-form-title p-b-34 p-t-27">View Project
                        </span>

                        <div class="container">
                            <div class="row">
                                <div class="col-sm-3">
                                    <div class="form-group">
                                        <label>Başlangıç Tarihi </label>
                                        <div class="input-group date" id="datetimepicker6">
                                            <input name="dateTimePickerf1" type="text" class="form-control" required />
                                            <span class="input-group-addon">
                                                <span class="glyphicon glyphicon-calendar"></span>
                                            </span>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-3">
                                    <div class="form-group">
                                        <label>Bitiş Tarihi</label>
                                        <div class="input-group date" id="datetimepicker7">
                                            <input name="dateTimePickerf2" type="text" class="form-control" required  />
                                            <span class="input-group-addon">
                                                <span class="glyphicon glyphicon-calendar"></span>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                         <div class="container-login100-form-btn p-b-34 p-t-27">
                            <span class="login100-form-btn">
                                <asp:Button ID="btnViewBtn" Text="Görüntüle" runat="server" CssClass="Btn-reset100" OnClick="btnView_Click" />
                            </span>
                        </div>

                        <div style="margin-top: 20px;">
                            <table class="table table-bordered">
                                <tr style="color: white; font-size: 14px">
                                    <th>Gider İsmi</th>
                                    <!--<th>Kategori Türü</th>-->
                                    <th>Gider Fiyatı</th>
                                    <th>Açıklama</th>
                                    <th>Tarih</th>
                                    <th>Gider Belgesi</th>
                                    <!--<th>Gider Sahibi</th>-->
                                </tr>
                                <asp:Repeater ID="RepaterDataSet" runat="server">
                                    <ItemTemplate>
                                        <tr style="color: white; font-size: 12px">
                                            <td><%# Eval("ExpenselName") %></td>
                                            <!--<td><%# Eval("CategoryId") %></td>-->
                                            <td><%# Eval("UnitPrice") %></td>
                                            <td><%# Eval("Explanation") %></td>
                                            <td><%# Eval("DateOperation","{0: yyyy.MM.dd}") %></td>
                                            <td>Göster</td>
                                            <!--<td><%# Eval("PersonId") %></td>-->
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>
                        </div>

                        <div class="text-center p-t-90">
                            <div id="lblInformationCss" runat="server">
                                <asp:Label ID="lblInformation" Text="" runat="server" ForeColor="White"> </asp:Label>
                            </div>
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
    <!--===============================================================================================-->

    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="//cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/src/js/bootstrap-datetimepicker.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/moment.js/2.9.0/moment-with-locales.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(function () {
            $('#datetimepicker6').datetimepicker({
            });
            $('#datetimepicker7').datetimepicker({
                useCurrent: false
            });
            $("#datetimepicker6").on("dp.change", function (e) {
                $('#datetimepicker7').data("DateTimePicker").minDate(e.date);
            });
            $("#datetimepicker7").on("dp.change", function (e) {
                $('#datetimepicker6').data("DateTimePicker").maxDate(e.date);
            });
        });
    </script>

</body>

</html>

