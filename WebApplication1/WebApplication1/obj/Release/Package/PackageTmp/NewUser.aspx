<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>  <asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="Black">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/Images/Logo.png" Width="154px" OnClick="ImageButton1_Click" />
                </asp:Panel>
            <hr /><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="152px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Department"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="DdlMonths" runat="server" OnSelectedIndexChanged="DdlMonths_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="Department" DataValueField="Department">

</asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="152px"></asp:TextBox>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" controltovalidate="TextBox3" validationexpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$" ErrorMessage="Invalid Email" SetFocusOnError="False" Display="Dynamic" ForeColor="#FF3300"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Phone No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="152px" OnTextChanged="TextBox4_TextChanged" TextMode="Phone"></asp:TextBox>
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid No." ForeColor="Red" MaximumValue="9999999999" MinimumValue="6000000000" ControlToValidate="TextBox4"></asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="User Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="152px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" Width="152px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Width="152px"></asp:TextBox>
        &nbsp;&nbsp;
           
            <asp:CompareValidator ID="CompareValidator1" runat="server" controltovalidate="TextBox6" controltocompare="TextBox7"  ErrorMessage="!!Password does not Match" Display="Dynamic" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" ForeColor="Red"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Log in</asp:LinkButton>
            <br />
            <br />
          <hr />  <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" BackColor="#3399FF" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NewUSER %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
            <br />
    

            <br />
        </div>
    </form>
    

</body>
</html>
