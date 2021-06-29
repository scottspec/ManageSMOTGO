Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Part_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Job_Category_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Brand_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Manufacturer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Number As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Description As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cost As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_List_Price As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Selling_Price As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Pricing_Matrix As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Supplier_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Taxable As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Old_Part_ID As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Part_ID() As Nullable(Of Integer)
            Get
                Return m_Part_ID
            End Get
            Set
                m_Part_ID = value
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
        Public Property Part_Job_Category_ID() As Nullable(Of Integer)
            Get
                Return m_Part_Job_Category_ID
            End Get
            Set
                m_Part_Job_Category_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Brand_ID() As Nullable(Of Integer)
            Get
                Return m_Part_Brand_ID
            End Get
            Set
                m_Part_Brand_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Manufacturer_ID() As Nullable(Of Integer)
            Get
                Return m_Part_Manufacturer_ID
            End Get
            Set
                m_Part_Manufacturer_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Number() As String
            Get
                Return m_Part_Number
            End Get
            Set
                m_Part_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Description() As String
            Get
                Return m_Description
            End Get
            Set
                m_Description = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cost() As Nullable(Of Decimal)
            Get
                Return m_Cost
            End Get
            Set
                m_Cost = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property List_Price() As Nullable(Of Decimal)
            Get
                Return m_List_Price
            End Get
            Set
                m_List_Price = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Selling_Price() As Nullable(Of Decimal)
            Get
                Return m_Selling_Price
            End Get
            Set
                m_Selling_Price = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Pricing_Matrix() As Nullable(Of Boolean)
            Get
                Return m_Pricing_Matrix
            End Get
            Set
                m_Pricing_Matrix = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Supplier_ID() As Nullable(Of Integer)
            Get
                Return m_Part_Supplier_ID
            End Get
            Set
                m_Part_Supplier_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Taxable() As Nullable(Of Boolean)
            Get
                Return m_Taxable
            End Get
            Set
                m_Taxable = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Note() As String
            Get
                Return m_Part_Note
            End Get
            Set
                m_Part_Note = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Old_Part_ID() As Nullable(Of Integer)
            Get
                Return m_Old_Part_ID
            End Get
            Set
                m_Old_Part_ID = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal part_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal part_Job_Category_ID As Nullable(Of Integer), ByVal part_Brand_ID As Nullable(Of Integer), ByVal part_Manufacturer_ID As Nullable(Of Integer), ByVal part_Number As String, ByVal description As String, ByVal cost As Nullable(Of Decimal), ByVal list_Price As Nullable(Of Decimal), ByVal selling_Price As Nullable(Of Decimal), ByVal pricing_Matrix As Nullable(Of Boolean), ByVal part_Supplier_ID As Nullable(Of Integer), ByVal taxable As Nullable(Of Boolean), ByVal part_Note As String, ByVal old_Part_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(part_ID, company_ID, part_Job_Category_ID, part_Brand_ID, part_Manufacturer_ID, part_Number, description, cost, list_Price, selling_Price, pricing_Matrix, part_Supplier_ID, taxable, part_Note, old_Part_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Part_View) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, sort, Part_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, sort, Part_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, Nothing, Part_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Part_View)
            Return New Part_ViewFactory().Select(filter, Nothing, Part_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Part_View
            Return New Part_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Part_View
            Return New Part_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Part_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Part_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Part_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Part_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Part_View")
            End Get
        End Property
        
        Public Shared Function Create() As Part_ViewFactory
            Return New Part_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal part_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal part_Job_Category_ID As Nullable(Of Integer),  _
                    ByVal part_Brand_ID As Nullable(Of Integer),  _
                    ByVal part_Manufacturer_ID As Nullable(Of Integer),  _
                    ByVal part_Number As String,  _
                    ByVal description As String,  _
                    ByVal cost As Nullable(Of Decimal),  _
                    ByVal list_Price As Nullable(Of Decimal),  _
                    ByVal selling_Price As Nullable(Of Decimal),  _
                    ByVal pricing_Matrix As Nullable(Of Boolean),  _
                    ByVal part_Supplier_ID As Nullable(Of Integer),  _
                    ByVal taxable As Nullable(Of Boolean),  _
                    ByVal part_Note As String,  _
                    ByVal old_Part_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If part_ID.HasValue Then
                filter.Add(("Part_ID:=" + part_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If part_Job_Category_ID.HasValue Then
                filter.Add(("Part_Job_Category_ID:=" + part_Job_Category_ID.Value.ToString()))
            End If
            If part_Brand_ID.HasValue Then
                filter.Add(("Part_Brand_ID:=" + part_Brand_ID.Value.ToString()))
            End If
            If part_Manufacturer_ID.HasValue Then
                filter.Add(("Part_Manufacturer_ID:=" + part_Manufacturer_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(part_Number)) Then
                filter.Add(("Part_Number:*" + part_Number))
            End If
            If Not (String.IsNullOrEmpty(description)) Then
                filter.Add(("Description:*" + description))
            End If
            If cost.HasValue Then
                filter.Add(("Cost:=" + cost.Value.ToString()))
            End If
            If list_Price.HasValue Then
                filter.Add(("List_Price:=" + list_Price.Value.ToString()))
            End If
            If selling_Price.HasValue Then
                filter.Add(("Selling_Price:=" + selling_Price.Value.ToString()))
            End If
            If pricing_Matrix.HasValue Then
                filter.Add(("Pricing_Matrix:=" + pricing_Matrix.Value.ToString()))
            End If
            If part_Supplier_ID.HasValue Then
                filter.Add(("Part_Supplier_ID:=" + part_Supplier_ID.Value.ToString()))
            End If
            If taxable.HasValue Then
                filter.Add(("Taxable:=" + taxable.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(part_Note)) Then
                filter.Add(("Part_Note:*" + part_Note))
            End If
            If old_Part_ID.HasValue Then
                filter.Add(("Old_Part_ID:=" + old_Part_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal part_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal part_Job_Category_ID As Nullable(Of Integer),  _
                    ByVal part_Brand_ID As Nullable(Of Integer),  _
                    ByVal part_Manufacturer_ID As Nullable(Of Integer),  _
                    ByVal part_Number As String,  _
                    ByVal description As String,  _
                    ByVal cost As Nullable(Of Decimal),  _
                    ByVal list_Price As Nullable(Of Decimal),  _
                    ByVal selling_Price As Nullable(Of Decimal),  _
                    ByVal pricing_Matrix As Nullable(Of Boolean),  _
                    ByVal part_Supplier_ID As Nullable(Of Integer),  _
                    ByVal taxable As Nullable(Of Boolean),  _
                    ByVal part_Note As String,  _
                    ByVal old_Part_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Part_View)
            Dim request As PageRequest = CreateRequest(part_ID, company_ID, part_Job_Category_ID, part_Brand_ID, part_Manufacturer_ID, part_Number, description, cost, list_Price, selling_Price, pricing_Matrix, part_Supplier_ID, taxable, part_Note, old_Part_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Part_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Part_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Part_View) As List(Of MyCompany.Data.Objects.Part_View)
            Return [Select](qbe.Part_ID, qbe.Company_ID, qbe.Part_Job_Category_ID, qbe.Part_Brand_ID, qbe.Part_Manufacturer_ID, qbe.Part_Number, qbe.Description, qbe.Cost, qbe.List_Price, qbe.Selling_Price, qbe.Pricing_Matrix, qbe.Part_Supplier_ID, qbe.Taxable, qbe.Part_Note, qbe.Old_Part_ID)
        End Function
        
        Public Function SelectCount( _
                    ByVal part_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal part_Job_Category_ID As Nullable(Of Integer),  _
                    ByVal part_Brand_ID As Nullable(Of Integer),  _
                    ByVal part_Manufacturer_ID As Nullable(Of Integer),  _
                    ByVal part_Number As String,  _
                    ByVal description As String,  _
                    ByVal cost As Nullable(Of Decimal),  _
                    ByVal list_Price As Nullable(Of Decimal),  _
                    ByVal selling_Price As Nullable(Of Decimal),  _
                    ByVal pricing_Matrix As Nullable(Of Boolean),  _
                    ByVal part_Supplier_ID As Nullable(Of Integer),  _
                    ByVal taxable As Nullable(Of Boolean),  _
                    ByVal part_Note As String,  _
                    ByVal old_Part_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(part_ID, company_ID, part_Job_Category_ID, part_Brand_ID, part_Manufacturer_ID, part_Number, description, cost, list_Price, selling_Price, pricing_Matrix, part_Supplier_ID, taxable, part_Note, old_Part_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Part_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal part_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal part_Job_Category_ID As Nullable(Of Integer), ByVal part_Brand_ID As Nullable(Of Integer), ByVal part_Manufacturer_ID As Nullable(Of Integer), ByVal part_Number As String, ByVal description As String, ByVal cost As Nullable(Of Decimal), ByVal list_Price As Nullable(Of Decimal), ByVal selling_Price As Nullable(Of Decimal), ByVal pricing_Matrix As Nullable(Of Boolean), ByVal part_Supplier_ID As Nullable(Of Integer), ByVal taxable As Nullable(Of Boolean), ByVal part_Note As String, ByVal old_Part_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Part_View)
            Return [Select](part_ID, company_ID, part_Job_Category_ID, part_Brand_ID, part_Manufacturer_ID, part_Number, description, cost, list_Price, selling_Price, pricing_Matrix, part_Supplier_ID, taxable, part_Note, old_Part_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Part_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Part_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Part_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Part_View
            Dim list As List(Of MyCompany.Data.Objects.Part_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
