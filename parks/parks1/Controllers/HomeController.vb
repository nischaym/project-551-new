

Imports Business
Imports Models
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Parks() As ActionResult
        ViewData("Message") = "Top Parks"
        Return View(ParksData.GetParksInformation())
    End Function

End Class
