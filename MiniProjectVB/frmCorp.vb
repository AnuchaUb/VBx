Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCorp
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim oldcid As String
    Dim oldcn As String
    Dim oldbn As String
    Dim oldadd As String
    Dim oldph As String
    Dim oldfax As String
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmCorp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()

        strSql = "select * from tbcompany"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loadcorp")
        dgvShowcorp.DataSource = myDS.Tables("Loadcorp")

        dgvShowcorp.Columns(0).Width = 50
        dgvShowcorp.Columns(1).Width = 280
        dgvShowcorp.Columns(2).Width = 127
        dgvShowcorp.Columns(3).Width = 290
        dgvShowcorp.Columns(4).Width = 80
        dgvShowcorp.Columns(5).Width = 80
        dgvShowcorp.Columns(6).Width = 80
        dgvShowcorp.Columns(7).Width = 80
        dgvShowcorp.Columns(8).Width = 50
        dgvShowcorp.Columns(9).Width = 80
        dgvShowcorp.Columns(10).Width = 80


        dgvShowcorp.Columns(0).HeaderText = "รหัส"
        dgvShowcorp.Columns(1).HeaderText = "ชื่อบริษัท"
        dgvShowcorp.Columns(2).HeaderText = "แบรนด์"
        dgvShowcorp.Columns(3).HeaderText = "ที่อยู่"
        dgvShowcorp.Columns(4).HeaderText = "ตำบล/แขวง"
        dgvShowcorp.Columns(5).HeaderText = "อำเภอ/เขต"
        dgvShowcorp.Columns(6).HeaderText = "จังหวัด"
        dgvShowcorp.Columns(7).HeaderText = "รหัสไปรษณีย์"
        dgvShowcorp.Columns(8).HeaderText = "ประเทศ"
        dgvShowcorp.Columns(9).HeaderText = "เบอร์โทรศัพท์"
        dgvShowcorp.Columns(10).HeaderText = "เบอร์ FAX"

        If dgvShowcorp.RowCount = 0 Or dgvShowcorp.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูลบริษัทผู้ผลิตด้วยครับ", "ไม่มีข้อมูลบริษัทผู้ผลิต", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowcorp.rowcount = 0 Then
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
        txtCorpid.Clear()
        txtCorpname.Clear()
        txtBrandname.Clear()
        txtCropaddress.Clear()
        txtCorpsubarea.Clear()
        txtCorparea.Clear()
        txtCorpprovince.Clear()
        txtCorppostalcode.Clear()
        txtCorpcountry.Clear()
        txtCorpphone.Clear()
        txtCorpfax.Clear()
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

        oldcid = txtCorpid.Text
        oldcn = txtCorpname.Text
        oldbn = txtBrandname.Text
        oldadd = txtCropaddress.Text
        oldph = txtCorpphone.Text
        oldfax = txtCorpfax.Text
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
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูล " & txtBrandname.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbcompany where companyid = @cid"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("cid", txtCorpid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ctxt()
            Call frmCorp_Load(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCorpid.Text = "" Or txtCorpname.Text = "" Or txtBrandname.Text = "" Or txtCropaddress.Text = "" Or txtCorpsubarea.Text = "" Or txtCorparea.Text = "" Or txtCorpprovince.Text = "" Or txtCorppostalcode.Text = "" Or txtCorpcountry.Text = "" Or txtCorpphone.Text = "" Or txtCorpfax.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorpid.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtCorppostalcode.Text) Or Not IsNumeric(txtCorpphone.Text) Or Not IsNumeric(txtCorpfax.text) Then
            MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง!", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            connData()
            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select companyid from tbcompany where companyid=@cid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCorpid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสบริษัทผู้ผลิตที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสบริษัทผู้ผลิตใหม่!", "รหัสบริษัทผู้ผลิตซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCorpid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต ชื่อ
                myDR.Close()
                strSql = "select comname from tbcompany where comname=@cn"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cn", txtCorpname.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อบริษัทผู้ผลิตที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อบริษัทผู้ผลิตใหม่!", "ชื่อบริษัทผู้ผลิตซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCorpname.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต แบรนด์
                myDR.Close()
                strSql = "select brandname from tbcompany where brandname=@bn"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("bn", txtBrandname.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มชื่อแบรนด์ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกชื่อแบรนด์ใหม่!", "ชื่อแบรนด์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBrandname.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'เช็คที่อยู่
                myDR.Close()
                strSql = "select comaddress from tbcompany where comaddress=@cadd"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cadd", txtCropaddress.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มที่อยู่ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกที่อยู่ใหม่!", "ที่อยู่ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCropaddress.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'เช็คเบอร์
                myDR.Close()
                strSql = "select comphone from tbcompany where comphone=@cph"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cph", txtCorpphone.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มเบอร์โทรศัพท์ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCorpphone.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'เช็ค FAX
                myDR.Close()
                strSql = "select comfax from tbcompany where comfax=@cfax"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cfax", txtCorpfax.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มเบอร์ FAX ที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกเบอร์ FAX ใหม่!", "เบอร์ FAX ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCorpfax.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'เพิ่มข้อมูล
                myDR.Close()
                strSql = "insert into tbcompany(companyid,comname,brandname,comaddress,comsubarea,comarea,comprovince,comcountry,compostalcode,comphone,comfax)" & vbCrLf &
                    "values(@cid,@cn,@bn,@cadd,@csa,@ca,@cpv,@cc,@cpc,@cph,@cfax)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCorpid.Text)
                myCom.Parameters.AddWithValue("cn", txtCorpname.Text)
                myCom.Parameters.AddWithValue("bn", txtBrandname.Text)
                myCom.Parameters.AddWithValue("cadd", txtCropaddress.Text)
                myCom.Parameters.AddWithValue("csa", txtCorpsubarea.Text)
                myCom.Parameters.AddWithValue("ca", txtCorparea.Text)
                myCom.Parameters.AddWithValue("cpv", txtCorpprovince.Text)
                myCom.Parameters.AddWithValue("cc", txtCorpcountry.Text)
                myCom.Parameters.AddWithValue("cpc", txtCorppostalcode.Text)
                myCom.Parameters.AddWithValue("cph", txtCorpphone.Text)
                myCom.Parameters.AddWithValue("cfax", txtCorpfax.Text)
                myCom.ExecuteNonQuery()
                Call frmCorp_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else 'แก้ไข
                'การเช็ค PK
                If txtCorpid.Text <> oldcid Then
                    strSql = "select companyid from tbcompany where companyid=@ocid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocid", txtCorpid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสบริษัทผู้ผลิตให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสบริษัทผู้ผลิตใหม่ด้วยครับ!!", "รหัสบริษัทผู้ผลิตซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCorpid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค ชื่อ
                If txtCorpname.Text <> oldcn Then
                    strSql = "select comname from tbcompany where comname = @ocn"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocn", txtCorpname.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อบริษัทผู้ผลิตให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อบริษัทผู้ผลิตใหม่ด้วยครับ!!", "ชื่อบริษัทผู้ผลิตซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCorpid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค แบรนด์
                If txtBrandname.Text <> oldbn Then
                    strSql = "select brandname from tbcompany where brandname =@obn"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("obn", txtBrandname.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนชื่อแบรนด์ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกชื่อแบรนด์ใหม่ด้วยครับ!!", "ชื่อแบรนด์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtBrandname.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค ที่อยู่
                If txtCropaddress.Text <> oldadd Then
                    strSql = "select comaddress from tbcompany where comaddress =@ocadd"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocadd", txtCropaddress.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนที่อยู่ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกที่อยู่ใหม่ด้วยครับ!!", "ที่อยู่ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCropaddress.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค เบอร์ติดต่อ
                If txtCorpphone.Text <> oldph Then
                    strSql = "select comphone from tbcompany where comphone=@ocph"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocph", txtCorpphone.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนเบอร์โทรศัพท์ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกเบอร์โทรศัพท์ใหม่ด้วยครับ!!", "เบอร์โทรศัพท์ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCorpphone.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค เบอร์ Fax.
                If txtCorpfax.Text <> oldfax Then
                    strSql = "select comfax from tbcompany where comfax=@ocfax"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("ocfax", txtCorpfax.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนเบอร์ FAX ให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกเบอร์ FAX ใหม่ด้วยครับ!!", "เบอร์ FAX ซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCorpfax.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                strSql = "update tbcompany set companyid=@cid,comname=@cn,brandname=@bn,comaddress=@cadd,comsubarea=@csa,comarea=@ca,comprovince=@cpv,compostalcode=@cpc,comcountry=@cc,comphone=@cph,comfax=@cfax where companyid=@ocid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("cid", txtCorpid.Text)
                myCom.Parameters.AddWithValue("cn", txtCorpname.Text)
                myCom.Parameters.AddWithValue("bn", txtBrandname.Text)
                myCom.Parameters.AddWithValue("cadd", txtCropaddress.Text)
                myCom.Parameters.AddWithValue("csa", txtCorpsubarea.Text)
                myCom.Parameters.AddWithValue("ca", txtCorparea.Text)
                myCom.Parameters.AddWithValue("cpv", txtCorpprovince.Text)
                myCom.Parameters.AddWithValue("cpc", txtCorppostalcode.Text)
                myCom.Parameters.AddWithValue("cc", txtCorpcountry.Text)
                myCom.Parameters.AddWithValue("cph", txtCorpphone.Text)
                myCom.Parameters.AddWithValue("cfax", txtCorpfax.Text)
                myCom.Parameters.AddWithValue("ocid", oldcid)
                myCom.ExecuteNonQuery()
                Call frmCorp_Load(sender, e)
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

    Private Sub dgvShowcorp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowcorp.CellEnter
        If dgvShowcorp.RowCount = 0 Or dgvShowcorp.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowcorp.CurrentCell.RowIndex
        Dim tid As String = dgvShowcorp.Item(0, r).Value

        txtCorpid.Text = dgvShowcorp.Item(0, r).Value
        txtCorpname.Text = dgvShowcorp.Item(1, r).Value
        txtBrandname.Text = dgvShowcorp.Item(2, r).Value
        txtCropaddress.Text = dgvShowcorp.Item(3, r).Value
        txtCorpsubarea.Text = dgvShowcorp.Item(4, r).Value
        txtCorparea.Text = dgvShowcorp.Item(5, r).Value
        txtCorpprovince.Text = dgvShowcorp.Item(6, r).Value
        txtCorppostalcode.Text = dgvShowcorp.Item(7, r).Value
        txtCorpcountry.Text = dgvShowcorp.Item(8, r).Value
        txtCorpphone.Text = dgvShowcorp.Item(9, r).Value
        txtCorpfax.Text = dgvShowcorp.Item(10, r).Value

    End Sub
    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click

        connData()
        strSql = "select * from tbcompany where companyid  like '" & txtSeach.Text & "%' or comname like '" & txtSeach.Text & "%'  or brandname like '" & txtSeach.Text & "%'" & vbCrLf &
                " or comaddress like '" & txtSeach.Text & "%'  or comsubarea like '" & txtSeach.Text & "%'  " & vbCrLf &
                "or comarea like '" & txtSeach.Text & "%'  or comprovince like '" & txtSeach.Text & "%'  or comcountry like '" & txtSeach.Text & "%'  or compostalcode like '" & txtSeach.Text & "%' " & vbCrLf &
                " or comphone like '" & txtSeach.Text & "%'  or comfax like '" & txtSeach.Text & "%' "
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            txtCorpid.Text = myDR.Item("companyid")
            txtCorpname.Text = myDR.Item("comname")
            txtBrandname.Text = myDR.Item("brandname")
            txtCropaddress.Text = myDR.Item("comaddress")
            txtCorpsubarea.Text = myDR.Item("comsubarea")
            txtCorparea.Text = myDR.Item("comarea")
            txtCorpprovince.Text = myDR.Item("comprovince")
            txtCorppostalcode.Text = myDR.Item("compostalcode")
            txtCorpcountry.Text = myDR.Item("comcountry")
            txtCorpphone.Text = myDR.Item("comphone")
            txtCorpfax.Text = myDR.Item("comfax")
            myDR.Close()
        Else
            MessageBox.Show("ไม่พบข้อมูลดังกล่าว" & vbCrLf & "กรุณากรอกข้อมูลที่จะค้นหาใหม่ครับ!", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        myDR.Close()
        myCon.Close()
    End Sub

    Private Sub txtSeach_TextChanged(sender As Object, e As EventArgs) Handles txtSeach.TextChanged

        If txtSeach.Text = "" Then
            Call frmCorp_Load(sender, e)

        Else

            connData()
            strSql = "select * from tbcompany where companyid  like '" & txtSeach.Text & "%' or comname like '" & txtSeach.Text & "%'  or brandname like '" & txtSeach.Text & "%'" & vbCrLf &
                " or comaddress like '" & txtSeach.Text & "%'  or comsubarea like '" & txtSeach.Text & "%'  " & vbCrLf &
                "or comarea like '" & txtSeach.Text & "%'  or comprovince like '" & txtSeach.Text & "%'  or comcountry like '" & txtSeach.Text & "%'  or compostalcode like '" & txtSeach.Text & "%' " & vbCrLf &
                " or comphone like '" & txtSeach.Text & "%'  or comfax like '" & txtSeach.Text & "%' "
            myDA = New SqlDataAdapter(strSql, myCon)
            myDS.Clear()
            myDA.Fill(myDS, "search")
            dgvShowcorp.DataSource = myDS.Tables("search")
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myDR = myCom.ExecuteReader
            If myDR.HasRows Then

            End If
        End If
        myDR.Close()
        myCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call frmCorp_Load(sender, e)
        txtSeach.Clear()
        ctxt()
    End Sub

    Private Sub txtCorpfax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpfax.KeyPress, txtCorppostalcode.KeyPress, txtCorpphone.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class