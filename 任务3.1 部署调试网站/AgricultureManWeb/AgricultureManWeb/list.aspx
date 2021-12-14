<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebApplication1.list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action=list.aspx>
    <div>
    <style> 
        table td{ border: 1px solid #000; }
        .style1
        {
            height: 22px;
        }
    </style> 
    <div>
     <table width="100%" border="0" cellpadding="0" cellspacing="0">
      <tbody>
       <tr class="Gray"> 
         <td align="center" style="padding: 0px"> <strong>学号</strong> </td> 
         <td align="center" style="padding: 0px"> <strong>姓名</strong> </td>
         <td align="center" style="padding: 0px"> <strong>操作</strong> </td>
       </tr> 
       <%--这个是重复显示内容的控件--%> 
       <asp:Repeater ID="repList" runat="server" OnItemCommand="repList_ItemCommand"> 
       <ItemTemplate> 
       <tr>
        <td class="zimu"> <%# Eval("opername")%> </td>
        <td align="center"> <%# Eval("operpwd")%> </td>
        <td align="center" class="chaozuo_txt"> <a href='showorder.aspx?opername=<%# Eval("opername")%>&operid=<%# Eval("operid")%>'>查看</a> </td>
       </tr>
       </ItemTemplate>
        </asp:Repeater>
         </tbody>
          </table>
    </div>
    </div>

    </form>
</body>
</html>
