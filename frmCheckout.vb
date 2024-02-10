Imports System.Data.OleDb
Public Class frmCheckout

    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmCheckinList.ShowDialog()
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bttnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckout.Click
        If txtTransID.Text = Nothing Then
            MsgBox("Please Complete transaction to checkout!", vbExclamation, "Note")
        Else
            If Val(txtCash.Text) < Val(TextBox_Grand_Total.Text) Then
                MsgBox("Insufficient cash!", vbExclamation, "Note")
            Else
                txtChange.Text = (Val(txtCash.Text) - Val(TextBox_Grand_Total.Text)).ToString("C")
                Dim out As String = MsgBox("Confirm Checkout", vbQuestion + vbYesNo, "Checkout")
                If out = vbYes Then
                    con.Open()
                    Dim update_trans As New OleDbCommand("UPDATE tblOrderTable SET Status = 'Complete' WHERE OrderID = " & txtTransID.Text & "", con)
                    update_trans.ExecuteNonQuery()

                    Dim update_table As New OleDbCommand("UPDATE TableNumber SET Status = 'Available' WHERE TableID = " & txtGuestName.Text & "", con)
                    update_table.ExecuteNonQuery()

                    MsgBox("Payment Success! Change for customer is " & txtChange.Text, vbInformation, "Checkout")
                    con.Close()
                    clear_text()
                End If
            End If
        End If
    End Sub

    Public Sub clear_text()
        txtTransID.Clear()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtDiscountType.Clear()
        txtSubTotal.Clear()
        txtCash.Clear()
        txtChange.Clear()
        TextBox_Grand_Total.Clear()
    End Sub

    Private Sub lblTransID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTransID.TextChanged

    End Sub

    Private Sub frmCheckout_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_text()
    End Sub

    Private Sub frmCheckout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRoomNumber.Clear()
        dtOut.Value = Date.Now
    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txtDiscountType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscountType.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemberListclick.ShowDialog()
    End Sub

    Private Sub TxtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim discount As Decimal
        If txtDiscountType.Text = "20%" Then
            discount = 0.2
        ElseIf txtDiscountType.Text = "10%" Then
            discount = 0.1
        End If

        TextBox_Grand_Total.Text = CDec(Val(txtSubTotal.Text)) - discount * CDec(Val(txtSubTotal.Text))
    End Sub
End Class