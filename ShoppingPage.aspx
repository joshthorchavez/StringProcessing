<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingPage.aspx.cs" Inherits="ShoppingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:crimson">
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
        <br /><br />Please select from the items below:<br /><br />
    </div>
    <div style="background-color:white">
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="http://i248.photobucket.com/albums/gg193/joshthor/a_zps1fwwb7sy.jpeg" Width="200px" OnClick="ImageButton1_Click"/>
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="http://i248.photobucket.com/albums/gg193/joshthor/b_zpscjmyb15k.jpg" Width="200px" OnClick="ImageButton2_Click"/>
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="http://i248.photobucket.com/albums/gg193/joshthor/c_zpsxgawkpao.jpg" Width="200px" OnClick="ImageButton3_Click"/>
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="http://i248.photobucket.com/albums/gg193/joshthor/d_zpstfywdeix.jpg" Width="200px" OnClick="ImageButton4_Click"/>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="http://i248.photobucket.com/albums/gg193/joshthor/e_zpsgkhboggp.jpg" Width="200px" OnClick="ImageButton5_Click"/>
    </div>
    </form>
</body>
</html>
