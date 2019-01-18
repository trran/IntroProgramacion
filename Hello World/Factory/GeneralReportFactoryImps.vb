Public Class GeneralReportFactoryImps
    Implements IGeneralReportFactory
    Private ReadOnly _dict As New Dictionary(Of GeneralReport, IGeneralReport)
    Public Sub New(_dict As Dictionary(Of GeneralReport, IGeneralReport))
        Me._dict = _dict
    End Sub

    Public Function GetReport(ByRef generalReport As GeneralReport) As IGeneralReport Implements IGeneralReportFactory.GetReport
        Dim entity As IGeneralReport = Nothing

        If (Not _dict.TryGetValue(generalReport, entity)) Then
            Throw New NotImplementedException("El Reporte que Intenta Imprimir no tiene una implementacion, favor contactar al administrador: " + generalReport.ToString())
        End If

        Return entity
    End Function
End Class
