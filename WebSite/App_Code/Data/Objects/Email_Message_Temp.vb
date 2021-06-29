Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Message_Temp
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_Temp_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Subject As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Message As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sent_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_Name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Email_Message_Temp_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Message_Temp_ID
            End Get
            Set
                m_Email_Message_Temp_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Message_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Message_ID
            End Get
            Set
                m_Email_Message_ID = value
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
        Public Property Email_Message() As String
            Get
                Return m_Email_Message
            End Get
            Set
                m_Email_Message = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Company_ID() As Nullable(Of Integer)
            Get
                Return m_Company_ID
            End Get
            Set
                m_Company_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Address() As String
            Get
                Return m_Email_Address
            End Get
            Set
                m_Email_Address = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Sent_On() As Nullable(Of DateTime)
            Get
                Return m_Sent_On
            End Get
            Set
                m_Sent_On = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Company_Name() As String
            Get
                Return m_Company_Name
            End Get
            Set
                m_Company_Name = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Message_Temp_ID As Nullable(Of Integer), ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Subject As String, ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal sent_On As Nullable(Of DateTime), ByVal company_Name As String) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(email_Message_Temp_ID, email_Message_ID, email_Subject, company_ID, email_Address, sent_On, company_Name)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message_Temp) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, sort, Email_Message_TempFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, sort, Email_Message_TempFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, Nothing, Email_Message_TempFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return New Email_Message_TempFactory().Select(filter, Nothing, Email_Message_TempFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message_Temp
            Return New Email_Message_TempFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Message_Temp
            Return New Email_Message_TempFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal email_Message_Temp_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message_Temp
            Return New Email_Message_TempFactory().SelectSingle(email_Message_Temp_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Email_Message_TempFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Email_Message_TempFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Email_Message_TempFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Email_Message_Temp_ID: {0}", Me.Email_Message_Temp_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_Message_TempFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Message_Temp")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Message_Temp")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Message_Temp")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Message_Temp")
            End Get
        End Property
        
        Public Shared Function Create() As Email_Message_TempFactory
            Return New Email_Message_TempFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Message_Temp_ID As Nullable(Of Integer), ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Subject As String, ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal sent_On As Nullable(Of DateTime), ByVal company_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Message_Temp_ID.HasValue Then
                filter.Add(("Email_Message_Temp_ID:=" + email_Message_Temp_ID.Value.ToString()))
            End If
            If email_Message_ID.HasValue Then
                filter.Add(("Email_Message_ID:=" + email_Message_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Subject)) Then
                filter.Add(("Email_Subject:*" + email_Subject))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Address)) Then
                filter.Add(("Email_Address:*" + email_Address))
            End If
            If sent_On.HasValue Then
                filter.Add(("Sent_On:=" + sent_On.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(company_Name)) Then
                filter.Add(("Company_Name:*" + company_Name))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Message_Temp_ID As Nullable(Of Integer), ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Subject As String, ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal sent_On As Nullable(Of DateTime), ByVal company_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Dim request As PageRequest = CreateRequest(email_Message_Temp_ID, email_Message_ID, email_Subject, company_ID, email_Address, sent_On, company_Name, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message_Temp", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message_Temp)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Message_Temp) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return [Select](qbe.Email_Message_Temp_ID, qbe.Email_Message_ID, qbe.Email_Subject, qbe.Company_ID, qbe.Email_Address, qbe.Sent_On, qbe.Company_Name)
        End Function
        
        Public Function SelectCount(ByVal email_Message_Temp_ID As Nullable(Of Integer), ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Subject As String, ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal sent_On As Nullable(Of DateTime), ByVal company_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Message_Temp_ID, email_Message_ID, email_Subject, company_ID, email_Address, sent_On, company_Name, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Message_Temp", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Message_Temp_ID As Nullable(Of Integer), ByVal email_Message_ID As Nullable(Of Integer), ByVal email_Subject As String, ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal sent_On As Nullable(Of DateTime), ByVal company_Name As String) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return [Select](email_Message_Temp_ID, email_Message_ID, email_Subject, company_ID, email_Address, sent_On, company_Name, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal email_Message_Temp_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Message_Temp
            Dim list As List(Of MyCompany.Data.Objects.Email_Message_Temp) = [Select](email_Message_Temp_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Message_Temp", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Message_Temp)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Message_Temp)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Message_Temp
            Dim list As List(Of MyCompany.Data.Objects.Email_Message_Temp) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp, ByVal original_Email_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Email_Message_Temp_ID", original_Email_Message_Temp.Email_Message_Temp_ID, theEmail_Message_Temp.Email_Message_Temp_ID, true))
            values.Add(New FieldValue("Email_Message_ID", original_Email_Message_Temp.Email_Message_ID, theEmail_Message_Temp.Email_Message_ID))
            values.Add(New FieldValue("Email_Subject", original_Email_Message_Temp.Email_Subject, theEmail_Message_Temp.Email_Subject))
            values.Add(New FieldValue("Email_Message", original_Email_Message_Temp.Email_Message, theEmail_Message_Temp.Email_Message))
            values.Add(New FieldValue("Company_ID", original_Email_Message_Temp.Company_ID, theEmail_Message_Temp.Company_ID))
            values.Add(New FieldValue("Email_Address", original_Email_Message_Temp.Email_Address, theEmail_Message_Temp.Email_Address))
            values.Add(New FieldValue("Sent_On", original_Email_Message_Temp.Sent_On, theEmail_Message_Temp.Sent_On))
            values.Add(New FieldValue("Company_Name", original_Email_Message_Temp.Company_Name, theEmail_Message_Temp.Company_Name))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp, ByVal original_Email_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Email_Message_Temp"
            args.View = dataView
            args.Values = CreateFieldValues(theEmail_Message_Temp, original_Email_Message_Temp)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Email_Message_Temp", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theEmail_Message_Temp)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp, ByVal original_Email_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp) As Integer
            Return ExecuteAction(theEmail_Message_Temp, original_Email_Message_Temp, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp) As Integer
            Return Update(theEmail_Message_Temp, SelectSingle(theEmail_Message_Temp.Email_Message_Temp_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp) As Integer
            Return ExecuteAction(theEmail_Message_Temp, New Email_Message_Temp(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theEmail_Message_Temp As MyCompany.Data.Objects.Email_Message_Temp) As Integer
            Return ExecuteAction(theEmail_Message_Temp, theEmail_Message_Temp, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
