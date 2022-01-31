Imports System.Drawing.Printing

Public Class Common

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

