Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Log_In
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sign_On_Log_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sign_On_Date As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sign_On_Time As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_User_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_IP_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Sign_On_Log_ID() As Nullable(Of Integer)
            Get
                Return m_Sign_On_Log_ID
            End Get
            Set
                m_Sign_On_Log_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Sign_On_Date() As Nullable(Of DateTime)
            Get
                Return m_Sign_On_Date
            End Get
            Set
                m_Sign_On_Date = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Sign_On_Time() As Nullable(Of DateTime)
            Get
                Return m_Sign_On_Time
            End Get
            Set
                m_Sign_On_Time = value
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
        Public Property IP_Address() As String
            Get
                Return m_IP_Address
            End Get
            Set
                m_IP_Address = value
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
        
        Public Overloads Shared Function [Select](ByVal sign_On_Log_ID As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sign_On_Time As Nullable(Of DateTime), ByVal user_Name As String, ByVal iP_Address As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(sign_On_Log_ID, sign_On_Date, sign_On_Time, user_Name, iP_Address, company_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Log_In) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, sort, Log_InFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, sort, Log_InFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, Nothing, Log_InFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Log_In)
            Return New Log_InFactory().Select(filter, Nothing, Log_InFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Log_In
            Return New Log_InFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Log_In
            Return New Log_InFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Log_InFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Log_In")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Log_In")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Log_In")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Log_In")
            End Get
        End Property
        
        Public Shared Function Create() As Log_InFactory
            Return New Log_InFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal sign_On_Log_ID As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sign_On_Time As Nullable(Of DateTime), ByVal user_Name As String, ByVal iP_Address As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If sign_On_Log_ID.HasValue Then
                filter.Add(("Sign_On_Log_ID:=" + sign_On_Log_ID.Value.ToString()))
            End If
            If sign_On_Date.HasValue Then
                filter.Add(("Sign_On_Date:=" + sign_On_Date.Value.ToString()))
            End If
            If sign_On_Time.HasValue Then
                filter.Add(("Sign_On_Time:=" + sign_On_Time.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(user_Name)) Then
                filter.Add(("User_Name:*" + user_Name))
            End If
            If Not (String.IsNullOrEmpty(iP_Address)) Then
                filter.Add(("IP_Address:*" + iP_Address))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal sign_On_Log_ID As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sign_On_Time As Nullable(Of DateTime), ByVal user_Name As String, ByVal iP_Address As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Log_In)
            Dim request As PageRequest = CreateRequest(sign_On_Log_ID, sign_On_Date, sign_On_Time, user_Name, iP_Address, company_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Log_In", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Log_In)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Log_In) As List(Of MyCompany.Data.Objects.Log_In)
            Return [Select](qbe.Sign_On_Log_ID, qbe.Sign_On_Date, qbe.Sign_On_Time, qbe.User_Name, qbe.IP_Address, qbe.Company_ID)
        End Function
        
        Public Function SelectCount(ByVal sign_On_Log_ID As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sign_On_Time As Nullable(Of DateTime), ByVal user_Name As String, ByVal iP_Address As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(sign_On_Log_ID, sign_On_Date, sign_On_Time, user_Name, iP_Address, company_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Log_In", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal sign_On_Log_ID As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sign_On_Time As Nullable(Of DateTime), ByVal user_Name As String, ByVal iP_Address As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Log_In)
            Return [Select](sign_On_Log_ID, sign_On_Date, sign_On_Time, user_Name, iP_Address, company_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Log_In", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Log_In)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Log_In)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Log_In
            Dim list As List(Of MyCompany.Data.Objects.Log_In) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
