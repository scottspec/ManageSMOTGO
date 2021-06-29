Namespace MyCompany.Handlers
    
    Partial Public Class BlobFactoryConfig
        Inherits BlobFactory
        
        Public Shared Sub Initialize()
            'register blob handlers
            RegisterHandler("Company_ViewLogo", """dbo"".""Company_View""", """Logo""", New String(-1) {}, "Company View Logo", "Company_View", "Logo")
        End Sub
    End Class
End Namespace
