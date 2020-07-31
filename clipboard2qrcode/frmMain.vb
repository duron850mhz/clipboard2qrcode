Public Class frmMain

    Private Sub picQR_Paint(sender As Object, e As PaintEventArgs) Handles picQR.Paint
        If (Clipboard.ContainsText() = True) Then
            Dim strText As String = Clipboard.GetText()
            Dim bc1 As DotNetBarcode = New DotNetBarcode
            bc1.Type = DotNetBarcode.Types.QRCode
            bc1.PrintCheckDigitChar = True
            bc1.WriteBar(strText, 0, 0, picQR.Width, picQR.Height, e.Graphics)
        Else
            picQR.Image = Nothing
        End If
    End Sub

    Private Sub picQR_Resize(sender As Object, e As EventArgs) Handles picQR.Resize
        picQR.Refresh()
    End Sub

    Private Sub picQR_MouseClick(sender As Object, e As MouseEventArgs) Handles picQR.MouseClick
        picQR.Refresh()
    End Sub
End Class
