Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton1.ForeColor = Color.Yellow
            RadioButton2.ForeColor = Color.Brown
            RadioButton3.ForeColor = Color.Purple
        End If
    End Sub

End Class