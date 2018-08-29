<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Summary.aspx.cs" Inherits="RS2015_Checkin.Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="TotalLabel" runat="server" Text="總報名人數：" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                <asp:Label ID="CurrentLabel" runat="server" Text="已報名人數：" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="Submit" runat="server" Text="更新" />
    </div>
    </form>
</body>
</html>
