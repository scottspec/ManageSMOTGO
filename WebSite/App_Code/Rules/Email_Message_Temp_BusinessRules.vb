Imports MyCompany.Data
Imports MyCompany.Data.Objects
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Rules
    
    Partial Public Class Email_Message_Temp_BusinessRules
        Inherits MyCompany.Rules.SharedBusinessRules

        <ControllerAction("Email_Message_Temp", "Select", ActionPhase.Before)> _
        Private Sub setId()
            If Not IsNothing(SelectExternalFilterFieldValueObject("Email_Message_ID")) Then
                Context.Session("LastMessageID") = SelectExternalFilterFieldValueObject("Email_Message_ID").Value
            End If
        End Sub

        <ControllerAction("Email_Message_Temp", "Custom", "LoadList")> _
        Private Sub LoadList()
            If IsNothing(Context.Session("LastMessageID")) Then
                Exit Sub
            End If
            Using _delete As New SqlText("Delete From Email_Message_Temp Where (Email_Message_ID = @0)")
                _delete.AddParameter("@0", Context.Session("LastMessageID"))
                _delete.ExecuteNonQuery()
            End Using

            Using _insert As New SqlText("INSERT INTO Email_Message_Temp (Email_Subject, Email_Message, Email_Address, " +
                                         "Email_Message_ID, Company_ID) " +
                                         "SELECT Email_Message.Email_Subject, Email_Message.Email_Message, " +
                                         "Email_Address.Email_Address, @0 AS Expr1, Email_Address.Company_ID " +
                                         "FROM Email_Message INNER JOIN Email_Message_To_Status ON " +
                                         "Email_Message.Email_Message_ID = Email_Message_To_Status.Email_Message_ID " +
                                         "INNER JOIN Email_Address ON Email_Message_To_Status.Email_Address_Status_ID " +
                                         "= Email_Address.Email_Address_Status_ID WHERE (Email_Message.Email_Message_ID = @0) " +
                                         "GROUP BY Email_Message.Email_Subject, Email_Message.Email_Message, " +
                                         "Email_Address.Email_Address, Email_Address.Company_ID")
                _insert.AddParameter("@0", Context.Session("LastMessageID"))
                _insert.ExecuteNonQuery()
            End Using
        End Sub

        <ControllerAction("Email_Message_Temp", "Custom", "Test")> _
        Private Sub Test(ByVal email_Message_Temp_ID As Nullable(Of Integer))
            If IsNothing(Context.Session("LastMessageID")) Then
                Exit Sub
            End If
            Using _messTemp As New SqlText("SELECT Email_Message_ID, Email_Message_Temp_ID, Email_Subject, " +
                                           "Email_Message, Email_Address FROM Email_Message_Temp WHERE " +
                                           "(Email_Message_Temp_ID = @0)")
                _messTemp.AddParameter("@0", email_Message_Temp_ID)
                If _messTemp.Read Then
                    SendEmail("scott@scottsautospec.com", "info@smotgo.com", "Smotgo.Com", _messTemp(2).ToString, _messTemp(3).ToString, True)
                End If
            End Using

        End Sub

        <ControllerAction("Email_Message_Temp", "Custom", "Send")> _
        Private Sub Send()
            If IsNothing(Context.Session("LastMessageID")) Then
                Exit Sub
            End If
            Using _messTemp As New SqlText("SELECT Email_Message_ID, Email_Message_Temp_ID, Email_Subject, " +
                                           "Email_Message, Email_Address FROM Email_Message_Temp WHERE " +
                                           "(Email_Message_ID = @0)")
                _messTemp.AddParameter("@0", Context.Session("LastMessageID"))
                Do While _messTemp.Read
                    SendEmail(_messTemp(4).ToString, "info@smotgo.com", "Smotgo.Com", _messTemp(2).ToString, _messTemp(3).ToString, True)
                    Using _archive As New SqlText("INSERT INTO Email_Message_Sent (Email_Message_ID, Email_Subject, " +
                                                  "Email_Message, Email_Address, Company_ID) SELECT Email_Message_ID, " +
                                                  "Email_Subject, Email_Message, Email_Address, Company_ID FROM " +
                                                  "Email_Message_Temp WHERE (Email_Message_Temp_ID = @0); " +
                                                  "Delete From Email_Message_Temp Where (Email_Message_Temp_ID = @0)")
                        _archive.AddParameter("@0", _messTemp(1))
                        _archive.ExecuteNonQuery()
                    End Using
                Loop
            End Using
        End Sub

        <ControllerAction("Email_Message_Temp", "Custom", "ClearList")> _
        Private Sub ClearList()
            If IsNothing(Context.Session("LastMessageID")) Then
                Exit Sub
            End If
            Using _delete As New SqlText("Delete From Email_Message_Temp Where (Email_Message_ID = @0)")
                _delete.AddParameter("@0", Context.Session("LastMessageID"))
                _delete.ExecuteNonQuery()
            End Using
        End Sub

    End Class
End Namespace
