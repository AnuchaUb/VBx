<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.lblDatetime = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblOrdernumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCusid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCus = New System.Windows.Forms.Label()
        Me.btnFindcus = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnFindpro = New System.Windows.Forms.Button()
        Me.lblTotalprice = New System.Windows.Forms.Label()
        Me.lblProprice = New System.Windows.Forms.Label()
        Me.lblProtype = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblBrandname = New System.Windows.Forms.Label()
        Me.txtProamount = New System.Windows.Forms.TextBox()
        Me.txtProid = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblunitinstock = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvShowdetail = New System.Windows.Forms.DataGridView()
        Me.proid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.protype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnOksale = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvShowdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSale)
        Me.Panel1.Controls.Add(Me.lblDatetime)
        Me.Panel1.Controls.Add(Me.lblEmployee)
        Me.Panel1.Controls.Add(Me.lblOrdernumber)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 143)
        Me.Panel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Navy
        Me.btnCancel.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Shutdown_48px
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(149, 30)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 81)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "ยกเลิกการขาย"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSale
        '
        Me.btnSale.BackColor = System.Drawing.Color.Transparent
        Me.btnSale.FlatAppearance.BorderSize = 0
        Me.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSale.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSale.ForeColor = System.Drawing.Color.Navy
        Me.btnSale.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Price_48px
        Me.btnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSale.Location = New System.Drawing.Point(54, 30)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(89, 81)
        Me.btnSale.TabIndex = 18
        Me.btnSale.Text = "เปิดบิลขาย"
        Me.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSale.UseVisualStyleBackColor = False
        '
        'lblDatetime
        '
        Me.lblDatetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDatetime.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatetime.ForeColor = System.Drawing.Color.Navy
        Me.lblDatetime.Location = New System.Drawing.Point(658, 30)
        Me.lblDatetime.Name = "lblDatetime"
        Me.lblDatetime.Size = New System.Drawing.Size(180, 31)
        Me.lblDatetime.TabIndex = 3
        Me.lblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.ForeColor = System.Drawing.Color.Navy
        Me.lblEmployee.Location = New System.Drawing.Point(413, 87)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(0, 31)
        Me.lblEmployee.TabIndex = 3
        Me.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdernumber
        '
        Me.lblOrdernumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrdernumber.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdernumber.ForeColor = System.Drawing.Color.Navy
        Me.lblOrdernumber.Location = New System.Drawing.Point(413, 30)
        Me.lblOrdernumber.Name = "lblOrdernumber"
        Me.lblOrdernumber.Size = New System.Drawing.Size(151, 31)
        Me.lblOrdernumber.TabIndex = 3
        Me.lblOrdernumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(597, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "วันที่ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(330, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ขายโดย :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(299, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "รหัสการขาย :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(51, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 31)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "รหัสลูกค้า :"
        '
        'txtCusid
        '
        Me.txtCusid.Location = New System.Drawing.Point(150, 31)
        Me.txtCusid.MaxLength = 4
        Me.txtCusid.Name = "txtCusid"
        Me.txtCusid.Size = New System.Drawing.Size(100, 22)
        Me.txtCusid.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(302, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 31)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ชื่อลูกค้า :"
        '
        'lblCus
        '
        Me.lblCus.AutoSize = True
        Me.lblCus.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCus.ForeColor = System.Drawing.Color.Navy
        Me.lblCus.Location = New System.Drawing.Point(388, 25)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(0, 31)
        Me.lblCus.TabIndex = 3
        Me.lblCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFindcus
        '
        Me.btnFindcus.BackColor = System.Drawing.Color.Transparent
        Me.btnFindcus.FlatAppearance.BorderSize = 0
        Me.btnFindcus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFindcus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindcus.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindcus.ForeColor = System.Drawing.Color.Navy
        Me.btnFindcus.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Find_User_Male_20px
        Me.btnFindcus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFindcus.Location = New System.Drawing.Point(256, 27)
        Me.btnFindcus.Name = "btnFindcus"
        Me.btnFindcus.Size = New System.Drawing.Size(40, 31)
        Me.btnFindcus.TabIndex = 18
        Me.btnFindcus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFindcus.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Navy
        Me.btnConfirm.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Ok_30px
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirm.Location = New System.Drawing.Point(655, 15)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(76, 64)
        Me.btnConfirm.TabIndex = 18
        Me.btnConfirm.Text = "ตกลง"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Navy
        Me.btnClear.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Cancel_30px
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(737, 15)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 64)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "ยกเลิก"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnFindcus)
        Me.Panel2.Controls.Add(Me.lblCus)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Controls.Add(Me.txtCusid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 90)
        Me.Panel2.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btnFindpro)
        Me.Panel3.Controls.Add(Me.lblTotalprice)
        Me.Panel3.Controls.Add(Me.lblProprice)
        Me.Panel3.Controls.Add(Me.lblProtype)
        Me.Panel3.Controls.Add(Me.btnRemove)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.lblModel)
        Me.Panel3.Controls.Add(Me.lblBrandname)
        Me.Panel3.Controls.Add(Me.txtProamount)
        Me.Panel3.Controls.Add(Me.txtProid)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblunitinstock)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1204, 151)
        Me.Panel3.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(49, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 31)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "รหัสสินค้า :"
        '
        'btnFindpro
        '
        Me.btnFindpro.BackColor = System.Drawing.Color.Transparent
        Me.btnFindpro.FlatAppearance.BorderSize = 0
        Me.btnFindpro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFindpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindpro.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindpro.ForeColor = System.Drawing.Color.Navy
        Me.btnFindpro.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Search_Property_20px
        Me.btnFindpro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFindpro.Location = New System.Drawing.Point(259, 24)
        Me.btnFindpro.Name = "btnFindpro"
        Me.btnFindpro.Size = New System.Drawing.Size(40, 31)
        Me.btnFindpro.TabIndex = 18
        Me.btnFindpro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFindpro.UseVisualStyleBackColor = False
        '
        'lblTotalprice
        '
        Me.lblTotalprice.AutoSize = True
        Me.lblTotalprice.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalprice.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalprice.Location = New System.Drawing.Point(791, 74)
        Me.lblTotalprice.Name = "lblTotalprice"
        Me.lblTotalprice.Size = New System.Drawing.Size(0, 31)
        Me.lblTotalprice.TabIndex = 3
        Me.lblTotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProprice
        '
        Me.lblProprice.AutoSize = True
        Me.lblProprice.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProprice.ForeColor = System.Drawing.Color.Navy
        Me.lblProprice.Location = New System.Drawing.Point(366, 74)
        Me.lblProprice.Name = "lblProprice"
        Me.lblProprice.Size = New System.Drawing.Size(0, 31)
        Me.lblProprice.TabIndex = 3
        Me.lblProprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProtype
        '
        Me.lblProtype.AutoSize = True
        Me.lblProtype.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtype.ForeColor = System.Drawing.Color.Navy
        Me.lblProtype.Location = New System.Drawing.Point(1027, 23)
        Me.lblProtype.Name = "lblProtype"
        Me.lblProtype.Size = New System.Drawing.Size(0, 31)
        Me.lblProtype.TabIndex = 3
        Me.lblProtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Navy
        Me.btnRemove.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Remove_30px
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(1058, 74)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(76, 64)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "ลบ"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Navy
        Me.btnAdd.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Add_Shopping_Cart_30px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(976, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 64)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "ใส่ตะกร้า"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Navy
        Me.lblModel.Location = New System.Drawing.Point(643, 20)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(0, 31)
        Me.lblModel.TabIndex = 3
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandname
        '
        Me.lblBrandname.AutoSize = True
        Me.lblBrandname.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandname.ForeColor = System.Drawing.Color.Navy
        Me.lblBrandname.Location = New System.Drawing.Point(366, 21)
        Me.lblBrandname.Name = "lblBrandname"
        Me.lblBrandname.Size = New System.Drawing.Size(0, 31)
        Me.lblBrandname.TabIndex = 3
        Me.lblBrandname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProamount
        '
        Me.txtProamount.Location = New System.Drawing.Point(567, 78)
        Me.txtProamount.MaxLength = 100
        Me.txtProamount.Name = "txtProamount"
        Me.txtProamount.Size = New System.Drawing.Size(64, 22)
        Me.txtProamount.TabIndex = 4
        '
        'txtProid
        '
        Me.txtProid.Location = New System.Drawing.Point(153, 28)
        Me.txtProid.MaxLength = 4
        Me.txtProid.Name = "txtProid"
        Me.txtProid.Size = New System.Drawing.Size(100, 22)
        Me.txtProid.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(300, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 31)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "ราคา :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(682, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 31)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "รวมเป็นเงิน :"
        '
        'lblunitinstock
        '
        Me.lblunitinstock.AutoSize = True
        Me.lblunitinstock.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitinstock.ForeColor = System.Drawing.Color.Navy
        Me.lblunitinstock.Location = New System.Drawing.Point(561, 107)
        Me.lblunitinstock.Name = "lblunitinstock"
        Me.lblunitinstock.Size = New System.Drawing.Size(0, 31)
        Me.lblunitinstock.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(405, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "จำนวนสินค้าในร้าน :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(489, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 31)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "จำนวน :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(903, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 31)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "ประเภทสินค้า :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(567, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 31)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Model :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(305, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 31)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ยี่ห้อ :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvShowdetail)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 384)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1204, 248)
        Me.Panel4.TabIndex = 21
        '
        'dgvShowdetail
        '
        Me.dgvShowdetail.AllowUserToAddRows = False
        Me.dgvShowdetail.AllowUserToDeleteRows = False
        Me.dgvShowdetail.AllowUserToResizeColumns = False
        Me.dgvShowdetail.AllowUserToResizeRows = False
        Me.dgvShowdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.proid, Me.brandname, Me.promod, Me.protype, Me.proprice, Me.proamount, Me.prototal})
        Me.dgvShowdetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvShowdetail.Location = New System.Drawing.Point(0, 0)
        Me.dgvShowdetail.Name = "dgvShowdetail"
        Me.dgvShowdetail.ReadOnly = True
        Me.dgvShowdetail.RowTemplate.Height = 24
        Me.dgvShowdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowdetail.Size = New System.Drawing.Size(1204, 248)
        Me.dgvShowdetail.TabIndex = 0
        '
        'proid
        '
        Me.proid.HeaderText = "รหัสสินค้า"
        Me.proid.MaxInputLength = 4
        Me.proid.Name = "proid"
        Me.proid.ReadOnly = True
        Me.proid.Width = 80
        '
        'brandname
        '
        Me.brandname.HeaderText = "ยี่ห้อ"
        Me.brandname.Name = "brandname"
        Me.brandname.ReadOnly = True
        '
        'promod
        '
        Me.promod.HeaderText = "Model"
        Me.promod.Name = "promod"
        Me.promod.ReadOnly = True
        Me.promod.Width = 380
        '
        'protype
        '
        Me.protype.HeaderText = "ประเภทสินค้า"
        Me.protype.Name = "protype"
        Me.protype.ReadOnly = True
        '
        'proprice
        '
        Me.proprice.HeaderText = "ราคา"
        Me.proprice.Name = "proprice"
        Me.proprice.ReadOnly = True
        '
        'proamount
        '
        Me.proamount.HeaderText = "จำนวน"
        Me.proamount.Name = "proamount"
        Me.proamount.ReadOnly = True
        Me.proamount.Width = 80
        '
        'prototal
        '
        Me.prototal.HeaderText = "ราคารวม"
        Me.prototal.Name = "prototal"
        Me.prototal.ReadOnly = True
        Me.prototal.Width = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(546, 673)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 49)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "รวมทั้งหมดเป็นเงิน :"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.BackColor = System.Drawing.Color.White
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNet.Location = New System.Drawing.Point(791, 664)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(99, 63)
        Me.lblNet.TabIndex = 3
        Me.lblNet.Text = "0.00"
        '
        'btnOksale
        '
        Me.btnOksale.BackColor = System.Drawing.Color.Transparent
        Me.btnOksale.FlatAppearance.BorderSize = 0
        Me.btnOksale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOksale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOksale.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOksale.ForeColor = System.Drawing.Color.Navy
        Me.btnOksale.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Cash_in_Hand_50px
        Me.btnOksale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOksale.Location = New System.Drawing.Point(1033, 651)
        Me.btnOksale.Name = "btnOksale"
        Me.btnOksale.Size = New System.Drawing.Size(76, 89)
        Me.btnOksale.TabIndex = 18
        Me.btnOksale.Text = "ยืนยัน"
        Me.btnOksale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOksale.UseVisualStyleBackColor = False
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1204, 754)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOksale)
        Me.Controls.Add(Me.lblNet)
        Me.Name = "frmSale"
        Me.Text = "Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvShowdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDatetime As Label
    Friend WithEvents lblOrdernumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSale As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblEmployee As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCusid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCus As Label
    Friend WithEvents btnFindcus As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnFindpro As Button
    Friend WithEvents lblModel As Label
    Friend WithEvents lblBrandname As Label
    Friend WithEvents txtProid As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblProtype As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalprice As Label
    Friend WithEvents lblProprice As Label
    Friend WithEvents txtProamount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvShowdetail As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents proid As DataGridViewTextBoxColumn
    Friend WithEvents brandname As DataGridViewTextBoxColumn
    Friend WithEvents promod As DataGridViewTextBoxColumn
    Friend WithEvents protype As DataGridViewTextBoxColumn
    Friend WithEvents proprice As DataGridViewTextBoxColumn
    Friend WithEvents proamount As DataGridViewTextBoxColumn
    Friend WithEvents prototal As DataGridViewTextBoxColumn
    Friend WithEvents lblNet As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOksale As Button
    Friend WithEvents lblunitinstock As Label
    Friend WithEvents Label4 As Label
End Class
