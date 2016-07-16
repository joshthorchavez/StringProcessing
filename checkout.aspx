<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:crimson">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <form id="form1" runat="server">
    <div style="background-color:white">
        <asp:Button ID="items" height="35" Width="150" Text="ITEMS" runat="server" OnClick="items_Click" CausesValidation="false"/> 
        <asp:Button ID="carts" height="35" Width="150" Text="CART" runat="server" OnClick="cart_Click" CausesValidation="false"/>
        <br />
    </div>
    <div style="font-size:30px; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color:crimson; color:white">
        <br /><span style="padding-left:1em">BIG BOBS <strike>MAGICAL</strike> STOREFRONT</span>
        <br />
        <br />
    </div>
    <div style="background-color:white">
        <b>Big Bobs Storefront</b> <br />
        <b>Order Checkout</b><br /><br />

        <div id="summary" >
            <div style="float:left; margin-left: 30px; border:1px solid red; width: 300px;">
                <br /><b>Order Summary</b><br /><br />
                Items: <asp:Label ID="numlabel" runat="server" Text=" "></asp:Label><br />
                Quantity: <asp:Label ID="quantlabel" runat="server" Text=" "></asp:Label><br />
                Weight: <asp:Label ID="weightlabel" runat="server" Text=" "></asp:Label> <br /><br />
                Order Total: <asp:Label ID="itemlabel" runat="server" Text=" "></asp:Label> <br />
            </div>
            <div style="margin-left: 360px; width: 400px">
               <br /><br /> Order number:<div style="float:right"><asp:Label ID="ordlabel" runat="server" Text="Label"></asp:Label></div><br />
                <br />
                Item total cost:<div style="float:right"><asp:Label ID="itemlabel2" runat="server" Text="Label"></asp:Label></div><br />
                Shipping:<div style="float:right"><asp:Label ID="shiplabel" runat="server" Text="Label"></asp:Label></div><br />
                <br />
                Total:<div style="float:right"><asp:Label ID="totallabel" runat="server" Text="Label"></asp:Label></div><br />
            </div>
            <div style="clear:both;">
            </div>
            <div style="float:left; margin-left: 30px; border:1px solid red; width: 300px;">
                <br /><b>Shipping information</b><br /><br />
                Name:* <div style="float:right"><asp:TextBox ID="namebox" runat="server" width="200px"></asp:TextBox></div><br /><br />
                Street:* <div style="float:right"><asp:TextBox ID="streetbox" runat="server" width="200px" ></asp:TextBox></div><br /><br />
                City:* <div style="float:right"><asp:TextBox ID="citybox" runat="server" width="200px" ></asp:TextBox></div><br /><br />
                State:* <div style="float:right"><asp:TextBox ID="statebox" runat="server" width="200px" ></asp:TextBox></div><br /><br />
                Zip:* <div style="float:right"><asp:TextBox ID="zipbox" runat="server" width="200px" ></asp:TextBox></div><br /><br />
                Email:* <div style="float:right"><asp:TextBox ID="emailbox" runat="server" width="200px" ></asp:TextBox></div><br /><br />
            </div>
            <div style="margin-left: 360px; width: 400px">
               <br /><br /><br /><asp:RequiredFieldValidator ID="RequiredValidator" runat="server" ErrorMessage="Name is required" ControlToValidate="namebox"
                    ForeColor="Red" Font-Bold="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Invalid Name" ForeColor="Red" Font-Bold="true" ValidationExpression="^[a-zA-Z ]+$" ControlToValidate="namebox" />
                <br />
                <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Street is required" ControlToValidate="streetbox"
                    ForeColor="Red" Font-Bold="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Invalid Street address (ex: 123 this ln)" ForeColor="Red" Font-Bold="true" ValidationExpression="^[0-9a-zA-Z. ]+$" ControlToValidate="streetbox" />
                <br />
                <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="City is required" ControlToValidate="citybox"
                    ForeColor="Red" Font-Bold="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Invalid city" ForeColor="Red" Font-Bold="true" ValidationExpression="^[a-zA-Z ]+$" ControlToValidate="citybox" />
                <br />
                <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="State is required" ControlToValidate="statebox"
                    ForeColor="Red" Font-Bold="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid state (2 Letter format)" ForeColor="Red" Font-Bold="true" ValidationExpression="\w{2}" ControlToValidate="statebox" />
                <br />
                <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Zip is required" ControlToValidate="zipbox"
                    ForeColor="Red" Font-Bold="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid zipcode" ForeColor="Red" Font-Bold="true" ValidationExpression="\d{5}" ControlToValidate="zipbox" />
                <br />
                <br /><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Email is required" ControlToValidate="emailbox"
                    ForeColor="Red" Font-Bold="true" /> 
                <asp:RegularExpressionValidator ID="vldEmail" runat="server" ErrorMessage="Invalid email" ForeColor="Red" Font-Bold="true" ValidationExpression="\S+@\S+\.\S+" ControlToValidate="emailbox" />


            </div>
            <div style="clear:both;">
            </div>
            <br />
            <div style="float:left; margin-left: 30px;">
                <asp:Button ID="Button1" Text="Continue Shopping" runat="server" OnClick="items_Click" CausesValidation="false"/>
                <asp:Button ID="Button2" Text="Submit Order" runat="server" OnClick="submit_Click" />
            </div>
            <br />
        </div>
        <br />

    </div>
    </form>
</body>
</html>
