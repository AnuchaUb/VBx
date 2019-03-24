Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmProtype
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim typeid As String
    Dim typename As String
    Dim oldtypeid As String
    Dim oldtypename As String

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmProtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()

        strSql = "select * from tbtypeofproduct"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loadtype")
        dgvShowprotype.DataSource = myDS.Tables("Loadtype")

        dgvShowprotype.Columns(0).Width = 200
        dgvShowprotype.Columns(1).Width = 225

        dgvShowprotype.Columns(0).HeaderText = "รหัสประเภทสินค้า"
        dgvShowprotype.Columns(1).HeaderText = "ชื่อประเภทสินค้า"

        Panel2.Enabled = True
        txtProtypeid.Enabled = False
        txtProtypename.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        If dgvShowprotype.RowCount = 0 Or dgvShowprotype.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มประเภทสินค้าด้วยครับ", "ไม่มีข้อมูลประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowprotype.Rowcount = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
        myCon.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Enabled = False
        Panel2.Enabled = False
        txtProtypeid.Enabled = True
        txtProtypename.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        txtProtypeid.Focus()
        txtProtypeid.Clear()
        txtProtypename.Clear()
        strBtn = "insert"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtProtypeid.Text = txtProtypeid.Text.Trim()
        txtProtypename.Text = txtProtypename.Text.Trim()
        If txtProtypeid.Text = "" Or txtProtypename.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProtypeid.Focus()
            Exit Sub
        Else
            connData()
            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select typeproductid from tbtypeofproduct where typeproductid=@tid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("tid", txtProtypeid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสประเภทที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสประเภทใหม่!", "รหัสประเภทซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtProtypeid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ค ชื่อ
                myDR.Close()
                strSql = "select typename from tbtypeofproduct where typename=@tn"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("tn", txtProtypename.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อประเภทที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อประเภทใหม่!", "ชื่อประเภทซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtProtypename.Focus()
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "insert into tbtypeofproduct(typeproductid,typename) values(@tid,@tn)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("tid", txtProtypeid.Text)
                myCom.Parameters.AddWithValue("tn", txtProtypename.Text)
                myCom.ExecuteNonQuery()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'การเช็ค PK
                If txtProtypeid.Text <> oldtypeid Then
                    strSql = "select typeproductid from tbtypeofproduct where typeproductid=@oldtypeid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oldtypeid", txtProtypeid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสประเภทให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสประเภทใหม่ด้วยครับ!!", "รหัสประเภทซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtProtypeid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                End If
                ' การเช็ค ชื่อ
                If txtProtypename.Text <> oldtypename Then
                    strSql = "select typename from tbtypeofproduct where typename=@oldtypename"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oldtypename", txtProtypename.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อประเภทให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อประเภทใหม่ด้วยครับ!!", "ชื่อประเภทซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtProtypename.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                strSql = "update tbtypeofproduct set typeproductid=@tid,typename=@tn where typeproductid=@oldtypeid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("tid", txtProtypeid.Text)
                myCom.Parameters.AddWithValue("tn", txtProtypename.Text)
                myCom.Parameters.AddWithValue("oldtypeid", oldtypeid)
                myCom.ExecuteNonQuery()
                MessageBox.Show("ข้อมูลดังกล่าวถูกแก้ไขเรียบร้อยแล้ว", "การแก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        Call btnCancel_Click(sender, e)
        Call frmProtype_Load(sender, e)
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel1.Enabled = True
        Panel2.Enabled = True
        txtProtypeid.Enabled = False
        txtProtypename.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False

        Call frmProtype_Load(sender, e)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูล " & txtProtypename.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbtypeofproduct where typeproductid = @tid"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("tid", txtProtypeid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtProtypeid.Clear()
            txtProtypename.Clear()
            Call frmProtype_Load(sender, e)
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        oldtypeid = txtProtypeid.Text
        oldtypename = txtProtypename.Text
        Panel1.Enabled = False
        Panel2.Enabled = False
        txtProtypeid.Enabled = True
        txtProtypename.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        txtProtypeid.Focus()
        strBtn = "edit"
    End Sub
    Private Sub dgvShowprotype_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowprotype.CellEnter
        If dgvShowprotype.RowCount = 0 Or dgvShowprotype.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowprotype.CurrentCell.RowIndex
        Dim tid As String = dgvShowprotype.Item(0, r).Value

        txtProtypeid.Text = dgvShowprotype.Item(0, r).Value
        txtProtypename.Text = dgvShowprotype.Item(1, r).Value
    End Sub
    Private Sub txtProtypeid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProtypeid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProtypename.Focus()
        End If
    End Sub

    Private Sub txtProtypename_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProtypename.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnSave_Click(sender, e)
        End If
    End Sub
End Class