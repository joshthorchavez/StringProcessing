<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:crimson">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <form id="form1" runat="server">
    <div style="background-color:white">
        <asp:Button ID="items" height="35" Width="150" Text="ITEMS" runat="server" OnClick="items_Click"/> 
        <asp:Button ID="carts" height="35" Width="150" Text="CART" runat="server" OnClick="cart_Click" />
        <br />
    </div>
    <div style="font-size:30px; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color:crimson; color:white">
        <br /><span style="padding-left:1em">BIG BOBS <strike>MAGICAL</strike> STOREFRONT</span>
        <br />
        <br />
    </div>
    <div style="background-color:white">
        Welcome to Big Bobs Storefront.
        <br /><br />
        A perfect place to buy gifts for all your family and friends. None of these items have ever threatened me or my family in any way.
       
        Even the notion that they would is rediculous. Please buy them.
    </div>
    <div style="background-color:white; height:500px">
        <br /><br />Cart Contents: <br /><br />
        <asp:Table ID="Table1" runat="server"></asp:Table>
        <asp:Button ID ="checkout" Text="Check Out" runat="server" OnClick="checkOut_Click" />
        <asp:Button ID="continue" Text="Continue Shopping" runat="server" OnClick="items_Click" />
    </div>
    </form>
</body>
</html>
