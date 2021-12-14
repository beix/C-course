<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="my_login.reset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>重置密码</title>
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
                                <h4 class="card-title">重置密码</h4>
                                <div class="form-group">
                                    <label for="new-password">新密码</label>
                                    <input id="new_password" type="password" class="form-control" name="password" required autofocus data-eye runat="server" />
                                    <div class="form-text text-muted">
                                        确保密码强度足够并易于记忆
                                    </div>
                                </div>

                                <div class="form-group no-margin">
                                    <asp:Button ID="bt_Reset" runat="server" Text="重置密码" CssClass="btn btn-primary btn-block" OnClick="bt_Reset_Click" />
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