<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registartion.aspx.cs" Inherits="practical4.Registartion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Form Registration</h1>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Table ID="tbl1" runat="server">
            <asp:TableRow>
                <asp:TableCell>Name:</asp:TableCell>
             
                <asp:TableCell>
                    <asp:TextBox ID="username" runat="server" AutoPostBack="true" />   

                     <asp:Label ID="uname" runat="server" ForeColor="Red"></asp:Label>
                </asp:TableCell>
         
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Email:</asp:TableCell>   
                <asp:Tablecell><asp:TextBox ID="email" runat="server" type="email"  AutoPostBack="true"  ></asp:TextBox>
                     <asp:Label ID="uemail" runat="server" ForeColor="Red"></asp:Label>
                </asp:Tablecell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Mobile Number:</asp:TableCell>
                <asp:Tablecell><asp:TextBox ID="mbnumber" runat="server" type="number"  AutoPostBack="true" ></asp:TextBox>
                    <asp:Label ID="umbnumber" runat="server" ForeColor="Red"></asp:Label>
                </asp:Tablecell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Collage:</asp:TableCell>
                <asp:Tablecell><asp:TextBox ID="collage" runat="server" type="text"  AutoPostBack="true" ></asp:TextBox>
                    <asp:Label ID="ucollage" runat="server" ForeColor="Red"></asp:Label>
                </asp:Tablecell>
            </asp:TableRow>
            <asp:TableRow>
                  <asp:TableCell>Department:</asp:TableCell>
                  <asp:Tablecell><asp:RadioButtonList ID="department" runat="server"  AutoPostBack="true" >
                                    <asp:ListItem Value="cse">CSE</asp:ListItem>
                                    <asp:ListItem Value="mce">Mechanical</asp:ListItem>
                                    <asp:ListItem Value="civil">Civil</asp:ListItem>
                                    <asp:ListItem Value="chemical">Chemical</asp:ListItem>
                                  </asp:RadioButtonList>
                                   <asp:Label ID="udepartment" runat="server" ForeColor="Red"></asp:Label>
                   </asp:Tablecell>

           </asp:TableRow>
           <asp:TableRow>
                <asp:TableCell>Event:</asp:TableCell>
                <asp:Tablecell>
                    <asp:DropDownList ID="events" runat="server"  AutoPostBack="true">
                        <asp:ListItem Value="">Select presentation</asp:ListItem>
                        <asp:ListItem Value="paper presentation">Paper presentation</asp:ListItem>
                        <asp:ListItem Value="post presentation">Poster presentation</asp:ListItem>
                        <asp:ListItem Value="quiz">Quiz</asp:ListItem>
                        <asp:ListItem Value="fung">Fun Games</asp:ListItem>
                         </asp:DropDownList>
                        <asp:Label ID="uevent" runat="server" ForeColor="Red"></asp:Label>

                   

                </asp:Tablecell>
           </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>Gender :</asp:TableCell>
                <asp:TableCell>
        
                  <asp:RadioButton ID="male" runat="server"  value="male" GroupName="gender"  AutoPostBack="true" />Male
                  <asp:RadioButton ID="female" runat="server"  value="female" GroupName="gender"  AutoPostBack="true" />Female
         
                <asp:Label ID="ugender" runat="server" ForeColor="Red"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>

              <asp:TableRow>
      <asp:TableCell>Skills :</asp:TableCell>
      <asp:TableCell>
            <asp:CheckBoxList ID="skills" runat="server"  AutoPostBack="true" >
                <asp:ListItem Value="c#">c#</asp:ListItem>
                <asp:ListItem Value="java">Java</asp:ListItem>
                <asp:ListItem Value="python">Python</asp:ListItem>
                <asp:ListItem Value="ai">Ai</asp:ListItem>
                 </asp:CheckBoxList>
                <asp:Label ID="uskills" runat="server" ForeColor="Red"></asp:Label>
           
          </asp:TableCell>
  </asp:TableRow>
                
    <asp:TableRow>

        <asp:TableCell>Address:</asp:TableCell>
        <asp:TableCell>
            <textarea id="Address" name="address"></textarea>
            <asp:Label ID="uaddress" runat="server" ForeColor="Red"></asp:Label>
        </asp:TableCell>
    </asp:TableRow>


            <asp:TableFooterRow>
                <asp:TableCell>
                    <asp:CheckBox ID="term" runat="server"/>term and condition<br />
                    <asp:Label ID="terms" runat="server" ForeColor="red"></asp:Label>
                    <br />
                    <asp:Button ID="btn1" runat="server" Text="Registartion" OnClick="btn_Click"/>
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>

               
            
      
       </form>
   
</body>
</html>
