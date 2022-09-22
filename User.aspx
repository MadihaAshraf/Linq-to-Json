<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 222px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <table>
            <tr>
                <td class="auto-style1">ID</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Name</td>
                <td>&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" CssClass="auto-style4" OnClick="btnInsert_Click" Text="Insert" />
                    <asp:Button ID="BtnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                    <asp:Button ID="BtnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                    <asp:Button ID="BtnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                </td>
            </tr>
        </table>
        <asp:TextBox ID="txtMain" runat="server" CssClass="auto-style2" Height="143px" Rows="10" TextMode="MultiLine" Width="729px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSaveToFile" runat="server" CssClass="auto-style3" OnClick="btnSaveToFile_Click" Text="Save To File" />
        <br />
        <br />
        <br />
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
