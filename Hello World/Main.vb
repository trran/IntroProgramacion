Module Main
    Private generalReport As GeneralReport
    Sub Main()

        encabezado()

        If (parseStringToGeneralReportEnum()) Then
            Console.WriteLine("Por favor eliga un número, no se ponga a inventar.")
            Console.ReadKey()
            Return
        End If

        Try
            Services._Factory.GetReport(generalReport).Print()
        Catch ex As NotImplementedException
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Fin!")
        Console.ReadKey()
    End Sub

    Private Function encabezado()
        Console.WriteLine("Ingrese número el reporte que desea imprimir:")
        Console.WriteLine("0: Republica Dominicana")
        Console.WriteLine("1: Estados Unidos")
        Console.WriteLine("2: India")
        Return True
    End Function

    Private Function parseStringToGeneralReportEnum() As Boolean

        Dim input As String = Console.ReadLine()

        Return Not [Enum].TryParse(input, generalReport)
    End Function

End Module
