Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports MyCompany.Data
Imports MyCompany.Rules.SharedBusinessRules


Partial Public Class Controls_PostSmotgoPE
    Inherits Global.System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim _comp As String = Nothing
        Dim _act As String = Nothing
        Dim _key As String = Nothing

        If Not IsNothing(Request.QueryString("action")) Then
            _act = Request.QueryString("action").ToString
        End If
        If Not IsNothing(Request.QueryString("company")) Then
            _comp = Request.QueryString("company").ToString
        End If
        If Not IsNothing(Request.QueryString("key")) Then
            _key = Request.QueryString("key").ToString
        End If
        Try


            If _key = "e73f1ece5087b8a5ae33998952202202" Then

                Using _sqlT As New SqlText("Insert into SmotgoPETracking (CompanyName, Action) Select @0, @1")
                    _sqlT.AddParameter("@0", _comp)
                    _sqlT.AddParameter("@1", _act)
                    _sqlT.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            Dim _sbr As New MyCompany.Rules.SharedBusinessRules

        End Try

    End Sub
End Class
