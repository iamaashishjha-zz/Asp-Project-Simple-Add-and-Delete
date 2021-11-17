<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Test_WAPP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Wapp</title>
    <style type="text/css">
        .auto-style2 {
            width: 101px;
        }
        .auto-style3 {
            width: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:darkred; text-align:center;">List Items Switching</h1>
            
            <table class="auto-style2" border="0" align = "center">
                <tr>
                    <td class="auto-style2">
                        <br />
                        <asp:TextBox ID="txtData1" runat="server" Width="300px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btnAdd1" runat="server" Text="Add" Width="300px" OnClick="btnAdd1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="lblCount1" runat="server" Width="300px"></asp:Label>
                        <br />
                        <br />
                        <asp:ListBox ID="ListBox2" runat="server" Height="300px" Width="300px" SelectionMode="Multiple" AppendDataBoundItems="True">
                            <asp:ListItem>Orange</asp:ListItem>
                            <asp:ListItem>Apple</asp:ListItem>
                            <asp:ListItem>Grape</asp:ListItem>
                            <asp:ListItem>Mango</asp:ListItem>
                            <asp:ListItem>Banana</asp:ListItem>
                        </asp:ListBox>
                        <br />
                        <br />
                        <asp:Button ID="btnDelete1" runat="server" OnClick="btnDelete1_Click" Text="Delete" Width="300px" />
                        <br />
                        <br />
                        <asp:Button ID="btnDelete3" runat="server" OnClick="btnDelete3_Click" Text="Delete All" Width="300px" />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style2">
                        <br />
                        <asp:CheckBox ID="chSelected" runat="server" Text="Selected" Width="150px" align="center"/>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btnMove1" runat="server" OnClick="btnMove1_Click" Text="&gt;" Width="150px" />
                        <br />
                        <br />
                        <asp:Button ID="btnMove2" runat="server" OnClick="btnMove2_Click" Text="&lt;" Width="150px" />
                        <br />
                        <br />
                        <asp:Button ID="btnMove3" runat="server" OnClick="btnMove3_Click" Text="&gt;&gt;" Width="150px" />
                        <br />
                        <br />
                        <asp:Button ID="btnMove4" runat="server" OnClick="btnMove4_Click" Text="&lt;&lt;" Width="150px" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtData2" runat="server" Width="300px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btnAdd2" runat="server" Text="Add" Width="300px" OnClick="btnAdd2_Click" />
                        <br />
                        <br />
                        <asp:Label ID="lblCount2" runat="server" Width="300px"></asp:Label>
                        <br />
                        <br />
                        <asp:ListBox ID="ListBox3" runat="server" Height="300px" Width="300px" SelectionMode="Multiple">
                            <asp:ListItem>Red</asp:ListItem>
                            <asp:ListItem>Blue</asp:ListItem>
                            <asp:ListItem>Black</asp:ListItem>
                            <asp:ListItem>Green</asp:ListItem>
                            <asp:ListItem>Yellow</asp:ListItem>
                        </asp:ListBox>
                        <br />
                        <br />
                        <asp:Button ID="btnDelete2" runat="server" OnClick="btnDelete2_Click" Text="Delete" Width="300px" />
                        <br />
                        <br />
                        <asp:Button ID="btnDelete4" runat="server" OnClick="btnDelete4_Click" Text="Delete All" Width="300px" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
