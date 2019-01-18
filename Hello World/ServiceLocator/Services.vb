Module Services
    Public ReadOnly _Factory As IGeneralReportFactory
    Sub New()
        Dim _Dict As New Dictionary(Of GeneralReport, IGeneralReport)
        _Dict.Add(GeneralReport.RD, New ReportRD())
        _Dict.Add(GeneralReport.USA, New ReportUSA())
        _Dict.Add(GeneralReport.India, New ReportIndia())
        _Factory = New GeneralReportFactoryImps(_Dict)
    End Sub
End Module


