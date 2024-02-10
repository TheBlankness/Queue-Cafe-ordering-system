Imports System.Data.OleDb
Public Class frmSelectGuest

    Private Sub frmSelectGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_guest()
    End Sub
    Private Sub display_guest()
        con.Open()
        Dim Dt As New DataTable("TableNumber")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from TableNumber WHERE Status = 'Available' ", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvGuest.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("TableID")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNum"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MaxPersons"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            lvGuest.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub lvGuest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvGuest.DoubleClick
        frmCheckin.lblGuestID.Text = lvGuest.SelectedItems(0).Text

        frmReserve.TextBox_table_number.Text = lvGuest.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class