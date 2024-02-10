Imports System.Data.OleDb
Public Class MemberListclick
    Private Sub MemberListclick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim Dt As New DataTable("tblMember")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblMember", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlcheckin.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem

            Dim value As Integer = Val(Dt.Rows(indx).Item("MemberID"))

            lv.Text = value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("MemberName"))
            lv.SubItems.Add(Dt.Rows(indx).Item("IC"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MemberType"))
            lvlcheckin.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub lvlcheckin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlcheckin.DoubleClick
        frmCheckout.txtRoomNumber.Text = lvlcheckin.SelectedItems(0).Text
        Dim discounttype As String = lvlcheckin.SelectedItems(0).SubItems(3).Text
        If discounttype = "Casual" Then
            frmCheckout.txtDiscountType.Text = "10%"
        ElseIf discounttype = "VIP" Then
            frmCheckout.txtDiscountType.Text = "20%"
        End If
        Me.Close()

    End Sub

End Class