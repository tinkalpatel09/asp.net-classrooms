<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectAssignmentForm.aspx.cs" Inherits="reviewmidterm.ProjectAssignmentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 170px;
        }
        .auto-style2 {
            width: 211px;
        }
        .auto-style3 {
            width: 251px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            width: 211px;
            height: 22px;
            text-align: center;
        }
        .auto-style6 {
            width: 251px;
            height: 22px;
            text-align: right;
        }
        .auto-style7 {
            height: 22px;
            text-align: center;
        }
        .auto-style8 {
            position: absolute;
            top: 149px;
            left: 423px;
            z-index: 1;
        }
    </style>
</head>
<body style="z-index: 1; width: 729px; height: 149px; position: absolute; top: 111px; left: 46px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="4">
                    <asp:Label ID="Label1" runat="server" Text="Project Assignment"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Select Student"></asp:Label>
                </td>
                <td class="auto-style3" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Select Project"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnAssignProject" runat="server" Text="Assign Project" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownStudent" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3" colspan="2">
                    <asp:DropDownList ID="DropDownProject" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="Assignment Date"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" colspan="2">
                    <asp:TextBox ID="TextBoxAssigndate" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnlistProject" runat="server" Text="List Project" Width="129px" />
                </td>
                <td class="auto-style6" colspan="2">
                    <asp:Button ID="btnListStudent" runat="server" CssClass="auto-style8" Text="List Student" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridViewProject" runat="server">
                    </asp:GridView>
                </td>
                <td colspan="2">
                    <asp:GridView ID="GridViewStudent" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
