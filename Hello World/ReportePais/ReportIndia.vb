Friend Class ReportIndia
    Implements IGeneralReport

    Sub Print() Implements IGeneralReport.Print
        Console.WriteLine("Imprimiendo Reporte de India.")
        Console.WriteLine("_______________________________________________")

        Console.WriteLine("Capital: Nueva Delhi.")
        Console.WriteLine("Ciudad más poblada: Mumbai.")
        Console.WriteLine("Idioma oficial: Hindi e inglés.")
        Console.WriteLine("Presidente: Ram Nath Kovind.")
        Console.WriteLine("_______________________________________________")

    End Sub
End Class
