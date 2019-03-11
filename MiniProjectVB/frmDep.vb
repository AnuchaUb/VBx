Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDep
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim olddepid As String
    Dim olddepname As String

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()

        strSql = "select * from tbdepartment"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loaddep")
        dgvShowdep.DataSource = myDS.Tables("Loaddep")

        dgvShowdep.Columns(0).Width = 200
        dgvShowdep.Columns(1).Width = 225

        dgvShowdep.Columns(0).HeaderText = "รหัสแผนก"
        dgvShowdep.Columns(1).HeaderText = "ชื่อแผนก"

        Panel2.Enabled = True
        txtDepid.Enabled = False
        txtDepname.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        If dgvShowdep.RowCount = 0 Or dgvShowdep.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มแผนกด้วยครับ", "ไม่มีข้อมูลแผนก", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowdep.rowcount = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
        myCon.Close()
    End Sub

    Private Sub dgvShowdep_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowdep.CellEnter
        If dgvShowdep.RowCount = 0 Or dgvShowdep.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowdep.CurrentCell.RowIndex
        Dim did As String = dgvShowdep.Item(0, r).Value

        txtDepid.Text = dgvShowdep.Item(0, r).Value
        txtDepname.Text = dgvShowdep.Item(1, r).Value

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Enabled = False
        Panel2.Enabled = False
        txtDepid.Enabled = True
        txtDepname.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        txtDepid.Focus()
        txtDepid.Clear()
        txtDepname.Clear()
        strBtn = "insert"
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtDepid.Text = txtDepid.Text.Trim()
        olddepid = txtDepid.Text
        olddepname = txtDepname.Text
        Panel1.Enabled = False
        Panel2.Enabled = False
        txtDepid.Enabled = True
        txtDepname.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        txtDepid.Focus()
        strBtn = "edit"
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูล " & txtDepname.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbdepartment where departmentid = @did"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("did", txtDepid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtDepid.Clear()
            txtDepname.Clear()
            Call frmDep_Load(sender, e)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtDepid.Text = txtDepid.Text.Trim()
        txtDepname.Text = txtDepname.Text.Trim()
        If txtDepid.Text = "" Or txtDepname.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepid.Focus()
            Exit Sub
        Else
            connData()
            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select departmentid from tbdepartment where departmentid=@did"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("did", txtDepid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสแผนกที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสแผนกใหม่!", "รหัสแผนกซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDepid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ค ชื่อ
                myDR.Close()
                strSql = "select departmentname from tbdepartment where departmentname=@dn"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("dn", txtDepname.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อแผนกที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อแผนกใหม่!", "ชื่อแผนกซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDepname.Focus()
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "insert into tbdepartment(departmentid,departmentname) values(@did,@dn)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("did", txtDepid.Text)
                myCom.Parameters.AddWithValue("dn", txtDepname.Text)
                myCom.ExecuteNonQuery()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'การเช็ค PK
                If txtDepid.Text <> olddepid Then
                    strSql = "select departmentid from tbdepartment where departmentid=@olddepid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("olddepid", txtDepid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสแผนกให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสแผนกใหม่ด้วยครับ!!", "รหัสแผนกซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtDepid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                ' การเช็ค ชื่อ
                If txtDepname.Text <> olddepname Then
                    strSql = "select departmentname from tbdepartment where departmentname=@olddepname"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("olddepname", txtDepname.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อแผนกให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อแผนกใหม่ด้วยครับ!!", "ชื่อแผนกซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtDepname.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If


                strSql = "update tbdepartment set departmentid=@did,departmentname=@dn where departmentid=@olddepid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("did", txtDepid.Text)
                myCom.Parameters.AddWithValue("dn", txtDepname.Text)
                myCom.Parameters.AddWithValue("olddepid", olddepid)
                myCom.ExecuteNonQuery()
                MessageBox.Show("ข้อมูลดังกล่าวถูกแก้ไขเรียบร้อยแล้ว", "การแก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
        End If
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        Call btnCancel_Click(sender, e)
        Call frmDep_Load(sender, e)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel1.Enabled = True
        Panel2.Enabled = True
        txtDepid.Enabled = False
        txtDepname.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False

        Call frmDep_Load(sender, e)
    End Sub

    Private Sub txtDepid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDepname.Focus()
        End If
    End Sub

    Private Sub txtDepname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnSave_Click(sender, e)
        End If
    End Sub
End Class
