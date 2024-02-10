Imports System.Data.OleDb
Public Class frmRoom
    Dim id As Integer
    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectTab(0)
        Dim dt As New DataTable("TableNumber")
        rs = New OleDbDataAdapter("SELECT * FROM TableNumber ORDER BY TableID DESC", con)
        rs.Fill(dt)

        If dt.Rows.Count = 0 Then
            id = 1
        Else
            Dim value As Integer = Val(dt.Rows(0).Item("TableID"))
            value = value + 1
            id = value
        End If
        display_room()
    End Sub
    Private Sub display_room()
        con.Open()
        Dim Dt As New DataTable("TableNumber")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from TableNumber", con)

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

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        txtID.Clear()
        txtRoomType.Clear()

        bttnSave.Text = "&Add"
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        con.Open()

        rs.Dispose()
        Dim MaxPersons As String = txtRoomType.Text
        Dim Status, BookingID, TableNumber As String
        Status = "Available"
        BookingID = "2"
        TableNumber = txtID.Text
        If txtID.Text = "" Or txtRoomType.Text = "" Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            If bttnSave.Text = "&Add" Then

                Dim checkin As New OleDbCommand("INSERT INTO TableNumber(TableNum,MaxPersons,Status,BookingID) values ('" & TableNumber & "','" & MaxPersons & "','" & Status & "','" & BookingID & "')", con)
                checkin.ExecuteNonQuery()
                MsgBox("Table Saved!", vbInformation, "Note")
            Else

                Dim update_room As New OleDbCommand("UPDATE TableNumber SET TableNum= '" & TableNumber & "',MaxPersons = '" & MaxPersons & "',Status = 'Available',BookingID = '0' WHERE TableID = " & SafeSqlLiteral(id, 2) & "", con)
                update_room.ExecuteNonQuery()
                update_room.Dispose()
                MsgBox("Table Updated!", vbInformation, "Note")
                bttnSave.Text = "&Add"
            End If
        End If
        con.Close()
        display_room()
    End Sub

    Private Sub lvRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        Dim a As String = MsgBox("Update selected Item?", vbQuestion + vbYesNo, "Update Table")
        If a = vbYes Then
            id = lvRoom.SelectedItems(0).Text
            txtID.Text = lvRoom.SelectedItems(0).SubItems(1).Text
            txtRoomType.Text = lvRoom.SelectedItems(0).SubItems(2).Text



            TabControl1.SelectTab(0)
            bttnSave.Text = "&Update"
        End If
    End Sub

    Private Sub lvRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.SelectedIndexChanged

    End Sub

End Class