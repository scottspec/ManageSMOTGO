<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Login.ascx.vb" Inherits="Controls_Login"  %>                  
<%@ Register Src="Welcome.ascx" TagName="Welcome" TagPrefix="uc1" %>
<div class="SettingsPanel">
    <asp:Login ID="Login1" runat="server" TitleText="" Style="border-collapse: separate;"
        >
    </asp:Login>
    <div style="width: 300px; margin: 20px -8px;">
        <uc1:Welcome ID="Welcome1" runat="server" />
    </div>
</div>
                