<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCFTest.aspx.cs" Inherits="WCFClient.WCFTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtName" runat="server">
        </asp:TextBox>
        <asp:Button ID="btn" runat="server" Text="测试WCF服务" OnClick="btn_Click" />
    </div>
    </form>
</body>
</html>
