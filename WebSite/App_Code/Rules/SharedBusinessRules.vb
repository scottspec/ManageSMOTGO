Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Net.Mail

Namespace MyCompany.Rules

    Partial Public Class SharedBusinessRules
        Inherits MyCompany.Data.BusinessRules

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub SendEmail(ByVal To_Str As String, ByVal From_Address_Str As String, ByVal From_Name_Str As String, _
        ByVal Subject_Str As String, ByVal Message_Str As String, ByVal Is_Html As Boolean)

            Dim message As MailMessage = New MailMessage()
            Dim smtp As SmtpClient = New SmtpClient()
            message.To.Add(To_Str)
            message.From = New MailAddress(From_Address_Str)
            message.Subject = Subject_Str
            message.Body = Message_Str
            If Is_Html = True Then
                message.IsBodyHtml = True
            End If
            smtp.Send(message)
           
        End Sub

    End Class
End Namespace
