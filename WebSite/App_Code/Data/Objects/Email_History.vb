Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_History
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_History_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Date_Sent As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_User_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_To_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_To_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_From_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_From_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_IP_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Subject As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Message As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Report_File As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Report_File_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Report_ID As Nullable(Of Integer)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Email_History_ID() As Nullable(Of Integer)
            Get
                Return m_Email_History_ID
            End Get
            Set
                m_Email_History_ID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Date_Sent() As Nullable(Of DateTime)
            Get
                Return m_Date_Sent
            End Get
            Set
                m_Date_Sent = value
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
        Public Property User_Name() As String
            Get
                Return m_User_Name
            End Get
            Set
                m_User_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property To_Address() As String
            Get
                Return m_To_Address
            End Get
            Set
                m_To_Address = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property To_Name() As String
            Get
                Return m_To_Name
            End Get
            Set
                m_To_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property From_Address() As String
            Get
                Return m_From_Address
            End Get
            Set
                m_From_Address = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property From_Name() As String
            Get
                Return m_From_Name
            End Get
            Set
                m_From_Name = value
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
        Public Property Subject() As String
            Get
                Return m_Subject
            End Get
            Set
                m_Subject = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Message() As String
            Get
                Return m_Message
            End Get
            Set
                m_Message = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Report_File() As String
            Get
                Return m_Report_File
            End Get
            Set
                m_Report_File = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Report_File_Name() As String
            Get
                Return m_Report_File_Name
            End Get
            Set
                m_Report_File_Name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Report_ID() As Nullable(Of Integer)
            Get
                Return m_Report_ID
            End Get
            Set
                m_Report_ID = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_History_ID As Nullable(Of Integer), ByVal date_Sent As Nullable(Of DateTime), ByVal company_ID As Nullable(Of Integer), ByVal user_Name As String, ByVal to_Address As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal iP_Address As String, ByVal subject As String, ByVal report_File As String, ByVal report_File_Name As String, ByVal report_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(email_History_ID, date_Sent, company_ID, user_Name, to_Address, to_Name, from_Address, from_Name, iP_Address, subject, report_File, report_File_Name, report_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_History) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, sort, Email_HistoryFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, sort, Email_HistoryFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, Nothing, Email_HistoryFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_History)
            Return New Email_HistoryFactory().Select(filter, Nothing, Email_HistoryFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_History
            Return New Email_HistoryFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_History
            Return New Email_HistoryFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_HistoryFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_History")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_History")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_History")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_History")
            End Get
        End Property
        
        Public Shared Function Create() As Email_HistoryFactory
            Return New Email_HistoryFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal email_History_ID As Nullable(Of Integer),  _
                    ByVal date_Sent As Nullable(Of DateTime),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal to_Address As String,  _
                    ByVal to_Name As String,  _
                    ByVal from_Address As String,  _
                    ByVal from_Name As String,  _
                    ByVal iP_Address As String,  _
                    ByVal subject As String,  _
                    ByVal report_File As String,  _
                    ByVal report_File_Name As String,  _
                    ByVal report_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_History_ID.HasValue Then
                filter.Add(("Email_History_ID:=" + email_History_ID.Value.ToString()))
            End If
            If date_Sent.HasValue Then
                filter.Add(("Date_Sent:=" + date_Sent.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(user_Name)) Then
                filter.Add(("User_Name:*" + user_Name))
            End If
            If Not (String.IsNullOrEmpty(to_Address)) Then
                filter.Add(("To_Address:*" + to_Address))
            End If
            If Not (String.IsNullOrEmpty(to_Name)) Then
                filter.Add(("To_Name:*" + to_Name))
            End If
            If Not (String.IsNullOrEmpty(from_Address)) Then
                filter.Add(("From_Address:*" + from_Address))
            End If
            If Not (String.IsNullOrEmpty(from_Name)) Then
                filter.Add(("From_Name:*" + from_Name))
            End If
            If Not (String.IsNullOrEmpty(iP_Address)) Then
                filter.Add(("IP_Address:*" + iP_Address))
            End If
            If Not (String.IsNullOrEmpty(subject)) Then
                filter.Add(("Subject:*" + subject))
            End If
            If Not (String.IsNullOrEmpty(report_File)) Then
                filter.Add(("Report_File:*" + report_File))
            End If
            If Not (String.IsNullOrEmpty(report_File_Name)) Then
                filter.Add(("Report_File_Name:*" + report_File_Name))
            End If
            If report_ID.HasValue Then
                filter.Add(("Report_ID:=" + report_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal email_History_ID As Nullable(Of Integer),  _
                    ByVal date_Sent As Nullable(Of DateTime),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal to_Address As String,  _
                    ByVal to_Name As String,  _
                    ByVal from_Address As String,  _
                    ByVal from_Name As String,  _
                    ByVal iP_Address As String,  _
                    ByVal subject As String,  _
                    ByVal report_File As String,  _
                    ByVal report_File_Name As String,  _
                    ByVal report_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_History)
            Dim request As PageRequest = CreateRequest(email_History_ID, date_Sent, company_ID, user_Name, to_Address, to_Name, from_Address, from_Name, iP_Address, subject, report_File, report_File_Name, report_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_History", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_History)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_History) As List(Of MyCompany.Data.Objects.Email_History)
            Return [Select](qbe.Email_History_ID, qbe.Date_Sent, qbe.Company_ID, qbe.User_Name, qbe.To_Address, qbe.To_Name, qbe.From_Address, qbe.From_Name, qbe.IP_Address, qbe.Subject, qbe.Report_File, qbe.Report_File_Name, qbe.Report_ID)
        End Function
        
        Public Function SelectCount( _
                    ByVal email_History_ID As Nullable(Of Integer),  _
                    ByVal date_Sent As Nullable(Of DateTime),  _
                    ByVal company_ID As Nullable(Of Integer),  _
                    ByVal user_Name As String,  _
                    ByVal to_Address As String,  _
                    ByVal to_Name As String,  _
                    ByVal from_Address As String,  _
                    ByVal from_Name As String,  _
                    ByVal iP_Address As String,  _
                    ByVal subject As String,  _
                    ByVal report_File As String,  _
                    ByVal report_File_Name As String,  _
                    ByVal report_ID As Nullable(Of Integer),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_History_ID, date_Sent, company_ID, user_Name, to_Address, to_Name, from_Address, from_Name, iP_Address, subject, report_File, report_File_Name, report_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_History", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_History_ID As Nullable(Of Integer), ByVal date_Sent As Nullable(Of DateTime), ByVal company_ID As Nullable(Of Integer), ByVal user_Name As String, ByVal to_Address As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal iP_Address As String, ByVal subject As String, ByVal report_File As String, ByVal report_File_Name As String, ByVal report_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Email_History)
            Return [Select](email_History_ID, date_Sent, company_ID, user_Name, to_Address, to_Name, from_Address, from_Name, iP_Address, subject, report_File, report_File_Name, report_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_History", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_History)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_History)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_History
            Dim list As List(Of MyCompany.Data.Objects.Email_History) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
