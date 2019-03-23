Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReport
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsPrintSale

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub cbodataBrandname()
        connData()
        strSql = "select * from tbcompany"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            cboBrand.Items.Add("ทั้งหมด")
            While myDR.Read()
                cboBrand.Items.Add(myDR.Item("brandname"))
            End While
            cboBrand.SelectedIndex = 0
        Else
            MessageBox.Show("ไม่พบยี่ห้อสินค้า", "ไม่พบยี่ห้อสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        myDR.Close()
        myCon.Close()
    End Sub
    Private Sub stockreport()
        Dim myRPT As New crpReportStock
        connData()
        strSql = "select * from tbproducts p,tbcompany cp,tbtypeofproduct tp,tbshop sp where p.companyid = cp.companyid and p.typeproductid = tp.typeproductid "
        If cboBrand.SelectedIndex > 0 Then
            strSql = strSql & " and cp.brandname = '" & cboBrand.SelectedItem & "' "
        End If
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Datatablex")

        myRPT.SetDataSource(myDS.Tables("Datatablex"))
        crvReport.ReportSource = myRPT
        crvReport.Show()
        myCon.Close()
    End Sub
    Private Sub salereport()
        Dim myRPT As New crpReportSale
        connData()
        strSql = "select * from tbsale s,tbsaledetail sd,tbproducts p,tbtypeofproduct tp,tbcompany cp,tbcustomers c,tbemployee e,tbshop sp where s.saleid = sd.saleid " & vbCrLf &
            "and s.empid = e.empid and s.cusid = c.cusid and sd.proid = p.proid and p.typeproductid = tp.typeproductid and p.companyid = cp.companyid"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Datatablex")

        myRPT.SetDataSource(myDS.Tables("Datatablex"))
        crvReport.ReportSource = myRPT
        crvReport.Show()
        myCon.Close()
    End Sub
    Private Sub frmReportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBrand.Visible = False
    End Sub

    Private Sub cboBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrand.SelectedIndexChanged
        stockreport()
    End Sub

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        If cboReport.SelectedItem = "รายงานยอดขาย" Then
            salereport()
            cboBrand.Visible = False
        Else
            cboBrand.Visible = True
            cbodataBrandname()
            stockreport()
        End If
    End Sub
End Class