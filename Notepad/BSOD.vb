Public Class BSOD
    Dim closeAllowed As Boolean = False

    Private Sub BSOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Windows.Forms.Cursor.Hide()
    End Sub

    Private Sub BSOD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseAllowed Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BSOD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.K Then
            CloseAllowed = True
            End
        End If
    End Sub
End Class