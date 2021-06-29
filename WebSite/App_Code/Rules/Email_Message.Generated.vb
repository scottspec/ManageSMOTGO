Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace MyCompany.Rules
    
    Partial Public Class Email_MessageBusinessRules
        Inherits MyCompany.Rules.SharedBusinessRules
        
        <RowBuilder("Email_Message", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("Address_Status", "Email_Message_ID", "Email_Message_To_Status", "Email_Message_ID", "Email_Address_Status_ID")
        End Sub
        
        <ControllerAction("Email_Message", "Insert", ActionPhase.Before),  _
         ControllerAction("Email_Message", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfAddress_Status As FieldValue = SelectFieldValueObject("Address_Status")
            If (Not (valueOfAddress_Status) Is Nothing) Then
                valueOfAddress_Status.Modified = false
            End If
        End Sub
        
        <ControllerAction("Email_Message", "Insert", ActionPhase.After),  _
         ControllerAction("Email_Message", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("Address_Status", "Email_Message_ID", "Email_Message_To_Status", "Email_Message_ID", "Email_Address_Status_ID")
        End Sub
        
        <ControllerAction("Email_Message", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("Address_Status", "Email_Message_ID", "Email_Message_To_Status", "Email_Message_ID", "Email_Address_Status_ID")
        End Sub
    End Class
End Namespace
