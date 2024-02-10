Imports System.Data.OleDb
Public Class frmCheckinList

    Private Sub frmCheckinList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim Dt As New DataTable("tblOrderTable")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblOrderTable WHERE Status = 'Pending'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlcheckin.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem

            Dim value As Integer = Val(Dt.Rows(indx).Item("OrderID"))

            lv.Text = value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("TableNumber"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Food1"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Food2"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Food3"))
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

    Private Sub lvlcheckin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlcheckin.DoubleClick
        frmCheckout.txtTransID.Text = lvlcheckin.SelectedItems(0).Text
        frmCheckout.txtGuestName.Text = lvlcheckin.SelectedItems(0).SubItems(1).Text
        Dim totalprice As Decimal
        totalprice += lvlcheckin.SelectedItems(0).SubItems(2).Text * 12
        totalprice += lvlcheckin.SelectedItems(0).SubItems(3).Text * 10
        totalprice += lvlcheckin.SelectedItems(0).SubItems(4).Text * 15
        totalprice += lvlcheckin.SelectedItems(0).SubItems(5).Text * 18
        totalprice += lvlcheckin.SelectedItems(0).SubItems(6).Text * 12
        totalprice += lvlcheckin.SelectedItems(0).SubItems(7).Text * 13
        totalprice += lvlcheckin.SelectedItems(0).SubItems(9).Text * 10
        totalprice += lvlcheckin.SelectedItems(0).SubItems(8).Text * 10
        frmCheckout.txtSubTotal.Text = totalprice & ".00"
        Me.Close()
    End Sub
End Class