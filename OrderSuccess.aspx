<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderSuccess.aspx.cs" Inherits="OrderSuccess" %>

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
    <div style="background-color:white; height:500px">
        <div style="float:left; margin-left: 30px; border:1px solid red; width:90%; margin-right: 30px; margin-top: 30px">
            <div style="margin-left:10px">
                <br /><b>Big Bobs Storefront</b><br /><br />
                <asp:Label ID="Label2" runat="server" Text="Order x has been processed"></asp:Label><br />
                An email has been sent to confirm your order. 
                <br /><br /><br />
            </div>

            
        </div>

        
    </div>
    </form>
</body>
</html>
