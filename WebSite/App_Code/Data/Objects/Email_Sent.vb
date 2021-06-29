Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Email_Sent
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email_Sent_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Is_Deleted As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_On As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Created_By As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_To_Addresse As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_To_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_From_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_From_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Subject As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Message As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Attached_Field_Name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Email_Sent_ID() As Nullable(Of Integer)
            Get
                Return m_Email_Sent_ID
            End Get
            Set
                m_Email_Sent_ID = value
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
        Public Property Is_Deleted() As Nullable(Of Boolean)
            Get
                Return m_Is_Deleted
            End Get
            Set
                m_Is_Deleted = value
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
        Public Property Created_By() As String
            Get
                Return m_Created_By
            End Get
            Set
                m_Created_By = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property To_Addresse() As String
            Get
                Return m_To_Addresse
            End Get
            Set
                m_To_Addresse = value
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
        Public Property Attached_Field_Name() As String
            Get
                Return m_Attached_Field_Name
            End Get
            Set
                m_Attached_Field_Name = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal email_Sent_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal is_Deleted As Nullable(Of Boolean), ByVal created_On As Nullable(Of DateTime), ByVal created_By As String, ByVal to_Addresse As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal subject As String, ByVal attached_Field_Name As String) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(email_Sent_ID, company_ID, is_Deleted, created_On, created_By, to_Addresse, to_Name, from_Address, from_Name, subject, attached_Field_Name)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Sent) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, sort, Email_SentFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, sort, Email_SentFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, Nothing, Email_SentFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return New Email_SentFactory().Select(filter, Nothing, Email_SentFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Sent
            Return New Email_SentFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Email_Sent
            Return New Email_SentFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Email_SentFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Email_Sent")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Email_Sent")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Email_Sent")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Email_Sent")
            End Get
        End Property
        
        Public Shared Function Create() As Email_SentFactory
            Return New Email_SentFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal email_Sent_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal is_Deleted As Nullable(Of Boolean), ByVal created_On As Nullable(Of DateTime), ByVal created_By As String, ByVal to_Addresse As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal subject As String, ByVal attached_Field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If email_Sent_ID.HasValue Then
                filter.Add(("Email_Sent_ID:=" + email_Sent_ID.Value.ToString()))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            If is_Deleted.HasValue Then
                filter.Add(("Is_Deleted:=" + is_Deleted.Value.ToString()))
            End If
            If created_On.HasValue Then
                filter.Add(("Created_On:=" + created_On.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(created_By)) Then
                filter.Add(("Created_By:*" + created_By))
            End If
            If Not (String.IsNullOrEmpty(to_Addresse)) Then
                filter.Add(("To_Addresse:*" + to_Addresse))
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
            If Not (String.IsNullOrEmpty(subject)) Then
                filter.Add(("Subject:*" + subject))
            End If
            If Not (String.IsNullOrEmpty(attached_Field_Name)) Then
                filter.Add(("Attached_Field_Name:*" + attached_Field_Name))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal email_Sent_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal is_Deleted As Nullable(Of Boolean), ByVal created_On As Nullable(Of DateTime), ByVal created_By As String, ByVal to_Addresse As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal subject As String, ByVal attached_Field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Email_Sent)
            Dim request As PageRequest = CreateRequest(email_Sent_ID, company_ID, is_Deleted, created_On, created_By, to_Addresse, to_Name, from_Address, from_Name, subject, attached_Field_Name, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Sent", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Sent)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Email_Sent) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return [Select](qbe.Email_Sent_ID, qbe.Company_ID, qbe.Is_Deleted, qbe.Created_On, qbe.Created_By, qbe.To_Addresse, qbe.To_Name, qbe.From_Address, qbe.From_Name, qbe.Subject, qbe.Attached_Field_Name)
        End Function
        
        Public Function SelectCount(ByVal email_Sent_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal is_Deleted As Nullable(Of Boolean), ByVal created_On As Nullable(Of DateTime), ByVal created_By As String, ByVal to_Addresse As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal subject As String, ByVal attached_Field_Name As String, ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(email_Sent_ID, company_ID, is_Deleted, created_On, created_By, to_Addresse, to_Name, from_Address, from_Name, subject, attached_Field_Name, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Email_Sent", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal email_Sent_ID As Nullable(Of Integer), ByVal company_ID As Nullable(Of Integer), ByVal is_Deleted As Nullable(Of Boolean), ByVal created_On As Nullable(Of DateTime), ByVal created_By As String, ByVal to_Addresse As String, ByVal to_Name As String, ByVal from_Address As String, ByVal from_Name As String, ByVal subject As String, ByVal attached_Field_Name As String) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return [Select](email_Sent_ID, company_ID, is_Deleted, created_On, created_By, to_Addresse, to_Name, from_Address, from_Name, subject, attached_Field_Name, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Email_Sent", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Email_Sent)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Email_Sent)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Email_Sent
            Dim list As List(Of MyCompany.Data.Objects.Email_Sent) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
