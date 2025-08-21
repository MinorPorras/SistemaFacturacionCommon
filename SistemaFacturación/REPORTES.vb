Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Module REPORTES
    Private Sub GenerarPDF()
        Dim document As New PdfDocument()
        Dim page As PdfPage = document.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        Dim font As New XFont("Verdana", 12, FontStyle.Regular)

        Dim width As Double = page.Width.Point
        Dim height As Double = page.Height.Point

        gfx.DrawString("Facturas del Día", font, XBrushes.Black, New XRect(0, 50, width, height), XStringFormats.TopCenter)
        gfx.DrawString("Contenido aquí...", font, XBrushes.Black, New XRect(0, 100, width, height), XStringFormats.TopLeft)

        document.Save("FacturasDelDia.pdf")
    End Sub

End Module
