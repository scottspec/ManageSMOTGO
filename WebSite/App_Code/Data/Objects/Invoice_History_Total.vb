Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Invoice_History_Total
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Expr1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Expr1() As Nullable(Of Decimal)
            Get
                Return m_Expr1
            End Get
            Set
                m_Expr1 = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Company_ID() As Nullable(Of Integer)
            Get
                Return m_Company_ID
            End Get
            Set
                m_Company_ID = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal expr1 As Nullable(Of Decimal), ByVal name As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(expr1, name, company_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_History_Total) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, sort, Invoice_History_TotalFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, sort, Invoice_History_TotalFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, Nothing, Invoice_History_TotalFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return New Invoice_History_TotalFactory().Select(filter, Nothing, Invoice_History_TotalFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_History_Total
            Return New Invoice_History_TotalFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Invoice_History_Total
            Return New Invoice_History_TotalFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Invoice_History_TotalFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Invoice_History_Total")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Invoice_History_Total")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Invoice_History_Total")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Invoice_History_Total")
            End Get
        End Property
        
        Public Shared Function Create() As Invoice_History_TotalFactory
            Return New Invoice_History_TotalFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal expr1 As Nullable(Of Decimal), ByVal name As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If expr1.HasValue Then
                filter.Add(("Expr1:=" + expr1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(name)) Then
                filter.Add(("Name:*" + name))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal expr1 As Nullable(Of Decimal), ByVal name As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Dim request As PageRequest = CreateRequest(expr1, name, company_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_History_Total", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_History_Total)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_History_Total) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return [Select](qbe.Expr1, qbe.Name, qbe.Company_ID)
        End Function
        
        Public Function SelectCount(ByVal expr1 As Nullable(Of Decimal), ByVal name As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(expr1, name, company_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_History_Total", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal expr1 As Nullable(Of Decimal), ByVal name As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return [Select](expr1, name, company_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Invoice_History_Total", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_History_Total)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_Total)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_History_Total
            Dim list As List(Of MyCompany.Data.Objects.Invoice_History_Total) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
