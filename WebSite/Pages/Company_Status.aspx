<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Company_Status.aspx.vb" Inherits="Pages_Company_Status"  Title="Company Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Company Status</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Company_Status" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows company status management.</div>
    </div>
  </div>
</asp:Content>