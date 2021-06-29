<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="PostSmotgoPE.aspx.vb" Inherits="Pages_PostSmotgoPE"  Title="Post Smotgo PE" %>
<%@ Register Src="../Controls/PostSmotgoPE.ascx" TagName="PostSmotgoPE"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Post Smotgo PE</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:PostSmotgoPE ID="control1" runat="server"></uc:PostSmotgoPE></div>
</asp:Content>