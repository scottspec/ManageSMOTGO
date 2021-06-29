Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Message_To_Status
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_Email_Message_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address_Status_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address_Status_Email_Address_Status As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, false, true)>  _
        Public Property Email_Message_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Message_ID
            End Get
            Set
                m_Email_Message_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Message_Email_Message_Name() As String
            Get
                Return m_Email_Message_Email_Message_Name
            End Get
            Set
                m_Email_Message_Email_Message_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Address_Status_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Address_Status_ID
            End Get
            Set
                m_Email_Address_Status_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Address_Status_Email_Address_Status() As String
            Get
                Return m_Email_Address_Status_Email_Address_Status
            End Get
            Set
                m_Email_Address_Status_Email_Address_Status = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Email_Message_Name As String, ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(email_Message_ID, email_Message_Email_Message_Name, email_Address_Status_ID, email_Address_Status_Email_Address_Status)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message_To_Status) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, sort, Email_Message_To_StatusFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, sort, Email_Message_To_StatusFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, Nothing, Email_Message_To_StatusFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return New Email_Message_To_StatusFactory().Select(filter, Nothing, Email_Message_To_StatusFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message_To_Status
            Return New Email_Message_To_StatusFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Message_To_Status
            Return New Email_Message_To_StatusFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal email_Message_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message_To_Status
            Return New Email_Message_To_StatusFactory().SelectSingle(email_Message_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Email_Message_To_StatusFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Email_Message_To_StatusFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Email_Message_To_StatusFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Email_Message_ID: {0}", Me.Email_Message_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_Message_To_StatusFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Message_To_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Message_To_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Message_To_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Message_To_Status")
            End Get
        End Property
        
        Public Shared Function Create() As Email_Message_To_StatusFactory
            Return New Email_Message_To_StatusFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Email_Message_Name As String, ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Message_ID.HasValue Then
                filter.Add(("Email_Message_ID:=" + email_Message_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Message_Email_Message_Name)) Then
                filter.Add(("Email_Message_Email_Message_Name:*" + email_Message_Email_Message_Name))
            End If
            If email_Address_Status_ID.HasValue Then
                filter.Add(("Email_Address_Status_ID:=" + email_Address_Status_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Address_Status_Email_Address_Status)) Then
                filter.Add(("Email_Address_Status_Email_Address_Status:*" + email_Address_Status_Email_Address_Status))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Email_Message_Name As String, ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Dim request As PageRequest = CreateRequest(email_Message_ID, email_Message_Email_Message_Name, email_Address_Status_ID, email_Address_Status_Email_Address_Status, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message_To_Status", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message_To_Status)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message_To_Status) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return [Select](qbe.Email_Message_ID, qbe.Email_Message_Email_Message_Name, qbe.Email_Address_Status_ID, qbe.Email_Address_Status_Email_Address_Status)
        End Function
        
        Public Function SelectCount(ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Email_Message_Name As String, ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Message_ID, email_Message_Email_Message_Name, email_Address_Status_ID, email_Address_Status_Email_Address_Status, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message_To_Status", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Message_Email_Message_Name As String, ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return [Select](email_Message_ID, email_Message_Email_Message_Name, email_Address_Status_ID, email_Address_Status_Email_Address_Status, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal email_Message_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message_To_Status
            Dim emptyEmail_Message_Email_Message_Name As String = Nothing
            Dim emptyEmail_Address_Status_ID As Nullable(Of Integer) = Nothing
            Dim emptyEmail_Address_Status_Email_Address_Status As String = Nothing
            Dim list As List(Of MyCompany.Data.Objects.Email_Message_To_Status) = [Select](email_Message_ID, emptyEmail_Message_Email_Message_Name, emptyEmail_Address_Status_ID, emptyEmail_Address_Status_Email_Address_Status)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Message_To_Status", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message_To_Status)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_To_Status)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message_To_Status
            Dim list As List(Of MyCompany.Data.Objects.Email_Message_To_Status) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status, ByVal original_Email_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Email_Message_ID", original_Email_Message_To_Status.Email_Message_ID, theEmail_Message_To_Status.Email_Message_ID))
            values.Add(New FieldValue("Email_Message_Email_Message_Name", original_Email_Message_To_Status.Email_Message_Email_Message_Name, theEmail_Message_To_Status.Email_Message_Email_Message_Name, true))
            values.Add(New FieldValue("Email_Address_Status_ID", original_Email_Message_To_Status.Email_Address_Status_ID, theEmail_Message_To_Status.Email_Address_Status_ID))
            values.Add(New FieldValue("Email_Address_Status_Email_Address_Status", original_Email_Message_To_Status.Email_Address_Status_Email_Address_Status, theEmail_Message_To_Status.Email_Address_Status_Email_Address_Status, true))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status, ByVal original_Email_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Email_Message_To_Status"
            args.View = dataView
            args.Values = CreateFieldValues(theEmail_Message_To_Status, original_Email_Message_To_Status)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Email_Message_To_Status", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theEmail_Message_To_Status)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status, ByVal original_Email_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status) As Integer
            Return ExecuteAction(theEmail_Message_To_Status, original_Email_Message_To_Status, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status) As Integer
            Return Update(theEmail_Message_To_Status, SelectSingle(theEmail_Message_To_Status.Email_Message_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status) As Integer
            Return ExecuteAction(theEmail_Message_To_Status, New Email_Message_To_Status(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theEmail_Message_To_Status As MyCompany.Data.Objects.Email_Message_To_Status) As Integer
            Return ExecuteAction(theEmail_Message_To_Status, theEmail_Message_To_Status, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
