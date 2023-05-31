Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim Usuario As New Usuario()
        Usuario.Cpf = "12345678912"
        Usuario.Nome = "Pedro Henrique"
        Usuario.Senha = "ph12345"
        Return View(Usuario)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
