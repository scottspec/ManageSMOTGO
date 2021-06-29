Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Company_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CompanyID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Name As String
        
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
        Private m_Federal_Tax_ID As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State_Tax_ID As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sales_Tax_ID As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Web_Site As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_1_Type As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_2_Type As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_3_Type As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Phone_Number_3 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fax_Number As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agreed_To_Terms_By As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agreed_To_Terms_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Number As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Order_Number As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Return_Number As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Appointment_Number As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Estimate_Number As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tax_Rate_Parts As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tax_Rate_Labor As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Logo() As Byte
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Is_Deleted As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Pricing_Matrix_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Process_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Full_Schedule_Hour As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Service_Interval_Mile As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Service_Interval_Day As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ink_Saver As Nullable(Of Boolean)
        
        Public Sub New()
            MyBase.New
        End Sub
        
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
        Public Property CompanyID() As Nullable(Of Integer)
            Get
                Return m_CompanyID
            End Get
            Set
                m_CompanyID = value
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
        Public Property Federal_Tax_ID() As String
            Get
                Return m_Federal_Tax_ID
            End Get
            Set
                m_Federal_Tax_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property State_Tax_ID() As String
            Get
                Return m_State_Tax_ID
            End Get
            Set
                m_State_Tax_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Sales_Tax_ID() As String
            Get
                Return m_Sales_Tax_ID
            End Get
            Set
                m_Sales_Tax_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Web_Site() As String
            Get
                Return m_Web_Site
            End Get
            Set
                m_Web_Site = value
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
        Public Property Phone_Number_1_Type() As Nullable(Of Integer)
            Get
                Return m_Phone_Number_1_Type
            End Get
            Set
                m_Phone_Number_1_Type = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Phone_Number_1() As String
            Get
                Return m_Phone_Number_1
            End Get
            Set
                m_Phone_Number_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Phone_Number_2_Type() As Nullable(Of Integer)
            Get
                Return m_Phone_Number_2_Type
            End Get
            Set
                m_Phone_Number_2_Type = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Phone_Number_2() As String
            Get
                Return m_Phone_Number_2
            End Get
            Set
                m_Phone_Number_2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Phone_Number_3_Type() As Nullable(Of Integer)
            Get
                Return m_Phone_Number_3_Type
            End Get
            Set
                m_Phone_Number_3_Type = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Phone_Number_3() As String
            Get
                Return m_Phone_Number_3
            End Get
            Set
                m_Phone_Number_3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fax_Number() As String
            Get
                Return m_Fax_Number
            End Get
            Set
                m_Fax_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Agreed_To_Terms_By() As String
            Get
                Return m_Agreed_To_Terms_By
            End Get
            Set
                m_Agreed_To_Terms_By = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Agreed_To_Terms_On() As Nullable(Of DateTime)
            Get
                Return m_Agreed_To_Terms_On
            End Get
            Set
                m_Agreed_To_Terms_On = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Note() As String
            Get
                Return m_Note
            End Get
            Set
                m_Note = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Number() As Nullable(Of Integer)
            Get
                Return m_Invoice_Number
            End Get
            Set
                m_Invoice_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Order_Number() As Nullable(Of Integer)
            Get
                Return m_Order_Number
            End Get
            Set
                m_Order_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Return_Number() As Nullable(Of Integer)
            Get
                Return m_Return_Number
            End Get
            Set
                m_Return_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Appointment_Number() As Nullable(Of Integer)
            Get
                Return m_Appointment_Number
            End Get
            Set
                m_Appointment_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Estimate_Number() As Nullable(Of Integer)
            Get
                Return m_Estimate_Number
            End Get
            Set
                m_Estimate_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Tax_Rate_Parts() As Nullable(Of Double)
            Get
                Return m_Tax_Rate_Parts
            End Get
            Set
                m_Tax_Rate_Parts = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Tax_Rate_Labor() As Nullable(Of Double)
            Get
                Return m_Tax_Rate_Labor
            End Get
            Set
                m_Tax_Rate_Labor = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Logo() As Byte()
            Get
                Return m_Logo
            End Get
            Set
                m_Logo = value
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
        Public Property Process_Date() As Nullable(Of DateTime)
            Get
                Return m_Process_Date
            End Get
            Set
                m_Process_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Full_Schedule_Hour() As Nullable(Of Double)
            Get
                Return m_Full_Schedule_Hour
            End Get
            Set
                m_Full_Schedule_Hour = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Service_Interval_Mile() As Nullable(Of Integer)
            Get
                Return m_Service_Interval_Mile
            End Get
            Set
                m_Service_Interval_Mile = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Service_Interval_Day() As Nullable(Of Integer)
            Get
                Return m_Service_Interval_Day
            End Get
            Set
                m_Service_Interval_Day = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Ink_Saver() As Nullable(Of Boolean)
            Get
                Return m_Ink_Saver
            End Get
            Set
                m_Ink_Saver = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal companyID As Nullable(Of Integer),  _
                    ByVal name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal federal_Tax_ID As String,  _
                    ByVal state_Tax_ID As String,  _
                    ByVal sales_Tax_ID As String,  _
                    ByVal web_Site As String,  _
                    ByVal email_Address As String,  _
                    ByVal phone_Number_1_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_1 As String,  _
                    ByVal phone_Number_2_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_2 As String,  _
                    ByVal phone_Number_3_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_3 As String,  _
                    ByVal fax_Number As String,  _
                    ByVal agreed_To_Terms_By As String,  _
                    ByVal agreed_To_Terms_On As Nullable(Of DateTime),  _
                    ByVal note As String,  _
                    ByVal invoice_Number As Nullable(Of Integer),  _
                    ByVal order_Number As Nullable(Of Integer),  _
                    ByVal return_Number As Nullable(Of Integer),  _
                    ByVal appointment_Number As Nullable(Of Integer),  _
                    ByVal estimate_Number As Nullable(Of Integer),  _
                    ByVal tax_Rate_Parts As Nullable(Of Double),  _
                    ByVal tax_Rate_Labor As Nullable(Of Double),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal process_Date As Nullable(Of DateTime),  _
                    ByVal full_Schedule_Hour As Nullable(Of Double),  _
                    ByVal service_Interval_Mile As Nullable(Of Integer),  _
                    ByVal service_Interval_Day As Nullable(Of Integer),  _
                    ByVal ink_Saver As Nullable(Of Boolean)) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(company_ID, companyID, name, address_Line_1, address_Line_2, city, state, zip_Code, federal_Tax_ID, state_Tax_ID, sales_Tax_ID, web_Site, email_Address, phone_Number_1_Type, phone_Number_1, phone_Number_2_Type, phone_Number_2, phone_Number_3_Type, phone_Number_3, fax_Number, agreed_To_Terms_By, agreed_To_Terms_On, note, invoice_Number, order_Number, return_Number, appointment_Number, estimate_Number, tax_Rate_Parts, tax_Rate_Labor, is_Deleted, pricing_Matrix_ID, process_Date, full_Schedule_Hour, service_Interval_Mile, service_Interval_Day, ink_Saver)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_View) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, sort, Company_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, sort, Company_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, Nothing, Company_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_View)
            Return New Company_ViewFactory().Select(filter, Nothing, Company_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_View
            Return New Company_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Company_View
            Return New Company_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Company_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Company_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Company_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Company_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Company_View")
            End Get
        End Property
        
        Public Shared Function Create() As Company_ViewFactory
            Return New Company_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal companyID As Nullable(Of Integer),  _
                    ByVal name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal federal_Tax_ID As String,  _
                    ByVal state_Tax_ID As String,  _
                    ByVal sales_Tax_ID As String,  _
                    ByVal web_Site As String,  _
                    ByVal email_Address As String,  _
                    ByVal phone_Number_1_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_1 As String,  _
                    ByVal phone_Number_2_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_2 As String,  _
                    ByVal phone_Number_3_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_3 As String,  _
                    ByVal fax_Number As String,  _
                    ByVal agreed_To_Terms_By As String,  _
                    ByVal agreed_To_Terms_On As Nullable(Of DateTime),  _
                    ByVal note As String,  _
                    ByVal invoice_Number As Nullable(Of Integer),  _
                    ByVal order_Number As Nullable(Of Integer),  _
                    ByVal return_Number As Nullable(Of Integer),  _
                    ByVal appointment_Number As Nullable(Of Integer),  _
                    ByVal estimate_Number As Nullable(Of Integer),  _
                    ByVal tax_Rate_Parts As Nullable(Of Double),  _
                    ByVal tax_Rate_Labor As Nullable(Of Double),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal process_Date As Nullable(Of DateTime),  _
                    ByVal full_Schedule_Hour As Nullable(Of Double),  _
                    ByVal service_Interval_Mile As Nullable(Of Integer),  _
                    ByVal service_Interval_Day As Nullable(Of Integer),  _
                    ByVal ink_Saver As Nullable(Of Boolean),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If companyID.HasValue Then
                filter.Add(("CompanyID:=" + companyID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(name)) Then
                filter.Add(("Name:*" + name))
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
            If Not (String.IsNullOrEmpty(federal_Tax_ID)) Then
                filter.Add(("Federal_Tax_ID:*" + federal_Tax_ID))
            End If
            If Not (String.IsNullOrEmpty(state_Tax_ID)) Then
                filter.Add(("State_Tax_ID:*" + state_Tax_ID))
            End If
            If Not (String.IsNullOrEmpty(sales_Tax_ID)) Then
                filter.Add(("Sales_Tax_ID:*" + sales_Tax_ID))
            End If
            If Not (String.IsNullOrEmpty(web_Site)) Then
                filter.Add(("Web_Site:*" + web_Site))
            End If
            If Not (String.IsNullOrEmpty(email_Address)) Then
                filter.Add(("Email_Address:*" + email_Address))
            End If
            If phone_Number_1_Type.HasValue Then
                filter.Add(("Phone_Number_1_Type:=" + phone_Number_1_Type.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(phone_Number_1)) Then
                filter.Add(("Phone_Number_1:*" + phone_Number_1))
            End If
            If phone_Number_2_Type.HasValue Then
                filter.Add(("Phone_Number_2_Type:=" + phone_Number_2_Type.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(phone_Number_2)) Then
                filter.Add(("Phone_Number_2:*" + phone_Number_2))
            End If
            If phone_Number_3_Type.HasValue Then
                filter.Add(("Phone_Number_3_Type:=" + phone_Number_3_Type.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(phone_Number_3)) Then
                filter.Add(("Phone_Number_3:*" + phone_Number_3))
            End If
            If Not (String.IsNullOrEmpty(fax_Number)) Then
                filter.Add(("Fax_Number:*" + fax_Number))
            End If
            If Not (String.IsNullOrEmpty(agreed_To_Terms_By)) Then
                filter.Add(("Agreed_To_Terms_By:*" + agreed_To_Terms_By))
            End If
            If agreed_To_Terms_On.HasValue Then
                filter.Add(("Agreed_To_Terms_On:=" + agreed_To_Terms_On.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(note)) Then
                filter.Add(("Note:*" + note))
            End If
            If invoice_Number.HasValue Then
                filter.Add(("Invoice_Number:=" + invoice_Number.Value.ToString()))
            End If
            If order_Number.HasValue Then
                filter.Add(("Order_Number:=" + order_Number.Value.ToString()))
            End If
            If return_Number.HasValue Then
                filter.Add(("Return_Number:=" + return_Number.Value.ToString()))
            End If
            If appointment_Number.HasValue Then
                filter.Add(("Appointment_Number:=" + appointment_Number.Value.ToString()))
            End If
            If estimate_Number.HasValue Then
                filter.Add(("Estimate_Number:=" + estimate_Number.Value.ToString()))
            End If
            If tax_Rate_Parts.HasValue Then
                filter.Add(("Tax_Rate_Parts:=" + tax_Rate_Parts.Value.ToString()))
            End If
            If tax_Rate_Labor.HasValue Then
                filter.Add(("Tax_Rate_Labor:=" + tax_Rate_Labor.Value.ToString()))
            End If
            If is_Deleted.HasValue Then
                filter.Add(("Is_Deleted:=" + is_Deleted.Value.ToString()))
            End If
            If pricing_Matrix_ID.HasValue Then
                filter.Add(("Pricing_Matrix_ID:=" + pricing_Matrix_ID.Value.ToString()))
            End If
            If process_Date.HasValue Then
                filter.Add(("Process_Date:=" + process_Date.Value.ToString()))
            End If
            If full_Schedule_Hour.HasValue Then
                filter.Add(("Full_Schedule_Hour:=" + full_Schedule_Hour.Value.ToString()))
            End If
            If service_Interval_Mile.HasValue Then
                filter.Add(("Service_Interval_Mile:=" + service_Interval_Mile.Value.ToString()))
            End If
            If service_Interval_Day.HasValue Then
                filter.Add(("Service_Interval_Day:=" + service_Interval_Day.Value.ToString()))
            End If
            If ink_Saver.HasValue Then
                filter.Add(("Ink_Saver:=" + ink_Saver.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal companyID As Nullable(Of Integer),  _
                    ByVal name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal federal_Tax_ID As String,  _
                    ByVal state_Tax_ID As String,  _
                    ByVal sales_Tax_ID As String,  _
                    ByVal web_Site As String,  _
                    ByVal email_Address As String,  _
                    ByVal phone_Number_1_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_1 As String,  _
                    ByVal phone_Number_2_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_2 As String,  _
                    ByVal phone_Number_3_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_3 As String,  _
                    ByVal fax_Number As String,  _
                    ByVal agreed_To_Terms_By As String,  _
                    ByVal agreed_To_Terms_On As Nullable(Of DateTime),  _
                    ByVal note As String,  _
                    ByVal invoice_Number As Nullable(Of Integer),  _
                    ByVal order_Number As Nullable(Of Integer),  _
                    ByVal return_Number As Nullable(Of Integer),  _
                    ByVal appointment_Number As Nullable(Of Integer),  _
                    ByVal estimate_Number As Nullable(Of Integer),  _
                    ByVal tax_Rate_Parts As Nullable(Of Double),  _
                    ByVal tax_Rate_Labor As Nullable(Of Double),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal process_Date As Nullable(Of DateTime),  _
                    ByVal full_Schedule_Hour As Nullable(Of Double),  _
                    ByVal service_Interval_Mile As Nullable(Of Integer),  _
                    ByVal service_Interval_Day As Nullable(Of Integer),  _
                    ByVal ink_Saver As Nullable(Of Boolean),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Company_View)
            Dim request As PageRequest = CreateRequest(company_ID, companyID, name, address_Line_1, address_Line_2, city, state, zip_Code, federal_Tax_ID, state_Tax_ID, sales_Tax_ID, web_Site, email_Address, phone_Number_1_Type, phone_Number_1, phone_Number_2_Type, phone_Number_2, phone_Number_3_Type, phone_Number_3, fax_Number, agreed_To_Terms_By, agreed_To_Terms_On, note, invoice_Number, order_Number, return_Number, appointment_Number, estimate_Number, tax_Rate_Parts, tax_Rate_Labor, is_Deleted, pricing_Matrix_ID, process_Date, full_Schedule_Hour, service_Interval_Mile, service_Interval_Day, ink_Saver, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_View) As List(Of MyCompany.Data.Objects.Company_View)
            Return [Select](qbe.Company_ID, qbe.CompanyID, qbe.Name, qbe.Address_Line_1, qbe.Address_Line_2, qbe.City, qbe.State, qbe.Zip_Code, qbe.Federal_Tax_ID, qbe.State_Tax_ID, qbe.Sales_Tax_ID, qbe.Web_Site, qbe.Email_Address, qbe.Phone_Number_1_Type, qbe.Phone_Number_1, qbe.Phone_Number_2_Type, qbe.Phone_Number_2, qbe.Phone_Number_3_Type, qbe.Phone_Number_3, qbe.Fax_Number, qbe.Agreed_To_Terms_By, qbe.Agreed_To_Terms_On, qbe.Note, qbe.Invoice_Number, qbe.Order_Number, qbe.Return_Number, qbe.Appointment_Number, qbe.Estimate_Number, qbe.Tax_Rate_Parts, qbe.Tax_Rate_Labor, qbe.Is_Deleted, qbe.Pricing_Matrix_ID, qbe.Process_Date, qbe.Full_Schedule_Hour, qbe.Service_Interval_Mile, qbe.Service_Interval_Day, qbe.Ink_Saver)
        End Function
        
        Public Function SelectCount( _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal companyID As Nullable(Of Integer),  _
                    ByVal name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal federal_Tax_ID As String,  _
                    ByVal state_Tax_ID As String,  _
                    ByVal sales_Tax_ID As String,  _
                    ByVal web_Site As String,  _
                    ByVal email_Address As String,  _
                    ByVal phone_Number_1_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_1 As String,  _
                    ByVal phone_Number_2_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_2 As String,  _
                    ByVal phone_Number_3_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_3 As String,  _
                    ByVal fax_Number As String,  _
                    ByVal agreed_To_Terms_By As String,  _
                    ByVal agreed_To_Terms_On As Nullable(Of DateTime),  _
                    ByVal note As String,  _
                    ByVal invoice_Number As Nullable(Of Integer),  _
                    ByVal order_Number As Nullable(Of Integer),  _
                    ByVal return_Number As Nullable(Of Integer),  _
                    ByVal appointment_Number As Nullable(Of Integer),  _
                    ByVal estimate_Number As Nullable(Of Integer),  _
                    ByVal tax_Rate_Parts As Nullable(Of Double),  _
                    ByVal tax_Rate_Labor As Nullable(Of Double),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal process_Date As Nullable(Of DateTime),  _
                    ByVal full_Schedule_Hour As Nullable(Of Double),  _
                    ByVal service_Interval_Mile As Nullable(Of Integer),  _
                    ByVal service_Interval_Day As Nullable(Of Integer),  _
                    ByVal ink_Saver As Nullable(Of Boolean),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(company_ID, companyID, name, address_Line_1, address_Line_2, city, state, zip_Code, federal_Tax_ID, state_Tax_ID, sales_Tax_ID, web_Site, email_Address, phone_Number_1_Type, phone_Number_1, phone_Number_2_Type, phone_Number_2, phone_Number_3_Type, phone_Number_3, fax_Number, agreed_To_Terms_By, agreed_To_Terms_On, note, invoice_Number, order_Number, return_Number, appointment_Number, estimate_Number, tax_Rate_Parts, tax_Rate_Labor, is_Deleted, pricing_Matrix_ID, process_Date, full_Schedule_Hour, service_Interval_Mile, service_Interval_Day, ink_Saver, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal companyID As Nullable(Of Integer),  _
                    ByVal name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal federal_Tax_ID As String,  _
                    ByVal state_Tax_ID As String,  _
                    ByVal sales_Tax_ID As String,  _
                    ByVal web_Site As String,  _
                    ByVal email_Address As String,  _
                    ByVal phone_Number_1_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_1 As String,  _
                    ByVal phone_Number_2_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_2 As String,  _
                    ByVal phone_Number_3_Type As Nullable(Of Integer),  _
                    ByVal phone_Number_3 As String,  _
                    ByVal fax_Number As String,  _
                    ByVal agreed_To_Terms_By As String,  _
                    ByVal agreed_To_Terms_On As Nullable(Of DateTime),  _
                    ByVal note As String,  _
                    ByVal invoice_Number As Nullable(Of Integer),  _
                    ByVal order_Number As Nullable(Of Integer),  _
                    ByVal return_Number As Nullable(Of Integer),  _
                    ByVal appointment_Number As Nullable(Of Integer),  _
                    ByVal estimate_Number As Nullable(Of Integer),  _
                    ByVal tax_Rate_Parts As Nullable(Of Double),  _
                    ByVal tax_Rate_Labor As Nullable(Of Double),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal process_Date As Nullable(Of DateTime),  _
                    ByVal full_Schedule_Hour As Nullable(Of Double),  _
                    ByVal service_Interval_Mile As Nullable(Of Integer),  _
                    ByVal service_Interval_Day As Nullable(Of Integer),  _
                    ByVal ink_Saver As Nullable(Of Boolean)) As List(Of MyCompany.Data.Objects.Company_View)
            Return [Select](company_ID, companyID, name, address_Line_1, address_Line_2, city, state, zip_Code, federal_Tax_ID, state_Tax_ID, sales_Tax_ID, web_Site, email_Address, phone_Number_1_Type, phone_Number_1, phone_Number_2_Type, phone_Number_2, phone_Number_3_Type, phone_Number_3, fax_Number, agreed_To_Terms_By, agreed_To_Terms_On, note, invoice_Number, order_Number, return_Number, appointment_Number, estimate_Number, tax_Rate_Parts, tax_Rate_Labor, is_Deleted, pricing_Matrix_ID, process_Date, full_Schedule_Hour, service_Interval_Mile, service_Interval_Day, ink_Saver, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Company_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_View
            Dim list As List(Of MyCompany.Data.Objects.Company_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
