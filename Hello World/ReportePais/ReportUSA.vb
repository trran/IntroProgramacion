Friend Class ReportUSA
    Implements IGeneralReport

    Public Sub Print() Implements IGeneralReport.Print
        Console.WriteLine("Imprimiendo Reporte de Estados Unidos:")
        Console.WriteLine("_______________________________________________")
        Console.WriteLine()
        Console.WriteLine("Capital:	Washington D. C.")
        Console.WriteLine("Ciudad más poblada:	Nueva York.")
        Console.WriteLine("Idioma oficial:	Ninguno a nivel federal.")
        Console.WriteLine("Presidente:	Donald Trump.")
        Console.WriteLine("_______________________________________________")

    End Sub
End Class
