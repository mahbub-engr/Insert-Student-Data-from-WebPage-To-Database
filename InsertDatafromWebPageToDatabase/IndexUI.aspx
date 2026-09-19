<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="InsertDatafromWebPageToDatabase.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NameText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Age" runat="server" Text="Age:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AgeText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="RegNo" runat="server" Text="Registration Number:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="RegText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Depertment" runat="server" Text="Depertment:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="DeptText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Address" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AddressText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="OutputLabel" runat="server" Text="Output"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
