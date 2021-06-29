Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Replacement_Field
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Replacement_Field_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Original_Text As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Field_Name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Email_Replacement_Field_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Replacement_Field_ID
            End Get
            Set
                m_Email_Replacement_Field_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Original_Text() As String
            Get
                Return m_Original_Text
            End Get
            Set
                m_Original_Text = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Field_Name() As String
            Get
                Return m_Field_Name
            End Get
            Set
                m_Field_Name = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Replacement_Field_ID As Nullable(Of Integer), ByVal original_Text As String, ByVal field_Name As String) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(email_Replacement_Field_ID, original_Text, field_Name)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Replacement_Field) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, sort, Email_Replacement_FieldFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, sort, Email_Replacement_FieldFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, Nothing, Email_Replacement_FieldFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return New Email_Replacement_FieldFactory().Select(filter, Nothing, Email_Replacement_FieldFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Replacement_Field
            Return New Email_Replacement_FieldFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Replacement_Field
            Return New Email_Replacement_FieldFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal email_Replacement_Field_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Replacement_Field
            Return New Email_Replacement_FieldFactory().SelectSingle(email_Replacement_Field_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Email_Replacement_FieldFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Email_Replacement_FieldFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Email_Replacement_FieldFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Email_Replacement_Field_ID: {0}", Me.Email_Replacement_Field_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_Replacement_FieldFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Replacement_Field")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Replacement_Field")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Replacement_Field")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Replacement_Field")
            End Get
        End Property
        
        Public Shared Function Create() As Email_Replacement_FieldFactory
            Return New Email_Replacement_FieldFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Replacement_Field_ID As Nullable(Of Integer), ByVal original_Text As String, ByVal field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Replacement_Field_ID.HasValue Then
                filter.Add(("Email_Replacement_Field_ID:=" + email_Replacement_Field_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(original_Text)) Then
                filter.Add(("Original_Text:*" + original_Text))
            End If
            If Not (String.IsNullOrEmpty(field_Name)) Then
                filter.Add(("Field_Name:*" + field_Name))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Replacement_Field_ID As Nullable(Of Integer), ByVal original_Text As String, ByVal field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Dim request As PageRequest = CreateRequest(email_Replacement_Field_ID, original_Text, field_Name, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Replacement_Field", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Replacement_Field)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Replacement_Field) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return [Select](qbe.Email_Replacement_Field_ID, qbe.Original_Text, qbe.Field_Name)
        End Function
        
        Public Function SelectCount(ByVal email_Replacement_Field_ID As Nullable(Of Integer), ByVal original_Text As String, ByVal field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Replacement_Field_ID, original_Text, field_Name, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Replacement_Field", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Replacement_Field_ID As Nullable(Of Integer), ByVal original_Text As String, ByVal field_Name As String) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return [Select](email_Replacement_Field_ID, original_Text, field_Name, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal email_Replacement_Field_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Replacement_Field
            Dim emptyOriginal_Text As String = Nothing
            Dim emptyField_Name As String = Nothing
            Dim list As List(Of MyCompany.Data.Objects.Email_Replacement_Field) = [Select](email_Replacement_Field_ID, emptyOriginal_Text, emptyField_Name)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Replacement_Field", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Replacement_Field)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Replacement_Field)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Replacement_Field
            Dim list As List(Of MyCompany.Data.Objects.Email_Replacement_Field) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field, ByVal original_Email_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Email_Replacement_Field_ID", original_Email_Replacement_Field.Email_Replacement_Field_ID, theEmail_Replacement_Field.Email_Replacement_Field_ID, true))
            values.Add(New FieldValue("Original_Text", original_Email_Replacement_Field.Original_Text, theEmail_Replacement_Field.Original_Text))
            values.Add(New FieldValue("Field_Name", original_Email_Replacement_Field.Field_Name, theEmail_Replacement_Field.Field_Name))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field, ByVal original_Email_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Email_Replacement_Field"
            args.View = dataView
            args.Values = CreateFieldValues(theEmail_Replacement_Field, original_Email_Replacement_Field)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Email_Replacement_Field", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theEmail_Replacement_Field)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field, ByVal original_Email_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field) As Integer
            Return ExecuteAction(theEmail_Replacement_Field, original_Email_Replacement_Field, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field) As Integer
            Return Update(theEmail_Replacement_Field, SelectSingle(theEmail_Replacement_Field.Email_Replacement_Field_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field) As Integer
            Return ExecuteAction(theEmail_Replacement_Field, New Email_Replacement_Field(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theEmail_Replacement_Field As MyCompany.Data.Objects.Email_Replacement_Field) As Integer
            Return ExecuteAction(theEmail_Replacement_Field, theEmail_Replacement_Field, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
