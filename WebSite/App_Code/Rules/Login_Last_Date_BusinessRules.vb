Imports MyCompany.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace MyCompany.Rules
    
    Partial Public Class Login_Last_Date_BusinessRules
        Inherits MyCompany.Rules.SharedBusinessRules

        <ControllerAction("", "Custom", "Assign")> _
        Private Sub assign(ByVal company_ID As Nullable(Of Integer))
            Dim sqlt As SqlText = New SqlText("Update ShopManager.dbo.aspnet_Users Set Company_ID = @0 Where (UserName = 'ScottSpecManage')")
            sqlt.AssignParameter("@0", company_ID)
            sqlt.ExecuteNonQuery()
            PreventDefault()
            Result.Continue()

        End Sub

        <ControllerAction("", "Custom", "Reset")>
        Private Sub unassign()
            Dim sqlt As SqlText = New SqlText("Update ShopManager.dbo.aspnet_Users Set Company_ID = 1 Where (UserName = 'ScottSpecManage')")
            sqlt.ExecuteNonQuery()
            PreventDefault()
            Result.Continue()

        End Sub

        <ControllerAction("Company_Status", "Select", ActionPhase.Before)>
        Private Sub LoadCompanyStats()
            Using _sqlT As New SqlText("Select Sql From SQl Where (SQL_ID < 14)")
                Do While _sqlT.Read()
                    Using _sqlT2 As New SqlText(_sqlT(0).ToString)
                        _sqlT2.ExecuteNonQuery()
                    End Using
                Loop
            End Using
        End Sub
    End Class
End Namespace
