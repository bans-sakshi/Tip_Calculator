Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        MsgBox(" Your Login is Successful !!", MsgBoxStyle.OkCancel, "LOGIN FORM ")

        If (a = MsgBoxResult.Ok) Then
            MsgBox(" You have successfully logged in.", " login")
        ElseIf (a = MsgBoxResult.Cancel) Then
            Me.Close()
        End If

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class


