Imports System.Data.OleDb
Public Class frmSelectRoom

    Private Sub frmSelectRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_room()
    End Sub
    Private Sub display_room()
        con.Open()
        Dim Dt As New DataTable("TableNumber")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from TableNumber WHERE Status = 'Available'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvRoom.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("TableID")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNum"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MaxPersons"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lv.SubItems.Add(Dt.Rows(indx).Item("BookingID"))
            lvRoom.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub my_bookings()
        con.Open()
        Dim Dt As New DataTable("TableNumber")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from TableNumber WHERE Status = 'Booked'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvRoom.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("TableID")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNum"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MaxPersons"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lv.SubItems.Add(Dt.Rows(indx).Item("BookingID"))
            lvRoom.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub


    Private Sub lvRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        frmCheckin.TextBox_table_number.Text = lvRoom.SelectedItems(0).SubItems(1).Text
        frmCheckin.TextBox_Max_person.Text = lvRoom.SelectedItems(0).SubItems(2).Text
        Me.Close()
    End Sub

    Private Sub lvRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        my_bookings()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        display_room()
    End Sub
End Class