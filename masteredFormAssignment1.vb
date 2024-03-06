Public Class Form1

    Private Sub btnPer_Click(sender As Object, e As EventArgs) Handles btnPer.Click
        Dim x, y, perimeter As String
        'used as string and then converted to its decimal equivalent number
        Try
            x = Decimal.Parse(TextBoxLength.Text, Globalization.NumberStyles.Number)
            y = Decimal.Parse(txtBoxSides.Text, Globalization.NumberStyles.Number)
            'perimeter + length x number of sides
            perimeter = Val(x) * Val(y)
            'listbox used so that multiple elements can show in the listbox
            ListBox1.Items.Add("Perimeter =" & perimeter)
        Catch
            MessageBox.Show("Please enter a number")
        End Try
        'error checking for when a number is not put in the text boxes
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim x, y, perimeter, z As Double
        Try
            x = Decimal.Parse(TextBoxLength.Text, Globalization.NumberStyles.Number)
            y = Decimal.Parse(txtBoxSides.Text, Globalization.NumberStyles.Number)
            Dim calculateApothem As Double = TextBoxLength.Text / (2 * (Math.Tan(Math.PI / txtBoxSides.Text)))
            perimeter = (x) * (y)
            z = (perimeter * calculateApothem) / 2
            ListBox1.Items.Add("Area = " & Math.Round(z, 2))
        Catch
            MessageBox.Show("Please enter a number")
        End Try
        'Error message for when a letter is entered instead of a number

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBoxLength.Clear()
        txtBoxSides.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
