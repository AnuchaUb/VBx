Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmFindcus
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmFindcus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()
        strSql = "select cusid ,cusname +' '+cuslastname as ชื่อนามสกุล from tbcustomers"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "findcus")
        dgvShowcus.DataSource = myDS.Tables("findcus")

        dgvShowcus.Columns(0).Width = 80
        dgvShowcus.Columns(1).Width = 240

        dgvShowcus.Columns(0).HeaderText = "รหัสลูกค้า"
        dgvShowcus.Columns(1).HeaderText = "ชื่อ - นามสกุล"

        myCon.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim r As Integer = dgvShowcus.CurrentCell.RowIndex
        cusidfind = dgvShowcus.Item(0, r).Value
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvShowcus_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowcus.CellDoubleClick
        Call btnOk_Click(sender, e)
    End Sub
End Class