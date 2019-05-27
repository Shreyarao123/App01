<%@ Page Title="" Language="C#" MasterPageFile="~/Gym.Master" AutoEventWireup="true" CodeBehind="Gym1.aspx.cs" Inherits="GymMangement.Gym1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        height: 1px;
    }
    .auto-style3 {
        width: 246px;
    }
    .auto-style4 {
        width: 185px;
    }
    .auto-style5 {
        width: 246px;
        height: 26px;
    }
    .auto-style6 {
        width: 185px;
        height: 26px;
    }
    .auto-style7 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="3"></td>
    </tr>
    <tr>
        <td class="auto-style3">MemberCode</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TextBox1" ErrorMessage="MemberCode Should be in Proper Format" ValidationExpression="^[GM]{2}[0-9]{3}$">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">MemberName</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Name Should Not be Empty">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">EmailId</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Email Should be in correct Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">PhoneNumber</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Phone Number Should Be 10 digits" ValidationExpression="^[0-9]{10}$">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">MemberShipStartDate</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="RangeValidator">*</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">MemberShipDuration</td>
        <td class="auto-style4">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1 Month</asp:ListItem>
                <asp:ListItem>3 Month</asp:ListItem>
                <asp:ListItem>6 Month</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select Any one">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>
</table>
</asp:Content>
