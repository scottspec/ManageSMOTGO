<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Email_Address_Status.aspx.vb" Inherits="Pages_Email_Address_Status"  Title="Email Address Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Email Address Status</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Email_Address_Status" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row">
    <div data-activator="Tab|Email Address">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Email_Address" view="grid1" FilterSource="view1Extender" FilterFields="Email_Address_Status_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|Email Message To Status">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Email_Message_To_Status" view="grid1" FilterSource="view1Extender" FilterFields="Email_Address_Status_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows email address status management.</div>
    </div>
  </div>
</asp:Content>