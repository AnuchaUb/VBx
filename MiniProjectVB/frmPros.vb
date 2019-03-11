Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmPros
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim opid As String
    Dim opmd As String

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub conncboBrand()
        connData()
        strSql = "select brandname from tbcompany"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read()
                cboProbrand.Items.Add(myDR.Item("brandname"))
                cbobrand2.Items.Add(myDR.Item("brandname"))
            End While
            cboProbrand.SelectedIndex = 0
            cbobrand2.SelectedIndex = 0
            myDR.Close()
        End If
        myCon.Close()
    End Sub
    Private Sub conncboType()
        connData()
        strSql = "select typename from tbtypeofproduct"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read()
                cboProtype2.Items.Add(myDR.Item("typename"))
            End While
            cboProtype2.SelectedIndex = 0
            myDR.Close()
        End If
        myCon.Close()
    End Sub

    Private Sub frmPros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()
        If cboProbrand.Items.Count = 0 Or cboProtype2.Items.Count = 0 Then
            conncboBrand()
            conncboType()
        End If
        strSql = "select proid,promod, tbcompany.brandname , probtu, tbtypeofproduct.typename," & vbCrLf &
            "iif(proivt=1,'มี','ไม่มี'),prosystem,procoldsystem,prowrt,proprice,proUnitsInStock" & vbCrLf &
            " from tbproducts,tbcompany,tbtypeofproduct where tbproducts.typeproductid = tbtypeofproduct.typeproductid And tbproducts.companyid = tbcompany.companyid"

        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Loadcorp")
        dgvShowpro.DataSource = myDS.Tables("Loadcorp")

        dgvShowpro.Columns(0).Width = 50
        dgvShowpro.Columns(1).Width = 280
        dgvShowpro.Columns(2).Width = 80
        dgvShowpro.Columns(3).Width = 80
        dgvShowpro.Columns(4).Width = 80
        dgvShowpro.Columns(5).Width = 80
        dgvShowpro.Columns(6).Width = 280
        dgvShowpro.Columns(7).Width = 80
        dgvShowpro.Columns(8).Width = 50
        dgvShowpro.Columns(9).Width = 80
        dgvShowpro.Columns(10).Width = 80


        dgvShowpro.Columns(0).HeaderText = "รหัส"
        dgvShowpro.Columns(1).HeaderText = "โมเดล"
        dgvShowpro.Columns(2).HeaderText = "แบรนด์"
        dgvShowpro.Columns(3).HeaderText = "BTU"
        dgvShowpro.Columns(4).HeaderText = "ประเภทสินค้า"
        dgvShowpro.Columns(5).HeaderText = "ระบบ Inverter"
        dgvShowpro.Columns(6).HeaderText = "ระบบฟองอากาศ"
        dgvShowpro.Columns(7).HeaderText = "ระบบกระจายความเย็น"
        dgvShowpro.Columns(8).HeaderText = "ประกัน(ปี)"
        dgvShowpro.Columns(9).HeaderText = "ราคา"
        dgvShowpro.Columns(10).HeaderText = "จำนวนคงเหลือ"

        If dgvShowpro.RowCount = 0 Or dgvShowpro.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูลสินค้าด้วยครับ", "ไม่มีข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        ElseIf dgvShowpro.rowcount = 0 Then
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
        txtProid.Clear()
        cboProbrand.SelectedIndex = 0
        txtPromodel.Clear()
        cboProtype2.SelectedIndex = 0
        txtProbtu.Clear()
        radInverter.Checked = True
        txtProsystem.Clear()
        txtProdtbtcold.Clear()
        txtProwarranty.Clear()
        txtProprice.Clear()
        txtProamount.Clear()
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
        txtProid.Text = txtProid.Text.Trim()
        opid = txtProid.Text
        opmd = txtPromodel.Text
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
        dgr = MessageBox.Show("คุณต้องการจะลบข้อมูลของโมเดล " & txtPromodel.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dgr = DialogResult.Yes Then
            connData()
            strSql = "delete from tbproducts where proid = @pid"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("pid", txtProid.Text)
            myCom.ExecuteNonQuery()

            MessageBox.Show("ข้อมูลดังกล่าวถูกลบเรียบร้อยแล้ว", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ctxt()
            Call frmPros_Load(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtProid.Text = txtProid.Text.Trim()
        If txtProid.Text = "" Or cboProbrand.Text = "" Or txtPromodel.Text = "" Or cboProtype2.Text = "" Or txtProbtu.Text = "" Or txtProdtbtcold.Text = "" Or txtProwarranty.Text = "" Or txtProprice.Text = "" Or txtProamount.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProid.Focus()
            Exit Sub
        ElseIf txtProsystem.Text = "" Then
            txtProsystem.Text = "ไม่มีระบบฟอกอากาศ"

        ElseIf Not IsNumeric(txtProbtu.Text) Or Not IsNumeric(txtProprice.Text) Or Not IsNumeric(txtProamount.Text) Or Not IsNumeric(txtProwarranty.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง!", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim inv As String
            Dim pt As String
            Dim bn As String

            If radInverter.Checked Then
                inv = "1"
            Else
                inv = "0"
            End If

            connData()
            strSql = "select companyid from tbcompany where brandname = @bn"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("bn", cboProbrand.SelectedItem)
            myDR = myCom.ExecuteReader
            myDR.Read()
            bn = myDR.Item("companyid")
            myDR.Close()

            strSql = "select typeproductid from tbtypeofproduct where typename = @tn"
            myCom = New SqlCommand(strSql, myCon)
            myCom.CommandType = CommandType.Text
            myCom.Parameters.AddWithValue("tn", cboProtype2.SelectedItem)
            myDR = myCom.ExecuteReader
            myDR.Read()
            pt = myDR.Item("typeproductid")
            myDR.Close()


            If strBtn = "insert" Then
                'การเช็ค PK
                strSql = "select proid from tbproducts where proid=@pid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("pid", txtProid.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่มรหัสสินค้าที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอกรหัสสินค้าใหม่!", "รหัสสินค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtProid.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'การเช็ต Model
                myDR.Close()
                strSql = "select promod from tbproducts where promod = @pmd "
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("pmd", txtPromodel.Text)
                myDR = myCom.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("ไม่สามารถเพิ่ม Model สินค้าที่มีอยู่ในระบบได้!" & vbCrLf & "กรุณากรอก Model สินค้าใหม่!", "Model สินค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPromodel.Focus()
                    myDR.Close()
                    Exit Sub
                End If
                'เพิ่มข้อมูล
                myDR.Close()
                strSql = "insert into tbproducts(proid,companyid,promod,probtu,typeproductid,proivt,prosystem,procoldsystem,prowrt,proprice,prounitsinstock)" & vbCrLf &
                    "values(@pid,@pbn,@pmd,@pbtu,@pt,@pinv,@ps,@pcs,@pwrt,@pp,@puis)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("pid", txtProid.Text)
                myCom.Parameters.AddWithValue("pbn", bn)
                myCom.Parameters.AddWithValue("pmd", txtPromodel.Text)
                myCom.Parameters.AddWithValue("pbtu", txtProbtu.Text)
                myCom.Parameters.AddWithValue("pt", pt)
                myCom.Parameters.AddWithValue("pinv", inv)
                myCom.Parameters.AddWithValue("ps", txtProsystem.Text)
                myCom.Parameters.AddWithValue("pcs", txtProdtbtcold.Text)
                myCom.Parameters.AddWithValue("pwrt", txtProwarranty.Text)
                myCom.Parameters.AddWithValue("pp", txtProprice.Text)
                myCom.Parameters.AddWithValue("puis", txtProamount.Text)
                myCom.ExecuteNonQuery()
                Call frmPros_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "การเพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                'แก้ไข
                'การเช็ค PK
                If txtProid.Text <> opid Then
                    strSql = "select proid from tbproducts where proid=@pid"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("pid", txtProid.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยนรหัสสินค้าให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอกรหัสสินค้าด้วยครับ!!", "รหัสสินค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtProid.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If
                'การเช็ค Model
                If txtPromodel.Text <> opmd Then
                    strSql = "select promod from tbproducts where promod = @pmd"
                    myCom = New SqlCommand(strSql, myCon)
                    myCom.CommandType = CommandType.Text
                    myCom.Parameters.AddWithValue("pmd", txtPromodel.Text)
                    myDR = myCom.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("คุณไม่สามารถเปลี่ยน Model สินค้าให้ซ้ำกับที่ระบบมีอยู่ได้" & vbCrLf & "กรุณากรอก Model สินค้าใหม่ด้วยครับ!!", "Model สินค้าซ้ำ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPromodel.Focus()
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                myDR.Close()
                strSql = "update tbproducts set proid=@pid,companyid=@pbn,promod=@pmd,probtu=@pbtu,typeproductid=@pt,proivt=@pinv,prosystem=@ps,procoldsystem=@pcs,prowrt=@pwrt,proprice=@pp,prounitsinstock=@puis where proid=@opid"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("pid", txtProid.Text)
                myCom.Parameters.AddWithValue("pbn", bn)
                myCom.Parameters.AddWithValue("pmd", txtPromodel.Text)
                myCom.Parameters.AddWithValue("pbtu", txtProbtu.Text)
                myCom.Parameters.AddWithValue("pt", pt)
                myCom.Parameters.AddWithValue("pinv", inv)
                myCom.Parameters.AddWithValue("ps", txtProsystem.Text)
                myCom.Parameters.AddWithValue("pcs", txtProdtbtcold.Text)
                myCom.Parameters.AddWithValue("pwrt", txtProwarranty.Text)
                myCom.Parameters.AddWithValue("pp", txtProprice.Text)
                myCom.Parameters.AddWithValue("puis", txtProamount.Text)
                myCom.Parameters.AddWithValue("opid", opid)
                myCom.ExecuteNonQuery()
                Call frmPros_Load(sender, e)
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
    End Sub

    Private Sub dgvShowpro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowpro.CellEnter
        If dgvShowpro.RowCount = 0 Or dgvShowpro.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        Dim r As Integer = dgvShowpro.CurrentCell.RowIndex
        Dim tid As String = dgvShowpro.Item(0, r).Value
        connData()

        strSql = "select tbproducts.* , tbtypeofproduct.typename , tbcompany.brandname from tbproducts,tbtypeofproduct,tbcompany where tbproducts.typeproductid = tbtypeofproduct.typeproductid and " & vbCrLf &
            "tbproducts.companyid = tbcompany.companyid and proid=@pid"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("pid", tid)
        myDR = myCom.ExecuteReader

        myDR.Read()
        txtProid.Text = dgvShowpro.Item(0, r).Value
        cboProbrand.SelectedItem = myDR.Item("brandname")
        txtPromodel.Text = dgvShowpro.Item(1, r).Value
        cboProtype2.SelectedItem = myDR.Item("typename")
        txtProbtu.Text = dgvShowpro.Item(3, r).Value

        If dgvShowpro.Item(5, r).Value = "มี" Then
            radInverter.Checked = True
        Else
            radNoninverter.Checked = True
        End If

        txtProsystem.Text = dgvShowpro.Item(6, r).Value
        txtProdtbtcold.Text = dgvShowpro.Item(7, r).Value
        txtProwarranty.Text = dgvShowpro.Item(8, r).Value
        txtProprice.Text = dgvShowpro.Item(9, r).Value
        txtProamount.Text = dgvShowpro.Item(10, r).Value
        myDR.Close()
    End Sub

    'Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
    '  connData()
    '  strSql = "select proid,promod, tbcompany.brandname , probtu, tbtypeofproduct.typename," & vbCrLf &
    '      "iif(proivt=1,'มี','ไม่มี') as inverter ,prosystem,procoldsystem,prowrt,proprice,proUnitsInStock" & vbCrLf &
    '      " from tbproducts,tbcompany,tbtypeofproduct where proid like '" & txtSearch.Text & "' or brandname like '" & txtSearch.Text & "' or promod like '" & txtSearch.Text & "'" & vbCrLf &
    '     "or typename like '" & txtSearch.Text & "'or probtu like '" & txtSearch.Text & "' or proivt like '" & txtSearch.Text & "' or prosystem like '" & txtSearch.Text & "'" & vbCrLf &
    '    "or procoldsystem like '" & txtSearch.Text & "' or prowrt like '" & txtSearch.Text & "'or proprice like '" & txtSearch.Text & "'or prounitsinstock like '" & txtSearch.Text & "'" & vbCrLf &
    '   "and tbproducts.companyid = tbcompany.companyid and tbproducts.typeproductid = tbtypeofproduct.typeproductid"
    'myDA = New SqlDataAdapter(strSql, myCon)
    'myDS.Clear()
    ' myDA.Fill(myDS, "search")
    '    dgvShowpro.DataSource = myDS.Tables("search")
    '
    '   myCom = New SqlCommand(strSql, myCon)
    '  myCom.CommandType = CommandType.Text
    ' 'myCom.Parameters.AddWithValue("@cn", txtScusname.Text)
    ''myCom.Parameters.AddWithValue("@cln", txtScuslname.Text)
    ' myDR = myCom.ExecuteReader
    '  If myDR.HasRows Then
    '         myDR.Read()
    '        txtProid.Text = myDR.Item("proid")
    '       cboProbrand.SelectedItem = myDR.Item("brandname")
    '      txtPromodel.Text = myDR.Item("promod")
    '     cboProtype2.SelectedItem = myDR.Item("typename")
    '    txtProbtu.Text = myDR.Item("probtu")
    '
    'If myDR.Item("inverter") = "มี" Then
    '           radInverter.Checked = True
    'Else
    '           radNoninverter.Checked = True
    'End If

    '       txtProsystem.Text = myDR.Item("prosystem")
    '      txtProdtbtcold.Text = myDR.Item("procoldsystem")
    '     txtProwarranty.Text = myDR.Item("prowrt")
    '    txtProprice.Text = myDR.Item("proprice")
    '   txtProamount.Text = myDR.Item("prounitsinstock")
    '  myDR.Close()
    'Else
    '       MessageBox.Show("ไม่พบข้อมูลดังกล่าว" & vbCrLf & "กรุณากรอกข้อมูลที่จะค้นหาใหม่ครับ!", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    'End If
    '   myDR.Close()
    '  myCon.Close()
    '    End Sub


    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
    '   connData()
    '  strSql = ""
    ' myDA = New SqlDataAdapter(strSql, myCon)
    '        'myDS.Clear()
    '       myDA.Fill(myDS, "search")
    '      dgvShowpro.DataSource = myDS.Tables("search")
    '
    '    myCom = New SqlCommand(strSql, myCon)
    '    myCom.CommandType = CommandType.Text
    '    'myCom.Parameters.AddWithValue("@cn", txtScusname.Text)
    '    'myCom.Parameters.AddWithValue("@cln", txtScuslname.Text)
    '    myDR = myCom.ExecuteReader
    ' If myDR.HasRows Then
    '         myDR.Read()
    '         txtProid.Text = myDR.Item("proid")
    '        cboProbrand.SelectedItem = myDR.Item("brandname")
    '         txtPromodel.Text = myDR.Item("promod")
    '         cboProtype2.SelectedItem = myDR.Item("typename")
    '         txtProbtu.Text = myDR.Item("probtu")
    ''
    'If myDR.Item("proivt") = "1" Then
    '            radInverter.Checked = True
    ' Else
    '             radNoninverter.Checked = True
    ' End If
    '
    '            txtProsystem.Text = myDR.Item("prosystem")
    '            txtProdtbtcold.Text = myDR.Item("procoldsystem")
    '            txtProwarranty.Text = myDR.Item("prowrt")
    '           txtProprice.Text = myDR.Item("proprice")
    '           txtProamount.Text = myDR.Item("prounitsinstock")
    '           myDR.Close()
    '   Else
    '
    '    End If
    '       myDR.Close()
    '        myCon.Close()
    '    End Sub

    Private Sub cbobrand2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobrand2.SelectedIndexChanged
        connData()
        strSql = "select proid,promod, tbcompany.brandname , probtu, tbtypeofproduct.typename," & vbCrLf &
            "iif(proivt=1,'มี','ไม่มี'),prosystem,procoldsystem,prowrt,proprice,proUnitsInStock" & vbCrLf &
            " from tbproducts,tbcompany,tbtypeofproduct where tbproducts.typeproductid = tbtypeofproduct.typeproductid And tbproducts.companyid = tbcompany.companyid" & vbCrLf &
            " and brandname = '" & cbobrand2.SelectedItem & "'"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "cboselect")
        dgvShowpro.DataSource = myDS.Tables("cboselect")

        dgvShowpro.Columns(0).Width = 50
        dgvShowpro.Columns(1).Width = 280
        dgvShowpro.Columns(2).Width = 80
        dgvShowpro.Columns(3).Width = 80
        dgvShowpro.Columns(4).Width = 80
        dgvShowpro.Columns(5).Width = 80
        dgvShowpro.Columns(6).Width = 280
        dgvShowpro.Columns(7).Width = 80
        dgvShowpro.Columns(8).Width = 50
        dgvShowpro.Columns(9).Width = 80
        dgvShowpro.Columns(10).Width = 80


        dgvShowpro.Columns(0).HeaderText = "รหัส"
        dgvShowpro.Columns(1).HeaderText = "โมเดล"
        dgvShowpro.Columns(2).HeaderText = "แบรนด์"
        dgvShowpro.Columns(3).HeaderText = "BTU"
        dgvShowpro.Columns(4).HeaderText = "ประเภทสินค้า"
        dgvShowpro.Columns(5).HeaderText = "ระบบ Inverter"
        dgvShowpro.Columns(6).HeaderText = "ระบบฟองอากาศ"
        dgvShowpro.Columns(7).HeaderText = "ระบบกระจายความเย็น"
        dgvShowpro.Columns(8).HeaderText = "ประกัน(ปี)"
        dgvShowpro.Columns(9).HeaderText = "ราคา"
        dgvShowpro.Columns(10).HeaderText = "จำนวนคงเหลือ"

        If dgvShowpro.RowCount = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub
End Class