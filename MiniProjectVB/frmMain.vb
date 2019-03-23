Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMain
    Dim myCon As New SqlConnection

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Dim osn As String
    Dim oadd As String
    Dim strbtn As String
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmLogin.ShowDialog()
        If empid = "" Then
            Me.Close()
        Else
            lblid.Text = empid
            lblfullname.Text = empname & " " & emplastname
            lbldate.Text = Format(Date.Now, "dd/MM/yyyy hh:mm")
            lbldepname.Text = depname

            txtadd.Enabled = False
            txtname.Enabled = False
            btnupdate.Visible = False

            connData()
            strSql = "select * from tbshop"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myDR = myCom.ExecuteReader
            If myDR.HasRows Then
                myDR.Read()
                txtname.Text = myDR.Item("shopname")
                txtadd.Text = myDR.Item("shopaddress")
            End If
            myDR.Close()
        End If
        If depname = "ผู้จัดการ" Or depname = "บุคคล" Then

            btnSell.Enabled = False
            btnCorp.Enabled = True
            btnProtype.Enabled = False
            btnPros.Enabled = False
            btnEditshop.Enabled = True
            btnEmp.Enabled = True
            btnDep.Enabled = True
            btnCus.Enabled = True
            btnList.Enabled = True
            btnReport.Enabled = True


        ElseIf depname = "การบัญชี" Then

            btnSell.Enabled = False
            btnCorp.Enabled = False
            btnProtype.Enabled = False
            btnPros.Enabled = False
            btnEditshop.Enabled = False
            btnEmp.Enabled = False
            btnDep.Enabled = False
            btnCus.Enabled = False
            btnList.Enabled = True
            btnReport.Enabled = True

        ElseIf depname = "Administrator" Then

            btnSell.Enabled = True
            btnCorp.Enabled = True
            btnProtype.Enabled = True
            btnPros.Enabled = True
            btnEditshop.Enabled = True
            btnEmp.Enabled = True
            btnDep.Enabled = True
            btnCus.Enabled = True
            btnList.Enabled = True
            btnReport.Enabled = True

        Else
            btnSell.Enabled = True
            btnCorp.Enabled = True
            btnProtype.Enabled = True
            btnPros.Enabled = True
            btnEditshop.Enabled = False
            btnEmp.Enabled = False
            btnDep.Enabled = False
            btnCus.Enabled = True
            btnList.Enabled = True
            btnReport.Enabled = True
        End If

    End Sub

    Private Sub btnProtype_Click(sender As Object, e As EventArgs) Handles btnProtype.Click
        frmProtype.Show()
    End Sub

    Private Sub btnPros_Click(sender As Object, e As EventArgs) Handles btnPros.Click
        frmPros.Show()
    End Sub

    Private Sub btnCorp_Click(sender As Object, e As EventArgs) Handles btnCorp.Click
        frmCorp.Show()
    End Sub

    Private Sub btnDep_Click(sender As Object, e As EventArgs) Handles btnDep.Click
        frmDep.Show()
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        frmEmp.Show()
    End Sub

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        frmCus.Show()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSale.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call frmMain_Load(sender, e)

    End Sub

    Private Sub btnEditshop_Click(sender As Object, e As EventArgs) Handles btnEditshop.Click
        txtname.Enabled = True
        txtadd.Enabled = True
        btnupdate.Visible = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        connData()
        btnupdate.Visible = False
        strSql = "update tbshop set shopname=@sn,shopaddress=@sa"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("sn", txtname.Text)
        myCom.Parameters.AddWithValue("sa", txtadd.Text)
        myCom.ExecuteNonQuery()

        MessageBox.Show("เปลี่ยนข้อมูลร้านเรียบร้อยแล้ว", "การแก้ไขข้อมูลร้านสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        myCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnList.Click
        frmSaledetail.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReport.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class