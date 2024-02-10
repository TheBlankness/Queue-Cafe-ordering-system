Public Class Drinks1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmCheckin.TextBox_Drink1.Text = Me.TextBox3.Text
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = "15.00"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_quantity.TextChanged
        Dim vtotal As Decimal = Val(TxtBox_quantity.Text) * Val(TextBox2.Text)
        TextBox3.Text = vtotal + ".00"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmCheckin.CheckBox8.Checked = False
        frmCheckin.TextBox_Drink1.Text = ""
    End Sub
End Class