<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgeCalc.aspx.cs" Inherits="AgeCalculator.AgeCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Age Calculator<br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter DOB (DD/MM/YYYY):"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" Width="97px" />
            <br />
            <br />
            Age:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="534px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
