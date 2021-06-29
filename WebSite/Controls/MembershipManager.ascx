﻿<%@ Control Language="VB" AutoEventWireup="true" CodeFile="MembershipManager.ascx.vb" Inherits="Controls_MembershipManager"  %>
              
<!doctype html>
<html>
<body>
    <div data-activator="Tab|{Web.MembershipResources.Manager.UsersTab}">
        <div id="users" data-controller="aspnet_Membership" data-search-by-first-letter="true" data-tags="multi-select-none"></div>
    </div>
    <div data-activator="Tab|{Web.MembershipResources.Manager.RolesTab}">
        <div id="roles" data-controller="aspnet_Roles" data-tags="multi-select-none"></div>
        <div id="role-users" data-controller="aspnet_Membership" data-view="usersInRolesGrid" 
             data-filter-source="roles" data-filter-fields="RoleId" data-page-size="5" 
             data-search-by-first-letter="true" data-auto-hide="self"  data-tags="multi-select-none"
             data-page-header="{Web.MembershipResources.Manager.UsersInRole}"></div>
    </div>
</body>
</html>
              