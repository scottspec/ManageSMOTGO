Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Invoice_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Start_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Completion_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Number As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Location_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Status_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Odometer As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Is_Deleted As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mileage_Correction As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Status As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tag As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vin As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Promised_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Picked_Up_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Total_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Total_Non_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Total_Non_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Total_Taxable As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Part_Tax As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Labor_Tax As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sub_Total As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Total As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Processed_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Note_Saved_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Invoice_Note_Saved_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Estimate_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Alias_Status As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, false, false)>  _
        Public Property Invoice_ID() As Nullable(Of Integer)
            Get
                Return m_Invoice_ID
            End Get
            Set
                m_Invoice_ID = value
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
        Public Property Invoice_Status_ID() As Nullable(Of Integer)
            Get
                Return m_Invoice_Status_ID
            End Get
            Set
                m_Invoice_Status_ID = value
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
        Public Property Invoice_Note() As String
            Get
                Return m_Invoice_Note
            End Get
            Set
                m_Invoice_Note = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Vehicle_ID() As Nullable(Of Integer)
            Get
                Return m_Vehicle_ID
            End Get
            Set
                m_Vehicle_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Vehicle() As String
            Get
                Return m_Vehicle
            End Get
            Set
                m_Vehicle = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Customer_ID() As Nullable(Of Integer)
            Get
                Return m_Customer_ID
            End Get
            Set
                m_Customer_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Customer() As String
            Get
                Return m_Customer
            End Get
            Set
                m_Customer = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Status() As String
            Get
                Return m_Invoice_Status
            End Get
            Set
                m_Invoice_Status = value
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
        Public Property Part_Tax() As Nullable(Of Double)
            Get
                Return m_Part_Tax
            End Get
            Set
                m_Part_Tax = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Labor_Tax() As Nullable(Of Double)
            Get
                Return m_Labor_Tax
            End Get
            Set
                m_Labor_Tax = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Total() As Nullable(Of Double)
            Get
                Return m_Total
            End Get
            Set
                m_Total = value
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
        Public Property Invoice_Note_Saved_Name() As String
            Get
                Return m_Invoice_Note_Saved_Name
            End Get
            Set
                m_Invoice_Note_Saved_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Vehicle_Note() As String
            Get
                Return m_Vehicle_Note
            End Get
            Set
                m_Vehicle_Note = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Invoice_Note_Saved_Note() As String
            Get
                Return m_Invoice_Note_Saved_Note
            End Get
            Set
                m_Invoice_Note_Saved_Note = value
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
        Public Property Alias_Status() As String
            Get
                Return m_Alias_Status
            End Get
            Set
                m_Alias_Status = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal vehicle As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal customer As String,  _
                    ByVal invoice_Status As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Double),  _
                    ByVal labor_Tax As Nullable(Of Double),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Double),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Note_Saved_Name As String,  _
                    ByVal alias_Status As String,  _
                    ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(invoice_ID, start_Date, completion_Date, invoice_Number, location_ID, invoice_Status_ID, odometer, is_Deleted, vehicle_ID, vehicle, mileage_Correction, customer_ID, customer, invoice_Status, tag, vin, promised_Date, picked_Up_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, sub_Total, total, processed_Date, invoice_Note_Saved_Name, alias_Status, company_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_View) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, sort, Invoice_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, sort, Invoice_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, Nothing, Invoice_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return New Invoice_ViewFactory().Select(filter, Nothing, Invoice_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_View
            Return New Invoice_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Invoice_View
            Return New Invoice_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal invoice_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Invoice_View
            Return New Invoice_ViewFactory().SelectSingle(invoice_ID)
        End Function
        
        Public Function Insert() As Integer
            Return New Invoice_ViewFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Invoice_ViewFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Invoice_ViewFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Invoice_ID: {0}", Me.Invoice_ID)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Invoice_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Invoice_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Invoice_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Invoice_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Invoice_View")
            End Get
        End Property
        
        Public Shared Function Create() As Invoice_ViewFactory
            Return New Invoice_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal vehicle As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal customer As String,  _
                    ByVal invoice_Status As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Double),  _
                    ByVal labor_Tax As Nullable(Of Double),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Double),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Note_Saved_Name As String,  _
                    ByVal alias_Status As String,  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If invoice_ID.HasValue Then
                filter.Add(("Invoice_ID:=" + invoice_ID.Value.ToString()))
            End If
            If start_Date.HasValue Then
                filter.Add(("Start_Date:=" + start_Date.Value.ToString()))
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
            If invoice_Status_ID.HasValue Then
                filter.Add(("Invoice_Status_ID:=" + invoice_Status_ID.Value.ToString()))
            End If
            If odometer.HasValue Then
                filter.Add(("Odometer:=" + odometer.Value.ToString()))
            End If
            If is_Deleted.HasValue Then
                filter.Add(("Is_Deleted:=" + is_Deleted.Value.ToString()))
            End If
            If vehicle_ID.HasValue Then
                filter.Add(("Vehicle_ID:=" + vehicle_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(vehicle)) Then
                filter.Add(("Vehicle:*" + vehicle))
            End If
            If mileage_Correction.HasValue Then
                filter.Add(("Mileage_Correction:=" + mileage_Correction.Value.ToString()))
            End If
            If customer_ID.HasValue Then
                filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(customer)) Then
                filter.Add(("Customer:*" + customer))
            End If
            If Not (String.IsNullOrEmpty(invoice_Status)) Then
                filter.Add(("Invoice_Status:*" + invoice_Status))
            End If
            If Not (String.IsNullOrEmpty(tag)) Then
                filter.Add(("Tag:*" + tag))
            End If
            If Not (String.IsNullOrEmpty(vin)) Then
                filter.Add(("Vin:*" + vin))
            End If
            If promised_Date.HasValue Then
                filter.Add(("Promised_Date:=" + promised_Date.Value.ToString()))
            End If
            If picked_Up_Date.HasValue Then
                filter.Add(("Picked_Up_Date:=" + picked_Up_Date.Value.ToString()))
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
            If sub_Total.HasValue Then
                filter.Add(("Sub_Total:=" + sub_Total.Value.ToString()))
            End If
            If total.HasValue Then
                filter.Add(("Total:=" + total.Value.ToString()))
            End If
            If processed_Date.HasValue Then
                filter.Add(("Processed_Date:=" + processed_Date.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(invoice_Note_Saved_Name)) Then
                filter.Add(("Invoice_Note_Saved_Name:*" + invoice_Note_Saved_Name))
            End If
            If Not (String.IsNullOrEmpty(alias_Status)) Then
                filter.Add(("Alias_Status:*" + alias_Status))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal vehicle As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal customer As String,  _
                    ByVal invoice_Status As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Double),  _
                    ByVal labor_Tax As Nullable(Of Double),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Double),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Note_Saved_Name As String,  _
                    ByVal alias_Status As String,  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Invoice_View)
            Dim request As PageRequest = CreateRequest(invoice_ID, start_Date, completion_Date, invoice_Number, location_ID, invoice_Status_ID, odometer, is_Deleted, vehicle_ID, vehicle, mileage_Correction, customer_ID, customer, invoice_Status, tag, vin, promised_Date, picked_Up_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, sub_Total, total, processed_Date, invoice_Note_Saved_Name, alias_Status, company_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Invoice_View) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return [Select](qbe.Invoice_ID, qbe.Start_Date, qbe.Completion_Date, qbe.Invoice_Number, qbe.Location_ID, qbe.Invoice_Status_ID, qbe.Odometer, qbe.Is_Deleted, qbe.Vehicle_ID, qbe.Vehicle, qbe.Mileage_Correction, qbe.Customer_ID, qbe.Customer, qbe.Invoice_Status, qbe.Tag, qbe.Vin, qbe.Promised_Date, qbe.Picked_Up_Date, qbe.Part_Total_Taxable, qbe.Part_Total_Non_Taxable, qbe.Labor_Total_Non_Taxable, qbe.Labor_Total_Taxable, qbe.Part_Tax, qbe.Labor_Tax, qbe.Sub_Total, qbe.Total, qbe.Processed_Date, qbe.Invoice_Note_Saved_Name, qbe.Alias_Status, qbe.Company_ID)
        End Function
        
        Public Function SelectCount( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal vehicle As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal customer As String,  _
                    ByVal invoice_Status As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Double),  _
                    ByVal labor_Tax As Nullable(Of Double),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Double),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Note_Saved_Name As String,  _
                    ByVal alias_Status As String,  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(invoice_ID, start_Date, completion_Date, invoice_Number, location_ID, invoice_Status_ID, odometer, is_Deleted, vehicle_ID, vehicle, mileage_Correction, customer_ID, customer, invoice_Status, tag, vin, promised_Date, picked_Up_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, sub_Total, total, processed_Date, invoice_Note_Saved_Name, alias_Status, company_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Invoice_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal invoice_ID As Nullable(Of Integer),  _
                    ByVal start_Date As Nullable(Of DateTime),  _
                    ByVal completion_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Number As String,  _
                    ByVal location_ID As Nullable(Of Integer),  _
                    ByVal invoice_Status_ID As Nullable(Of Integer),  _
                    ByVal odometer As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal vehicle As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal customer As String,  _
                    ByVal invoice_Status As String,  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal promised_Date As Nullable(Of DateTime),  _
                    ByVal picked_Up_Date As Nullable(Of DateTime),  _
                    ByVal part_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Non_Taxable As Nullable(Of Decimal),  _
                    ByVal labor_Total_Taxable As Nullable(Of Decimal),  _
                    ByVal part_Tax As Nullable(Of Double),  _
                    ByVal labor_Tax As Nullable(Of Double),  _
                    ByVal sub_Total As Nullable(Of Decimal),  _
                    ByVal total As Nullable(Of Double),  _
                    ByVal processed_Date As Nullable(Of DateTime),  _
                    ByVal invoice_Note_Saved_Name As String,  _
                    ByVal alias_Status As String,  _
                    ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return [Select](invoice_ID, start_Date, completion_Date, invoice_Number, location_ID, invoice_Status_ID, odometer, is_Deleted, vehicle_ID, vehicle, mileage_Correction, customer_ID, customer, invoice_Status, tag, vin, promised_Date, picked_Up_Date, part_Total_Taxable, part_Total_Non_Taxable, labor_Total_Non_Taxable, labor_Total_Taxable, part_Tax, labor_Tax, sub_Total, total, processed_Date, invoice_Note_Saved_Name, alias_Status, company_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal invoice_ID As Nullable(Of Integer)) As MyCompany.Data.Objects.Invoice_View
            Dim list As List(Of MyCompany.Data.Objects.Invoice_View) = [Select](invoice_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Invoice_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Invoice_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Invoice_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Invoice_View
            Dim list As List(Of MyCompany.Data.Objects.Invoice_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View, ByVal original_Invoice_View As MyCompany.Data.Objects.Invoice_View) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Invoice_ID", original_Invoice_View.Invoice_ID, theInvoice_View.Invoice_ID))
            values.Add(New FieldValue("Start_Date", original_Invoice_View.Start_Date, theInvoice_View.Start_Date))
            values.Add(New FieldValue("Completion_Date", original_Invoice_View.Completion_Date, theInvoice_View.Completion_Date))
            values.Add(New FieldValue("Invoice_Number", original_Invoice_View.Invoice_Number, theInvoice_View.Invoice_Number))
            values.Add(New FieldValue("Location_ID", original_Invoice_View.Location_ID, theInvoice_View.Location_ID))
            values.Add(New FieldValue("Invoice_Status_ID", original_Invoice_View.Invoice_Status_ID, theInvoice_View.Invoice_Status_ID, true))
            values.Add(New FieldValue("Odometer", original_Invoice_View.Odometer, theInvoice_View.Odometer, true))
            values.Add(New FieldValue("Invoice_Note", original_Invoice_View.Invoice_Note, theInvoice_View.Invoice_Note))
            values.Add(New FieldValue("Is_Deleted", original_Invoice_View.Is_Deleted, theInvoice_View.Is_Deleted))
            values.Add(New FieldValue("Vehicle_ID", original_Invoice_View.Vehicle_ID, theInvoice_View.Vehicle_ID))
            values.Add(New FieldValue("Vehicle", original_Invoice_View.Vehicle, theInvoice_View.Vehicle, true))
            values.Add(New FieldValue("Mileage_Correction", original_Invoice_View.Mileage_Correction, theInvoice_View.Mileage_Correction, true))
            values.Add(New FieldValue("Customer_ID", original_Invoice_View.Customer_ID, theInvoice_View.Customer_ID))
            values.Add(New FieldValue("Customer", original_Invoice_View.Customer, theInvoice_View.Customer, true))
            values.Add(New FieldValue("Invoice_Status", original_Invoice_View.Invoice_Status, theInvoice_View.Invoice_Status))
            values.Add(New FieldValue("Tag", original_Invoice_View.Tag, theInvoice_View.Tag))
            values.Add(New FieldValue("Vin", original_Invoice_View.Vin, theInvoice_View.Vin))
            values.Add(New FieldValue("Promised_Date", original_Invoice_View.Promised_Date, theInvoice_View.Promised_Date))
            values.Add(New FieldValue("Picked_Up_Date", original_Invoice_View.Picked_Up_Date, theInvoice_View.Picked_Up_Date))
            values.Add(New FieldValue("Part_Total_Taxable", original_Invoice_View.Part_Total_Taxable, theInvoice_View.Part_Total_Taxable, true))
            values.Add(New FieldValue("Part_Total_Non_Taxable", original_Invoice_View.Part_Total_Non_Taxable, theInvoice_View.Part_Total_Non_Taxable, true))
            values.Add(New FieldValue("Labor_Total_Non_Taxable", original_Invoice_View.Labor_Total_Non_Taxable, theInvoice_View.Labor_Total_Non_Taxable, true))
            values.Add(New FieldValue("Labor_Total_Taxable", original_Invoice_View.Labor_Total_Taxable, theInvoice_View.Labor_Total_Taxable, true))
            values.Add(New FieldValue("Part_Tax", original_Invoice_View.Part_Tax, theInvoice_View.Part_Tax, true))
            values.Add(New FieldValue("Labor_Tax", original_Invoice_View.Labor_Tax, theInvoice_View.Labor_Tax, true))
            values.Add(New FieldValue("Sub_Total", original_Invoice_View.Sub_Total, theInvoice_View.Sub_Total, true))
            values.Add(New FieldValue("Total", original_Invoice_View.Total, theInvoice_View.Total, true))
            values.Add(New FieldValue("Processed_Date", original_Invoice_View.Processed_Date, theInvoice_View.Processed_Date))
            values.Add(New FieldValue("Invoice_Note_Saved_Name", original_Invoice_View.Invoice_Note_Saved_Name, theInvoice_View.Invoice_Note_Saved_Name))
            values.Add(New FieldValue("Vehicle_Note", original_Invoice_View.Vehicle_Note, theInvoice_View.Vehicle_Note))
            values.Add(New FieldValue("Invoice_Note_Saved_Note", original_Invoice_View.Invoice_Note_Saved_Note, theInvoice_View.Invoice_Note_Saved_Note))
            values.Add(New FieldValue("Estimate_Note", original_Invoice_View.Estimate_Note, theInvoice_View.Estimate_Note))
            values.Add(New FieldValue("Alias_Status", original_Invoice_View.Alias_Status, theInvoice_View.Alias_Status))
            values.Add(New FieldValue("Company_ID", original_Invoice_View.Company_ID, theInvoice_View.Company_ID))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View, ByVal original_Invoice_View As MyCompany.Data.Objects.Invoice_View, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Invoice_View"
            args.View = dataView
            args.Values = CreateFieldValues(theInvoice_View, original_Invoice_View)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Invoice_View", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theInvoice_View)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View, ByVal original_Invoice_View As MyCompany.Data.Objects.Invoice_View) As Integer
            Return ExecuteAction(theInvoice_View, original_Invoice_View, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View) As Integer
            Return Update(theInvoice_View, SelectSingle(theInvoice_View.Invoice_ID))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View) As Integer
            Return ExecuteAction(theInvoice_View, New Invoice_View(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theInvoice_View As MyCompany.Data.Objects.Invoice_View) As Integer
            Return ExecuteAction(theInvoice_View, theInvoice_View, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
