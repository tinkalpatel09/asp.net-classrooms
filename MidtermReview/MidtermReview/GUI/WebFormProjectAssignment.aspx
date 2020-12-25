<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormProjectAssignment.aspx.cs" Inherits="MidtermReview.GUI.WebFormProjectAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            width: 29px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 29px;
            height: 23px;
        }
        .auto-style6 {
            width: 212px;
        }
        .auto-style7 {
            height: 23px;
            width: 212px;
        }
        .auto-style8 {
            width: 275px;
        }
        .auto-style9 {
            height: 23px;
            width: 275px;
        }
        .auto-style11 {
            width: 238px;
            font-size: medium;
            font-weight: bold;
        }
        .auto-style12 {
            font-size: medium;
        }
        .auto-style13 {
            width: 212px;
            font-size: medium;
            font-weight: bold;
        }
        .auto-style14 {
            width: 275px;
            font-size: medium;
            font-weight: bold;
        }
        .auto-style15 {
            height: 8px;
            width: 212px;
        }
        .auto-style16 {
            width: 29px;
            height: 8px;
        }
        .auto-style17 {
            height: 8px;
            width: 275px;
        }
        .auto-style18 {
            height: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Project Assignment</strong></td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13"><strong>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Text="Select Student"></asp:Label>
                </strong></td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style14"><strong>Select Project</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:DropDownList ID="DropDownListStudent" runat="server" DataSourceID="SqlDataSource1" DataTextField="StudentNumber" DataValueField="StudentNumber" Height="25px" Width="209px" AutoPostBack="true" OnSelectedIndexChanged="DropDownListStudent_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentProjectsDBConnectionString %>" SelectCommand="SELECT [StudentNumber] FROM [Students]"></asp:SqlDataSource>
            </td>
            <td class="auto-style16"></td>
            <td class="auto-style17">
                <asp:DropDownList ID="DropDownListProject" runat="server" DataSourceID="SqlDataSource2" DataTextField="ProjectCode" DataValueField="ProjectCode" Height="25px" Width="226px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListProject_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudentProjectsDBConnectionString2 %>" SelectCommand="SELECT [ProjectCode] FROM [Projects]"></asp:SqlDataSource>
            </td>
            <td class="auto-style18">
                <asp:Button ID="ButtonAssignProject" runat="server" Font-Bold="True" ForeColor="#3333CC" Height="33px" Text="Assign Project" Width="158px" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style6" rowspan="3">
                <asp:Label ID="LabelStudentInfo" runat="server" Text="Student Info"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8" rowspan="3">
                <asp:Label ID="LabelProjectInfo" runat="server" Text="Project Info"></asp:Label>
            </td>
            <td>
                <asp:Button ID="ButtonListProject" runat="server" Font-Bold="True" ForeColor="#3333CC" Height="34px" Text="List Projects" Width="158px" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonListStudent" runat="server" Font-Bold="True" ForeColor="#3333CC" Height="33px" Text="List Students" Width="158px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">Assigned Date</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style14">Submission Date</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxAssignedDate" runat="server" Height="16px" Width="182px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style14">
                <asp:TextBox ID="TextBoxSubmissionDate" runat="server" Height="16px" Width="182px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LabelHeader" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Calendar ID="CalendarAssigned" runat="server"></asp:Calendar>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8">
                <asp:Calendar ID="CalendarSubmission" runat="server" Height="16px" Width="248px"></asp:Calendar>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Height="174px" Width="442px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style5"></td>
            <td class="auto-style9"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
