Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Rules
    
    Partial Public Class Email_Address_BusinessRules
        Inherits MyCompany.Rules.SharedBusinessRules

        <ControllerAction("Email_Address", "Custom", "RefreshEmailAddresses")>
        Private Sub RefreshEmailAddresses()

            Try
                Dim _sql As String
                Using _sqlT As New SqlText("Select Sql From Sql Where (SQL_ID = 14)")
                    _sql = _sqlT.ExecuteScalar
                End Using

                Using _sqlT As New SqlText(_sql)
                    _sql = _sqlT.ExecuteNonQuery
                End Using
            Catch
            End Try

        End Sub

        <ControllerAction("Email_Address", "Custom", "LoadList")> _
        Private Sub LoadList(ByVal parameters_Email_Message_ID As Nullable(Of Integer))


            Dim _emailAddList As ArrayList = New ArrayList
            Dim _emailAdd As String = Nothing

            Dim Request As PageRequest = New PageRequest()
            Request.Controller = Arguments.Controller
            Request.Filter = Arguments.Filter
            Request.RequiresRowCount = True
            Request.RequiresMetaData = False
            Request.PageSize = Int32.MaxValue

            Dim reader As IDataReader
            reader = ControllerFactory.CreateDataEngine().ExecuteReader(Request)
            Do While reader.Read
                _emailAddList.Add(reader("Email_Address"))
            Loop

            If _emailAddList.Count < 1 Then
                Exit Sub
            End If

            For i = 0 To _emailAddList.Count - 1
                _emailAdd += "Email_Address.Email_Address = '" + _emailAddList(i).ToString + "'"
                If i < _emailAddList.Count - 1 Then
                    _emailAdd += " OR "
                End If
            Next
            _emailAdd = " AND (" + _emailAdd + ")"



                Using _delete As New SqlText("Delete From Email_Message_Temp Where (Email_Message_ID = @0)")
                _delete.AddParameter("@0", parameters_Email_Message_ID)
                    _delete.ExecuteNonQuery()
                End Using

            Using _insert As New SqlText("INSERT INTO Email_Message_Temp (Email_Subject, Email_Message, Email_Address, " +
                                         "Email_Message_ID, Company_ID) " +
                                         "SELECT Email_Message.Email_Subject, Email_Message.Email_Message, " +
                                         "Email_Address.Email_Address, @0 AS Expr1, Email_Address.Company_ID " +
                                         "FROM Email_Address CROSS JOIN Email_Message WHERE (Email_Message.Email_Message_ID = @0) " + _emailAdd)
                _insert.AddParameter("@0", parameters_Email_Message_ID)
                _insert.ExecuteNonQuery()
            End Using

        End Sub

        <ControllerAction("Email_Address", "Custom", "CombineAll")> _
        Private Sub CombineAll()

            Dim ii As Integer = 1
            Dim _emailAddList As ArrayList = New ArrayList
            Dim _emailAdd As String = Nothing

            Dim Request As PageRequest = New PageRequest()
            Request.Controller = Arguments.Controller
            Request.Filter = Arguments.Filter
            Request.RequiresRowCount = True
            Request.RequiresMetaData = False
            Request.PageSize = Int32.MaxValue

            Dim reader As IDataReader
            reader = ControllerFactory.CreateDataEngine().ExecuteReader(Request)
            Do While reader.Read
                If reader("Email_Address_Status_ID") = 1 Then
                    _emailAddList.Add(reader("Email_Address"))
                End If
            Loop

            If _emailAddList.Count < 1 Then
                Exit Sub
            End If

            For i = 0 To _emailAddList.Count - 1
                If InStr(_emailAdd, _emailAddList(i).ToString) < 1 Then
                    _emailAdd += _emailAddList(i).ToString + "; "
                    If ii > 49 Then
                        _emailAdd += vbCrLf + vbCrLf
                        ii = 1
                    Else
                        ii += 1
                    End If
                End If
            Next

            '   SendEmail("Scott@4volvoservice.com", "Scott@4volvoservice.com", "Scott@4volvoservice.com", "Addresses", _emailAdd, False)

        End Sub

        <ControllerAction("Email_Address", "Delete", ActionPhase.After)> _
        Private Sub DeleteEmailAddress(ByVal email_address As String)


            Try
                Dim _sql As String
                Using _sqlT As New SqlText("Select Sql From Sql Where (SQL_ID = 15)")
                    _sql = _sqlT.ExecuteScalar
                End Using

                Using _sqlT As New SqlText(_sql)
                    _sqlT.AddParameter("@0", email_address)
                    _sql = _sqlT.ExecuteNonQuery
                End Using
            Catch
            End Try

            Exit Sub
            Using _sql As New SqlText("Update Shopmanager.dbo.Company Set Email_Address = null " +
                                      "Where (Email_Address = @0)")
                _sql.AddParameter("@0", email_address)
                _sql.ExecuteNonQuery()
            End Using

        End Sub

    End Class
End Namespace
