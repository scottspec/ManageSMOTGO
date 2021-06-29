Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Customer_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_Type_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_First_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Last_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Other_First_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Other_Last_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Address_Line_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Address_Line_2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_City As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Zip_Code As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Referred_By_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Referral_Type_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Province As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Is_Deleted As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Pricing_Matrix_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Old_Customer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Modified_On As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Customer_ID() As Nullable(Of Integer)
            Get
                Return m_Customer_ID
            End Get
            Set
                m_Customer_ID = value
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
        Public Property Customer_Type_ID() As Nullable(Of Integer)
            Get
                Return m_Customer_Type_ID
            End Get
            Set
                m_Customer_Type_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property First_Name() As String
            Get
                Return m_First_Name
            End Get
            Set
                m_First_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Last_Name() As String
            Get
                Return m_Last_Name
            End Get
            Set
                m_Last_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Other_First_Name() As String
            Get
                Return m_Other_First_Name
            End Get
            Set
                m_Other_First_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Other_Last_Name() As String
            Get
                Return m_Other_Last_Name
            End Get
            Set
                m_Other_Last_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Address_Line_1() As String
            Get
                Return m_Address_Line_1
            End Get
            Set
                m_Address_Line_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Address_Line_2() As String
            Get
                Return m_Address_Line_2
            End Get
            Set
                m_Address_Line_2 = value
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
        Public Property Zip_Code() As String
            Get
                Return m_Zip_Code
            End Get
            Set
                m_Zip_Code = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Referred_By_ID() As Nullable(Of Integer)
            Get
                Return m_Referred_By_ID
            End Get
            Set
                m_Referred_By_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Referral_Type_ID() As Nullable(Of Integer)
            Get
                Return m_Referral_Type_ID
            End Get
            Set
                m_Referral_Type_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Province() As String
            Get
                Return m_Province
            End Get
            Set
                m_Province = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Is_Deleted() As Nullable(Of Boolean)
            Get
                Return m_Is_Deleted
            End Get
            Set
                m_Is_Deleted = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Pricing_Matrix_ID() As Nullable(Of Integer)
            Get
                Return m_Pricing_Matrix_ID
            End Get
            Set
                m_Pricing_Matrix_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Old_Customer_ID() As Nullable(Of Integer)
            Get
                Return m_Old_Customer_ID
            End Get
            Set
                m_Old_Customer_ID = value
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
        Public Property Customer_Note() As String
            Get
                Return m_Customer_Note
            End Get
            Set
                m_Customer_Note = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal customer_Type_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal referred_By_ID As Nullable(Of Integer),  _
                    ByVal referral_Type_ID As Nullable(Of Integer),  _
                    ByVal province As String,  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal old_Customer_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(customer_ID, company_ID, customer_Type_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, referred_By_ID, referral_Type_ID, province, is_Deleted, pricing_Matrix_ID, old_Customer_ID, created_On, modified_On)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Customer_View) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, sort, Customer_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, sort, Customer_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, Nothing, Customer_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Customer_View)
            Return New Customer_ViewFactory().Select(filter, Nothing, Customer_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Customer_View
            Return New Customer_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Customer_View
            Return New Customer_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Customer_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Customer_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Customer_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Customer_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Customer_View")
            End Get
        End Property
        
        Public Shared Function Create() As Customer_ViewFactory
            Return New Customer_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal customer_Type_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal referred_By_ID As Nullable(Of Integer),  _
                    ByVal referral_Type_ID As Nullable(Of Integer),  _
                    ByVal province As String,  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal old_Customer_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If customer_ID.HasValue Then
                filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If customer_Type_ID.HasValue Then
                filter.Add(("Customer_Type_ID:=" + customer_Type_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(first_Name)) Then
                filter.Add(("First_Name:*" + first_Name))
            End If
            If Not (String.IsNullOrEmpty(last_Name)) Then
                filter.Add(("Last_Name:*" + last_Name))
            End If
            If Not (String.IsNullOrEmpty(other_First_Name)) Then
                filter.Add(("Other_First_Name:*" + other_First_Name))
            End If
            If Not (String.IsNullOrEmpty(other_Last_Name)) Then
                filter.Add(("Other_Last_Name:*" + other_Last_Name))
            End If
            If Not (String.IsNullOrEmpty(address_Line_1)) Then
                filter.Add(("Address_Line_1:*" + address_Line_1))
            End If
            If Not (String.IsNullOrEmpty(address_Line_2)) Then
                filter.Add(("Address_Line_2:*" + address_Line_2))
            End If
            If Not (String.IsNullOrEmpty(city)) Then
                filter.Add(("City:*" + city))
            End If
            If Not (String.IsNullOrEmpty(state)) Then
                filter.Add(("State:*" + state))
            End If
            If Not (String.IsNullOrEmpty(zip_Code)) Then
                filter.Add(("Zip_Code:*" + zip_Code))
            End If
            If referred_By_ID.HasValue Then
                filter.Add(("Referred_By_ID:=" + referred_By_ID.Value.ToString()))
            End If
            If referral_Type_ID.HasValue Then
                filter.Add(("Referral_Type_ID:=" + referral_Type_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(province)) Then
                filter.Add(("Province:*" + province))
            End If
            If is_Deleted.HasValue Then
                filter.Add(("Is_Deleted:=" + is_Deleted.Value.ToString()))
            End If
            If pricing_Matrix_ID.HasValue Then
                filter.Add(("Pricing_Matrix_ID:=" + pricing_Matrix_ID.Value.ToString()))
            End If
            If old_Customer_ID.HasValue Then
                filter.Add(("Old_Customer_ID:=" + old_Customer_ID.Value.ToString()))
            End If
            If created_On.HasValue Then
                filter.Add(("Created_On:=" + created_On.Value.ToString()))
            End If
            If modified_On.HasValue Then
                filter.Add(("Modified_On:=" + modified_On.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal customer_Type_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal referred_By_ID As Nullable(Of Integer),  _
                    ByVal referral_Type_ID As Nullable(Of Integer),  _
                    ByVal province As String,  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal old_Customer_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Customer_View)
            Dim request As PageRequest = CreateRequest(customer_ID, company_ID, customer_Type_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, referred_By_ID, referral_Type_ID, province, is_Deleted, pricing_Matrix_ID, old_Customer_ID, created_On, modified_On, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Customer_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Customer_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Customer_View) As List(Of MyCompany.Data.Objects.Customer_View)
            Return [Select](qbe.Customer_ID, qbe.Company_ID, qbe.Customer_Type_ID, qbe.First_Name, qbe.Last_Name, qbe.Other_First_Name, qbe.Other_Last_Name, qbe.Address_Line_1, qbe.Address_Line_2, qbe.City, qbe.State, qbe.Zip_Code, qbe.Referred_By_ID, qbe.Referral_Type_ID, qbe.Province, qbe.Is_Deleted, qbe.Pricing_Matrix_ID, qbe.Old_Customer_ID, qbe.Created_On, qbe.Modified_On)
        End Function
        
        Public Function SelectCount( _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal customer_Type_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal referred_By_ID As Nullable(Of Integer),  _
                    ByVal referral_Type_ID As Nullable(Of Integer),  _
                    ByVal province As String,  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal old_Customer_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(customer_ID, company_ID, customer_Type_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, referred_By_ID, referral_Type_ID, province, is_Deleted, pricing_Matrix_ID, old_Customer_ID, created_On, modified_On, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Customer_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal customer_Type_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal referred_By_ID As Nullable(Of Integer),  _
                    ByVal referral_Type_ID As Nullable(Of Integer),  _
                    ByVal province As String,  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal old_Customer_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Customer_View)
            Return [Select](customer_ID, company_ID, customer_Type_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, referred_By_ID, referral_Type_ID, province, is_Deleted, pricing_Matrix_ID, old_Customer_ID, created_On, modified_On, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Customer_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Customer_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Customer_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Customer_View
            Dim list As List(Of MyCompany.Data.Objects.Customer_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
