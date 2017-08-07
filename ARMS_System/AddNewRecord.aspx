<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddNewRecord.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

           
        .button {
            border: 3px solid black;
            background-color:#B5F2F2;
            font-style:normal;
            font-weight:normal;
            color: #000066;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 1333px">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
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

            <hr style="font-size: 3px; color: #006699; font-weight: bold; height: 4px; width: 1240px; background-color: #003366;" />



            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label ID="Label7" runat="server" Text="Logged in as:"></asp:Label>
&nbsp;<asp:Label ID="Label8" runat="server" ForeColor="#333399"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" Font-Underline="True" ForeColor="#990000" Text="➤ Add a New Record:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="74px" ImageUrl="~/Pics/logoutA.png" Width="83px" CssClass="iconbutton" OnClick="ImageButton2_Click" CausesValidation="False" ToolTip="Logout" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Names="Cambria" Font-Size="Large" Text="System Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Names="Cambria" Font-Size="Large" Text="System Development:"></asp:Label>
        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="g1" OnCheckedChanged="RadioButton1_CheckedChanged" Text="In-House " />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="g1" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchased" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="SystemOwner" runat="server" Font-Names="Cambria" Font-Size="Large">System Owner:</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="SystemOwner_TextBox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="SystemOwner_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Font-Names="Nyala" Font-Size="Large" Text="(Department)"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ProjectManager" runat="server" Font-Names="Cambria" Font-Size="Large">Project Manager:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="ProjectManager_Textbox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ProjectManager_Textbox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ProjectManagerEXT" runat="server" Font-Names="Cambria" Font-Size="Large">Project Manager Ext.:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ProjectManagerEXT_Textbox0" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ProjectManagerEXT_Textbox0" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ProjectManagerEXT_Textbox0" ErrorMessage="*EXT should be numeric only!" ForeColor="#CC0000" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ProjectManagerEmail" runat="server" Font-Names="Cambria" Font-Size="Large">Project Manager Email:</asp:Label>
&nbsp;<asp:TextBox ID="ProjectManagerEmail_Textbox1" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ProjectManagerEmail_Textbox1" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ProjectManagerEmail_Textbox1" ErrorMessage="*Invalid Email!" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="FocalPointUser" runat="server" Font-Names="Cambria" Font-Size="Large">Focal Point User:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FocalPointUser_TextBox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FocalPointUser_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="FocalPointUserExt" runat="server" Font-Names="Cambria" Font-Size="Large">Focal Point User Ext.:</asp:Label>
        &nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="FocalPointUserExt_TextBox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="FocalPointUserExt_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="FocalPointUserExt_TextBox" ErrorMessage="*EXT should be numeric only!" ForeColor="#CC0000" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="FocalPointUserEmail" runat="server" Font-Names="Cambria" Font-Size="Large">Focal Point User Email:</asp:Label>
&nbsp;<asp:TextBox ID="FocalPointUserEmail_Textbox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="FocalPointUserEmail_Textbox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="FocalPointUserEmail_Textbox" ErrorMessage="*Invalid Email!" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="ImpLang" runat="server" Font-Names="Cambria" Font-Size="Large">Implementation Lang.:</asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="ImpLang_TextBox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ImpLang_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="SystemDescription" runat="server" Font-Names="Cambria" Font-Size="Large">System Description:</asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="SystemDesc_TextBox" runat="server" Height="92px" Width="370px" TextMode="MultiLine" MaxLength="500"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="SystemDesc_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="VersionNo" runat="server" Font-Names="Cambria" Font-Size="Large">Version No.:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="VersionNo_TextBox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="VersionNo_TextBox" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="SpecialReqs" runat="server" Font-Names="Cambria" Font-Size="Large">Special Requirements:</asp:Label>
&nbsp;
        <asp:TextBox ID="SpecialReqs_Textbox" runat="server" Height="20px" Width="258px" MaxLength="50"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="SpecialReqs_Textbox" ErrorMessage="*Please enter any special requirements of the system. If there are none, type &quot;None&quot;." ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Attachments" runat="server" Font-Names="Cambria" Font-Size="Large">Attachments:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" Width="258px" />
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" Font-Size="Medium" Height="31px" OnClick="Button11_Click" Text="Save" Width="108px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" Font-Size="Medium" Height="31px" OnClick="Button12_Click" Text="Clear Fields" Width="108px" CausesValidation="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Records] WHERE [SystemName] = @original_SystemName AND [SystemType] = @original_SystemType AND [SystemOwner] = @original_SystemOwner AND [ProjectManager] = @original_ProjectManager AND [ProjectManagerExt] = @original_ProjectManagerExt AND [SuperUser] = @original_SuperUser AND [SuperUserExt] = @original_SuperUserExt AND (([ImpLang] = @original_ImpLang) OR ([ImpLang] IS NULL AND @original_ImpLang IS NULL)) AND [SystemDescription] = @original_SystemDescription AND (([VersionNo] = @original_VersionNo) OR ([VersionNo] IS NULL AND @original_VersionNo IS NULL)) AND [SpecialReqs] = @original_SpecialReqs AND (([SystemCost] = @original_SystemCost) OR ([SystemCost] IS NULL AND @original_SystemCost IS NULL)) AND (([VendorName] = @original_VendorName) OR ([VendorName] IS NULL AND @original_VendorName IS NULL)) AND (([VendorContactNo] = @original_VendorContactNo) OR ([VendorContactNo] IS NULL AND @original_VendorContactNo IS NULL)) AND (([PurchaseDate] = @original_PurchaseDate) OR ([PurchaseDate] IS NULL AND @original_PurchaseDate IS NULL)) AND (([LicenseType] = @original_LicenseType) OR ([LicenseType] IS NULL AND @original_LicenseType IS NULL)) AND (([LicenseDateFrom] = @original_LicenseDateFrom) OR ([LicenseDateFrom] IS NULL AND @original_LicenseDateFrom IS NULL)) AND (([LicenseDateTo] = @original_LicenseDateTo) OR ([LicenseDateTo] IS NULL AND @original_LicenseDateTo IS NULL)) AND (([LicenseNo] = @original_LicenseNo) OR ([LicenseNo] IS NULL AND @original_LicenseNo IS NULL)) AND (([IndentNo] = @original_IndentNo) OR ([IndentNo] IS NULL AND @original_IndentNo IS NULL)) AND (([IndentType] = @original_IndentType) OR ([IndentType] IS NULL AND @original_IndentType IS NULL)) AND (([Attachments] = @original_Attachments) OR ([Attachments] IS NULL AND @original_Attachments IS NULL)) AND [UserID] = @original_UserID" InsertCommand="INSERT INTO [Records] ([SystemName], [SystemType], [SystemOwner], [ProjectManager], [ProjectManagerExt], [SuperUser], [SuperUserExt], [ImpLang], [SystemDescription], [VersionNo], [SpecialReqs], [SystemCost], [VendorName], [VendorContactNo], [PurchaseDate], [LicenseType], [LicenseDateFrom], [LicenseDateTo], [LicenseNo], [IndentNo], [IndentType], [Attachments], [UserID]) VALUES (@SystemName, @SystemType, @SystemOwner, @ProjectManager, @ProjectManagerExt, @SuperUser, @SuperUserExt, @ImpLang, @SystemDescription, @VersionNo, @SpecialReqs, @SystemCost, @VendorName, @VendorContactNo, @PurchaseDate, @LicenseType, @LicenseDateFrom, @LicenseDateTo, @LicenseNo, @IndentNo, @IndentType, @Attachments, @UserID)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Records]" UpdateCommand="UPDATE [Records] SET [SystemType] = @SystemType, [SystemOwner] = @SystemOwner, [ProjectManager] = @ProjectManager, [ProjectManagerExt] = @ProjectManagerExt, [SuperUser] = @SuperUser, [SuperUserExt] = @SuperUserExt, [ImpLang] = @ImpLang, [SystemDescription] = @SystemDescription, [VersionNo] = @VersionNo, [SpecialReqs] = @SpecialReqs, [SystemCost] = @SystemCost, [VendorName] = @VendorName, [VendorContactNo] = @VendorContactNo, [PurchaseDate] = @PurchaseDate, [LicenseType] = @LicenseType, [LicenseDateFrom] = @LicenseDateFrom, [LicenseDateTo] = @LicenseDateTo, [LicenseNo] = @LicenseNo, [IndentNo] = @IndentNo, [IndentType] = @IndentType, [Attachments] = @Attachments, [UserID] = @UserID WHERE [SystemName] = @original_SystemName AND [SystemType] = @original_SystemType AND [SystemOwner] = @original_SystemOwner AND [ProjectManager] = @original_ProjectManager AND [ProjectManagerExt] = @original_ProjectManagerExt AND [SuperUser] = @original_SuperUser AND [SuperUserExt] = @original_SuperUserExt AND (([ImpLang] = @original_ImpLang) OR ([ImpLang] IS NULL AND @original_ImpLang IS NULL)) AND [SystemDescription] = @original_SystemDescription AND (([VersionNo] = @original_VersionNo) OR ([VersionNo] IS NULL AND @original_VersionNo IS NULL)) AND [SpecialReqs] = @original_SpecialReqs AND (([SystemCost] = @original_SystemCost) OR ([SystemCost] IS NULL AND @original_SystemCost IS NULL)) AND (([VendorName] = @original_VendorName) OR ([VendorName] IS NULL AND @original_VendorName IS NULL)) AND (([VendorContactNo] = @original_VendorContactNo) OR ([VendorContactNo] IS NULL AND @original_VendorContactNo IS NULL)) AND (([PurchaseDate] = @original_PurchaseDate) OR ([PurchaseDate] IS NULL AND @original_PurchaseDate IS NULL)) AND (([LicenseType] = @original_LicenseType) OR ([LicenseType] IS NULL AND @original_LicenseType IS NULL)) AND (([LicenseDateFrom] = @original_LicenseDateFrom) OR ([LicenseDateFrom] IS NULL AND @original_LicenseDateFrom IS NULL)) AND (([LicenseDateTo] = @original_LicenseDateTo) OR ([LicenseDateTo] IS NULL AND @original_LicenseDateTo IS NULL)) AND (([LicenseNo] = @original_LicenseNo) OR ([LicenseNo] IS NULL AND @original_LicenseNo IS NULL)) AND (([IndentNo] = @original_IndentNo) OR ([IndentNo] IS NULL AND @original_IndentNo IS NULL)) AND (([IndentType] = @original_IndentType) OR ([IndentType] IS NULL AND @original_IndentType IS NULL)) AND (([Attachments] = @original_Attachments) OR ([Attachments] IS NULL AND @original_Attachments IS NULL)) AND [UserID] = @original_UserID">
            <DeleteParameters>
                <asp:Parameter Name="original_SystemName" Type="String" />
                <asp:Parameter Name="original_SystemType" Type="String" />
                <asp:Parameter Name="original_SystemOwner" Type="String" />
                <asp:Parameter Name="original_ProjectManager" Type="String" />
                <asp:Parameter Name="original_ProjectManagerExt" Type="Int32" />
                <asp:Parameter Name="original_SuperUser" Type="String" />
                <asp:Parameter Name="original_SuperUserExt" Type="Int32" />
                <asp:Parameter Name="original_ImpLang" Type="String" />
                <asp:Parameter Name="original_SystemDescription" Type="String" />
                <asp:Parameter Name="original_VersionNo" Type="Int32" />
                <asp:Parameter Name="original_SpecialReqs" Type="String" />
                <asp:Parameter Name="original_SystemCost" Type="Decimal" />
                <asp:Parameter Name="original_VendorName" Type="String" />
                <asp:Parameter Name="original_VendorContactNo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="original_PurchaseDate" />
                <asp:Parameter Name="original_LicenseType" Type="String" />
                <asp:Parameter DbType="Date" Name="original_LicenseDateFrom" />
                <asp:Parameter DbType="Date" Name="original_LicenseDateTo" />
                <asp:Parameter Name="original_LicenseNo" Type="Int32" />
                <asp:Parameter Name="original_IndentNo" Type="Int32" />
                <asp:Parameter Name="original_IndentType" Type="String" />
                <asp:Parameter Name="original_Attachments" Type="Object" />
                <asp:Parameter Name="original_UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter Name="SystemName" Type="String" />
                <asp:Parameter Name="SystemType" Type="String" />
                <asp:Parameter Name="SystemOwner" Type="String" />
                <asp:Parameter Name="ProjectManager" Type="String" />
                <asp:Parameter Name="ProjectManagerExt" Type="Int32" />
                <asp:Parameter Name="SuperUser" Type="String" />
                <asp:Parameter Name="SuperUserExt" Type="Int32" />
                <asp:Parameter Name="ImpLang" Type="String" />
                <asp:Parameter Name="SystemDescription" Type="String" />
                <asp:Parameter Name="VersionNo" Type="Int32" />
                <asp:Parameter Name="SpecialReqs" Type="String" />
                <asp:Parameter Name="SystemCost" Type="Decimal" />
                <asp:Parameter Name="VendorName" Type="String" />
                <asp:Parameter Name="VendorContactNo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="PurchaseDate" />
                <asp:Parameter Name="LicenseType" Type="String" />
                <asp:Parameter DbType="Date" Name="LicenseDateFrom" />
                <asp:Parameter DbType="Date" Name="LicenseDateTo" />
                <asp:Parameter Name="LicenseNo" Type="Int32" />
                <asp:Parameter Name="IndentNo" Type="Int32" />
                <asp:Parameter Name="IndentType" Type="String" />
                <asp:ControlParameter ControlID="FileUpload1" Name="Attachments" PropertyName="FileName" Type="Object" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="SystemType" Type="String" />
                <asp:Parameter Name="SystemOwner" Type="String" />
                <asp:Parameter Name="ProjectManager" Type="String" />
                <asp:Parameter Name="ProjectManagerExt" Type="Int32" />
                <asp:Parameter Name="SuperUser" Type="String" />
                <asp:Parameter Name="SuperUserExt" Type="Int32" />
                <asp:Parameter Name="ImpLang" Type="String" />
                <asp:Parameter Name="SystemDescription" Type="String" />
                <asp:Parameter Name="VersionNo" Type="Int32" />
                <asp:Parameter Name="SpecialReqs" Type="String" />
                <asp:Parameter Name="SystemCost" Type="Decimal" />
                <asp:Parameter Name="VendorName" Type="String" />
                <asp:Parameter Name="VendorContactNo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="PurchaseDate" />
                <asp:Parameter Name="LicenseType" Type="String" />
                <asp:Parameter DbType="Date" Name="LicenseDateFrom" />
                <asp:Parameter DbType="Date" Name="LicenseDateTo" />
                <asp:Parameter Name="LicenseNo" Type="Int32" />
                <asp:Parameter Name="IndentNo" Type="Int32" />
                <asp:Parameter Name="IndentType" Type="String" />
                <asp:Parameter Name="Attachments" Type="Object" />
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="original_SystemName" Type="String" />
                <asp:Parameter Name="original_SystemType" Type="String" />
                <asp:Parameter Name="original_SystemOwner" Type="String" />
                <asp:Parameter Name="original_ProjectManager" Type="String" />
                <asp:Parameter Name="original_ProjectManagerExt" Type="Int32" />
                <asp:Parameter Name="original_SuperUser" Type="String" />
                <asp:Parameter Name="original_SuperUserExt" Type="Int32" />
                <asp:Parameter Name="original_ImpLang" Type="String" />
                <asp:Parameter Name="original_SystemDescription" Type="String" />
                <asp:Parameter Name="original_VersionNo" Type="Int32" />
                <asp:Parameter Name="original_SpecialReqs" Type="String" />
                <asp:Parameter Name="original_SystemCost" Type="Decimal" />
                <asp:Parameter Name="original_VendorName" Type="String" />
                <asp:Parameter Name="original_VendorContactNo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="original_PurchaseDate" />
                <asp:Parameter Name="original_LicenseType" Type="String" />
                <asp:Parameter DbType="Date" Name="original_LicenseDateFrom" />
                <asp:Parameter DbType="Date" Name="original_LicenseDateTo" />
                <asp:Parameter Name="original_LicenseNo" Type="Int32" />
                <asp:Parameter Name="original_IndentNo" Type="Int32" />
                <asp:Parameter Name="original_IndentType" Type="String" />
                <asp:Parameter Name="original_Attachments" Type="Object" />
                <asp:Parameter Name="original_UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
    </style> 


</asp:Content>

