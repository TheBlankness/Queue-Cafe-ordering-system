Imports System.Data.OleDb
Public Class frmReserve
    Dim trans_id As String
    Dim id, guest_id, room_num As Integer



    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmSelectGuest.ShowDialog()
    End Sub

    Private Sub bttnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectRoom.ShowDialog()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmReserve_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel")
        If a = vbNo Then
            e.Cancel = True
        Else

        End If
    End Sub


    Private Sub frmReserve_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"

        lblDateNow.Text = Now.Date
        transID()
        display_reserve()
    End Sub

    Public Sub transID()

        con.Open()
        Dim dt As New DataTable("tblTransaction")
        rs = New OleDbDataAdapter("SELECT * FROM tblTransaction ORDER BY TransID DESC", con)
        rs.Fill(dt)

        If dt.Rows.Count = 0 Then
            txtTransID.Text = "TransID - 0001"
        Else
            Dim value As Integer = Val(dt.Rows(0).Item("TransID"))
            value = value + 1
            txtTransID.Text = "TransID - " & value.ToString("0000")
        End If
        rs.Dispose()
        con.Close()

    End Sub


    Private Sub display_reserve()
        con.Open()
        Dim Dt As New DataTable("TableNumber")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from TableNumber WHERE Status = 'Booked'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlreserve.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem

            Dim value As Integer = Val(Dt.Rows(indx).Item("TableID"))

            lv.Text = value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNum"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MaxPersons"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lv.SubItems.Add(Dt.Rows(indx).Item("BookingID"))

            lvlreserve.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReserve.Click
        Dim stat As String = "Pending"

        If TextBox_table_number.Text = Nothing Then
            MsgBox("Please Choose a Table", vbInformation, "Note")
        Else

            Dim a As String = MsgBox("Confirm Order Transaction?", vbQuestion + vbYesNo, "Check In")
            If a = vbYes Then
                con.Open()


                Dim update_guest As New OleDbCommand("UPDATE TableNumber SET Status = 'Booked' WHERE TableID = " & TextBox_table_number.Text & "", con)
                update_guest.ExecuteNonQuery()


                con.Close()
                display_reserve()
                transID()

            End If
        End If
    End Sub


End Class