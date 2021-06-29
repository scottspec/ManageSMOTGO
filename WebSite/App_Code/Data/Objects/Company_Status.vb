Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Company_Status
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_Status_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_User_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_City As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_First_Log_In As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Last_Log_In As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Log_Ins As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoices As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Total As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_History_Count As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_History_Total As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customers As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicles As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Parts As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Total_Pages As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Daily_Pages As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Company_Status_ID() As Nullable(Of Integer)
            Get
                Return m_Company_Status_ID
            End Get
            Set
                m_Company_Status_ID = value
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
        Public Property User_Name() As String
            Get
                Return m_User_Name
            End Get
            Set
                m_User_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set
                m_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property City() As String
            Get
                Return m_City
            End Get
            Set
                m_City = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property State() As String
            Get
                Return m_State
            End Get
            Set
                m_State = value
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
        Public Property First_Log_In() As Nullable(Of DateTime)
            Get
                Return m_First_Log_In
            End Get
            Set
                m_First_Log_In = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoices() As Nullable(Of Integer)
            Get
                Return m_Invoices
            End Get
            Set
                m_Invoices = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Total() As Nullable(Of Integer)
            Get
                Return m_Invoice_Total
            End Get
            Set
                m_Invoice_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property History_Count() As Nullable(Of Integer)
            Get
                Return m_History_Count
            End Get
            Set
                m_History_Count = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property History_Total() As Nullable(Of Integer)
            Get
                Return m_History_Total
            End Get
            Set
                m_History_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Customers() As Nullable(Of Integer)
            Get
                Return m_Customers
            End Get
            Set
                m_Customers = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Vehicles() As Nullable(Of Integer)
            Get
                Return m_Vehicles
            End Get
            Set
                m_Vehicles = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Parts() As Nullable(Of Integer)
            Get
                Return m_Parts
            End Get
            Set
                m_Parts = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Total_Pages() As Nullable(Of Integer)
            Get
                Return m_Total_Pages
            End Get
            Set
                m_Total_Pages = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Daily_Pages() As Nullable(Of Integer)
            Get
                Return m_Daily_Pages
            End Get
            Set
                m_Daily_Pages = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal company_Status_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal name As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal first_Log_In As Nullable(Of DateTime),  _
                    ByVal last_Log_In As Nullable(Of DateTime),  _
                    ByVal log_Ins As Nullable(Of Integer),  _
                    ByVal invoices As Nullable(Of Integer),  _
                    ByVal invoice_Total As Nullable(Of Integer),  _
                    ByVal history_Count As Nullable(Of Integer),  _
                    ByVal history_Total As Nullable(Of Integer),  _
                    ByVal customers As Nullable(Of Integer),  _
                    ByVal vehicles As Nullable(Of Integer),  _
                    ByVal parts As Nullable(Of Integer),  _
                    ByVal total_Pages As Nullable(Of Integer),  _
                    ByVal daily_Pages As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(company_Status_ID, company_ID, user_Name, name, city, state, created_On, first_Log_In, last_Log_In, log_Ins, invoices, invoice_Total, history_Count, history_Total, customers, vehicles, parts, total_Pages, daily_Pages)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_Status) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, sort, Company_StatusFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, sort, Company_StatusFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, Nothing, Company_StatusFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_Status)
            Return New Company_StatusFactory().Select(filter, Nothing, Company_StatusFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_Status
            Return New Company_StatusFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Company_Status
            Return New Company_StatusFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal company_Status_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Company_Status
            Return New Company_StatusFactory().SelectSingle(company_Status_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Company_StatusFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Company_StatusFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Company_StatusFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Company_Status_ID: {0}", Me.Company_Status_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Company_StatusFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Company_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Company_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Company_Status")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Company_Status")
            End Get
        End Property
        
        Public Shared Function Create() As Company_StatusFactory
            Return New Company_StatusFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal company_Status_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal name As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal first_Log_In As Nullable(Of DateTime),  _
                    ByVal last_Log_In As Nullable(Of DateTime),  _
                    ByVal log_Ins As Nullable(Of Integer),  _
                    ByVal invoices As Nullable(Of Integer),  _
                    ByVal invoice_Total As Nullable(Of Integer),  _
                    ByVal history_Count As Nullable(Of Integer),  _
                    ByVal history_Total As Nullable(Of Integer),  _
                    ByVal customers As Nullable(Of Integer),  _
                    ByVal vehicles As Nullable(Of Integer),  _
                    ByVal parts As Nullable(Of Integer),  _
                    ByVal total_Pages As Nullable(Of Integer),  _
                    ByVal daily_Pages As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If company_Status_ID.HasValue Then
                filter.Add(("Company_Status_ID:=" + company_Status_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(user_Name)) Then
                filter.Add(("User_Name:*" + user_Name))
            End If
            If Not (String.IsNullOrEmpty(name)) Then
                filter.Add(("Name:*" + name))
            End If
            If Not (String.IsNullOrEmpty(city)) Then
                filter.Add(("City:*" + city))
            End If
            If Not (String.IsNullOrEmpty(state)) Then
                filter.Add(("State:*" + state))
            End If
            If created_On.HasValue Then
                filter.Add(("Created_On:=" + created_On.Value.ToString()))
            End If
            If first_Log_In.HasValue Then
                filter.Add(("First_Log_In:=" + first_Log_In.Value.ToString()))
            End If
            If last_Log_In.HasValue Then
                filter.Add(("Last_Log_In:=" + last_Log_In.Value.ToString()))
            End If
            If log_Ins.HasValue Then
                filter.Add(("Log_Ins:=" + log_Ins.Value.ToString()))
            End If
            If invoices.HasValue Then
                filter.Add(("Invoices:=" + invoices.Value.ToString()))
            End If
            If invoice_Total.HasValue Then
                filter.Add(("Invoice_Total:=" + invoice_Total.Value.ToString()))
            End If
            If history_Count.HasValue Then
                filter.Add(("History_Count:=" + history_Count.Value.ToString()))
            End If
            If history_Total.HasValue Then
                filter.Add(("History_Total:=" + history_Total.Value.ToString()))
            End If
            If customers.HasValue Then
                filter.Add(("Customers:=" + customers.Value.ToString()))
            End If
            If vehicles.HasValue Then
                filter.Add(("Vehicles:=" + vehicles.Value.ToString()))
            End If
            If parts.HasValue Then
                filter.Add(("Parts:=" + parts.Value.ToString()))
            End If
            If total_Pages.HasValue Then
                filter.Add(("Total_Pages:=" + total_Pages.Value.ToString()))
            End If
            If daily_Pages.HasValue Then
                filter.Add(("Daily_Pages:=" + daily_Pages.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal company_Status_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal name As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal first_Log_In As Nullable(Of DateTime),  _
                    ByVal last_Log_In As Nullable(Of DateTime),  _
                    ByVal log_Ins As Nullable(Of Integer),  _
                    ByVal invoices As Nullable(Of Integer),  _
                    ByVal invoice_Total As Nullable(Of Integer),  _
                    ByVal history_Count As Nullable(Of Integer),  _
                    ByVal history_Total As Nullable(Of Integer),  _
                    ByVal customers As Nullable(Of Integer),  _
                    ByVal vehicles As Nullable(Of Integer),  _
                    ByVal parts As Nullable(Of Integer),  _
                    ByVal total_Pages As Nullable(Of Integer),  _
                    ByVal daily_Pages As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Company_Status)
            Dim request As PageRequest = CreateRequest(company_Status_ID, company_ID, user_Name, name, city, state, created_On, first_Log_In, last_Log_In, log_Ins, invoices, invoice_Total, history_Count, history_Total, customers, vehicles, parts, total_Pages, daily_Pages, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_Status", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_Status)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_Status) As List(Of MyCompany.Data.Objects.Company_Status)
            Return [Select](qbe.Company_Status_ID, qbe.Company_ID, qbe.User_Name, qbe.Name, qbe.City, qbe.State, qbe.Created_On, qbe.First_Log_In, qbe.Last_Log_In, qbe.Log_Ins, qbe.Invoices, qbe.Invoice_Total, qbe.History_Count, qbe.History_Total, qbe.Customers, qbe.Vehicles, qbe.Parts, qbe.Total_Pages, qbe.Daily_Pages)
        End Function
        
        Public Function SelectCount( _
                    ByVal company_Status_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal name As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal first_Log_In As Nullable(Of DateTime),  _
                    ByVal last_Log_In As Nullable(Of DateTime),  _
                    ByVal log_Ins As Nullable(Of Integer),  _
                    ByVal invoices As Nullable(Of Integer),  _
                    ByVal invoice_Total As Nullable(Of Integer),  _
                    ByVal history_Count As Nullable(Of Integer),  _
                    ByVal history_Total As Nullable(Of Integer),  _
                    ByVal customers As Nullable(Of Integer),  _
                    ByVal vehicles As Nullable(Of Integer),  _
                    ByVal parts As Nullable(Of Integer),  _
                    ByVal total_Pages As Nullable(Of Integer),  _
                    ByVal daily_Pages As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(company_Status_ID, company_ID, user_Name, name, city, state, created_On, first_Log_In, last_Log_In, log_Ins, invoices, invoice_Total, history_Count, history_Total, customers, vehicles, parts, total_Pages, daily_Pages, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_Status", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal company_Status_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal name As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal first_Log_In As Nullable(Of DateTime),  _
                    ByVal last_Log_In As Nullable(Of DateTime),  _
                    ByVal log_Ins As Nullable(Of Integer),  _
                    ByVal invoices As Nullable(Of Integer),  _
                    ByVal invoice_Total As Nullable(Of Integer),  _
                    ByVal history_Count As Nullable(Of Integer),  _
                    ByVal history_Total As Nullable(Of Integer),  _
                    ByVal customers As Nullable(Of Integer),  _
                    ByVal vehicles As Nullable(Of Integer),  _
                    ByVal parts As Nullable(Of Integer),  _
                    ByVal total_Pages As Nullable(Of Integer),  _
                    ByVal daily_Pages As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Company_Status)
            Return [Select](company_Status_ID, company_ID, user_Name, name, city, state, created_On, first_Log_In, last_Log_In, log_Ins, invoices, invoice_Total, history_Count, history_Total, customers, vehicles, parts, total_Pages, daily_Pages, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal company_Status_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Company_Status
            Dim list As List(Of MyCompany.Data.Objects.Company_Status) = [Select](company_Status_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Company_Status", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_Status)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_Status)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_Status
            Dim list As List(Of MyCompany.Data.Objects.Company_Status) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status, ByVal original_Company_Status As MyCompany.Data.Objects.Company_Status) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Company_Status_ID", original_Company_Status.Company_Status_ID, theCompany_Status.Company_Status_ID, true))
            values.Add(New FieldValue("Company_ID", original_Company_Status.Company_ID, theCompany_Status.Company_ID))
            values.Add(New FieldValue("User_Name", original_Company_Status.User_Name, theCompany_Status.User_Name))
            values.Add(New FieldValue("Name", original_Company_Status.Name, theCompany_Status.Name))
            values.Add(New FieldValue("City", original_Company_Status.City, theCompany_Status.City))
            values.Add(New FieldValue("State", original_Company_Status.State, theCompany_Status.State))
            values.Add(New FieldValue("Created_On", original_Company_Status.Created_On, theCompany_Status.Created_On))
            values.Add(New FieldValue("First_Log_In", original_Company_Status.First_Log_In, theCompany_Status.First_Log_In))
            values.Add(New FieldValue("Last_Log_In", original_Company_Status.Last_Log_In, theCompany_Status.Last_Log_In))
            values.Add(New FieldValue("Log_Ins", original_Company_Status.Log_Ins, theCompany_Status.Log_Ins))
            values.Add(New FieldValue("Invoices", original_Company_Status.Invoices, theCompany_Status.Invoices))
            values.Add(New FieldValue("Invoice_Total", original_Company_Status.Invoice_Total, theCompany_Status.Invoice_Total))
            values.Add(New FieldValue("History_Count", original_Company_Status.History_Count, theCompany_Status.History_Count))
            values.Add(New FieldValue("History_Total", original_Company_Status.History_Total, theCompany_Status.History_Total))
            values.Add(New FieldValue("Customers", original_Company_Status.Customers, theCompany_Status.Customers))
            values.Add(New FieldValue("Vehicles", original_Company_Status.Vehicles, theCompany_Status.Vehicles))
            values.Add(New FieldValue("Parts", original_Company_Status.Parts, theCompany_Status.Parts))
            values.Add(New FieldValue("Total_Pages", original_Company_Status.Total_Pages, theCompany_Status.Total_Pages))
            values.Add(New FieldValue("Daily_Pages", original_Company_Status.Daily_Pages, theCompany_Status.Daily_Pages))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status, ByVal original_Company_Status As MyCompany.Data.Objects.Company_Status, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Company_Status"
            args.View = dataView
            args.Values = CreateFieldValues(theCompany_Status, original_Company_Status)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Company_Status", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theCompany_Status)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status, ByVal original_Company_Status As MyCompany.Data.Objects.Company_Status) As Integer
            Return ExecuteAction(theCompany_Status, original_Company_Status, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status) As Integer
            Return Update(theCompany_Status, SelectSingle(theCompany_Status.Company_Status_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status) As Integer
            Return ExecuteAction(theCompany_Status, New Company_Status(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theCompany_Status As MyCompany.Data.Objects.Company_Status) As Integer
            Return ExecuteAction(theCompany_Status, theCompany_Status, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
