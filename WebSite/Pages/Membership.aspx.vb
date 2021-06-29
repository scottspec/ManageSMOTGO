Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class Pages_Membership
    Inherits Global.MyCompany.Web.PageBase
    
    Public ReadOnly Property CssClass() As String
        Get
            Return "UsersPage"
        End Get
    End Property
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
End Class
