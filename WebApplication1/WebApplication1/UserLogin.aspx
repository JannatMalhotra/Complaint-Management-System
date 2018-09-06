<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1541px;
            height: 352px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                        <asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="Black">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/Images/Logo.png" Width="154px" OnClick="ImageButton1_Click" />
                </asp:Panel>
        <br />
        <hr /><asp:Label ID="Label1" runat="server" Text="User Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password" ></asp:TextBox>
        <br />
        &nbsp;<hr />  <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">New User</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Forget Password</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;<hr /><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign in" Width="177px" BackColor="#3399FF" />

                        <br /><asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NewUSER %>" SelectCommand="SELECT * FROM [NewUser]"></asp:SqlDataSource>
                        

    </form>

    </body>
</html>
