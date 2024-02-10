Imports System.Data.OleDb
Public Class frmGuest

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        con.Open()
        Dim fname As String = Trim(txtFName.Text)
        Dim mname As String = Trim(txtMName.Text)
        Dim lname As String = Trim(txtLName.Text)

        If fname = Nothing Or mname = Nothing Or lname = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            Dim add_guest As New OleDbCommand("INSERT INTO tblMember(MemberName,IC,MemberType) values ('" &
                                              fname & "','" &
                                              lname & "','" &
                                              mname & "')", con)
            add_guest.ExecuteNonQuery()
            add_guest.Dispose()
            MsgBox("Member Added!", vbInformation, "Note")
            txtFName.Clear()
            txtLName.Clear()
        End If
        con.Close()
        display_guest()
    End Sub

    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_guest()
        TabControl1.SelectTab(0)
    End Sub

    Private Sub display_guest()
        con.Open()
        Dim Dt As New DataTable("tblMember")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblMember", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvGuest.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("MemberID")
            lv.SubItems.Add(Dt.Rows(indx).Item("MemberName"))
            lv.SubItems.Add(Dt.Rows(indx).Item("IC"))
            lv.SubItems.Add(Dt.Rows(indx).Item("MemberType"))
            lvGuest.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        txtFName.Clear()
        txtLName.Clear()

    End Sub
End Class