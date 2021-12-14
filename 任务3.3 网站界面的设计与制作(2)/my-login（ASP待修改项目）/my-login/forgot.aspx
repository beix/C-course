<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot.aspx.cs" Inherits="my_login.forgot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>忘记密码</title>
    <link href="Content/my-login.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body class="my-login-page">
    <form id="form1" runat="server">
        <section class="h-100">
            <div class="container h-100">
                <div class="row justify-content-md-center align-items-center h-100">
                    <div class="card-wrapper">
                        <div class="brand">
                            <img src="Images/logo.png" />
                        </div>
                        <div class="card fat">
                            <div class="card-body">
                                <h4 class="card-title">忘记密码</h4>
                                    <div class="form-group">
                                        <label for="email">邮箱地址</label>
                                        <input id="email" type="email" class="form-control" name="email" value="" required autofocus />
                                        <div class="form-text text-muted">
                                            点击“重置密码”按钮，我们将向您的邮箱发送一个重置链接
                                        </div>
                                    </div>

                                    <div class="form-group no-margin">
                                        <button type="submit" class="btn btn-primary btn-block" aria-orientation="horizontal">
                                            重置密码
                                        </button>
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
