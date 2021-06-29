Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class Company_User
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_UserName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Company_ID As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Password As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmailAddress As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CompanyName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Address As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_City As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Zip As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClearAll As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Key As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Create_New_User As Nullable(Of Boolean)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, false, false)>  _
        Public Property UserName() As String
            Get
                Return m_UserName
            End Get
            Set
                m_UserName = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Password() As String
            Get
                Return m_Password
            End Get
            Set
                m_Password = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property EmailAddress() As String
            Get
                Return m_EmailAddress
            End Get
            Set
                m_EmailAddress = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property CompanyName() As String
            Get
                Return m_CompanyName
            End Get
            Set
                m_CompanyName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Address() As String
            Get
                Return m_Address
            End Get
            Set
                m_Address = value
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
        Public Property Zip() As String
            Get
                Return m_Zip
            End Get
            Set
                m_Zip = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property ClearAll() As Nullable(Of Boolean)
            Get
                Return m_ClearAll
            End Get
            Set
                m_ClearAll = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Key() As String
            Get
                Return m_Key
            End Get
            Set
                m_Key = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Create_New_User() As Nullable(Of Boolean)
            Get
                Return m_Create_New_User
            End Get
            Set
                m_Create_New_User = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select](ByVal userName As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(userName, company_ID)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_User) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, sort, Company_UserFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, sort, Company_UserFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, Nothing, Company_UserFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of MyCompany.Data.Objects.Company_User)
            Return New Company_UserFactory().Select(filter, Nothing, Company_UserFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_User
            Return New Company_UserFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As MyCompany.Data.Objects.Company_User
            Return New Company_UserFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal userName As String) As MyCompany.Data.Objects.Company_User
            Return New Company_UserFactory().SelectSingle(userName)
        End Function
        
        Public Function Insert() As Integer
            Return New Company_UserFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New Company_UserFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New Company_UserFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("UserName: {0}", Me.UserName)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class Company_UserFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("Company_User")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("Company_User")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("Company_User")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("Company_User")
            End Get
        End Property
        
        Public Shared Function Create() As Company_UserFactory
            Return New Company_UserFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal userName As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If (Not (userName) Is Nothing) Then
                filter.Add(("UserName:=" + userName))
            End If
            If company_ID.HasValue Then
                filter.Add(("Company_ID:=" + company_ID.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select](ByVal userName As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of MyCompany.Data.Objects.Company_User)
            Dim request As PageRequest = CreateRequest(userName, company_ID, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_User", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_User)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As MyCompany.Data.Objects.Company_User) As List(Of MyCompany.Data.Objects.Company_User)
            Return [Select](qbe.UserName, qbe.Company_ID)
        End Function
        
        Public Function SelectCount(ByVal userName As String, ByVal company_ID As Nullable(Of Integer), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(userName, company_ID, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("Company_User", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal userName As String, ByVal company_ID As Nullable(Of Integer)) As List(Of MyCompany.Data.Objects.Company_User)
            Return [Select](userName, company_ID, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal userName As String) As MyCompany.Data.Objects.Company_User
            Dim emptyCompany_ID As Nullable(Of Integer) = Nothing
            Dim list As List(Of MyCompany.Data.Objects.Company_User) = [Select](userName, emptyCompany_ID)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("Company_User", dataView, request)
            Return page.ToList(Of MyCompany.Data.Objects.Company_User)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of MyCompany.Data.Objects.Company_User)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As MyCompany.Data.Objects.Company_User
            Dim list As List(Of MyCompany.Data.Objects.Company_User) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theCompany_User As MyCompany.Data.Objects.Company_User, ByVal original_Company_User As MyCompany.Data.Objects.Company_User) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("UserName", original_Company_User.UserName, theCompany_User.UserName))
            values.Add(New FieldValue("Company_ID", original_Company_User.Company_ID, theCompany_User.Company_ID))
            values.Add(New FieldValue("Password", original_Company_User.Password, theCompany_User.Password))
            values.Add(New FieldValue("EmailAddress", original_Company_User.EmailAddress, theCompany_User.EmailAddress))
            values.Add(New FieldValue("CompanyName", original_Company_User.CompanyName, theCompany_User.CompanyName))
            values.Add(New FieldValue("Address", original_Company_User.Address, theCompany_User.Address))
            values.Add(New FieldValue("City", original_Company_User.City, theCompany_User.City))
            values.Add(New FieldValue("State", original_Company_User.State, theCompany_User.State))
            values.Add(New FieldValue("Zip", original_Company_User.Zip, theCompany_User.Zip))
            values.Add(New FieldValue("ClearAll", original_Company_User.ClearAll, theCompany_User.ClearAll))
            values.Add(New FieldValue("Key", original_Company_User.Key, theCompany_User.Key))
            values.Add(New FieldValue("Create_New_User", original_Company_User.Create_New_User, theCompany_User.Create_New_User))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theCompany_User As MyCompany.Data.Objects.Company_User, ByVal original_Company_User As MyCompany.Data.Objects.Company_User, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "Company_User"
            args.View = dataView
            args.Values = CreateFieldValues(theCompany_User, original_Company_User)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("Company_User", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theCompany_User)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theCompany_User As MyCompany.Data.Objects.Company_User, ByVal original_Company_User As MyCompany.Data.Objects.Company_User) As Integer
            Return ExecuteAction(theCompany_User, original_Company_User, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theCompany_User As MyCompany.Data.Objects.Company_User) As Integer
            Return Update(theCompany_User, SelectSingle(theCompany_User.UserName))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theCompany_User As MyCompany.Data.Objects.Company_User) As Integer
            Return ExecuteAction(theCompany_User, New Company_User(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theCompany_User As MyCompany.Data.Objects.Company_User) As Integer
            Return ExecuteAction(theCompany_User, theCompany_User, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
