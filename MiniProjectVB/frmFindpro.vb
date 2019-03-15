
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmFindpro
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
    Private Sub conncbotypeData()
        connData()
        strSql = "select typename from tbtypeofproduct"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read()
                cboprotype.Items.Add(myDR.Item("typename"))
            End While
            cboprotype.SelectedIndex = 0
            myDR.Close()
        End If
        myCon.Close()
    End Sub
    Private Sub frmFindpro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()
        If cboprotype.Items.Count = 0 Then
            conncbotypeData()
        End If

        strSql = "select proid,brandname,promod,proprice,probtu,iif(proivt=1,'มี','ไม่มี') from tbproducts,tbcompany where tbproducts.companyid = tbcompany.companyid"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "findpro")
        dgvShowpro.DataSource = myDS.Tables("findpro")

        dgvShowpro.Columns(0).Width = 50
        dgvShowpro.Columns(1).Width = 80
        dgvShowpro.Columns(2).Width = 180
        dgvShowpro.Columns(3).Width = 50
        dgvShowpro.Columns(4).Width = 50
        dgvShowpro.Columns(5).Width = 50

        dgvShowpro.Columns(0).HeaderText = "รหัสสินค้า"
        dgvShowpro.Columns(1).HeaderText = "ยี่ห้อ"
        dgvShowpro.Columns(2).HeaderText = "Model"
        dgvShowpro.Columns(3).HeaderText = "ราคา"
        dgvShowpro.Columns(4).HeaderText = "ขนาด BTU"
        dgvShowpro.Columns(5).HeaderText = "ระบบ Inverter"

        myCon.Close()
    End Sub

    Private Sub cboprotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboprotype.SelectedIndexChanged
        connData()
        strSql = "select proid,brandname,promod,proprice,probtu,iif(proivt=1,'มี','ไม่มี') from tbproducts,tbcompany,tbtypeofproduct where tbproducts.companyid = tbcompany.companyid " & vbCrLf &
            "and tbproducts.typeproductid = tbtypeofproduct.typeproductid and typename= '" & cboprotype.SelectedItem & "'"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "findprot")
        dgvShowpro.DataSource = myDS.Tables("findprot")

        dgvShowpro.Columns(0).Width = 50
        dgvShowpro.Columns(1).Width = 80
        dgvShowpro.Columns(2).Width = 180
        dgvShowpro.Columns(3).Width = 50
        dgvShowpro.Columns(4).Width = 50
        dgvShowpro.Columns(5).Width = 50

        dgvShowpro.Columns(0).HeaderText = "รหัสสินค้า"
        dgvShowpro.Columns(1).HeaderText = "ยี่ห้อ"
        dgvShowpro.Columns(2).HeaderText = "Model"
        dgvShowpro.Columns(3).HeaderText = "ราคา"
        dgvShowpro.Columns(4).HeaderText = "ขนาด BTU"
        dgvShowpro.Columns(5).HeaderText = "ระบบ Inverter"

        myCon.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim r As Integer = dgvShowpro.CurrentCell.RowIndex
        proidfind = dgvShowpro.Item(0, r).Value
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvShowpro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowpro.CellDoubleClick
        Call btnOk_Click(sender, e)
    End Sub
End Class