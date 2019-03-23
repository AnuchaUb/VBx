Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSaledetail
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsPrintSale

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Dim myRPT As New crpSale
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub cbodatasale()
        connData()
        strSql = "select * from tbsale"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read()
                cbosale.Items.Add(myDR.Item("saleid"))
            End While
            cbosale.SelectedIndex = 0
        Else
            MessageBox.Show("ไม่พบรายการขายสินค้า", "ไม่พบรายการขายสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        myDR.Close()
        myCon.Close()
    End Sub
    Private Sub salereport()
        connData()
        strSql = "select * from tbsale s,tbsaledetail sd,tbproducts p,tbtypeofproduct tp,tbcompany cp,tbcustomers c,tbemployee e,tbshop sp where s.saleid = sd.saleid and s.saleid = '" & cbosale.SelectedItem & "'" & vbCrLf &
            "and s.empid = e.empid and s.cusid = c.cusid and sd.proid = p.proid and p.typeproductid = tp.typeproductid and p.companyid = cp.companyid"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Datatablex")

        myRPT.SetDataSource(myDS.Tables("Datatablex"))
        crvSaledetail.ReportSource = myRPT
        crvSaledetail.Show()
        myCon.Close()
    End Sub
    Private Sub frmSaledetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbodatasale()
        salereport()
        cbosale.DropDownHeight = cbosale.ItemHeight * 10

    End Sub

    Private Sub cbosale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosale.SelectedIndexChanged
        salereport()
    End Sub
End Class