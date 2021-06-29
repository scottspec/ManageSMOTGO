Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Message
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Subject As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Address_Status As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Email_Message_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Message_ID
            End Get
            Set
                m_Email_Message_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Message_Name() As String
            Get
                Return m_Email_Message_Name
            End Get
            Set
                m_Email_Message_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Subject() As String
            Get
                Return m_Email_Subject
            End Get
            Set
                m_Email_Subject = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Message_() As String
            Get
                Return m_Email_Message
            End Get
            Set
                m_Email_Message = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Address_Status() As String
            Get
                Return m_Address_Status
            End Get
            Set
                m_Address_Status = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Name As String, ByVal email_Subject As String) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(email_Message_ID, email_Message_Name, email_Subject)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, sort, Email_MessageFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, sort, Email_MessageFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, Nothing, Email_MessageFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message)
            Return New Email_MessageFactory().Select(filter, Nothing, Email_MessageFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message
            Return New Email_MessageFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Message
            Return New Email_MessageFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal email_Message_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message
            Return New Email_MessageFactory().SelectSingle(email_Message_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Email_MessageFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Email_MessageFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Email_MessageFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Email_Message_ID: {0}", Me.Email_Message_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_MessageFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Message")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Message")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Message")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Message")
            End Get
        End Property
        
        Public Shared Function Create() As Email_MessageFactory
            Return New Email_MessageFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Name As String, ByVal email_Subject As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Message_ID.HasValue Then
                filter.Add(("Email_Message_ID:=" + email_Message_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Message_Name)) Then
                filter.Add(("Email_Message_Name:*" + email_Message_Name))
            End If
            If Not (String.IsNullOrEmpty(email_Subject)) Then
                filter.Add(("Email_Subject:*" + email_Subject))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Name As String, ByVal email_Subject As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Message)
            Dim request As PageRequest = CreateRequest(email_Message_ID, email_Message_Name, email_Subject, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message) As List(Of MyCompany.Data.Objects.Email_Message)
            Return [Select](qbe.Email_Message_ID, qbe.Email_Message_Name, qbe.Email_Subject)
        End Function
        
        Public Function SelectCount(ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Name As String, ByVal email_Subject As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Message_ID, email_Message_Name, email_Subject, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Name As String, ByVal email_Subject As String) As List(Of MyCompany.Data.Objects.Email_Message)
            Return [Select](email_Message_ID, email_Message_Name, email_Subject, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal email_Message_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message
            Dim emptyEmail_Message_Name As String = Nothing
            Dim emptyEmail_Subject As String = Nothing
            Dim list As List(Of MyCompany.Data.Objects.Email_Message) = [Select](email_Message_ID, emptyEmail_Message_Name, emptyEmail_Subject)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Message", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message
            Dim list As List(Of MyCompany.Data.Objects.Email_Message) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message, ByVal original_Email_Message As MyCompany.Data.Objects.Email_Message) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Email_Message_ID", original_Email_Message.Email_Message_ID, theEmail_Message.Email_Message_ID, true))
            values.Add(New FieldValue("Email_Message_Name", original_Email_Message.Email_Message_Name, theEmail_Message.Email_Message_Name))
            values.Add(New FieldValue("Email_Subject", original_Email_Message.Email_Subject, theEmail_Message.Email_Subject))
            values.Add(New FieldValue("Email_Message", original_Email_Message.Email_Message_, theEmail_Message.Email_Message_))
            values.Add(New FieldValue("Address_Status", original_Email_Message.Address_Status, theEmail_Message.Address_Status))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message, ByVal original_Email_Message As MyCompany.Data.Objects.Email_Message, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Email_Message"
            args.View = dataView
            args.Values = CreateFieldValues(theEmail_Message, original_Email_Message)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Email_Message", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theEmail_Message)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message, ByVal original_Email_Message As MyCompany.Data.Objects.Email_Message) As Integer
            Return ExecuteAction(theEmail_Message, original_Email_Message, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message) As Integer
            Return Update(theEmail_Message, SelectSingle(theEmail_Message.Email_Message_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message) As Integer
            Return ExecuteAction(theEmail_Message, New Email_Message(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theEmail_Message As MyCompany.Data.Objects.Email_Message) As Integer
            Return ExecuteAction(theEmail_Message, theEmail_Message, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
