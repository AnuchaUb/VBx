Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmEmp
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim oeid As String
    Dim oen As String
    Dim oeln As String
    Dim oeidc As String
    Dim oeph As String
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub conncboDep()
        connData()
        strSql = "select departmentname from tbdepartment"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read()
                cboDep.Items.Add(myDR.Item("departmentname"))
                cboEmpdep.Items.Add(myDR.Item("departmentname"))
            End While
            cboDep.SelectedIndex = 0
            cboEmpdep.SelectedIndex = 0
            myDR.Close()
        End If
        myCon.Close()
    End Sub
    Private Sub frmEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()
        If cboDep.Items.Count = 0 Or cboEmpdep.Items.Count = 0 Then
            conncboDep()
        End If
        strSql = "select empid,empname,emplastname,iif(empsex=1,'ชาย','หญิง') as sex,empidcard,empaddress,empsubarea,emparea,empprovince,emppostalcode," & vbCrLf &
            "empphone,tbdepartment.departmentname,emphiredate,empsalary from tbemployee,tbdepartment where tbemployee.departmentid = tbdepartment.departmentid"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loadcorp")
        dgvShowemp.DataSource = myDS.Tables("Loadcorp")

        dgvShowemp.Columns(0).Width = 50
        dgvShowemp.Columns(1).Width = 90
        dgvShowemp.Columns(2).Width = 90
        dgvShowemp.Columns(3).Width = 50
        dgvShowemp.Columns(4).Width = 100
        dgvShowemp.Columns(5).Width = 250
        dgvShowemp.Columns(6).Width = 80
        dgvShowemp.Columns(7).Width = 80
        dgvShowemp.Columns(8).Width = 80
        dgvShowemp.Columns(9).Width = 80
        dgvShowemp.Columns(10).Width = 80
        dgvShowemp.Columns(11).Width = 80
        dgvShowemp.Columns(12).Width = 80
        dgvShowemp.Columns(13).Width = 85


        dgvShowemp.Columns(0).HeaderText = "รหัส"
        dgvShowemp.Columns(1).HeaderText = "ชื่อ"
        dgvShowemp.Columns(2).HeaderText = "นามสกุล"
        dgvShowemp.Columns(3).HeaderText = "เพศ"
        dgvShowemp.Columns(4).HeaderText = "รหัสประจำตัวประชาชน"
        dgvShowemp.Columns(5).HeaderText = "ที่อยู่"
        dgvShowemp.Columns(6).HeaderText = "ตำบล/แขวง"
        dgvShowemp.Columns(7).HeaderText = "อำเภอ/เขต"
        dgvShowemp.Columns(8).HeaderText = "จังหวัด"
        dgvShowemp.Columns(9).HeaderText = "รหัสไปรษณีย์"
        dgvShowemp.Columns(10).HeaderText = "เบอร์โทรศัพท์"
        dgvShowemp.Columns(11).HeaderText = "แผนก"
        dgvShowemp.Columns(12).HeaderText = "วันที่เข้าทำงาน"
        dgvShowemp.Columns(13).HeaderText = "เงินเดือน"

        If dgvShowemp.RowCount = 0 Or dgvShowemp.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูลลูกค้าด้วยครับ", "ไม่มีข้อมูลลูกค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowemp.RowCount = 0 Then
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
        txtEmpid.Clear()
        txtEmppass.Clear()
        txtEmpname.Clear()
        txtEmplname.Clear()
        txtEmpbirthday.Clear()
        txtEmpidcard.Clear()
        txtEmpaddress.Clear()
        txtEmpsubarea.Clear()
        txtEmparea.Clear()
        txtEmpprovince.Clear()
        txtEmppostalcode.Clear()
        txtEmpphone.Clear()
        cboEmpdep.SelectedIndex = 0
        txtEmphiredate.Clear()
        txtEmpsalary.Clear()
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
        txtEmpid.Text = txtEmpid.Text.Trim()
        oeid = txtEmpid.Text
        oen = txtEmpname.Text
        oeln = txtEmplname.Text
        oeidc = txtEmpidcard.Text
        oeph = txtEmpphone.Text
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
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูลของคุณ " & txtEmpname.Text & " " & txtEmplname.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbemployee where empid = @eid"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("eid", txtEmpid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ctxt()
            Call frmEmp_Load(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtEmpid.Text = txtEmpid.Text.Trim()
        If txtEmpid.Text = "" Or txtEmppass.Text = "" Or txtEmpname.Text = "" Or txtEmplname.Text = "" Or txtEmpbirthday.Text = "" Or txtEmpidcard.Text = "" Or txtEmpaddress.Text = "" Or txtEmpsubarea.Text = "" Or txtEmparea.Text = "" Or txtEmpprovince.Text = "" Or txtEmppostalcode.Text = "" Or txtEmpphone.Text = "" Or cboDep.Text = "" Or txtEmphiredate.Text = "" Or txtEmpsalary.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmpid.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtemppostalcode.Text) Or Not IsNumeric(txtempphone.text) Or Not IsNumeric(txtEmpidcard.text) Or Not IsNumeric(txtEmpsalary.text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง!", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim gender As String
            Dim dep As String
            If radMale.Checked Then
                gender = "1"
            Else
                gender = "0"
            End If
            connData()
            strSql = "select departmentid from tbdepartment where departmentname=@dn"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("dn", cboEmpdep.SelectedItem)
            myDR = myCom.ExecuteReader
            myDR.Read()
            dep = myDR.Item("departmentid")
            myDR.Close()

            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select empid from tbemployee where empid=@eid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("eid", txtEmpid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสพนักงานที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสพนักงานใหม่!", "รหัสพนักงานซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmpid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต ชื่อ+นามสกุล
                myDR.Close()
                strSql = "select empname,emplastname from tbemployee where empname = @en and emplastname = @eln"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("en", txtEmpname.Text)
                myCom.Parameters.AddWithValue("eln", txtEmplname.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อ-นามสกุลพนักงานที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อ-นามสกุลพนักงานใหม่!", "ชื่อ-นามสกุลพนักงานซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmpname.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ครหัสปชช.
                myDR.Close()
                strSql = "select empidcard from tbemployee where empidcard=@eidc"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("eidc", txtEmpidcard.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสประจำตัวประชาชนที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสประจำตัวประชาชนใหม่!", "รหัสประจำตัวประชาชนซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmpidcard.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต เบอร์โทรศัพท์
                myDR.Close()
                strSql = "select empphone from tbemployee where empphone=@eph"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("eph", txtEmpphone.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มเบอร์โทรศัพท์ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmpphone.Focus()
                    myDR.Close()
                    Exit Sub
                End If

                'เพิ่มข้อมูล
                myDR.Close()
                strSql = "insert into tbemployee(empid,empname,emplastname,empbirthday,empsex,empidcard,empaddress,empsubarea,emparea,empprovince,emppostalcode,empphone,departmentid,emphiredate,empsalary,emppassword)" & vbCrLf &
                    "values(@eid,@en,@eln,@ebd,@esex,@eidc,@eadd,@esa,@ea,@epv,@epc,@eph,@edepid,@ehd,@esl,@epass)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("eid", txtEmpid.Text)
                myCom.Parameters.AddWithValue("en", txtEmpname.Text)
                myCom.Parameters.AddWithValue("eln", txtEmplname.Text)
                myCom.Parameters.AddWithValue("ebd", txtEmpbirthday.Text)
                myCom.Parameters.AddWithValue("esex", gender)
                myCom.Parameters.AddWithValue("eidc", txtEmpidcard.Text)
                myCom.Parameters.AddWithValue("eadd", txtEmpaddress.Text)
                myCom.Parameters.AddWithValue("esa", txtEmpsubarea.Text)
                myCom.Parameters.AddWithValue("ea", txtEmparea.Text)
                myCom.Parameters.AddWithValue("epv", txtEmpprovince.Text)
                myCom.Parameters.AddWithValue("epc", txtEmppostalcode.Text)
                myCom.Parameters.AddWithValue("eph", txtEmpphone.Text)
                myCom.Parameters.AddWithValue("edepid", dep)
                myCom.Parameters.AddWithValue("ehd", txtEmphiredate.Text)
                myCom.Parameters.AddWithValue("esl", txtEmpsalary.Text)
                myCom.Parameters.AddWithValue("epass", txtEmppass.Text)
                myCom.ExecuteNonQuery()
                Call frmEmp_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'แก้ไข
                'การเช็ค PK
                If txtEmpid.Text <> oeid Then
                    strSql = "select empid from tbemployee where empid=@oeid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oeid", txtEmpid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสพนักงานให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสพนักงานด้วยครับ!!", "รหัสพนักงานซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtEmpid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค ชื่อ+นามสกุล
                If txtEmpname.Text <> oen And txtEmplname.Text <> oeln Then
                    strSql = "select empname,emplastname from tbemployee where empname = @en and emplastname = @eln"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oen", txtEmpname.Text)
                    myCom.Parameters.AddWithValue("oeln", txtEmplname.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อ-นามสกุลพนักงานให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อ-นามสกุลพนักงานใหม่ด้วยครับ!!", "ชื่อ-นามสกุลพนักงานซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtEmpname.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค รหัสปชช.
                If txtEmpidcard.Text <> oeidc Then
                    strSql = "select empidcard from tbemployee where empidcard = @oeidc"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oeidc", txtEmpidcard.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสประจำตัวประชาชนให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสประจำตัวประชาชนใหม่ด้วยครับ!!", "รหัสประจำตัวประชาชนซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtEmpname.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค เบอร์โทรศัพท์
                If txtEmpphone.Text <> oeph Then
                    strSql = "select empphone from tbemployee where empphone =@oeph"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("oeph", txtEmpphone.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนเบอร์โทรศัพท์ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่ด้วยครับ!!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtEmpphone.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                myDR.Close()
                strSql = "update tbemployee set empid=@eid,empname=@en,emplastname=@eln,empbirthday=@ebd,empsex=@esex,empidcard=@eidc,empaddress=@eadd,empsubarea=@esa,emparea=@ea,empprovince=@epv,emppostalcode=@epc,empphone=@eph,departmentid=@edepid,emphiredate=@ehd,empsalary=@esl,emppassword=@epass where empid=@oeid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("eid", txtEmpid.Text)
                myCom.Parameters.AddWithValue("en", txtEmpname.Text)
                myCom.Parameters.AddWithValue("eln", txtEmplname.Text)
                myCom.Parameters.AddWithValue("ebd", txtEmpbirthday.Text)
                myCom.Parameters.AddWithValue("esex", gender)
                myCom.Parameters.AddWithValue("eidc", txtEmpidcard.Text)
                myCom.Parameters.AddWithValue("eadd", txtEmpaddress.Text)
                myCom.Parameters.AddWithValue("esa", txtEmpsubarea.Text)
                myCom.Parameters.AddWithValue("ea", txtEmparea.Text)
                myCom.Parameters.AddWithValue("epv", txtEmpprovince.Text)
                myCom.Parameters.AddWithValue("epc", txtEmppostalcode.Text)
                myCom.Parameters.AddWithValue("eph", txtEmpphone.Text)
                myCom.Parameters.AddWithValue("edepid", dep)
                myCom.Parameters.AddWithValue("ehd", txtEmphiredate.Text)
                myCom.Parameters.AddWithValue("esl", txtEmpsalary.Text)
                myCom.Parameters.AddWithValue("epass", txtEmppass.Text)
                myCom.Parameters.AddWithValue("oeid", oeid)
                myCom.ExecuteNonQuery()
                Call frmEmp_Load(sender, e)
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

    Private Sub cboDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDep.SelectedIndexChanged
        connData()
        strSql = "select empid,empname,emplastname,iif(empsex=1,'ชาย','หญิง') as sex,empidcard,empaddress,empsubarea,emparea,empprovince,emppostalcode," & vbCrLf &
            "empphone,tbdepartment.departmentname,emphiredate,empsalary from tbemployee,tbdepartment where tbemployee.departmentid = tbdepartment.departmentid and " & vbCrLf &
            "departmentname = '" & cboDep.SelectedItem & "'"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "cboselect")
        dgvShowemp.DataSource = myDS.Tables("cboselect")

        dgvShowemp.Columns(0).Width = 50
        dgvShowemp.Columns(1).Width = 90
        dgvShowemp.Columns(2).Width = 90
        dgvShowemp.Columns(3).Width = 50
        dgvShowemp.Columns(4).Width = 100
        dgvShowemp.Columns(5).Width = 250
        dgvShowemp.Columns(6).Width = 80
        dgvShowemp.Columns(7).Width = 80
        dgvShowemp.Columns(8).Width = 80
        dgvShowemp.Columns(9).Width = 80
        dgvShowemp.Columns(10).Width = 80
        dgvShowemp.Columns(11).Width = 80
        dgvShowemp.Columns(12).Width = 80
        dgvShowemp.Columns(13).Width = 85


        dgvShowemp.Columns(0).HeaderText = "รหัส"
        dgvShowemp.Columns(1).HeaderText = "ชื่อ"
        dgvShowemp.Columns(2).HeaderText = "นามสกุล"
        dgvShowemp.Columns(3).HeaderText = "เพศ"
        dgvShowemp.Columns(4).HeaderText = "รหัสประจำตัวประชาชน"
        dgvShowemp.Columns(5).HeaderText = "ที่อยู่"
        dgvShowemp.Columns(6).HeaderText = "ตำบล/แขวง"
        dgvShowemp.Columns(7).HeaderText = "อำเภอ/เขต"
        dgvShowemp.Columns(8).HeaderText = "จังหวัด"
        dgvShowemp.Columns(9).HeaderText = "รหัสไปรษณีย์"
        dgvShowemp.Columns(10).HeaderText = "เบอร์โทรศัพท์"
        dgvShowemp.Columns(11).HeaderText = "แผนก"
        dgvShowemp.Columns(12).HeaderText = "วันที่เข้าทำงาน"
        dgvShowemp.Columns(13).HeaderText = "เงินเดือน"

        If dgvShowemp.RowCount = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub dgvShowemp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowemp.CellEnter
        If dgvShowemp.RowCount = 0 Or dgvShowemp.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowemp.CurrentCell.RowIndex
        Dim eid As String = dgvShowemp.Item(0, r).Value
        connData()

        strSql = "select tbemployee.* , tbdepartment.departmentname from tbemployee,tbdepartment " & vbCrLf &
            "where tbemployee.departmentid = tbdepartment.departmentid and empid=@eid"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("eid", eid)
        myDR = myCom.ExecuteReader

        myDR.Read()
        txtEmpid.Text = dgvShowemp.Item(0, r).Value
        txtEmppass.Text = myDR.Item("emppassword")
        txtEmpname.Text = dgvShowemp.Item(1, r).Value
        txtEmplname.Text = dgvShowemp.Item(2, r).Value
        If dgvShowemp.Item(3, r).Value = "ชาย" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        txtEmpidcard.Text = dgvShowemp.Item(4, r).Value
        txtEmpaddress.Text = dgvShowemp.Item(5, r).Value
        txtEmpsubarea.Text = dgvShowemp.Item(6, r).Value
        txtEmparea.Text = dgvShowemp.Item(7, r).Value
        txtEmpprovince.Text = dgvShowemp.Item(8, r).Value
        txtEmppostalcode.Text = dgvShowemp.Item(9, r).Value
        txtEmpphone.Text = dgvShowemp.Item(10, r).Value
        cboEmpdep.SelectedItem = myDR.Item("departmentname")
        txtEmphiredate.Text = dgvShowemp.Item(12, r).Value
        txtEmpsalary.Text = dgvShowemp.Item(13, r).Value
        txtEmpbirthday.Text = myDR.Item("empbirthday")

        myDR.Close()
    End Sub
End Class