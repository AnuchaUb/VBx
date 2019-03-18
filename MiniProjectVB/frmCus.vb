Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCus
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim ocid As String
    Dim ocn As String
    Dim ocln As String
    Dim ocph As String
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()

        strSql = "select cusid,cusname,cuslastname,cusbirthday,iif(cussex=1,'ชาย','หญิง') as เพศ,cusaddress,cussubarea,cusarea,cusprovince,cuspostalcode,cusphone from tbcustomers"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loadcorp")
        dgvShowcus.DataSource = myDS.Tables("Loadcorp")

        dgvShowcus.Columns(0).Width = 50
        dgvShowcus.Columns(1).Width = 150
        dgvShowcus.Columns(2).Width = 150
        dgvShowcus.Columns(3).Width = 80
        dgvShowcus.Columns(4).Width = 50
        dgvShowcus.Columns(5).Width = 260
        dgvShowcus.Columns(6).Width = 80
        dgvShowcus.Columns(7).Width = 80
        dgvShowcus.Columns(8).Width = 50
        dgvShowcus.Columns(9).Width = 80
        dgvShowcus.Columns(10).Width = 80


        dgvShowcus.Columns(0).HeaderText = "รหัส"
        dgvShowcus.Columns(1).HeaderText = "ชื่อ"
        dgvShowcus.Columns(2).HeaderText = "นามสกุล"
        dgvShowcus.Columns(3).HeaderText = "วันเกิด"
        dgvShowcus.Columns(4).HeaderText = "เพศ"
        dgvShowcus.Columns(5).HeaderText = "ที่อยู่"
        dgvShowcus.Columns(6).HeaderText = "ตำบล/แขวง"
        dgvShowcus.Columns(7).HeaderText = "อำเภอ/เขต"
        dgvShowcus.Columns(8).HeaderText = "จังหวัด"
        dgvShowcus.Columns(9).HeaderText = "รหัสไปรษณีย์"
        dgvShowcus.Columns(10).HeaderText = "เบอร์โทรศัพท์"

        If dgvShowcus.RowCount = 0 Or dgvShowcus.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูลลูกค้าด้วยครับ", "ไม่มีข้อมูลลูกค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowcus.RowCount = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        Panel1.Enabled = True
        Panel2.Enabled = True
        Panel3.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        myCon.Close()
    End Sub
    Private Sub ctxt()
        txtCusid.Clear()
        txtCusname.Clear()
        txtCuslname.Clear()
        txtCusbirthday.Clear()
        txtCusaddress.Clear()
        txtCussubarea.Clear()
        txtCusarea.Clear()
        txtCusprovince.Clear()
        txtCuspostalcode.Clear()
        txtCusphone.Clear()
        radMale.Checked = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        strBtn = "insert"
        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        ctxt()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtCusid.Text = txtCusid.Text.Trim()
        ocid = txtCusid.Text
        ocn = txtCusname.Text
        ocln = txtCuslname.Text
        ocph = txtCusphone.Text
        strBtn = "edit"
        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูลของคุณ " & txtCusname.Text & " " & txtCuslname.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbcustomers where cusid = @cid"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("cid", txtCusid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ctxt()
            Call frmCus_Load(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtCusid.Text = txtCusid.Text.Trim()
        If txtCusid.Text = "" Or txtCusname.Text = "" Or txtCuslname.Text = "" Or txtCusbirthday.Text = "" Or txtCusaddress.Text = "" Or txtCussubarea.Text = "" Or txtCusarea.Text = "" Or txtCusprovince.Text = "" Or txtCuspostalcode.Text = "" Or txtCusphone.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCusid.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtCuspostalcode.Text) Or Not IsNumeric(txtCusphone.text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง!", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim gender As String
            If radMale.Checked Then
                gender = "1"
            Else
                gender = "0"
            End If
            connData()
            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select cusid from tbcustomers where cusid=@cid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCusid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสลูกค้าที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสลูกค้าใหม่!", "รหัสลูกค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCusid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต ชื่อ+นามสกุล
                myDR.Close()
                strSql = "select cusname,cuslastname from tbcustomers where cusname = @cn and cuslastname = @cln"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cn", txtCusname.Text)
                myCom.Parameters.AddWithValue("cln", txtCuslname.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อ-นามสกุลลูกค้าที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อ-นามสกุลลูกค้าใหม่!", "ชื่อ-นามสกุลลูกค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCusname.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต เบอร์โทรศัพท์
                myDR.Close()
                strSql = "select cusphone from tbcustomers where cusphone=@cph"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cph", txtCusphone.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มเบอร์โทรศัพท์ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCusphone.Focus()
                    myDR.Close()
                    Exit Sub
                End If

                'เพิ่มข้อมูล
                myDR.Close()
                strSql = "insert into tbcustomers(cusid,cusname,cuslastname,cusbirthday,cussex,cusaddress,cussubarea,cusarea,cusprovince,cuspostalcode,cusphone)" & vbCrLf &
                    "values(@cid,@cn,@cln,@cbd,@csex,@cadd,@csa,@ca,@cpv,@cpc,@cph)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCusid.Text)
                myCom.Parameters.AddWithValue("cn", txtCusname.Text)
                myCom.Parameters.AddWithValue("cln", txtCuslname.Text)
                myCom.Parameters.AddWithValue("cbd", txtCusbirthday.Text)
                myCom.Parameters.AddWithValue("csex", gender)
                myCom.Parameters.AddWithValue("cadd", txtCusaddress.Text)
                myCom.Parameters.AddWithValue("csa", txtCussubarea.Text)
                myCom.Parameters.AddWithValue("ca", txtCusarea.Text)
                myCom.Parameters.AddWithValue("cpv", txtCusprovince.Text)
                myCom.Parameters.AddWithValue("cpc", txtCuspostalcode.Text)
                myCom.Parameters.AddWithValue("cph", txtCusphone.Text)
                myCom.ExecuteNonQuery()
                Call frmCus_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'แก้ไข
                'การเช็ค PK
                If txtCusid.Text <> ocid Then
                    strSql = "select cusid from tbcustomers where cusid=@ocid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocid", txtCusid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสลูกค้าให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสลูกค้าด้วยครับ!!", "รหัสลูกค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCusid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค ชื่อ+นามสกุล
                If txtCusname.Text <> ocn And txtCuslname.Text <> ocln Then
                    strSql = "select cusname,cuslastname from tbcustomers where cusname = @cn and cuslastname = @cln"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocn", txtCusname.Text)
                    myCom.Parameters.AddWithValue("ocln", txtCuslname.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อ-นามสกุลลูกค้าให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อ-นามสกุลลูกค้าใหม่ด้วยครับ!!", "ชื่อ-นามสกุลลูกค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCusname.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค เบอร์โทรศัพท์
                If txtCusphone.Text <> ocph Then
                    strSql = "select cusphone from tbcustomers where cusphone =@oph"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oph", txtCusphone.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนเบอร์โทรศัพท์ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่ด้วยครับ!!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCusphone.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                myDR.Close()
                strSql = "update tbcustomers set cusid=@cid,cusname=@cn,cuslastname=@cln,cusbirthday=@cbd,cussex=@csex,cusaddress=@cadd,cussubarea=@csa,cusarea=@ca,cusprovince=@cpv,cuspostalcode=@cpc,cusphone=@cph where cusid=@ocid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCusid.Text)
                myCom.Parameters.AddWithValue("cn", txtCusname.Text)
                myCom.Parameters.AddWithValue("cln", txtCuslname.Text)
                myCom.Parameters.AddWithValue("cbd", txtCusbirthday.Text)
                myCom.Parameters.AddWithValue("csex", gender)
                myCom.Parameters.AddWithValue("cadd", txtCusaddress.Text)
                myCom.Parameters.AddWithValue("csa", txtCussubarea.Text)
                myCom.Parameters.AddWithValue("ca", txtCusarea.Text)
                myCom.Parameters.AddWithValue("cpv", txtCusprovince.Text)
                myCom.Parameters.AddWithValue("cpc", txtCuspostalcode.Text)
                myCom.Parameters.AddWithValue("cph", txtCusphone.Text)
                myCom.Parameters.AddWithValue("ocid", ocid)
                myCom.ExecuteNonQuery()
                Call frmCus_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลดังกล่าวถูกแก้ไขเรียบร้อยแล้ว", "การแก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel1.Enabled = True
        Panel2.Enabled = True
        Panel3.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        ctxt()
    End Sub

    Private Sub dgvShowcus_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowcus.CellEnter
        If dgvShowcus.RowCount = 0 Or dgvShowcus.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowcus.CurrentCell.RowIndex
        Dim tid As String = dgvShowcus.Item(0, r).Value
        connData()
        strSql = "select cusid,cusname,cuslastname,cusbirthday,iif(cussex=1,'ชาย','หญิง') as เพศ,cusaddress,cussubarea,cusarea,cusprovince,cuspostalcode,cusphone from tbcustomers"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        'myCom.Parameters.AddWithValue("cid", txtCusid.Text)
        myDR = myCom.ExecuteReader

        myDR.Read()
        txtCusid.Text = dgvShowcus.Item(0, r).Value
        txtCusname.Text = dgvShowcus.Item(1, r).Value
        txtCuslname.Text = dgvShowcus.Item(2, r).Value
        txtCusbirthday.Text = dgvShowcus.Item(3, r).Value

        If dgvShowcus.Item(4, r).Value = "ชาย" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        txtCusaddress.Text = dgvShowcus.Item(5, r).Value
        txtCussubarea.Text = dgvShowcus.Item(6, r).Value
        txtCusarea.Text = dgvShowcus.Item(7, r).Value
        txtCusprovince.Text = dgvShowcus.Item(8, r).Value
        txtCuspostalcode.Text = dgvShowcus.Item(9, r).Value
        txtCusphone.Text = dgvShowcus.Item(10, r).Value
        myDR.Close()
    End Sub

    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        connData()
        strSql = "select cusid,cusname,cuslastname,cusbirthday,iif(cussex=1,'ชาย','หญิง') as เพศ,cusaddress,cussubarea,cusarea,cusprovince,cuspostalcode,cusphone from tbcustomers where cusname like '" & txtScusname.Text & "' or cuslastname like '" & txtScuslname.Text & "'"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "search")
        dgvShowcus.DataSource = myDS.Tables("search")

        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        'myCom.Parameters.AddWithValue("@cn", txtScusname.Text)
        'myCom.Parameters.AddWithValue("@cln", txtScuslname.Text)
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            txtCusid.Text = myDR.Item("cusid")
            txtCusname.Text = myDR.Item("cusname")
            txtCuslname.Text = myDR.Item("cuslastname")
            txtCusbirthday.Text = myDR.Item("cusbirthday")
            If myDR.Item("เพศ") = "ชาย" Then
                radMale.Checked = True
            Else
                radFemale.Checked = True
            End If
            txtCusaddress.Text = myDR.Item("cusaddress")
            txtCussubarea.Text = myDR.Item("cussubarea")
            txtCusarea.Text = myDR.Item("cusarea")
            txtCusprovince.Text = myDR.Item("cusprovince")
            txtCuspostalcode.Text = myDR.Item("cuspostalcode")
            txtCusphone.Text = myDR.Item("cusphone")
            myDR.Close()
        Else
            MessageBox.Show("ไม่พบข้อมูลดังกล่าว" & vbCrLf & "กรุณากรอกข้อมูลที่จะค้นหาใหม่ครับ!", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        myDR.Close()
        myCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call frmCus_Load(sender, e)
        txtScusname.Clear()
        txtScuslname.Clear()
    End Sub

    Private Sub txtCusphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusphone.KeyPress, txtCuspostalcode.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCusbirthday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusbirthday.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Or keyInt = 47 Or keyInt = 45 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class