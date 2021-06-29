<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Home.aspx.vb" Inherits="Pages_Home"  Title="Manage" %>
<%@ Register Src="../Controls/SelectedGridRefresh.ascx" TagName="SelectedGridRefresh"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Manage</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SelectedGridRefresh ID="control1" runat="server"></uc:SelectedGridRefresh><div data-activator="Tab|Available">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Company_Status" view="available_Grid" />
    </div>
  </div>
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Company_Status" view="grid1" Tags="Summary" />
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Email_Address" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>