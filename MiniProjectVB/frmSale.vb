Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSale
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim i As Integer
    Dim cn As String
    Dim cln As String
    Dim fcn As String
    Dim net As Double

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCancel.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
        btnOksale.Enabled = False
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        btnSale.Enabled = False
        btnCancel.Enabled = True
        Panel2.Enabled = True
        btnFindcus.Enabled = True
        btnConfirm.Enabled = True
        btnClear.Enabled = False

        lblOrdernumber.Text = getnewSale()
        lblDatetime.Text = Format(Date.Now, "dd/MM/yyyy")
        lblEmployee.Text = empname & " " & emplastname
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnSale.Enabled = True
        btnCancel.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
        lblOrdernumber.Text = ""
        lblDatetime.Text = ""
        lblEmployee.Text = ""
        txtCusid.Clear()
        lblCus.Text = ""
        txtProid.Clear()
        lblBrandname.Text = ""
        lblModel.Text = ""
        lblProtype.Text = ""
        lblProprice.Text = ""
        txtProamount.Clear()
        lblTotalprice.Text = ""
        dgvShowdetail.Rows.Clear()
        lblNet.Text = FormatNumber(net, 2)
        btnOksale.Enabled = False
        lblunitinstock.Text = ""
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If lblCus.Text = "" Or txtCusid.Text = "" Then
            MessageBox.Show("กรุณากรอกรหัสลูกค้าด้วยครับ", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCusid.Focus()
            Exit Sub
        Else
            btnConfirm.Enabled = False
            btnClear.Enabled = True
            Panel3.Enabled = True
            btnFindcus.Enabled = False
            btnAdd.Enabled = False
            btnRemove.Enabled = False
            Panel4.Enabled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCusid.Clear()
        lblCus.Text = ""
        btnFindcus.Enabled = True
        btnConfirm.Enabled = True
        btnClear.Enabled = False
        Panel3.Enabled = False
        txtProid.Clear()
        lblBrandname.Text = ""
        lblModel.Text = ""
        lblProtype.Text = ""
        lblProprice.Text = ""
        txtProamount.Clear()
        lblTotalprice.Text = ""
        lblNet.Text = FormatNumber(net, 2)
        lblunitinstock.Text = ""
        dgvShowdetail.Rows.Clear()
        btnOksale.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim found As Boolean = False
        Dim total As Double
        Dim unitinstock As Integer
        Dim amount As Integer = Val(txtProamount.Text)

        For i = 0 To dgvShowdetail.RowCount - 1
            If txtProid.Text = dgvShowdetail.Item(0, i).Value Then
                amount = Val(dgvShowdetail.Item(5, i).Value) + amount
            End If
        Next
        connData()
        strSql = "select prounitsinstock from tbproducts where proid = @pid"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("pid", txtProid.Text)
        myDR = myCom.ExecuteReader
        myDR.Read()
        unitinstock = Val(myDR.Item("prounitsinstock"))
        myDR.Close()
        If amount > unitinstock Then
            MessageBox.Show("สินค้ามีจำนวนไม่พอกรุณากรอกจำนวนสินค้าใหม่ครับ", "สินค้าไม่พอ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProamount.SelectAll()
            txtProamount.Focus()
            Exit Sub
        End If

        For i = 0 To dgvShowdetail.RowCount - 1
            If txtProid.Text = dgvShowdetail.Item(0, i).Value Then
                dgvShowdetail.Item(5, i).Value = Val(dgvShowdetail.Item(5, i).Value) + Val(txtProamount.Text)
                total = Val(dgvShowdetail.Item(4, i).Value) * Val(dgvShowdetail.Item(5, i).Value)
                dgvShowdetail.Item(6, i).Value = total
                found = True
                Exit For
            End If
        Next

        If found = False Then
            Dim x As Integer
            dgvShowdetail.Rows.Add()
            x = dgvShowdetail.Rows.Count
            dgvShowdetail.Item(0, x - 1).Value = txtProid.Text
            dgvShowdetail.Item(1, x - 1).Value = lblBrandname.Text
            dgvShowdetail.Item(2, x - 1).Value = lblModel.Text
            dgvShowdetail.Item(3, x - 1).Value = lblProtype.Text
            dgvShowdetail.Item(4, x - 1).Value = lblProprice.Text
            dgvShowdetail.Item(5, x - 1).Value = txtProamount.Text
            dgvShowdetail.Item(6, x - 1).Value = lblTotalprice.Text
        End If

        Call caldata()

    End Sub
    Private Sub caldata()
        Dim total, net As Double

        For i = 0 To dgvShowdetail.RowCount - 1
            total = total + Val(dgvShowdetail.Item(6, i).Value)
        Next
        net = total
        lblNet.Text = FormatNumber(net, 2)
        txtProid.Clear()
        lblBrandname.Text = ""
        lblModel.Text = ""
        lblProtype.Text = ""
        lblProprice.Text = ""
        txtProamount.Clear()
        lblTotalprice.Text = ""
        lblunitinstock.Text = ""
        btnOksale.Enabled = True
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim i As Integer = dgvShowdetail.CurrentCell.RowIndex
        Dim total As Double

        dgvShowdetail.Rows.RemoveAt(i)

        If dgvShowdetail.RowCount = 0 Then
            btnRemove.Enabled = False
            btnOksale.Enabled = False
        Else
            btnOksale.Enabled = True
        End If

        For i = 0 To dgvShowdetail.RowCount - 1
            'net = 0
            total = total + Val(dgvShowdetail.Item(6, i).Value)
        Next

        net = total
        lblNet.Text = FormatNumber(Net, 2)
        txtProid.Clear()
        lblBrandname.Text = ""
        lblModel.Text = ""
        lblProtype.Text = ""
        lblProprice.Text = ""
        txtProamount.Clear()
        lblTotalprice.Text = ""
        lblunitinstock.Text = ""
    End Sub

    Private Sub btnFindcus_Click(sender As Object, e As EventArgs) Handles btnFindcus.Click
        cusidfind = ""
        frmFindcus.ShowDialog()

        If cusidfind <> "" Then
            txtCusid.Text = cusidfind
            Call findcus()
        Else
            txtCusid.Focus()
        End If
    End Sub

    Private Sub btnFindpro_Click(sender As Object, e As EventArgs) Handles btnFindpro.Click
        proidfind = ""
        Dim frm As New frmFindpro

        frmFindpro.ShowDialog()

        If proidfind <> "" Then
            txtProid.Text = proidfind
            Call findpro()
        Else
            txtProid.Focus()
        End If
    End Sub
    Private Sub findpro()
        connData()
        strSql = "select brandname,promod,typename,proprice,prounitsinstock from tbproducts,tbcompany,tbtypeofproduct" & vbCrLf &
            "where tbproducts.companyid = tbcompany.companyid and tbtypeofproduct.typeproductid = tbproducts.typeproductid" & vbCrLf &
            "and proid=@pid"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("pid", txtProid.Text)
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            lblBrandname.Text = myDR.Item("brandname")
            lblModel.Text = myDR.Item("promod")
            lblProtype.Text = myDR.Item("typename")
            lblProprice.Text = myDR.Item("proprice")
            txtProamount.Text = "1"
            lblunitinstock.Text = myDR.Item("prounitsinstock")
            lblTotalprice.Text = Val(lblProprice.Text) * Val(txtProamount.Text)
            txtProamount.Focus()
        Else
            'MessageBox.Show("ไม่พบสินค้าตามรหัสที่ระบุ", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'txtProid.SelectAll()
            txtProid.Focus()
        End If
        myDR.Close()
    End Sub
    Private Sub findcus()
        connData()
        strSql = "select cusname +' '+cuslastname as fullname from tbcustomers where cusid=@cid"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myCom.Parameters.AddWithValue("cid", txtCusid.Text)
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()

            lblCus.Text = myDR.Item("fullname")
        Else
            'MessageBox.Show("ไม่พบลูกค้าตามรหัสที่ระบุ", "ไม่พบข้อมูลลูกค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'txtCusid.SelectAll()
            txtCusid.Focus()
        End If
        myDR.Close()
    End Sub
    Private Function getnewSale() As String
        Dim newSale As String = ""
        Dim lastSale As String = ""

        Dim year As Integer = Format(Date.Now, "yyyy")
        connData()
        strSql = "select max(saleid) as maxsale from tbsale where saleid like 'S" & year & "%'"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        myDR.Read()

        If Not IsDBNull(myDR.Item("maxsale")) Then
            lastSale = myDR.Item("maxsale")
            lastSale = Mid(lastSale, 9)
            newSale = Val(lastSale) + 1
            Select Case newSale.Length
                Case 1 : newSale = "000" & newSale
                Case 2 : newSale = "00" & newSale
                Case 3 : newSale = "0" & newSale
            End Select
            newSale = "S" & year & "/" & newSale
        Else
            newSale = "S" & year & "/" & "0001"
        End If
        myDR.Close()
        myCon.Close()
        Return newSale
    End Function

    Private Sub txtProamount_TextChanged(sender As Object, e As EventArgs) Handles txtProamount.TextChanged
        lblTotalprice.Text = Val(lblProprice.Text) * Val(txtProamount.Text)
        If Val(lblTotalprice.Text) = 0 Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub txtCusid_TextChanged(sender As Object, e As EventArgs) Handles txtCusid.TextChanged

        If txtCusid.Text.Length = 0 Then
            lblCus.Text = ""
            Exit Sub
        Else
            Call findcus()
        End If

    End Sub

    Private Sub txtProid_TextChanged(sender As Object, e As EventArgs) Handles txtProid.TextChanged

        If txtProid.Text.Length = 0 Then
            lblBrandname.Text = ""
            lblModel.Text = ""
            lblProtype.Text = ""
            lblProprice.Text = ""
            txtProamount.Clear()
            lblTotalprice.Text = ""
            Exit Sub
        Else
            Call findpro()
        End If

    End Sub

    Private Sub txtProamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProamount.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) = 13 Then
                Call btnAdd_Click(sender, e)
            ElseIf Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub btnOksale_Click(sender As Object, e As EventArgs) Handles btnOksale.Click
        Dim dgr As DialogResult
        Dim sdate As String = Format(Date.Now, "yyyy/MM/dd")
        If dgvShowdetail.RowCount = 0 Then

            MessageBox.Show("ไม่มีสินค้าในรายการกรุณาเลือกสินค้าก่อนครับ", "ยังไม่ทำการเลือกสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else 'ทำการขาย
            dgr = MessageBox.Show("คุณต้องการจะลบข้อมูล " & lblOrdernumber.Text & " ใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If dgr = DialogResult.Yes Then
                connData()
                strSql = "insert into tbsale(saleid,saledate,empid,cusid) values(@sid,@sdate,@sempid,@scusid)"
                myCom = New SqlCommand(strSql, myCon)
                myCom.CommandType = CommandType.Text
                myCom.Parameters.AddWithValue("sid", lblOrdernumber.Text)
                myCom.Parameters.AddWithValue("sdate", SqlDbType.Date).Value = sdate
                myCom.Parameters.AddWithValue("sempid", empid)
                myCom.Parameters.AddWithValue("scusid", txtCusid.Text)
                myCom.ExecuteNonQuery()

                For i = 0 To dgvShowdetail.RowCount - 1

                    strSql = "insert into tbsaledetail(saleid,proid,saleamount,saletotal) values(@sid,@pid,@samount,@stotal)"
                    myCom.CommandText = strSql
                    myCom.Parameters.Clear()
                    myCom.Parameters.AddWithValue("sid", lblOrdernumber.Text)
                    myCom.Parameters.AddWithValue("pid", dgvShowdetail.Item(0, i).Value)
                    myCom.Parameters.AddWithValue("samount", dgvShowdetail.Item(5, i).Value)
                    myCom.Parameters.AddWithValue("stotal", dgvShowdetail.Item(6, i).Value)
                    myCom.ExecuteNonQuery()

                    strSql = "update tbproducts set prounitsinstock = prounitsinstock - @samount where proid = @pid"
                    myCom.CommandText = strSql
                    myCom.ExecuteNonQuery()

                Next
                myCon.Close()
                MessageBox.Show("ทำการบันทึกการขายที่ : " & lblOrdernumber.Text & " เรียบร้อยแล้ว", "บันทึกการขายสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                btnSale.Enabled = True
                btnCancel.Enabled = False
                Panel2.Enabled = False
                Panel3.Enabled = False
                Panel4.Enabled = False
                btnOksale.Enabled = False
                lblOrdernumber.Text = ""
                lblDatetime.Text = ""
                lblEmployee.Text = ""
                txtCusid.Clear()
                lblCus.Text = ""
                txtProid.Clear()
                lblBrandname.Text = ""
                lblModel.Text = ""
                lblProtype.Text = ""
                lblProprice.Text = ""
                txtProamount.Clear()
                lblTotalprice.Text = ""
                net = 0
                lblNet.Text = FormatNumber(net, 2)
                dgvShowdetail.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub dgvShowdetail_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowdetail.CellEnter
        If dgvShowdetail.RowCount = 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If
    End Sub

    '" Private Sub dgvShowdetail_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowdetail.CellEnter
    '     btnRemove.Enabled = True
    'Dim r As Integer = dgvShowdetail.CurrentCell.RowIndex
    '      Dim sid As String = dgvShowdetail.Item(0, r).Value

    '     txtproid.Text = dgvShowdetail.Item(0, r).Value
    '    lblBrandname.Text = dgvShowdetail.Item(1, r).Value'
    '     lblModel.Text = dgvShowdetail.Item(2, r).Value
    '   lblProtype.Text = dgvShowdetail.Item(3, r).Value'
    '    lblProprice.Text = dgvShowdetail.Item(4, r).Value
    '     txtProamount.Text = dgvShowdetail.Item(5, r).Value
    '     lblTotalprice.Text = dgvShowdetail.Item(6, r).Value
    ' End Sub"
End Class