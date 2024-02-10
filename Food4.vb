Public Class Food4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmCheckin.TextBox_Food4.Text = Me.TextBox3.Text
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = "18.00"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_quantity.TextChanged
        Dim vtotal As Decimal = Val(TxtBox_quantity.Text) * Val(TextBox2.Text)
        TextBox3.Text = vtotal + ".00"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmCheckin.CheckBox4.Checked = False
        frmCheckin.TextBox_Food4.Text = ""
    End Sub
End Class