<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MilkTeaPT.aspx.cs" Inherits="MilkTeaShop.MilkTeaPT" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Milk Tea Order</title>
    <style>
        body { font-family: Arial; text-align: center; }
        table { width: 50%; margin: auto; border-collapse: collapse; background: #fdf7e3; }
        td { padding: 10px; border: 1px solid brown; }
        h2 { color: brown; }
    </style>
</head>
<body>
    <h2>Milk Tea Order Form</h2>
    <table>
        <tr>
            <td>Flavor:</td>
            <td>
                <asp:DropDownList ID="ddlFlavor" runat="server">
                    <asp:ListItem Text="Wintermelon - 100" Value="100"></asp:ListItem>
                    <asp:ListItem Text="Okinawa - 110" Value="110"></asp:ListItem>
                    <asp:ListItem Text="Matcha - 120" Value="120"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Size:</td>
            <td>
                <asp:RadioButton ID="rbSmall" runat="server" GroupName="Size" Text="Small" Checked="true" />
                <asp:RadioButton ID="rbMedium" runat="server" GroupName="Size" Text="Medium +15" />
                <asp:RadioButton ID="rbLarge" runat="server" GroupName="Size" Text="Large +20" />
            </td>
        </tr>
        <tr>
            <td>Add-ons:</td>
            <td>
                <asp:CheckBox ID="chkPearls" runat="server" Text=" Pearls +10" />
                <asp:CheckBox ID="chkOreo" runat="server" Text=" Oreo +10" />
                <asp:CheckBox ID="chkCheesecake" runat="server" Text=" Cheesecake +20" />
            </td>
        </tr>
        <tr>
            <td>Name:</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Payment:</td>
            <td>
                <asp:DropDownList ID="ddlPayment" runat="server">
                    <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                    <asp:ListItem Text="Card" Value="Card"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Button ID="btnOrder" runat="server" Text="Place Order" OnClick="btnOrder_Click" />
            </td>
        </tr>
    </table>

    <h3>Order Summary:</h3>
    <asp:Label ID="lblSummary" runat="server" Text=""></asp:Label>
</body>
</html>
