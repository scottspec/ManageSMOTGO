Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Address
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Modified_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address_Status_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address_Status_Email_Address_Status As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CO_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Last_Log_In As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Log_Ins As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Email_Address_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Address_ID
            End Get
            Set
                m_Email_Address_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Company_ID() As Nullable(Of Integer)
            Get
                Return m_Company_ID
            End Get
            Set
                m_Company_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email_Address_() As String
            Get
                Return m_Email_Address
            End Get
            Set
                m_Email_Address = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Created_On() As Nullable(Of DateTime)
            Get
                Return m_Created_On
            End Get
            Set
                m_Created_On = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Modified_On() As Nullable(Of DateTime)
            Get
                Return m_Modified_On
            End Get
            Set
                m_Modified_On = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CO_Created_On() As Nullable(Of DateTime)
            Get
                Return m_CO_Created_On
            End Get
            Set
                m_CO_Created_On = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Last_Log_In() As Nullable(Of DateTime)
            Get
                Return m_Last_Log_In
            End Get
            Set
                m_Last_Log_In = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Log_Ins() As Nullable(Of Integer)
            Get
                Return m_Log_Ins
            End Get
            Set
                m_Log_Ins = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Address_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal created_On As Nullable(Of DateTime), ByVal modified_On As Nullable(Of DateTime), ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal cO_Created_On As Nullable(Of DateTime), ByVal last_Log_In As Nullable(Of DateTime), ByVal log_Ins As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(email_Address_ID, company_ID, email_Address, created_On, modified_On, email_Address_Status_ID, email_Address_Status_Email_Address_Status, cO_Created_On, last_Log_In, log_Ins)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Address) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, sort, Email_AddressFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, sort, Email_AddressFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, Nothing, Email_AddressFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Address)
            Return New Email_AddressFactory().Select(filter, Nothing, Email_AddressFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Address
            Return New Email_AddressFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Address
            Return New Email_AddressFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal email_Address_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Address
            Return New Email_AddressFactory().SelectSingle(email_Address_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Email_AddressFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Email_AddressFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Email_AddressFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Email_Address_ID: {0}", Me.Email_Address_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_AddressFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Address")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Address")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Address")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Address")
            End Get
        End Property
        
        Public Shared Function Create() As Email_AddressFactory
            Return New Email_AddressFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Address_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal created_On As Nullable(Of DateTime), ByVal modified_On As Nullable(Of DateTime), ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal cO_Created_On As Nullable(Of DateTime), ByVal last_Log_In As Nullable(Of DateTime), ByVal log_Ins As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Address_ID.HasValue Then
                filter.Add(("Email_Address_ID:=" + email_Address_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Address)) Then
                filter.Add(("Email_Address:*" + email_Address))
            End If
            If created_On.HasValue Then
                filter.Add(("Created_On:=" + created_On.Value.ToString()))
            End If
            If modified_On.HasValue Then
                filter.Add(("Modified_On:=" + modified_On.Value.ToString()))
            End If
            If email_Address_Status_ID.HasValue Then
                filter.Add(("Email_Address_Status_ID:=" + email_Address_Status_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(email_Address_Status_Email_Address_Status)) Then
                filter.Add(("Email_Address_Status_Email_Address_Status:*" + email_Address_Status_Email_Address_Status))
            End If
            If cO_Created_On.HasValue Then
                filter.Add(("CO_Created_On:=" + cO_Created_On.Value.ToString()))
            End If
            If last_Log_In.HasValue Then
                filter.Add(("Last_Log_In:=" + last_Log_In.Value.ToString()))
            End If
            If log_Ins.HasValue Then
                filter.Add(("Log_Ins:=" + log_Ins.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Address_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal created_On As Nullable(Of DateTime), ByVal modified_On As Nullable(Of DateTime), ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal cO_Created_On As Nullable(Of DateTime), ByVal last_Log_In As Nullable(Of DateTime), ByVal log_Ins As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Address)
            Dim request As PageRequest = CreateRequest(email_Address_ID, company_ID, email_Address, created_On, modified_On, email_Address_Status_ID, email_Address_Status_Email_Address_Status, cO_Created_On, last_Log_In, log_Ins, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Address", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Address)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Address) As List(Of MyCompany.Data.Objects.Email_Address)
            Return [Select](qbe.Email_Address_ID, qbe.Company_ID, qbe.Email_Address_, qbe.Created_On, qbe.Modified_On, qbe.Email_Address_Status_ID, qbe.Email_Address_Status_Email_Address_Status, qbe.CO_Created_On, qbe.Last_Log_In, qbe.Log_Ins)
        End Function
        
        Public Function SelectCount(ByVal email_Address_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal created_On As Nullable(Of DateTime), ByVal modified_On As Nullable(Of DateTime), ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal cO_Created_On As Nullable(Of DateTime), ByVal last_Log_In As Nullable(Of DateTime), ByVal log_Ins As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Address_ID, company_ID, email_Address, created_On, modified_On, email_Address_Status_ID, email_Address_Status_Email_Address_Status, cO_Created_On, last_Log_In, log_Ins, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Address", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Address_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal email_Address As String, ByVal created_On As Nullable(Of DateTime), ByVal modified_On As Nullable(Of DateTime), ByVal email_Address_Status_ID As Nullable(Of Integer), ByVal email_Address_Status_Email_Address_Status As String, ByVal cO_Created_On As Nullable(Of DateTime), ByVal last_Log_In As Nullable(Of DateTime), ByVal log_Ins As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Email_Address)
            Return [Select](email_Address_ID, company_ID, email_Address, created_On, modified_On, email_Address_Status_ID, email_Address_Status_Email_Address_Status, cO_Created_On, last_Log_In, log_Ins, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal email_Address_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Email_Address
            Dim list As List(Of MyCompany.Data.Objects.Email_Address) = [Select](email_Address_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Address", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Address)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Address)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Address
            Dim list As List(Of MyCompany.Data.Objects.Email_Address) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address, ByVal original_Email_Address As MyCompany.Data.Objects.Email_Address) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Email_Address_ID", original_Email_Address.Email_Address_ID, theEmail_Address.Email_Address_ID, true))
            values.Add(New FieldValue("Company_ID", original_Email_Address.Company_ID, theEmail_Address.Company_ID))
            values.Add(New FieldValue("Email_Address", original_Email_Address.Email_Address_, theEmail_Address.Email_Address_))
            values.Add(New FieldValue("Created_On", original_Email_Address.Created_On, theEmail_Address.Created_On))
            values.Add(New FieldValue("Modified_On", original_Email_Address.Modified_On, theEmail_Address.Modified_On))
            values.Add(New FieldValue("Email_Address_Status_ID", original_Email_Address.Email_Address_Status_ID, theEmail_Address.Email_Address_Status_ID))
            values.Add(New FieldValue("Email_Address_Status_Email_Address_Status", original_Email_Address.Email_Address_Status_Email_Address_Status, theEmail_Address.Email_Address_Status_Email_Address_Status, true))
            values.Add(New FieldValue("CO_Created_On", original_Email_Address.CO_Created_On, theEmail_Address.CO_Created_On, true))
            values.Add(New FieldValue("Last_Log_In", original_Email_Address.Last_Log_In, theEmail_Address.Last_Log_In, true))
            values.Add(New FieldValue("Log_Ins", original_Email_Address.Log_Ins, theEmail_Address.Log_Ins, true))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address, ByVal original_Email_Address As MyCompany.Data.Objects.Email_Address, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Email_Address"
            args.View = dataView
            args.Values = CreateFieldValues(theEmail_Address, original_Email_Address)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Email_Address", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theEmail_Address)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address, ByVal original_Email_Address As MyCompany.Data.Objects.Email_Address) As Integer
            Return ExecuteAction(theEmail_Address, original_Email_Address, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address) As Integer
            Return Update(theEmail_Address, SelectSingle(theEmail_Address.Email_Address_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address) As Integer
            Return ExecuteAction(theEmail_Address, New Email_Address(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theEmail_Address As MyCompany.Data.Objects.Email_Address) As Integer
            Return ExecuteAction(theEmail_Address, theEmail_Address, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
