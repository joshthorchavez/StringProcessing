<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frontEnd.aspx.cs" Inherits="frontEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bobbies Stuff</title>
</head>
<body style="background-color:crimson">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <form id="form1" runat="server">
    <div style="background-color:white">
        <asp:Button ID="items" height="35" Width="150" Text="ITEMS" runat="server" OnClick="items_Click"/> 
        <asp:Button ID="cart" height="35" Width="150" Text="CART" runat="server" OnClick="cart_Click" />
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
    <div style="background-color:white">
        <br /><br />Item information: <br /><br />
    </div>
    <div style="background-color:white; width:100%; height:523px">
        <div style="float:left">
            <asp:Image ID="Image1" runat="server" Width="300px"/>
        </div>
        <div style="float:left; height: 523px; background-color:white">
            <br /><br /><br /><br /><br /><br /><br />
            <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="description" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="price" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click"/>
        </div>
    </div>
    </form>
</body>
</html>
