<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Style.css" rel="stylesheet" type="text/css" />
    <title>智能农业管理平台—用户登录</title>
     <style type="text/css">
        body {  margin:0px; padding:0px; background-size:100%;}
         
    </style>

</head>
<body>
    <form id="form1" runat="server">
     <div align="center" style=" margin-top:180px;" >
        <table style="width: 460px; background:url(Images/center-blue.png)">
             <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2"><img src="Images/title3.png" /></td>
            </tr>
            
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <table>
                        <tr>
                <td class="tdl">用户名：&nbsp;</td>
                <td><asp:TextBox ID="txtUserName" CssClass="txt" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdl">密&nbsp;码：&nbsp;</td>
                <td><asp:TextBox ID="txtUserPW" CssClass="txt" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:ImageButton ID="imgBtnLogin" runat="server" ImageUrl="Images/btn_register_normal.png" OnClick="imgBtnLogin_Click" /></td>
            </tr>
                    </table>
                </td>
            </tr>
            
            <tr >
                <td colspan="2" style="padding-top:40px;"></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
