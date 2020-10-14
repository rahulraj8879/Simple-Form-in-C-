<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Values Entered in Previous Form Are"></asp:Label>
            <br />
            <font color="maroon"><strong>
                <%string name ="";string address = "";string city= "";string gender = "";
                    name = Request.QueryString.Get("Name");
                    address = Request.QueryString.Get("Address");
                    city = Request.QueryString.Get("City");
                    gender = Request.QueryString.Get("Gender");
                    Response.Write("Name is " + name+"<br>");
                    Response.Write("Address is " + address+"<br>");
                    Response.Write("City is " + city+"<br>");
                    Response.Write("Gender is " + gender+"<br>");%>
                                 </strong></font><br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Back" PostBackUrl="~/Default.aspx" OnClick="Button1_Click"/>
    </form>
</body>
</html>
