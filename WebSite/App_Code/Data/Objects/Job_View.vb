Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Job_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Issue As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Solution As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_Saved_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Job_ID() As Nullable(Of Integer)
            Get
                Return m_Job_ID
            End Get
            Set
                m_Job_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_ID() As Nullable(Of Integer)
            Get
                Return m_Invoice_ID
            End Get
            Set
                m_Invoice_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Vehicle_ID() As Nullable(Of Integer)
            Get
                Return m_Vehicle_ID
            End Get
            Set
                m_Vehicle_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Issue() As String
            Get
                Return m_Issue
            End Get
            Set
                m_Issue = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Solution() As String
            Get
                Return m_Solution
            End Get
            Set
                m_Solution = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Job_Saved_ID() As Nullable(Of Integer)
            Get
                Return m_Job_Saved_ID
            End Get
            Set
                m_Job_Saved_ID = value
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
        Public Property Created_On() As Nullable(Of DateTime)
            Get
                Return m_Created_On
            End Get
            Set
                m_Created_On = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal job_ID As Nullable(Of Integer), ByVal invoice_ID As Nullable(Of Integer), ByVal vehicle_ID As Nullable(Of Integer), ByVal issue As String, ByVal job_Saved_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal created_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(job_ID, invoice_ID, vehicle_ID, issue, job_Saved_ID, company_ID, created_On)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Job_View) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, sort, Job_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, sort, Job_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, Nothing, Job_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Job_View)
            Return New Job_ViewFactory().Select(filter, Nothing, Job_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Job_View
            Return New Job_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Job_View
            Return New Job_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Job_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Job_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Job_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Job_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Job_View")
            End Get
        End Property
        
        Public Shared Function Create() As Job_ViewFactory
            Return New Job_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal job_ID As Nullable(Of Integer), ByVal invoice_ID As Nullable(Of Integer), ByVal vehicle_ID As Nullable(Of Integer), ByVal issue As String, ByVal job_Saved_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal created_On As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If job_ID.HasValue Then
                filter.Add(("Job_ID:=" + job_ID.Value.ToString()))
            End If
            If invoice_ID.HasValue Then
                filter.Add(("Invoice_ID:=" + invoice_ID.Value.ToString()))
            End If
            If vehicle_ID.HasValue Then
                filter.Add(("Vehicle_ID:=" + vehicle_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(issue)) Then
                filter.Add(("Issue:*" + issue))
            End If
            If job_Saved_ID.HasValue Then
                filter.Add(("Job_Saved_ID:=" + job_Saved_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If created_On.HasValue Then
                filter.Add(("Created_On:=" + created_On.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal job_ID As Nullable(Of Integer), ByVal invoice_ID As Nullable(Of Integer), ByVal vehicle_ID As Nullable(Of Integer), ByVal issue As String, ByVal job_Saved_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal created_On As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Job_View)
            Dim request As PageRequest = CreateRequest(job_ID, invoice_ID, vehicle_ID, issue, job_Saved_ID, company_ID, created_On, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Job_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Job_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Job_View) As List(Of MyCompany.Data.Objects.Job_View)
            Return [Select](qbe.Job_ID, qbe.Invoice_ID, qbe.Vehicle_ID, qbe.Issue, qbe.Job_Saved_ID, qbe.Company_ID, qbe.Created_On)
        End Function
        
        Public Function SelectCount(ByVal job_ID As Nullable(Of Integer), ByVal invoice_ID As Nullable(Of Integer), ByVal vehicle_ID As Nullable(Of Integer), ByVal issue As String, ByVal job_Saved_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal created_On As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(job_ID, invoice_ID, vehicle_ID, issue, job_Saved_ID, company_ID, created_On, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Job_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal job_ID As Nullable(Of Integer), ByVal invoice_ID As Nullable(Of Integer), ByVal vehicle_ID As Nullable(Of Integer), ByVal issue As String, ByVal job_Saved_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal created_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Job_View)
            Return [Select](job_ID, invoice_ID, vehicle_ID, issue, job_Saved_ID, company_ID, created_On, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Job_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Job_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Job_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Job_View
            Dim list As List(Of MyCompany.Data.Objects.Job_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
