Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Demo_Summary
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Date As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_User_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_IP_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Count As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Sign_On_Date As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property [Date]() As String
            Get
                Return m_Date
            End Get
            Set
                m_Date = value
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
        Public Property Count() As Nullable(Of Integer)
            Get
                Return m_Count
            End Get
            Set
                m_Count = value
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
        
        Public Overloads Shared Function [Select](ByVal [date] As String, ByVal user_Name As String, ByVal iP_Address As String, ByVal count As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select([date], user_Name, iP_Address, count, sign_On_Date)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Demo_Summary) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, sort, Demo_SummaryFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, sort, Demo_SummaryFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, Nothing, Demo_SummaryFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return New Demo_SummaryFactory().Select(filter, Nothing, Demo_SummaryFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Demo_Summary
            Return New Demo_SummaryFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Demo_Summary
            Return New Demo_SummaryFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Demo_SummaryFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Demo_Summary")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Demo_Summary")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Demo_Summary")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Demo_Summary")
            End Get
        End Property
        
        Public Shared Function Create() As Demo_SummaryFactory
            Return New Demo_SummaryFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal [date] As String, ByVal user_Name As String, ByVal iP_Address As String, ByVal count As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If Not (String.IsNullOrEmpty([date])) Then
                filter.Add(("Date:*" + [date]))
            End If
            If Not (String.IsNullOrEmpty(user_Name)) Then
                filter.Add(("User_Name:*" + user_Name))
            End If
            If Not (String.IsNullOrEmpty(iP_Address)) Then
                filter.Add(("IP_Address:*" + iP_Address))
            End If
            If count.HasValue Then
                filter.Add(("Count:=" + count.Value.ToString()))
            End If
            If sign_On_Date.HasValue Then
                filter.Add(("Sign_On_Date:=" + sign_On_Date.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal [date] As String, ByVal user_Name As String, ByVal iP_Address As String, ByVal count As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Dim request As PageRequest = CreateRequest([date], user_Name, iP_Address, count, sign_On_Date, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Demo_Summary", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Demo_Summary)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Demo_Summary) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return [Select](qbe.Date, qbe.User_Name, qbe.IP_Address, qbe.Count, qbe.Sign_On_Date)
        End Function
        
        Public Function SelectCount(ByVal [date] As String, ByVal user_Name As String, ByVal iP_Address As String, ByVal count As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest([date], user_Name, iP_Address, count, sign_On_Date, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Demo_Summary", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal [date] As String, ByVal user_Name As String, ByVal iP_Address As String, ByVal count As Nullable(Of Integer), ByVal sign_On_Date As Nullable(Of DateTime)) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return [Select]([date], user_Name, iP_Address, count, sign_On_Date, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Demo_Summary", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Demo_Summary)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Demo_Summary)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Demo_Summary
            Dim list As List(Of MyCompany.Data.Objects.Demo_Summary) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
