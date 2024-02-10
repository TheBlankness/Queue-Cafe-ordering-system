Imports System.Data.OleDb
Public Class frmCheckin
    Dim guestID, roomID, trans_ID As Integer

    Private Sub frmCheckin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim exit_app As String = MsgBox("Cancel Order?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            clear_text()
        End If
    End Sub

    Private Sub frmCheckin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"

        transID()
        display_checkin()
    End Sub

    Public Sub transID()
        con.Open()
        Dim dt As New DataTable("tblOrderTable")
        rs = New OleDbDataAdapter("SELECT * FROM tblOrderTable ORDER BY OrderID DESC", con)
        rs.Fill(dt)

        If dt.Rows.Count = 0 Then
            txtTransID.Text = "0001"
        Else
            Dim value As Integer = Val(dt.Rows(0).Item("OrderID"))
            value = value + 1
            txtTransID.Text = value.ToString("0000")
            trans_ID = value
        End If
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnCheckIn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckIn.Click

        Dim stat As String = "Pending"

        If TextBox_table_number.Text = Nothing Then
            MsgBox("Please Choose a Table", vbInformation, "Note")
        Else

            Dim a As String = MsgBox("Confirm Order Transaction?", vbQuestion + vbYesNo, "Check In")
            If a = vbYes Then
                con.Open()

                Dim Food1 As Decimal = CDec(Val(TextBox_Food1.Text)) / 12
                Dim Food2 As Decimal = CDec(Val(TextBox_Food2.Text)) / 10
                Dim Food3 As Decimal = CDec(Val(TextBox_Food3.Text)) / 15
                Dim Food4 As Decimal = CDec(Val(TextBox_Food4.Text)) / 18
                Dim Drink1 As Decimal = CDec(Val(TextBox_Drink1.Text)) / 12
                Dim Drink2 As Decimal = CDec(Val(TextBox_Drink2.Text)) / 13
                Dim Drink3 As Decimal = CDec(Val(TextBox_Drink3.Text)) / 10
                Dim Drink4 As Decimal = CDec(Val(TextBox_Drink4.Text)) / 10
                Dim checkin As New OleDbCommand("INSERT INTO tblOrderTable(OrderID,TableNumber,Food1,Food2,Food3,Food4,Drink1,Drink2,Drink3,Drink4,Status) values ('" &
                                                txtTransID.Text & "','" &
                                                TextBox_table_number.Text & "','" &
                                                Food1 & "','" &
                                                Food2 & "','" &
                                                Food3 & "','" &
                                                Food4 & "','" &
                                                Drink1 & "','" &
                                                Drink2 & "','" &
                                                Drink3 & "','" &
                                                Drink4 & "','" &
                                                stat & "')", con)
                checkin.ExecuteNonQuery()

                Dim update_guest As New OleDbCommand("UPDATE TableNumber SET Status = 'Occupied' WHERE TableID = " & TextBox_table_number.Text & "", con)
                update_guest.ExecuteNonQuery()

                clear_text()
                con.Close()
                transID()
                display_checkin()
            End If
        End If
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        clear_text()
    End Sub

    Private Sub txtAdvance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub clear_text()

        TextBox_total_items.Text = ""
        TextBox_table_number.Text = ""
        TextBox_Food1.Text = "0"
        TextBox_Food2.Text = "0"
        TextBox_Food3.Text = "0"
        TextBox_Food4.Text = "0"
        TextBox_Drink1.Text = "0"
        TextBox_Drink2.Text = "0"
        TextBox_Drink3.Text = "0"
        TextBox_Drink4.Text = "0"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        TextBox_Max_person.Text = ""


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox_Food1.Enabled = True
            Food1.Show()
            Food1.TxtBox_quantity.Focus()
        Else
            TextBox_Food1.Enabled = False
            TextBox_Food1.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox_Food2.Enabled = True
            Food2.Show()
            Food2.TxtBox_quantity.Focus()
        Else
            TextBox_Food2.Enabled = False
            TextBox_Food2.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox_Food3.Enabled = True
            Food3.Show()
            Food3.TxtBox_quantity.Focus()
        Else
            TextBox_Food3.Enabled = False
            TextBox_Food3.Text = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox_Food4.Enabled = True
            Food4.Show()
            Food4.TxtBox_quantity.Focus()
        Else
            TextBox_Food4.Enabled = False
            TextBox_Food4.Text = ""
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox_Drink1.Enabled = True
            Drinks1.Show()
            Drinks1.TxtBox_quantity.Focus()
        Else
            TextBox_Drink1.Enabled = False
            TextBox_Drink1.Text = ""
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox_Drink2.Enabled = True
            Drink2.Show()
            Drink2.TxtBox_quantity.Focus()
        Else
            TextBox_Drink2.Enabled = False
            TextBox_Drink2.Text = ""
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox_Drink3.Enabled = True
            Drink3.Show()
            Drink3.TxtBox_quantity.Focus()
        Else
            TextBox_Drink3.Enabled = False
            TextBox_Drink3.Text = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox_Drink4.Enabled = True
            Drink4.Show()
            Drink4.TxtBox_quantity.Focus()
        Else
            TextBox_Drink4.Enabled = False
            TextBox_Drink4.Text = ""
        End If
    End Sub

    Private Sub Button_table_pick_Click(sender As Object, e As EventArgs) Handles button_table_pick.Click
        frmSelectRoom.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TotalItem As Decimal

        If String.IsNullOrEmpty(TextBox_Food1.Text) Then

        Else
            TotalItem += TextBox_Food1.Text
        End If
        If String.IsNullOrEmpty(TextBox_Food2.Text) Then

        Else
            TotalItem += TextBox_Food2.Text
        End If
        If String.IsNullOrEmpty(TextBox_Food3.Text) Then

        Else
            TotalItem += TextBox_Food3.Text
        End If
        If String.IsNullOrEmpty(TextBox_Food4.Text) Then

        Else
            TotalItem += TextBox_Food4.Text
        End If
        If String.IsNullOrEmpty(TextBox_Drink1.Text) Then

        Else
            TotalItem += TextBox_Drink1.Text
        End If
        If String.IsNullOrEmpty(TextBox_Drink2.Text) Then

        Else
            TotalItem += TextBox_Drink2.Text
        End If
        If String.IsNullOrEmpty(TextBox_Drink3.Text) Then

        Else
            TotalItem += TextBox_Drink3.Text
        End If
        If String.IsNullOrEmpty(TextBox_Drink4.Text) Then

        Else
            TotalItem += TextBox_Drink4.Text
        End If


        TextBox_total_items.Text = TotalItem
    End Sub

    Private Sub display_checkin()
        con.Open()
        Dim Dt As New DataTable("tblOrderTable")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblOrderTable", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlcheckin.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem

            Dim value As Integer = Val(Dt.Rows(indx).Item("OrderID"))

            lv.Text = value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNumber"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Food1"))

            ''rate = Dt.Rows(indx).Item("RoomRate")

            lv.SubItems.Add(Dt.Rows(indx).Item("Food2"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Food3"))

            ''dtIn.Value = Dt.Rows(indx).Item("CheckOutDate")
            ''dtOut.Value = Dt.Rows(indx).Item("CheckInDate")

            ''getdate = dtIn.Value - dtOut.Value
            ''days = getdate.Days

            lv.SubItems.Add(Dt.Rows(indx).Item("Food4"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Drink1"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Drink2"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Drink3"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Drink4"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lvlcheckin.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class