Public Class ReportIndia
    Implements IGeneralReport

    Public Function Print() As Object Implements IGeneralReport.Print
        Console.WriteLine("Imprimiendo Reporte de India.")
        Console.WriteLine("_______________________________________________")

        Console.WriteLine("Capital: Nueva Delhi.")
        Console.WriteLine("Ciudad más poblada: Mumbai.")
        Console.WriteLine("Idioma oficial: Hindi e inglés.")
        Console.WriteLine("Presidente: Ram Nath Kovind.")
        Console.WriteLine("_______________________________________________")

        Return Me.ToString()
    End Function
End Class
