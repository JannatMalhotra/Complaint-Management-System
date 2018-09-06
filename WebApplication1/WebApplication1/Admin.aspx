<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        #form1 {
            height: 354px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>  <asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="Black">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/Images/Logo.png" Width="154px" OnClick="ImageButton1_Click" />
                </asp:Panel>
            <hr /><p style="margin-left: 440px" class="auto-style1">
                <strong>Admin<span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button4" runat="server" Text="New Admin" BackColor="Blue" OnClick="Button4_Click1" />
                </span></strong></p>
        </div>
         <div>
             <br />
        <asp:Label ID="Label1" runat="server" Text="Admin Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password" ></asp:TextBox>
             <br />
             <br />
             <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forget Password</asp:LinkButton>
             <br />
             <hr />
             <asp:Button ID="Button1" runat="server" BackColor="#3399FF" ForeColor="Black" OnClick="Button1_Click" Text="Login" />
             <br />
             <asp:Label ID="Label3" runat="server"></asp:Label>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NewUSER %>" SelectCommand="SELECT [AdminId], [Password] FROM [NewAdmin]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
