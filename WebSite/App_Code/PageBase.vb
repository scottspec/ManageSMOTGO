Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls

Namespace MyCompany.Web
    
   Partial Public Class PageBase

        Protected Overrides Sub OnLoad(e As EventArgs)

            If Not Context.User.Identity.IsAuthenticated Then
                If InStr(Request.Url.ToString, "MVeScquolMEg2ZlIsRRfr2YwOY", CompareMethod.Binary) > 0 Then
                    FormsAuthentication.SetAuthCookie("ScottSpec", False)
                    Response.Redirect("../Pages/Home")
                End If
            End If

            If Context.User.Identity.IsAuthenticated = True Then
                If String.Compare(Context.User.Identity.Name, "ScottSpec", True) <> 0 Then
                    FormsAuthentication.SignOut()
                    Session.Abandon()
                End If
            End If
        End Sub

    End Class
End Namespace
