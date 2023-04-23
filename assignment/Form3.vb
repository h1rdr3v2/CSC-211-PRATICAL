Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables to hold all inputs and sum
        Dim num1, num2, num3, sum As Integer

        ' Check if the inputs are real intergers

        If Not Integer.TryParse(TextBox1.Text, num1) Then
            MessageBox.Show("Please enter a valid integer in input1.")
            Return
        End If
        If Not Integer.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Please enter a valid integer in input2.")
            Return
        End If
        If Not Integer.TryParse(TextBox3.Text, num3) Then
            MessageBox.Show("Please enter a valid integer in input3.")
            Return
        End If

        ' Sum them up
        sum = num1 + num2 + num3

        ' Display on the application
        Label4.Visible = True
        Label4.Text = "Sum of all your inputs is " & sum

    End Sub
End Class