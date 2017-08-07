<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminManageUserAccounts.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

           
        .button {
            background-color:#B5F2F2;
            font-style:normal;
            font-weight:normal;
            border-color:black;
            border-width:3px;
            border-style:solid;
            color: #000066;
            height:41px;
            width:197px;   
        }


             
        .button {
            background-color:#B5F2F2;
            font-style:normal;
            font-weight:normal;
            border-color:black;
            border-width:3px;
            border-style:solid;
            color: #000066;
            height:41px;
            width:197px;
            
        }
           
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 1109px">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp; &nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Create New User" Font-Size="Medium" OnClick="Button1_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Manage User Accounts" Font-Size="Medium" OnClick="Button2_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Manage Records Status" Font-Size="Medium" OnClick="Button3_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server"  Text="Add New Record" Font-Size="Medium" OnClick="Button4_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="Update a Record" Font-Size="Medium" OnClick="Button7_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="Search In-House Systems" Font-Size="Medium" OnClick="Button8_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server"  Text="Search Purchased Systems" Font-Size="Medium" OnClick="Button9_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server"  Text="Reports" Font-Size="Medium" OnClick="Button10_Click" CssClass="button" Height="42px" Width="246px" CausesValidation="False"/>
            <br />
            <br />
        <br />

            <hr style="font-size: 3px; color: #336699; font-weight: bold; height: 4px; width: 1240px; background-color: #003366;" />



            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Logged in as:"></asp:Label>
&nbsp;<asp:Label ID="Label8" runat="server" ForeColor="#333399"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" Font-Underline="True" ForeColor="#990000" Text="➤ Manage User Accounts Status:"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Names="Calibri" Font-Size="Large" Font-Underline="False" ForeColor="#003366" Text="(Activate/De-activate User Accounts):"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="74px" ImageUrl="~/Pics/logoutA.png" Width="83px" CssClass="iconbutton" OnClick="ImageButton2_Click" CausesValidation="False" ToolTip="Logout" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Names="Cambria" Font-Size="Large" Text="User ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="258px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button14" runat="server" Text="Search" Width="85px" BorderColor="#003366" BorderWidth="2px" CssClass="viewDetails" Font-Size="Medium" OnClick="Button14_Click" ValidationGroup="Search_regex" />
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Please enter a User ID to search" ForeColor="#CC0000" ValidationGroup="Search_regex"></asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*The User ID should be numeric only!" ForeColor="#CC0000" ValidationExpression="^[0-9]+$" ValidationGroup="Search_regex"></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Please enter a User ID to search" ForeColor="#CC0000" ValidationGroup="button_activate"></asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Please enter a User ID to search" ForeColor="#CC0000" ValidationGroup="button_deactivate"></asp:RequiredFieldValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" AllowCustomPaging="True" AllowPaging="True" AllowSorting="True" BorderColor="#000066" BorderStyle="Solid" BorderWidth="3px" CellPadding="10" CellSpacing="5" EnableSortingAndPagingCallbacks="True" Font-Bold="False" ForeColor="#333333" AutoGenerateColumns="False" BackColor="#F0F0F0" DataKeyNames="UserID" DataSourceID="SqlDataSource2" PageSize="5" ToolTip="User Details" Width="85%">
            <AlternatingRowStyle BorderWidth="2px" />
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Ext" HeaderText="Ext" SortExpression="Ext" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Dept" HeaderText="Dept" SortExpression="Dept" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
            </Columns>
            <EditRowStyle BorderColor="#333399" BorderWidth="2px" />
            <HeaderStyle BackColor="#A8EEFF" />
            <RowStyle BorderColor="#000066" BorderWidth="2px" BorderStyle="Solid" />
            <SelectedRowStyle BackColor="#A2E7EA" />
        </asp:GridView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" Font-Size="Medium" Height="40px" OnClick="Button11_Click" Text="Re-activate account" Width="235px" ValidationGroup="button_activate" BorderColor="#003366" BorderWidth="2px" CssClass="viewDetails" Font-Names="Tahoma" />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button12" runat="server" Font-Size="Medium" Height="40px" OnClick="Button12_Click" Text="De-activate account" Width="235px" ValidationGroup="button_deactivate" BorderColor="#003366" BorderWidth="2px" CssClass="viewDetails" Font-Names="Tahoma" />
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button15" runat="server" Font-Size="Medium" Height="40px" OnClick="Button15_Click" Text="Assign Administrative Role" Width="235px" ValidationGroup="button_deactivate" BorderColor="#003366" BorderWidth="2px" CssClass="viewDetails" Font-Names="Tahoma" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button16" runat="server" Font-Size="Medium" Height="40px" OnClick="Button16_Click" Text="Remove Administrative Role" Width="235px" ValidationGroup="button_deactivate" BorderColor="#003366" BorderWidth="2px" CssClass="viewDetails" Font-Names="Tahoma" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [UserID], [Name], [Ext], [Dept], [Email], [Designation], [Status], [RoleID] FROM [UserDetails] WHERE ([UserID] = @UserID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="UserID" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT a.UserID, a.Name, a.Ext, a.Password, a.Dept, a.Email, a.Status, r.Role
FROM UserDetails AS a INNER JOIN
Roles AS r ON a.RoleID = r.RoleID
WHERE (a.UserID = @Param1)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Param1" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>

    <style type="text/css">
            .button:hover {
               cursor:pointer;
               font-style:oblique;
               font-weight:bold;
                border-color: maroon;
                color: red;
                text-underline-position:below;
            }
           
        .button {
            border: 3px solid black;
            background-color:#B5F2F2;
            font-style:normal;
            font-weight:normal;
            color: #000066;
        }

        .iconbutton:hover {
           background-color: lightyellow;
           border-color:darkblue;
        }
        .iconbutton {
            border-color:none;
        }
    

         .viewDetails {
            background-color: whitesmoke;
            height: 28px;
        }

        .viewDetails:hover {
            cursor:pointer;
            background-color: lightblue;
        }

        </style>  



</asp:Content>

