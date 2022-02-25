Imports System.Drawing.Printing

Public Class Common

    Public Shared FontNaslovi As New Font("calibri", 9)
    Public Shared MalFont As New Font("calibri", 9)
    Public Shared MalFont10 As New Font("calibri", 10)
    Public Shared MalFont10Bold As New Font("calibri", 10, FontStyle.Bold)
    Public Shared MalFontK As New Font("consolas", 8)                      'font za karticki
    Public Shared MalFont12 As New Font("consolas", 12)                    'font za cenovnici
    Public Shared MalFont12Bold As New Font("consolas", 12, FontStyle.Bold) 'font za cenovnici
    Public Shared MalFont10cns As New Font("consolas", 10)                    'font za cenovnici
    Public Shared MalFontBold As New Font("consolas", 9, FontStyle.Bold)
    Public Shared GolemFont As New Font("consolas", 16, FontStyle.Bold)
    Public Shared strDesno As New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center}
    Public Shared strDesnoGore As New StringFormat With {.Alignment = StringAlignment.Far}
    Public Shared strDesnoDolu As New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Far}
    Public Shared strCentar As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
    Public Shared strCentarGore As New StringFormat With {.Alignment = StringAlignment.Center}
    Public Shared strLevo As New StringFormat With {.LineAlignment = StringAlignment.Center}
    Public Shared strLevoDolu As New StringFormat With {.LineAlignment = StringAlignment.Far}

    Function xDatum(Datum As Date) As String
        Return Datum.ToString("dd.MM.yyyy")
    End Function


    Public Shared Sub LoadPrinters(cmb As ComboBox)
        cmb.Items.Clear()
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            Try
                cmb.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
            Catch ex As Exception
            End Try
        Next
    End Sub

End Class

Public Enum DijalogRezultati
    Да = 1
    Не = 2
    Откажано = 3
    Замени = 4
End Enum

