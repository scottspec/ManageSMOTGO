Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Invoice_History_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Completion_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Number As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Location_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Odometer As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mileage_Correction As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Actual_Mileage As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
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
        Private m_Province As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_Pricing_Matrix_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tag As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vin As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_Pricing_Matrix_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_Year_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_Year_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Make_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Make_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Engine_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Engine_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transmission_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transmission_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Body_Style_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Body_Style_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Trim_Level_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Trim_Level_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Taxable_Labor As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Taxable_Part As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_NonTaxable_Labor As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_NonTaxable_Part As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sub_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Start_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Promised_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Picked_Up_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Processed_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Total_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Total_Non_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Total_Non_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Total_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Tax As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Tax As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Status_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_OldID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Estimate_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Cost_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Cost_Total As Nullable(Of Decimal)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Invoice_ID() As Nullable(Of Integer)
            Get
                Return m_Invoice_ID
            End Get
            Set
                m_Invoice_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Completion_Date() As Nullable(Of DateTime)
            Get
                Return m_Completion_Date
            End Get
            Set
                m_Completion_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Number() As String
            Get
                Return m_Invoice_Number
            End Get
            Set
                m_Invoice_Number = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Location_ID() As Nullable(Of Integer)
            Get
                Return m_Location_ID
            End Get
            Set
                m_Location_ID = value
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
        Public Property Odometer() As Nullable(Of Integer)
            Get
                Return m_Odometer
            End Get
            Set
                m_Odometer = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Mileage_Correction() As Nullable(Of Integer)
            Get
                Return m_Mileage_Correction
            End Get
            Set
                m_Mileage_Correction = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Actual_Mileage() As Nullable(Of Integer)
            Get
                Return m_Actual_Mileage
            End Get
            Set
                m_Actual_Mileage = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Note() As String
            Get
                Return m_Invoice_Note
            End Get
            Set
                m_Invoice_Note = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
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
        Public Property First_Name() As String
            Get
                Return m_First_Name
            End Get
            Set
                m_First_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
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
        Public Property Province() As String
            Get
                Return m_Province
            End Get
            Set
                m_Province = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Customer_Pricing_Matrix_ID() As Nullable(Of Integer)
            Get
                Return m_Customer_Pricing_Matrix_ID
            End Get
            Set
                m_Customer_Pricing_Matrix_ID = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Tag() As String
            Get
                Return m_Tag
            End Get
            Set
                m_Tag = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Vin() As String
            Get
                Return m_Vin
            End Get
            Set
                m_Vin = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Vehicle_Pricing_Matrix_ID() As Nullable(Of Integer)
            Get
                Return m_Vehicle_Pricing_Matrix_ID
            End Get
            Set
                m_Vehicle_Pricing_Matrix_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Model_Year_ID() As Nullable(Of Integer)
            Get
                Return m_Model_Year_ID
            End Get
            Set
                m_Model_Year_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Model_Year_Name() As String
            Get
                Return m_Model_Year_Name
            End Get
            Set
                m_Model_Year_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Make_ID() As Nullable(Of Integer)
            Get
                Return m_Make_ID
            End Get
            Set
                m_Make_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Make_Name() As String
            Get
                Return m_Make_Name
            End Get
            Set
                m_Make_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Model_ID() As Nullable(Of Integer)
            Get
                Return m_Model_ID
            End Get
            Set
                m_Model_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Model_Name() As String
            Get
                Return m_Model_Name
            End Get
            Set
                m_Model_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Engine_ID() As Nullable(Of Integer)
            Get
                Return m_Engine_ID
            End Get
            Set
                m_Engine_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Engine_Name() As String
            Get
                Return m_Engine_Name
            End Get
            Set
                m_Engine_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Transmission_ID() As Nullable(Of Integer)
            Get
                Return m_Transmission_ID
            End Get
            Set
                m_Transmission_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Transmission_Name() As String
            Get
                Return m_Transmission_Name
            End Get
            Set
                m_Transmission_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Body_Style_ID() As Nullable(Of Integer)
            Get
                Return m_Body_Style_ID
            End Get
            Set
                m_Body_Style_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Body_Style_Name() As String
            Get
                Return m_Body_Style_Name
            End Get
            Set
                m_Body_Style_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Trim_Level_ID() As Nullable(Of Integer)
            Get
                Return m_Trim_Level_ID
            End Get
            Set
                m_Trim_Level_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Trim_Level_Name() As String
            Get
                Return m_Trim_Level_Name
            End Get
            Set
                m_Trim_Level_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Taxable_Labor() As Nullable(Of Decimal)
            Get
                Return m_Taxable_Labor
            End Get
            Set
                m_Taxable_Labor = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Taxable_Part() As Nullable(Of Decimal)
            Get
                Return m_Taxable_Part
            End Get
            Set
                m_Taxable_Part = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property NonTaxable_Labor() As Nullable(Of Decimal)
            Get
                Return m_NonTaxable_Labor
            End Get
            Set
                m_NonTaxable_Labor = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property NonTaxable_Part() As Nullable(Of Decimal)
            Get
                Return m_NonTaxable_Part
            End Get
            Set
                m_NonTaxable_Part = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Total() As Nullable(Of Decimal)
            Get
                Return m_Labor_Total
            End Get
            Set
                m_Labor_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Total() As Nullable(Of Decimal)
            Get
                Return m_Part_Total
            End Get
            Set
                m_Part_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Sub_Total() As Nullable(Of Decimal)
            Get
                Return m_Sub_Total
            End Get
            Set
                m_Sub_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Total() As Nullable(Of Decimal)
            Get
                Return m_Total
            End Get
            Set
                m_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Start_Date() As Nullable(Of DateTime)
            Get
                Return m_Start_Date
            End Get
            Set
                m_Start_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Promised_Date() As Nullable(Of DateTime)
            Get
                Return m_Promised_Date
            End Get
            Set
                m_Promised_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Picked_Up_Date() As Nullable(Of DateTime)
            Get
                Return m_Picked_Up_Date
            End Get
            Set
                m_Picked_Up_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Processed_Date() As Nullable(Of DateTime)
            Get
                Return m_Processed_Date
            End Get
            Set
                m_Processed_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Total_Taxable() As Nullable(Of Decimal)
            Get
                Return m_Part_Total_Taxable
            End Get
            Set
                m_Part_Total_Taxable = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Total_Non_Taxable() As Nullable(Of Decimal)
            Get
                Return m_Part_Total_Non_Taxable
            End Get
            Set
                m_Part_Total_Non_Taxable = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Total_Non_Taxable() As Nullable(Of Decimal)
            Get
                Return m_Labor_Total_Non_Taxable
            End Get
            Set
                m_Labor_Total_Non_Taxable = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Total_Taxable() As Nullable(Of Decimal)
            Get
                Return m_Labor_Total_Taxable
            End Get
            Set
                m_Labor_Total_Taxable = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Tax() As Nullable(Of Decimal)
            Get
                Return m_Part_Tax
            End Get
            Set
                m_Part_Tax = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Tax() As Nullable(Of Decimal)
            Get
                Return m_Labor_Tax
            End Get
            Set
                m_Labor_Tax = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Status_ID() As Nullable(Of Integer)
            Get
                Return m_Invoice_Status_ID
            End Get
            Set
                m_Invoice_Status_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property OldID() As Nullable(Of Integer)
            Get
                Return m_OldID
            End Get
            Set
                m_OldID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Estimate_Note() As String
            Get
                Return m_Estimate_Note
            End Get
            Set
                m_Estimate_Note = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Part_Cost_Total() As Nullable(Of Decimal)
            Get
                Return m_Part_Cost_Total
            End Get
            Set
                m_Part_Cost_Total = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Cost_Total() As Nullable(Of Decimal)
            Get
                Return m_Labor_Cost_Total
            End Get
            Set
                m_Labor_Cost_Total = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal actual_Mileage As Nullable(Of Integer),  _
                    ByVal invoice_Note As String,  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal province As String,  _
                    ByVal customer_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal customer_Note As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal vehicle_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal model_Year_Name As String,  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal make_Name As String,  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal model_Name As String,  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal engine_Name As String,  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal transmission_Name As String,  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal body_Style_Name As String,  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_Name As String,  _
                    ByVal taxable_Labor As Nullable(Of Decimal),  _
                    ByVal taxable_Part As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Labor As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Part As Nullable(Of Decimal),  _
                    ByVal labor_Total As Nullable(Of Decimal),  _
                    ByVal part_Total As Nullable(Of Decimal),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Decimal),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Decimal),  _
                    ByVal labor_Tax As Nullable(Of Decimal),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal oldID As Nullable(Of Integer),  _
                    ByVal estimate_Note As String,  _
                    ByVal part_Cost_Total As Nullable(Of Decimal),  _
                    ByVal labor_Cost_Total As Nullable(Of Decimal)) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(invoice_ID, completion_Date, invoice_Number, location_ID, vehicle_ID, odometer, mileage_Correction, actual_Mileage, invoice_Note, customer_ID, company_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, province, customer_Pricing_Matrix_ID, customer_Note, tag, vin, vehicle_Pricing_Matrix_ID, model_Year_ID, model_Year_Name, make_ID, make_Name, model_ID, model_Name, engine_ID, engine_Name, transmission_ID, transmission_Name, body_Style_ID, body_Style_Name, trim_Level_ID, trim_Level_Name, taxable_Labor, taxable_Part, nonTaxable_Labor, nonTaxable_Part, labor_Total, part_Total, sub_Total, total, start_Date, promised_Date, picked_Up_Date, processed_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, invoice_Status_ID, oldID, estimate_Note, part_Cost_Total, labor_Cost_Total)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_History_View) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, sort, Invoice_History_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, sort, Invoice_History_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, Nothing, Invoice_History_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return New Invoice_History_ViewFactory().Select(filter, Nothing, Invoice_History_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_History_View
            Return New Invoice_History_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Invoice_History_View
            Return New Invoice_History_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Invoice_History_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Invoice_History_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Invoice_History_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Invoice_History_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Invoice_History_View")
            End Get
        End Property
        
        Public Shared Function Create() As Invoice_History_ViewFactory
            Return New Invoice_History_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal actual_Mileage As Nullable(Of Integer),  _
                    ByVal invoice_Note As String,  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal province As String,  _
                    ByVal customer_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal customer_Note As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal vehicle_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal model_Year_Name As String,  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal make_Name As String,  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal model_Name As String,  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal engine_Name As String,  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal transmission_Name As String,  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal body_Style_Name As String,  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_Name As String,  _
                    ByVal taxable_Labor As Nullable(Of Decimal),  _
                    ByVal taxable_Part As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Labor As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Part As Nullable(Of Decimal),  _
                    ByVal labor_Total As Nullable(Of Decimal),  _
                    ByVal part_Total As Nullable(Of Decimal),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Decimal),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Decimal),  _
                    ByVal labor_Tax As Nullable(Of Decimal),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal oldID As Nullable(Of Integer),  _
                    ByVal estimate_Note As String,  _
                    ByVal part_Cost_Total As Nullable(Of Decimal),  _
                    ByVal labor_Cost_Total As Nullable(Of Decimal),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If invoice_ID.HasValue Then
                filter.Add(("Invoice_ID:=" + invoice_ID.Value.ToString()))
            End If
            If completion_Date.HasValue Then
                filter.Add(("Completion_Date:=" + completion_Date.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(invoice_Number)) Then
                filter.Add(("Invoice_Number:*" + invoice_Number))
            End If
            If location_ID.HasValue Then
                filter.Add(("Location_ID:=" + location_ID.Value.ToString()))
            End If
            If vehicle_ID.HasValue Then
                filter.Add(("Vehicle_ID:=" + vehicle_ID.Value.ToString()))
            End If
            If odometer.HasValue Then
                filter.Add(("Odometer:=" + odometer.Value.ToString()))
            End If
            If mileage_Correction.HasValue Then
                filter.Add(("Mileage_Correction:=" + mileage_Correction.Value.ToString()))
            End If
            If actual_Mileage.HasValue Then
                filter.Add(("Actual_Mileage:=" + actual_Mileage.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(invoice_Note)) Then
                filter.Add(("Invoice_Note:*" + invoice_Note))
            End If
            If customer_ID.HasValue Then
                filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
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
            If Not (String.IsNullOrEmpty(province)) Then
                filter.Add(("Province:*" + province))
            End If
            If customer_Pricing_Matrix_ID.HasValue Then
                filter.Add(("Customer_Pricing_Matrix_ID:=" + customer_Pricing_Matrix_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(customer_Note)) Then
                filter.Add(("Customer_Note:*" + customer_Note))
            End If
            If Not (String.IsNullOrEmpty(tag)) Then
                filter.Add(("Tag:*" + tag))
            End If
            If Not (String.IsNullOrEmpty(vin)) Then
                filter.Add(("Vin:*" + vin))
            End If
            If vehicle_Pricing_Matrix_ID.HasValue Then
                filter.Add(("Vehicle_Pricing_Matrix_ID:=" + vehicle_Pricing_Matrix_ID.Value.ToString()))
            End If
            If model_Year_ID.HasValue Then
                filter.Add(("Model_Year_ID:=" + model_Year_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(model_Year_Name)) Then
                filter.Add(("Model_Year_Name:*" + model_Year_Name))
            End If
            If make_ID.HasValue Then
                filter.Add(("Make_ID:=" + make_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(make_Name)) Then
                filter.Add(("Make_Name:*" + make_Name))
            End If
            If model_ID.HasValue Then
                filter.Add(("Model_ID:=" + model_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(model_Name)) Then
                filter.Add(("Model_Name:*" + model_Name))
            End If
            If engine_ID.HasValue Then
                filter.Add(("Engine_ID:=" + engine_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(engine_Name)) Then
                filter.Add(("Engine_Name:*" + engine_Name))
            End If
            If transmission_ID.HasValue Then
                filter.Add(("Transmission_ID:=" + transmission_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(transmission_Name)) Then
                filter.Add(("Transmission_Name:*" + transmission_Name))
            End If
            If body_Style_ID.HasValue Then
                filter.Add(("Body_Style_ID:=" + body_Style_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(body_Style_Name)) Then
                filter.Add(("Body_Style_Name:*" + body_Style_Name))
            End If
            If trim_Level_ID.HasValue Then
                filter.Add(("Trim_Level_ID:=" + trim_Level_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(trim_Level_Name)) Then
                filter.Add(("Trim_Level_Name:*" + trim_Level_Name))
            End If
            If taxable_Labor.HasValue Then
                filter.Add(("Taxable_Labor:=" + taxable_Labor.Value.ToString()))
            End If
            If taxable_Part.HasValue Then
                filter.Add(("Taxable_Part:=" + taxable_Part.Value.ToString()))
            End If
            If nonTaxable_Labor.HasValue Then
                filter.Add(("NonTaxable_Labor:=" + nonTaxable_Labor.Value.ToString()))
            End If
            If nonTaxable_Part.HasValue Then
                filter.Add(("NonTaxable_Part:=" + nonTaxable_Part.Value.ToString()))
            End If
            If labor_Total.HasValue Then
                filter.Add(("Labor_Total:=" + labor_Total.Value.ToString()))
            End If
            If part_Total.HasValue Then
                filter.Add(("Part_Total:=" + part_Total.Value.ToString()))
            End If
            If sub_Total.HasValue Then
                filter.Add(("Sub_Total:=" + sub_Total.Value.ToString()))
            End If
            If total.HasValue Then
                filter.Add(("Total:=" + total.Value.ToString()))
            End If
            If start_Date.HasValue Then
                filter.Add(("Start_Date:=" + start_Date.Value.ToString()))
            End If
            If promised_Date.HasValue Then
                filter.Add(("Promised_Date:=" + promised_Date.Value.ToString()))
            End If
            If picked_Up_Date.HasValue Then
                filter.Add(("Picked_Up_Date:=" + picked_Up_Date.Value.ToString()))
            End If
            If processed_Date.HasValue Then
                filter.Add(("Processed_Date:=" + processed_Date.Value.ToString()))
            End If
            If part_Total_Taxable.HasValue Then
                filter.Add(("Part_Total_Taxable:=" + part_Total_Taxable.Value.ToString()))
            End If
            If part_Total_Non_Taxable.HasValue Then
                filter.Add(("Part_Total_Non_Taxable:=" + part_Total_Non_Taxable.Value.ToString()))
            End If
            If labor_Total_Non_Taxable.HasValue Then
                filter.Add(("Labor_Total_Non_Taxable:=" + labor_Total_Non_Taxable.Value.ToString()))
            End If
            If labor_Total_Taxable.HasValue Then
                filter.Add(("Labor_Total_Taxable:=" + labor_Total_Taxable.Value.ToString()))
            End If
            If part_Tax.HasValue Then
                filter.Add(("Part_Tax:=" + part_Tax.Value.ToString()))
            End If
            If labor_Tax.HasValue Then
                filter.Add(("Labor_Tax:=" + labor_Tax.Value.ToString()))
            End If
            If invoice_Status_ID.HasValue Then
                filter.Add(("Invoice_Status_ID:=" + invoice_Status_ID.Value.ToString()))
            End If
            If oldID.HasValue Then
                filter.Add(("OldID:=" + oldID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(estimate_Note)) Then
                filter.Add(("Estimate_Note:*" + estimate_Note))
            End If
            If part_Cost_Total.HasValue Then
                filter.Add(("Part_Cost_Total:=" + part_Cost_Total.Value.ToString()))
            End If
            If labor_Cost_Total.HasValue Then
                filter.Add(("Labor_Cost_Total:=" + labor_Cost_Total.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal actual_Mileage As Nullable(Of Integer),  _
                    ByVal invoice_Note As String,  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal province As String,  _
                    ByVal customer_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal customer_Note As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal vehicle_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal model_Year_Name As String,  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal make_Name As String,  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal model_Name As String,  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal engine_Name As String,  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal transmission_Name As String,  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal body_Style_Name As String,  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_Name As String,  _
                    ByVal taxable_Labor As Nullable(Of Decimal),  _
                    ByVal taxable_Part As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Labor As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Part As Nullable(Of Decimal),  _
                    ByVal labor_Total As Nullable(Of Decimal),  _
                    ByVal part_Total As Nullable(Of Decimal),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Decimal),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Decimal),  _
                    ByVal labor_Tax As Nullable(Of Decimal),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal oldID As Nullable(Of Integer),  _
                    ByVal estimate_Note As String,  _
                    ByVal part_Cost_Total As Nullable(Of Decimal),  _
                    ByVal labor_Cost_Total As Nullable(Of Decimal),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Dim request As PageRequest = CreateRequest(invoice_ID, completion_Date, invoice_Number, location_ID, vehicle_ID, odometer, mileage_Correction, actual_Mileage, invoice_Note, customer_ID, company_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, province, customer_Pricing_Matrix_ID, customer_Note, tag, vin, vehicle_Pricing_Matrix_ID, model_Year_ID, model_Year_Name, make_ID, make_Name, model_ID, model_Name, engine_ID, engine_Name, transmission_ID, transmission_Name, body_Style_ID, body_Style_Name, trim_Level_ID, trim_Level_Name, taxable_Labor, taxable_Part, nonTaxable_Labor, nonTaxable_Part, labor_Total, part_Total, sub_Total, total, start_Date, promised_Date, picked_Up_Date, processed_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, invoice_Status_ID, oldID, estimate_Note, part_Cost_Total, labor_Cost_Total, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_History_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_History_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_History_View) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return [Select](qbe.Invoice_ID, qbe.Completion_Date, qbe.Invoice_Number, qbe.Location_ID, qbe.Vehicle_ID, qbe.Odometer, qbe.Mileage_Correction, qbe.Actual_Mileage, qbe.Invoice_Note, qbe.Customer_ID, qbe.Company_ID, qbe.First_Name, qbe.Last_Name, qbe.Other_First_Name, qbe.Other_Last_Name, qbe.Address_Line_1, qbe.Address_Line_2, qbe.City, qbe.State, qbe.Zip_Code, qbe.Province, qbe.Customer_Pricing_Matrix_ID, qbe.Customer_Note, qbe.Tag, qbe.Vin, qbe.Vehicle_Pricing_Matrix_ID, qbe.Model_Year_ID, qbe.Model_Year_Name, qbe.Make_ID, qbe.Make_Name, qbe.Model_ID, qbe.Model_Name, qbe.Engine_ID, qbe.Engine_Name, qbe.Transmission_ID, qbe.Transmission_Name, qbe.Body_Style_ID, qbe.Body_Style_Name, qbe.Trim_Level_ID, qbe.Trim_Level_Name, qbe.Taxable_Labor, qbe.Taxable_Part, qbe.NonTaxable_Labor, qbe.NonTaxable_Part, qbe.Labor_Total, qbe.Part_Total, qbe.Sub_Total, qbe.Total, qbe.Start_Date, qbe.Promised_Date, qbe.Picked_Up_Date, qbe.Processed_Date, qbe.Part_Total_Taxable, qbe.Part_Total_Non_Taxable, qbe.Labor_Total_Non_Taxable, qbe.Labor_Total_Taxable, qbe.Part_Tax, qbe.Labor_Tax, qbe.Invoice_Status_ID, qbe.OldID, qbe.Estimate_Note, qbe.Part_Cost_Total, qbe.Labor_Cost_Total)
        End Function
        
        Public Function SelectCount( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal actual_Mileage As Nullable(Of Integer),  _
                    ByVal invoice_Note As String,  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal province As String,  _
                    ByVal customer_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal customer_Note As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal vehicle_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal model_Year_Name As String,  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal make_Name As String,  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal model_Name As String,  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal engine_Name As String,  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal transmission_Name As String,  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal body_Style_Name As String,  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_Name As String,  _
                    ByVal taxable_Labor As Nullable(Of Decimal),  _
                    ByVal taxable_Part As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Labor As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Part As Nullable(Of Decimal),  _
                    ByVal labor_Total As Nullable(Of Decimal),  _
                    ByVal part_Total As Nullable(Of Decimal),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Decimal),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Decimal),  _
                    ByVal labor_Tax As Nullable(Of Decimal),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal oldID As Nullable(Of Integer),  _
                    ByVal estimate_Note As String,  _
                    ByVal part_Cost_Total As Nullable(Of Decimal),  _
                    ByVal labor_Cost_Total As Nullable(Of Decimal),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(invoice_ID, completion_Date, invoice_Number, location_ID, vehicle_ID, odometer, mileage_Correction, actual_Mileage, invoice_Note, customer_ID, company_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, province, customer_Pricing_Matrix_ID, customer_Note, tag, vin, vehicle_Pricing_Matrix_ID, model_Year_ID, model_Year_Name, make_ID, make_Name, model_ID, model_Name, engine_ID, engine_Name, transmission_ID, transmission_Name, body_Style_ID, body_Style_Name, trim_Level_ID, trim_Level_Name, taxable_Labor, taxable_Part, nonTaxable_Labor, nonTaxable_Part, labor_Total, part_Total, sub_Total, total, start_Date, promised_Date, picked_Up_Date, processed_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, invoice_Status_ID, oldID, estimate_Note, part_Cost_Total, labor_Cost_Total, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_History_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal actual_Mileage As Nullable(Of Integer),  _
                    ByVal invoice_Note As String,  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal first_Name As String,  _
                    ByVal last_Name As String,  _
                    ByVal other_First_Name As String,  _
                    ByVal other_Last_Name As String,  _
                    ByVal address_Line_1 As String,  _
                    ByVal address_Line_2 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal zip_Code As String,  _
                    ByVal province As String,  _
                    ByVal customer_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal customer_Note As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal vehicle_Pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal model_Year_Name As String,  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal make_Name As String,  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal model_Name As String,  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal engine_Name As String,  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal transmission_Name As String,  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal body_Style_Name As String,  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_Name As String,  _
                    ByVal taxable_Labor As Nullable(Of Decimal),  _
                    ByVal taxable_Part As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Labor As Nullable(Of Decimal),  _
                    ByVal nonTaxable_Part As Nullable(Of Decimal),  _
                    ByVal labor_Total As Nullable(Of Decimal),  _
                    ByVal part_Total As Nullable(Of Decimal),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Decimal),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Decimal),  _
                    ByVal labor_Tax As Nullable(Of Decimal),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal oldID As Nullable(Of Integer),  _
                    ByVal estimate_Note As String,  _
                    ByVal part_Cost_Total As Nullable(Of Decimal),  _
                    ByVal labor_Cost_Total As Nullable(Of Decimal)) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return [Select](invoice_ID, completion_Date, invoice_Number, location_ID, vehicle_ID, odometer, mileage_Correction, actual_Mileage, invoice_Note, customer_ID, company_ID, first_Name, last_Name, other_First_Name, other_Last_Name, address_Line_1, address_Line_2, city, state, zip_Code, province, customer_Pricing_Matrix_ID, customer_Note, tag, vin, vehicle_Pricing_Matrix_ID, model_Year_ID, model_Year_Name, make_ID, make_Name, model_ID, model_Name, engine_ID, engine_Name, transmission_ID, transmission_Name, body_Style_ID, body_Style_Name, trim_Level_ID, trim_Level_Name, taxable_Labor, taxable_Part, nonTaxable_Labor, nonTaxable_Part, labor_Total, part_Total, sub_Total, total, start_Date, promised_Date, picked_Up_Date, processed_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, invoice_Status_ID, oldID, estimate_Note, part_Cost_Total, labor_Cost_Total, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Invoice_History_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_History_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_History_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_History_View
            Dim list As List(Of MyCompany.Data.Objects.Invoice_History_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
