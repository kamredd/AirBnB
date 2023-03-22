Public Class frmairbnb
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal

        Const cdecCostPerNight As Decimal = 79D

        intNumNights = Convert.ToInt32(txtNumber.Text)

        decTotalCost = intNumNights * cdecCostPerNight

        lblActualCost.Text = decTotalCost.ToString("C")
        lblActualCost.Visible = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblActualCost.Text = " "
        lblActualCost.Visible = False
        txtNumber.Clear()
        txtNumber.Focus()

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class
