Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Rules
    
    Partial Public Class Company_User_BusinessRules
        Inherits MyCompany.Rules.SharedBusinessRules

        <ControllerAction("Company_User", "Insert", ActionPhase.Before)> _
        Private Sub CreateUserAndAccount()
            PreventDefault()
            Dim _cID As Integer = Nothing
            Dim _uName As String = Nothing
            Dim _pWord As String = Nothing
            Dim _eMail As String = Nothing
            Dim _cName As String = Nothing
            Dim _address As String = Nothing
            Dim _city As String = Nothing
            Dim _state As String = Nothing
            Dim _zip As String = Nothing
            Dim _newUser As String = Nothing

            Try
                _cID = SelectExternalFilterFieldValue("Company_ID")
                _uName = Arguments.Item("UserName").NewValue
                _pWord = Arguments.Item("Password").NewValue
                _eMail = Arguments.Item("EmailAddress").NewValue
                _cName = Arguments.Item("CompanyName").NewValue
                _address = Arguments.Item("Address").NewValue
                _city = Arguments.Item("City").NewValue
                _state = Arguments.Item("State").NewValue
                _zip = Arguments.Item("Zip").NewValue
                _newUser = Arguments.Item("Create_New_User").NewValue

                If Arguments.Item("Key").NewValue <> "ThisNew123%" Then
                    Result.ShowAlert("You do not have proper permission.")
                    Exit Sub
                End If

                Using _sqlT As New SqlText("Select Count(Company_ID) From shopmanager.dbo.aspnet_Users Where (Company_ID = @0)")
                    _sqlT.AddParameter("@0", _cID)
                    If _sqlT.ExecuteScalar > 0 Then
                        Result.ShowAlert("This Company has users.  You must delete those first.")
                        Exit Sub
                    End If
                End Using

                Using _sqlT As New SqlText("Select Count(UserName) From shopmanager.dbo.aspnet_Users Where (UserName = @0)")
                    _sqlT.AddParameter("@0", _uName)
                    If _sqlT.ExecuteScalar > 0 Then
                        Result.Focus("UserName", "This user name is already taken.  Please try another.")
                        Exit Sub
                    End If
                End Using

                If _uName.Contains(",") Then
                    Result.Focus("User_Name", "A user name cannot contain commas.  Please try another.")
                    Exit Sub
                End If


                Using _sqlT As New SqlText("Select UserName From shopmanager.dbo.aspnet_Users Where (Company_ID = @0)")
                    _sqlT.AddParameter("@0", _cID)
                    Do While _sqlT.Read
                        Membership.DeleteUser(_sqlT(0))
                    Loop
                End Using

                Using _sqlT As New SqlText("Delete From Email_Address Where (Company_ID = @0)")
                    _sqlT.AddParameter("@0", _cID)
                    _sqlT.ExecuteNonQuery()
                End Using

                If _newuser = True Then

                    Dim status As MembershipCreateStatus
                    Membership.CreateUser(Trim(_uName), _pWord, _eMail, "Registered Email Address", _eMail, True, status)
                    Dim _roles As String() = {"Administrators", "NewHomePage"}
                    System.Web.Security.Roles.AddUserToRoles(_uName, _roles)

                    Using _sqlT As New SqlText("Update shopmanager.dbo.aspnet_Users Set Company_ID = @0 " _
                                           & "Where (UserName = @1)")
                        _sqlT.AddParameter("@0", _cID)
                        _sqlT.AddParameter("@1", _uName)
                        _sqlT.ExecuteNonQuery()
                    End Using

                End If


                If Arguments.Item("ClearAll").NewValue = True Then
                    Dim _str As String = "delete from ManageSMOTGO.dbo.Email_Address Where Company_ID = @0;"
                    _str += "update shopmanager.dbo.company set CompanyID = 0 Where (CompanyID = @0);"
                    _str += "update shopmanager.dbo.Additional_Charge set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Additional_Charge_Invoice set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Additional_Charge_Invoice_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Appointments set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Body_Style set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Communication set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Communication_Customer_Status set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Communication_Sent set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Communication_Temp set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Communication_Vehicle_Status set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Contact_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Contact set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Ledger set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee_Position set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee_Document_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee_Document set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Company_Account set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Create_Document_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Group set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Reward set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Reward_Account set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Reward_Item set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Customer_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Data_Archive set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Date_Closed set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Document set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Document_Category set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Email_Template set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Email_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Email_Message set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Email_Sent set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Email_Subject  set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee_Time_Description set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Employee_Time_Log set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Engine set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Fax_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Follow_Up_Survey set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Follow_Up_Survey_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Invoice set Location_ID = @3 Where (Location_ID = @0);"
                    _str += "update shopmanager.dbo.Invoice_Estimate_Note_Saved set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Invoice_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Invoice_Note_Saved set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Invoice_Status set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Issue_Instruction_Saved set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Catalog set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Catalog_Job set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Name set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Saved set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Saved_Cache set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Saved_Filter_Cache set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Job_Time_Log set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Make set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Marketing_Code set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Model set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Model_Year set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.News_Letter set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.News_Letter_Detail set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.News_Letter_Send_Temp set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.News_Letter_Sent set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Location_Info set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Purchase_Order set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.[Return] set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Purchase_Order_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Return_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Alternate set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Audit set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Brand set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Document set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Document_Category set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Job_Category set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Manufacturer set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Required set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_Used set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Part_V set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Payment_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Phone_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Pricing_Matrix set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Print_Option set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Print_Option_Detail set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Print_Option_Detail_Company set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Promotion set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Purchase_Order set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Purchase_Order_History set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Purchase_Order_Type set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.QuickBooks_Deposit set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.QuickBooks_Deposit_Detail set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Report set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Report_Custom_Name set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Return_Reason set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Service_Reminder_Replacement set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Sign_On_Log set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Text_Message set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Text_Message_Saved set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Time_Off set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Transmission set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Trim_Level set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle_Atribute_Name set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle_Attribute set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle_Document_Category set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle_Group set Company_ID = @3 Where (Company_ID = @0);"
                    _str += "update shopmanager.dbo.Vehicle_Specification_Name set Company_ID = @3 Where (Company_ID = @0)"

                    Using _sql As New SqlText(_str)
                        _sql.AddParameter("@0", _cID)
                        _sql.AddParameter("@3", 3)
                        _sql.ExecuteNonQuery()
                    End Using


                End If

                Using _sqlT As New SqlText("update shopmanager.dbo.company set Name = @0, Address_Line_1 = @1, Address_Line_2 = @2, " +
                                            "City = @3, State = @4, Zip_Code = @5, Appointment_Number = 1, Appointment_Text_ID = 0, Email_Address = @6, " +
                                            "Estimate_Number = 1, Fax_Number = null, Invoice_Number = 1, Is_Deleted = @8, Kukui_Key = null, Logo = null, Note = null, " +
                                            "Order_Number = 1, Phone_Number_1 = null, Phone_Number_2 = null, Phone_Number_3 = null, " +
                                            "Pricing_Matrix_ID = null, Return_Number = 1, Sales_Tax_ID = null, Service_Interval_Day = 120, Service_Interval_Mile = 4000, " +
                                            "State_Tax_ID = null, Tax_Rate_Labor = 0, Tax_Rate_Parts = 0, Web_Site = null Where (Company_ID = @7)")
                    _sqlT.AddParameter("@0", _cName)
                    _sqlT.AddParameter("@1", _address)
                    _sqlT.AddParameter("@2", "")
                    _sqlT.AddParameter("@3", _city)
                    _sqlT.AddParameter("@4", _state)
                    _sqlT.AddParameter("@5", _zip)
                    _sqlT.AddParameter("@6", _eMail)
                    _sqlT.AddParameter("@7", _cID)

                    If _newUser = True Then
                        _sqlT.AddParameter("@8", 0)
                    Else
                        _sqlT.AddParameter("@8", 1)
                    End If

                    _sqlT.ExecuteNonQuery()

                End Using

            Catch ex As Exception

            End Try

        End Sub

    End Class
End Namespace
