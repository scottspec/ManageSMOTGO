Imports System
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.HtmlControls

Namespace MyCompany.Web
    
    <TargetControlType(GetType(HtmlGenericControl)),  _
     ToolboxItem(false)>  _
    Public Class MembershipManagerExtender
        Inherits AquariumExtenderBase
        
        Public Sub New()
            MyBase.New("Web.MembershipManager")
        End Sub
        
        Protected Overrides ReadOnly Property RequiresMembershipScripts() As Boolean
            Get
                Return true
            End Get
        End Property
    End Class
End Namespace
