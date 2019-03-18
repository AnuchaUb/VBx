﻿Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReportStock
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsPrintSale

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Dim myRPT As New crpReportStock
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
        connData()
        strSql = "select * from tbproducts p,tbcompany cp,tbtypeofproduct tp,tbshop sp where p.companyid = cp.companyid and p.typeproductid = tp.typeproductid "
        If cboBrand.SelectedIndex > 0 Then
            strSql = strSql & " and cp.brandname = '" & cboBrand.SelectedItem & "' "
        End If
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Datatablex")

        myRPT.SetDataSource(myDS.Tables("Datatablex"))
        crvReportStock.ReportSource = myRPT
        crvReportStock.Show()
        myCon.Close()
    End Sub
    Private Sub frmReportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbodataBrandname()
        stockreport()
    End Sub

    Private Sub cboBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrand.SelectedIndexChanged
        stockreport()
    End Sub
End Class