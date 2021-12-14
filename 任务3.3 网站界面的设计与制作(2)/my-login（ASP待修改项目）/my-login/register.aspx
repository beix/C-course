<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="my_login.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册</title>
    <link href="Content/my-login.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body class="my-login-page">
    <form id="form1" runat="server">
        <section class="h-100">
            <div class="container h-100">
                <div class="row justify-content-md-center h-100">
                    <div class="card-wrapper">
                        <div class="brand">
                            <img src="Images/logo.png" />
                        </div>
                        <div class="card fat">
                            <div class="card-body">
                                <h4 class="card-title">注册</h4>
                                <div class="form-group">
                                    <label for="name">姓名</label>
                                    <input id="name" type="text" class="form-control" name="name" required autofocus runat="server" />
                                </div>

                                <div class="form-group">
                                    <label for="email">邮箱地址</label>
                                    <input id="email" type="email" class="form-control" name="email" required runat="server" />
                                </div>

                                <div class="form-group">
                                    <label for="password">密码</label>
                                    <input id="password" type="password" class="form-control" name="password" required data-eye runat="server" />
                                </div>

                                <div class="form-group">
                                    <label>
                                        <input type="checkbox" name="aggree" value="1" />
                                        同意条款
                                    </label>
                                </div>

                                <div class="form-group no-margin">
                                    <asp:Button ID="bt_Register" runat="server" Text="注册" CssClass="btn btn-primary btn-block" OnClick="bt_Register_Click" />
                                </div>
                                <div class="margin-top20 text-center">
                                    已经有账户了? <a href="index.aspx">登录</a>
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