Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Vehicle_View
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Customer_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tag As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vin As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mileage_Correction As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Vehicle_Note As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Pricing_Matrix_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_Year_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Make_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Model_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Engine_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transmission_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Body_Style_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Trim_Level_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Is_Deleted As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Old_Vehicle_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Modified_On As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
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
        Public Property Customer_ID() As Nullable(Of Integer)
            Get
                Return m_Customer_ID
            End Get
            Set
                m_Customer_ID = value
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
        Public Property Mileage_Correction() As Nullable(Of Integer)
            Get
                Return m_Mileage_Correction
            End Get
            Set
                m_Mileage_Correction = value
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
        Public Property Pricing_Matrix_ID() As Nullable(Of Integer)
            Get
                Return m_Pricing_Matrix_ID
            End Get
            Set
                m_Pricing_Matrix_ID = value
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
        Public Property Model_Year_ID() As Nullable(Of Integer)
            Get
                Return m_Model_Year_ID
            End Get
            Set
                m_Model_Year_ID = value
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
        Public Property Model_ID() As Nullable(Of Integer)
            Get
                Return m_Model_ID
            End Get
            Set
                m_Model_ID = value
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
        Public Property Transmission_ID() As Nullable(Of Integer)
            Get
                Return m_Transmission_ID
            End Get
            Set
                m_Transmission_ID = value
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
        Public Property Trim_Level_ID() As Nullable(Of Integer)
            Get
                Return m_Trim_Level_ID
            End Get
            Set
                m_Trim_Level_ID = value
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
        Public Property Old_Vehicle_ID() As Nullable(Of Integer)
            Get
                Return m_Old_Vehicle_ID
            End Get
            Set
                m_Old_Vehicle_ID = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal old_Vehicle_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(vehicle_ID, customer_ID, tag, vin, mileage_Correction, pricing_Matrix_ID, company_ID, model_Year_ID, make_ID, model_ID, engine_ID, transmission_ID, body_Style_ID, trim_Level_ID, is_Deleted, old_Vehicle_ID, created_On, modified_On)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Vehicle_View) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, sort, Vehicle_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, sort, Vehicle_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, Nothing, Vehicle_ViewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return New Vehicle_ViewFactory().Select(filter, Nothing, Vehicle_ViewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Vehicle_View
            Return New Vehicle_ViewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Vehicle_View
            Return New Vehicle_ViewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Vehicle_ViewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Vehicle_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Vehicle_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Vehicle_View")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Vehicle_View")
            End Get
        End Property
        
        Public Shared Function Create() As Vehicle_ViewFactory
            Return New Vehicle_ViewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal old_Vehicle_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If vehicle_ID.HasValue Then
                filter.Add(("Vehicle_ID:=" + vehicle_ID.Value.ToString()))
            End If
            If customer_ID.HasValue Then
                filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(tag)) Then
                filter.Add(("Tag:*" + tag))
            End If
            If Not (String.IsNullOrEmpty(vin)) Then
                filter.Add(("Vin:*" + vin))
            End If
            If mileage_Correction.HasValue Then
                filter.Add(("Mileage_Correction:=" + mileage_Correction.Value.ToString()))
            End If
            If pricing_Matrix_ID.HasValue Then
                filter.Add(("Pricing_Matrix_ID:=" + pricing_Matrix_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If model_Year_ID.HasValue Then
                filter.Add(("Model_Year_ID:=" + model_Year_ID.Value.ToString()))
            End If
            If make_ID.HasValue Then
                filter.Add(("Make_ID:=" + make_ID.Value.ToString()))
            End If
            If model_ID.HasValue Then
                filter.Add(("Model_ID:=" + model_ID.Value.ToString()))
            End If
            If engine_ID.HasValue Then
                filter.Add(("Engine_ID:=" + engine_ID.Value.ToString()))
            End If
            If transmission_ID.HasValue Then
                filter.Add(("Transmission_ID:=" + transmission_ID.Value.ToString()))
            End If
            If body_Style_ID.HasValue Then
                filter.Add(("Body_Style_ID:=" + body_Style_ID.Value.ToString()))
            End If
            If trim_Level_ID.HasValue Then
                filter.Add(("Trim_Level_ID:=" + trim_Level_ID.Value.ToString()))
            End If
            If is_Deleted.HasValue Then
                filter.Add(("Is_Deleted:=" + is_Deleted.Value.ToString()))
            End If
            If old_Vehicle_ID.HasValue Then
                filter.Add(("Old_Vehicle_ID:=" + old_Vehicle_ID.Value.ToString()))
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
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal old_Vehicle_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Dim request As PageRequest = CreateRequest(vehicle_ID, customer_ID, tag, vin, mileage_Correction, pricing_Matrix_ID, company_ID, model_Year_ID, make_ID, model_ID, engine_ID, transmission_ID, body_Style_ID, trim_Level_ID, is_Deleted, old_Vehicle_ID, created_On, modified_On, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Vehicle_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Vehicle_View)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Vehicle_View) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return [Select](qbe.Vehicle_ID, qbe.Customer_ID, qbe.Tag, qbe.Vin, qbe.Mileage_Correction, qbe.Pricing_Matrix_ID, qbe.Company_ID, qbe.Model_Year_ID, qbe.Make_ID, qbe.Model_ID, qbe.Engine_ID, qbe.Transmission_ID, qbe.Body_Style_ID, qbe.Trim_Level_ID, qbe.Is_Deleted, qbe.Old_Vehicle_ID, qbe.Created_On, qbe.Modified_On)
        End Function
        
        Public Function SelectCount( _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal old_Vehicle_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(vehicle_ID, customer_ID, tag, vin, mileage_Correction, pricing_Matrix_ID, company_ID, model_Year_ID, make_ID, model_ID, engine_ID, transmission_ID, body_Style_ID, trim_Level_ID, is_Deleted, old_Vehicle_ID, created_On, modified_On, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Vehicle_View", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal vehicle_ID As Nullable(Of Integer),  _
                    ByVal customer_ID As Nullable(Of Integer),  _
                    ByVal tag As String,  _
                    ByVal vin As String,  _
                    ByVal mileage_Correction As Nullable(Of Integer),  _
                    ByVal pricing_Matrix_ID As Nullable(Of Integer),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal model_Year_ID As Nullable(Of Integer),  _
                    ByVal make_ID As Nullable(Of Integer),  _
                    ByVal model_ID As Nullable(Of Integer),  _
                    ByVal engine_ID As Nullable(Of Integer),  _
                    ByVal transmission_ID As Nullable(Of Integer),  _
                    ByVal body_Style_ID As Nullable(Of Integer),  _
                    ByVal trim_Level_ID As Nullable(Of Integer),  _
                    ByVal is_Deleted As Nullable(Of Boolean),  _
                    ByVal old_Vehicle_ID As Nullable(Of Integer),  _
                    ByVal created_On As Nullable(Of DateTime),  _
                    ByVal modified_On As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return [Select](vehicle_ID, customer_ID, tag, vin, mileage_Correction, pricing_Matrix_ID, company_ID, model_Year_ID, make_ID, model_ID, engine_ID, transmission_ID, body_Style_ID, trim_Level_ID, is_Deleted, old_Vehicle_ID, created_On, modified_On, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Vehicle_View", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Vehicle_View)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Vehicle_View)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Vehicle_View
            Dim list As List(Of MyCompany.Data.Objects.Vehicle_View) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
