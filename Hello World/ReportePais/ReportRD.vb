Public Class ReportRD
    Implements IGeneralReport

    Public Function Print() As Object Implements IGeneralReport.Print
        Console.WriteLine("Imprimiendo Reporte de Republica Dominicana:")
        Console.WriteLine("_______________________________________________")
        Console.WriteLine("Capital: Santo Domingo.")
        Console.WriteLine("Ciudad más poblada: Santo Domingo.")
        Console.WriteLine("Idioma oficial: Español.")
        Console.WriteLine("Presidente: Danilo Medina.")
        Console.WriteLine("_______________________________________________")

        Return Me.ToString()
    End Function
End Class
