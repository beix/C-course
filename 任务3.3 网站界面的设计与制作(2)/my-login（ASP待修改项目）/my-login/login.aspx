<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="my_login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <link href="Content/my-login.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body class="my-login-page">
    <form id="form2" runat="server">
        <section class="h-100">
            <div class="container h-100">
                <div class="row justify-content-md-center h-100">
                    <div class="card-wrapper">
                        <div class="brand">
                            <img src="Images/logo.png" />
                        </div>
                        <div class="card fat">
                            <div class="card-body">
                                <h4 class="card-title">登录</h4>
                                <div class="form-group">
                                    <label for="email">邮件地址</label>
                                    <input id="email" type="email" class="form-control" name="email" value="" required autofocus runat="server"/>
                                </div>

                                <div class="form-group">
                                    <label for="password">
                                        密码
                                    </label>
                                    <input id="password" type="password" class="form-control" name="password" required data-eye runat="server"/>
                                </div>

                                <div class="form-group">
                                    <label>
                                        <input type="checkbox" name="remember" />
                                        记住我
                                        <a href="forgot.aspx" class="float-right">忘记密码?
                                        </a>
                                    </label>
                                </div>

                                <div class="form-group no-margin">
                                    <asp:Button ID="bt_Login" runat="server" Text="登录" CssClass="btn btn-primary btn-block" OnClick="bt_Login_Click"/>
                                </div>
                                <div class="margin-top20 text-center">
                                    没有账户? <a href="register.aspx">注册</a>
                                </div>
                            </div>
                        </div>
                        <div class="footer">
                            Copyright &copy; 2018 &mdash; CQCET-IOT
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>