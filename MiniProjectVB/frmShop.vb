Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmShop
    Dim myCon As New SqlConnection

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Dim strsql As String
    Dim strbtn As String
    Dim osn As String
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtShopname.Enabled = False
        txtShopaddress.Enabled = False
        btnOk.Enabled = False
        btnCancel.Enabled = False

        connData()
        strsql = "select * from tbshop"
        myCom = New SqlCommand(strsql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            txtShopname.Text = myDR.Item("shopname")
            txtShopaddress.Text = myDR.Item("shopaddress")
            btnEdit.Enabled = True
        Else
            MessageBox.Show("ไม่มีข้อมูลร้าน" & vbCrLf & "กรุณากรอกข้อมูลร้านด้วยครับ", "ไม่มีข้อมูลร้าน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtShopname.Clear()
            txtShopaddress.Clear()
            txtShopname.Focus()
            strbtn = "insert"
            btnOk.Enabled = True
            txtShopname.Enabled = True
            txtShopaddress.Enabled = True
            btnEdit.Enabled = False
        End If


        myDR.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnOk.Enabled = True
        btnCancel.Enabled = True
        txtShopname.Enabled = True
        txtShopaddress.Enabled = True
        osn = txtShopname.Text
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        connData()
        If txtShopname.Text = "" Or txtShopaddress.Text = "" Then
            MessageBox.Show("กรอกข้อมูลไม่ครบถ้วน", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtShopname.Focus()
            Exit Sub
        Else
            If strbtn = "insert" Then
                strsql = "insert into tbshop(shopname,shopaddress) values(@sn,@sadd)"
                myCom = New SqlCommand(strsql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("sn", txtShopname.Text)
                myCom.Parameters.AddWithValue("sadd", txtShopaddress.Text)
                myCom.ExecuteNonQuery()

                MessageBox.Show("เพิ่มข้อมูลร้านเรียบร้อยแล้วครับ", "เพิ่มข้อมูลร้านสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                btnOk.Enabled = False
                Call frmShop_Load(sender, e)
            Else
                strsql = "update tbshop set shopname=@sn,shopaddress=@sadd where shopname = @osn"
                myCom = New SqlCommand(strsql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("sn", txtShopname.Text)
                myCom.Parameters.AddWithValue("sadd", txtShopaddress.Text)
                myCom.Parameters.AddWithValue("osn", osn)
                myCom.ExecuteNonQuery()

                MessageBox.Show("แก้ไขข้อมูลร้านเรียบร้อยแล้วครับ", "แก้ไขข้อมูลร้านสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                btnOk.Enabled = False
                Call frmShop_Load(sender, e)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnOk.Enabled = False
        btnCancel.Enabled = False
        Call frmShop_Load(sender, e)
    End Sub
End Class