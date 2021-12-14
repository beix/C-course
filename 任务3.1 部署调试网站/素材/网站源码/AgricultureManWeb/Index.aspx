<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Style.css" rel="stylesheet" type="text/css" />
    <title>智能农业管理平台-首页</title>
</head>
<body style="background: url(images/body_bg2.gif);">
 
<div style="background: url(images/header.gif) no-repeat; width:100%; height:70px;"></div>
<div class="header">
<span class="floatrigth">&nbsp;&nbsp;<img src="images/arrow.gif" />&nbsp;修改密码&nbsp;&nbsp;<img src="images/arrow.gif" />&nbsp;退出&nbsp;&nbsp;</span>&nbsp;&nbsp;<img src="images/arrow.gif"/>&nbsp;Test001&nbsp;&nbsp;<img src="images/arrow.gif" />&nbsp;欢迎你&nbsp;&nbsp;<img src="images/arrow.gif" />&nbsp;现在是2018年08月26日
</div>
<div style="background:url(imags/body_bg1.gif) repeat-x; width:100%; height:5px;"></div>
<form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager> 
<div style="margin:0 auto;width:1000px;">
    <div style=" margin-bottom:5px;">
        <table>
            <tr>
                <td>
                    <div class="SensorDetail">
                	<div class="Title">当前环境情况</div>
                      
       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
         <ContentTemplate>
             <asp:Timer ID="Timer2" runat="server" Interval="1000" ontick="Timer2_Tick"></asp:Timer>
                    <div class="SensorInfo">
                    	<table>
                        	<tr>
                            	<th style="text-align:right;width:40%">温度:</th>
                                <td>
                                    <asp:Label ID="LabTemp" runat="server" Text=""></asp:Label></td>                              
                            </tr>
                            <tr>
                            	<th style="text-align:right;width:40%">湿度:</th>
                                <td><asp:Label ID="LabHR" runat="server" Text=""></asp:Label></td>                            
                            </tr>
                            <tr>
                            	<th style="text-align:right;width:40%">光照:</th>
                                <td><asp:Label ID="LabLight" runat="server" Text=""></asp:Label></td>
                        	</tr>
                        </table>
                    </div>
              </ContentTemplate>
      </asp:UpdatePanel>
                </div>
                </td>
                 <td width="5">&nbsp;</td>
                <td>
                    <div class="Control">  
                	<div class="Title">设备控制</div>	
                    <div class="ControlInfo" style="text-align:center">
                    	<div><input type="button" class="InputButton" id="button1" value="遮阳篷" style="width:90px;margin:0 10px 10px 0;"/></div>
                        <div>
                        <input type="button" class="InputButton" value="水泵" width="90" style="width:90px;margin:0 10px 10px 0;"/>
                        
                        </div>
                        <div>
                          <input type="button" class="InputButton" value="风机" width="90" style="width:90px;margin:0 10px 10px 0;"/>
                          
                        </div>
                    </div>
                    <div class="ControlInfoDetail" style="display:none">
                    	<input type="button" class="InputButton" value="内遮阳1" style="width:90px;margin:0 10px 10px 0;"/>
                        <input type="button" class="InputButton" value="内遮阳2" style="width:90px;margin:0 10px 10px 0;"/>
                        <input type="button" class="InputButton" value="内遮阳3" style="width:90px;margin:0 10px 10px 0;"/>
                        <input type="button" class="InputButton" value="内遮阳4" style="width:90px;margin:0 10px 10px 0;"/>
                        <input type="button" class="InputButton" value="内遮阳5" style="width:90px;margin:0 10px 10px 0;"/>
                    </div>
                </div>
                </td>
            </tr>
        </table>
    </div>
    
    <div style="display:none">     
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
          <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick"></asp:Timer>
           update中的：<asp:Label  ID="Label2" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label  ID="Label1" runat="server" Text=""></asp:Label>
             <br />
          <asp:TextBox ID="txtRec" runat="server" Height="206px" Width="700px" TextMode="MultiLine"></asp:TextBox>
        </ContentTemplate>
      </asp:UpdatePanel>
    
    </div>
    </div>
</form>
</body>
</html>
