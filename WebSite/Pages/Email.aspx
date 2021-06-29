<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Email.aspx.vb" Inherits="Pages_Email"  Title="Email" %>
<%@ Register Src="../Controls/SelectedGridRefresh.ascx" TagName="SelectedGridRefresh"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Email</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|Email Message">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Email_Message" view="grid1" ShowInSummary="True" Tags="Email Message" />
    </div>
    <div data-activator="Tab|Field Replacements">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="Email_Replacement_Field" view="grid1" ShowInSummary="True" Tags="Field Replacements" />
    </div>
    <div data-activator="Tab|Email Addresses">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="Email_Address" view="grid1" ShowInSummary="True" Tags="Email Addresses" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|Email Addresses Status">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="Email_Address_Status" view="grid1" ShowInSummary="True" Tags="Email Addresses Status" />
    </div><uc:SelectedGridRefresh ID="control1" runat="server"></uc:SelectedGridRefresh></div>
  <div data-flow="row">
    <div data-activator="Tab|Email Temp">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Email_Message_Temp" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Email_Message_ID" SelectionMode="Multiple" Tags="Email Temp" />
    </div>
    <div data-activator="Tab|Email Sent">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Email_Message_Sent" view="grid1" FilterSource="view1Extender" FilterFields="Email_Message_ID" Tags="Email Sent" />
    </div>
    <div data-activator="Tab|Company Info">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="Company_View" view="grid1" ShowInSummary="True" FilterSource="view5Extender" FilterFields="Company_ID" Tags="Company Info" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>