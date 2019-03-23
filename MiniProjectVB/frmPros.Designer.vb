<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPros))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbobrand2 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvShowpro = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProbrand = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPromodel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radInverter = New System.Windows.Forms.RadioButton()
        Me.radNoninverter = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProbtu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProsystem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboProtype2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProdtbtcold = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProwarranty = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProprice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProamount = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvShowpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbobrand2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1486, 57)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ค้นหา :"
        '
        'cbobrand2
        '
        Me.cbobrand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobrand2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobrand2.FormattingEnabled = True
        Me.cbobrand2.Location = New System.Drawing.Point(97, 14)
        Me.cbobrand2.Name = "cbobrand2"
        Me.cbobrand2.Size = New System.Drawing.Size(205, 27)
        Me.cbobrand2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvShowpro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1486, 249)
        Me.Panel2.TabIndex = 5
        '
        'dgvShowpro
        '
        Me.dgvShowpro.AllowUserToAddRows = False
        Me.dgvShowpro.AllowUserToDeleteRows = False
        Me.dgvShowpro.AllowUserToResizeColumns = False
        Me.dgvShowpro.AllowUserToResizeRows = False
        Me.dgvShowpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowpro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvShowpro.Location = New System.Drawing.Point(0, 0)
        Me.dgvShowpro.Name = "dgvShowpro"
        Me.dgvShowpro.RowTemplate.Height = 24
        Me.dgvShowpro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowpro.Size = New System.Drawing.Size(1486, 249)
        Me.dgvShowpro.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(26, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสสินค้า :"
        '
        'txtProid
        '
        Me.txtProid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProid.Location = New System.Drawing.Point(126, 31)
        Me.txtProid.MaxLength = 4
        Me.txtProid.Name = "txtProid"
        Me.txtProid.Size = New System.Drawing.Size(110, 27)
        Me.txtProid.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(242, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ยี่ห้อ :"
        '
        'cboProbrand
        '
        Me.cboProbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProbrand.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProbrand.FormattingEnabled = True
        Me.cboProbrand.Location = New System.Drawing.Point(303, 31)
        Me.cboProbrand.Name = "cboProbrand"
        Me.cboProbrand.Size = New System.Drawing.Size(205, 27)
        Me.cboProbrand.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(514, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "รุ่น :"
        '
        'txtPromodel
        '
        Me.txtPromodel.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromodel.Location = New System.Drawing.Point(565, 31)
        Me.txtPromodel.Name = "txtPromodel"
        Me.txtPromodel.Size = New System.Drawing.Size(266, 27)
        Me.txtPromodel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(26, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ประเภทสินค้า :"
        '
        'radInverter
        '
        Me.radInverter.AutoSize = True
        Me.radInverter.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInverter.ForeColor = System.Drawing.Color.Navy
        Me.radInverter.Location = New System.Drawing.Point(653, 67)
        Me.radInverter.Name = "radInverter"
        Me.radInverter.Size = New System.Drawing.Size(45, 35)
        Me.radInverter.TabIndex = 6
        Me.radInverter.TabStop = True
        Me.radInverter.Text = "มี"
        Me.radInverter.UseVisualStyleBackColor = True
        '
        'radNoninverter
        '
        Me.radNoninverter.AutoSize = True
        Me.radNoninverter.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoninverter.ForeColor = System.Drawing.Color.Navy
        Me.radNoninverter.Location = New System.Drawing.Point(704, 67)
        Me.radNoninverter.Name = "radNoninverter"
        Me.radNoninverter.Size = New System.Drawing.Size(61, 35)
        Me.radNoninverter.TabIndex = 7
        Me.radNoninverter.TabStop = True
        Me.radNoninverter.Text = "ไม่มี"
        Me.radNoninverter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(297, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 31)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ขนาด BTU :"
        '
        'txtProbtu
        '
        Me.txtProbtu.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProbtu.Location = New System.Drawing.Point(404, 73)
        Me.txtProbtu.Name = "txtProbtu"
        Me.txtProbtu.Size = New System.Drawing.Size(104, 27)
        Me.txtProbtu.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(26, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 31)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ระบบฟองอากาศ :"
        '
        'txtProsystem
        '
        Me.txtProsystem.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProsystem.Location = New System.Drawing.Point(171, 115)
        Me.txtProsystem.Name = "txtProsystem"
        Me.txtProsystem.Size = New System.Drawing.Size(489, 27)
        Me.txtProsystem.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(516, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 31)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ระบบ Inverter :"
        '
        'cboProtype2
        '
        Me.cboProtype2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProtype2.FormattingEnabled = True
        Me.cboProtype2.Location = New System.Drawing.Point(150, 71)
        Me.cboProtype2.Name = "cboProtype2"
        Me.cboProtype2.Size = New System.Drawing.Size(141, 27)
        Me.cboProtype2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(26, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 31)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "ระบบกระจายความเย็น :"
        '
        'txtProdtbtcold
        '
        Me.txtProdtbtcold.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdtbtcold.Location = New System.Drawing.Point(212, 160)
        Me.txtProdtbtcold.Name = "txtProdtbtcold"
        Me.txtProdtbtcold.Size = New System.Drawing.Size(85, 27)
        Me.txtProdtbtcold.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(303, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 31)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "รับประกันCompressor(ปี) :"
        '
        'txtProwarranty
        '
        Me.txtProwarranty.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProwarranty.Location = New System.Drawing.Point(516, 160)
        Me.txtProwarranty.Name = "txtProwarranty"
        Me.txtProwarranty.Size = New System.Drawing.Size(43, 27)
        Me.txtProwarranty.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(26, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 31)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ราคา :"
        '
        'txtProprice
        '
        Me.txtProprice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProprice.Location = New System.Drawing.Point(92, 202)
        Me.txtProprice.Name = "txtProprice"
        Me.txtProprice.Size = New System.Drawing.Size(114, 27)
        Me.txtProprice.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(212, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 31)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "จำนวน :"
        '
        'txtProamount
        '
        Me.txtProamount.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProamount.Location = New System.Drawing.Point(290, 202)
        Me.txtProamount.Name = "txtProamount"
        Me.txtProamount.Size = New System.Drawing.Size(114, 27)
        Me.txtProamount.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Navy
        Me.btnDelete.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Minus_48px
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(787, 593)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 81)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Navy
        Me.btnEdit.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Edit_Property_48px
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(692, 593)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 81)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Navy
        Me.btnCancel.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Cancel_48px
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(1377, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 81)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Save_Close_48px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(1282, 184)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 81)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Navy
        Me.btnAdd.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(597, 593)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 81)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radNoninverter)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.radInverter)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtProamount)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtProprice)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtProwarranty)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtProdtbtcold)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtProsystem)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtProbtu)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtPromodel)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtProid)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cboProtype2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboProbrand)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1486, 281)
        Me.Panel3.TabIndex = 5
        '
        'frmPros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1486, 686)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPros"
        Me.Text = "Products"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvShowpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvShowpro As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtProid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProbrand As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPromodel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents radInverter As RadioButton
    Friend WithEvents radNoninverter As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProbtu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProsystem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboProtype2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProdtbtcold As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProwarranty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProprice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProamount As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbobrand2 As ComboBox
End Class
