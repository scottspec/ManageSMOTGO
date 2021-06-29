Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


<Global.MyCompany.Web.AquariumFieldEditor()> _
Partial Public Class Controls_RichEditor
    Inherits Global.System.Web.UI.UserControl
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Page.ClientScript.RegisterClientScriptBlock([GetType](), "ClientScripts", String.Format(""&Global.Microsoft.VisualBasic.ChrW(10)&"                                    function FieldEditor_GetValue(){{return $get"& _ 
                        "('{0}$HtmlEditorExtenderBehavior_ExtenderContentEditable').innerHTML;}}"&Global.Microsoft.VisualBasic.ChrW(10)&"function"& _ 
                        " FieldEditor_SetValue(value) {{$get('{0}$HtmlEditorExtenderBehavior_ExtenderCont"& _ 
                        "entEditable').innerHTML=value;}}"&Global.Microsoft.VisualBasic.ChrW(10)&"                                  ", Controls(0).ClientID), true)
        End If
    End Sub
End Class
