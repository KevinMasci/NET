<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="LabGrillaASP.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdUsuarios" runat="server">
            </asp:GridView>
            <asp:ObjectDataSource ID="odsUsuarios" runat="server"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
