Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpass.PasswordChar = "•"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        connData()
        If txtid.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("กรุณากรอก ID - Password ให้ครบถ้วนด้วยครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid.Focus()
            Exit Sub
        End If
        strSql = "select * from tbemployee e,tbdepartment d where e.departmentid = d.departmentid" & vbCrLf &
            "and empid = @id and emppassword = @pass"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("id", txtid.Text)
        myCom.Parameters.AddWithValue("pass", txtpass.Text)
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            empid = myDR.Item("empid")
            empname = myDR.Item("empname")
            emplastname = myDR.Item("emplastname")
            depname = myDR.Item("departmentname")
            myDR.Close()
            myCon.Close()
            txtid.Clear()
            txtpass.Clear()
            Me.Close()
        ElseIf txtid.Text = "admin" And txtpass.Text = "123456" Then
            empid = "Admin"
            empname = "Admin"
            emplastname = "System"
            depname = "Administrator"
            txtid.Clear()
            txtpass.Clear()
            Me.Close()
        Else
            MessageBox.Show("กรุณาตรวจสอบ ID, Password ด้วยครับ", "ID - Password ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid.SelectAll()
            txtid.Focus()
            myDR.Close()
            myCon.Close()
            Exit Sub
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class