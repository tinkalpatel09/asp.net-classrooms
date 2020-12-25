<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseWebform.aspx.cs" Inherits="StroedProcedure.GUI.CourseWebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 67%;
            height: 117px;
            position: absolute;
            top: 119px;
            left: 204px;
            z-index: 1;
        }
        .auto-style2 {
            width: 226px;
        }
        .auto-style3 {
            width: 281px;
        }
        .auto-style4 {
            width: 211px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="CourseCode"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtboxCourseCode" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="CourseTitle"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtboxCTitle" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Btnupdate" runat="server" OnClick="Btnupdate_Click" Text="Update" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Duration"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtboxduration" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Btndelete" runat="server" OnClick="Btndelete_Click" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save Course" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
