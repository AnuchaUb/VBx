<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCus))
        Me.dgvShowcus = New System.Windows.Forms.DataGridView()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCusphone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuspostalcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCusprovince = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCusarea = New System.Windows.Forms.TextBox()
        Me.txtCussubarea = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCusaddress = New System.Windows.Forms.TextBox()
        Me.txtCusbirthday = New System.Windows.Forms.TextBox()
        Me.txtCuslname = New System.Windows.Forms.TextBox()
        Me.txtCusid = New System.Windows.Forms.TextBox()
        Me.txtCusname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSeach = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScuslname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScusname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvShowcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvShowcus
        '
        Me.dgvShowcus.AllowUserToAddRows = False
        Me.dgvShowcus.AllowUserToDeleteRows = False
        Me.dgvShowcus.AllowUserToResizeColumns = False
        Me.dgvShowcus.AllowUserToResizeRows = False
        Me.dgvShowcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowcus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvShowcus.Location = New System.Drawing.Point(0, 0)
        Me.dgvShowcus.Name = "dgvShowcus"
        Me.dgvShowcus.RowTemplate.Height = 24
        Me.dgvShowcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowcus.Size = New System.Drawing.Size(1357, 249)
        Me.dgvShowcus.TabIndex = 0
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.ForeColor = System.Drawing.Color.Navy
        Me.radFemale.Location = New System.Drawing.Point(830, 63)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(67, 35)
        Me.radFemale.TabIndex = 8
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.ForeColor = System.Drawing.Color.Navy
        Me.radMale.Location = New System.Drawing.Point(763, 63)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(61, 35)
        Me.radMale.TabIndex = 7
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Navy
        Me.btnDelete.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Denied_48px
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(759, 566)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 81)
        Me.btnDelete.TabIndex = 19
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
        Me.btnEdit.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Registration_48px
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(664, 566)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 81)
        Me.btnEdit.TabIndex = 18
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
        Me.btnCancel.Location = New System.Drawing.Point(1231, 153)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 81)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(221, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 31)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "นามสกุล :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 31)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "ชื่อ :"
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
        Me.btnSave.Location = New System.Drawing.Point(1136, 153)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 81)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "รหัสลูกค้า :"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Navy
        Me.btnAdd.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Add_User_Male_48px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(569, 566)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 81)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(461, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 31)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "ด/ว/ป เกิด :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(705, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 31)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "เพศ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(24, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 31)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "ที่อยู่ :"
        '
        'txtCusphone
        '
        Me.txtCusphone.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusphone.Location = New System.Drawing.Point(593, 155)
        Me.txtCusphone.MaxLength = 10
        Me.txtCusphone.Name = "txtCusphone"
        Me.txtCusphone.Size = New System.Drawing.Size(130, 27)
        Me.txtCusphone.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(517, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 31)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "ตำบล/แขวง :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(763, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 31)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "อำเภอ/เขต :"
        '
        'txtCuspostalcode
        '
        Me.txtCuspostalcode.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuspostalcode.Location = New System.Drawing.Point(344, 153)
        Me.txtCuspostalcode.MaxLength = 5
        Me.txtCuspostalcode.Name = "txtCuspostalcode"
        Me.txtCuspostalcode.Size = New System.Drawing.Size(119, 27)
        Me.txtCuspostalcode.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(24, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 31)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "จังหวัด :"
        '
        'txtCusprovince
        '
        Me.txtCusprovince.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusprovince.Location = New System.Drawing.Point(101, 153)
        Me.txtCusprovince.Name = "txtCusprovince"
        Me.txtCusprovince.Size = New System.Drawing.Size(116, 27)
        Me.txtCusprovince.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(223, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 31)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "รหัสไปรษณีย์ :"
        '
        'txtCusarea
        '
        Me.txtCusarea.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusarea.Location = New System.Drawing.Point(866, 111)
        Me.txtCusarea.Name = "txtCusarea"
        Me.txtCusarea.Size = New System.Drawing.Size(116, 27)
        Me.txtCusarea.TabIndex = 11
        '
        'txtCussubarea
        '
        Me.txtCussubarea.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCussubarea.Location = New System.Drawing.Point(630, 111)
        Me.txtCussubarea.Name = "txtCussubarea"
        Me.txtCussubarea.Size = New System.Drawing.Size(127, 27)
        Me.txtCussubarea.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(469, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 31)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "เบอร์โทรศัพท์ :"
        '
        'txtCusaddress
        '
        Me.txtCusaddress.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusaddress.Location = New System.Drawing.Point(85, 111)
        Me.txtCusaddress.Name = "txtCusaddress"
        Me.txtCusaddress.Size = New System.Drawing.Size(411, 27)
        Me.txtCusaddress.TabIndex = 9
        '
        'txtCusbirthday
        '
        Me.txtCusbirthday.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusbirthday.Location = New System.Drawing.Point(580, 67)
        Me.txtCusbirthday.Name = "txtCusbirthday"
        Me.txtCusbirthday.Size = New System.Drawing.Size(111, 27)
        Me.txtCusbirthday.TabIndex = 6
        '
        'txtCuslname
        '
        Me.txtCuslname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuslname.Location = New System.Drawing.Point(311, 67)
        Me.txtCuslname.Name = "txtCuslname"
        Me.txtCuslname.Size = New System.Drawing.Size(143, 27)
        Me.txtCuslname.TabIndex = 5
        '
        'txtCusid
        '
        Me.txtCusid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusid.Location = New System.Drawing.Point(144, 25)
        Me.txtCusid.MaxLength = 4
        Me.txtCusid.Name = "txtCusid"
        Me.txtCusid.Size = New System.Drawing.Size(110, 27)
        Me.txtCusid.TabIndex = 3
        '
        'txtCusname
        '
        Me.txtCusname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusname.Location = New System.Drawing.Point(72, 67)
        Me.txtCusname.Name = "txtCusname"
        Me.txtCusname.Size = New System.Drawing.Size(143, 27)
        Me.txtCusname.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSeach)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtScuslname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtScusname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1357, 57)
        Me.Panel1.TabIndex = 89
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Broom_30px
        Me.Button1.Location = New System.Drawing.Point(517, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 38)
        Me.Button1.TabIndex = 92
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSeach
        '
        Me.btnSeach.BackColor = System.Drawing.Color.Transparent
        Me.btnSeach.FlatAppearance.BorderSize = 0
        Me.btnSeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeach.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeach.ForeColor = System.Drawing.Color.Navy
        Me.btnSeach.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Search_30px
        Me.btnSeach.Location = New System.Drawing.Point(460, 8)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(51, 38)
        Me.btnSeach.TabIndex = 13
        Me.btnSeach.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSeach.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(221, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "นามสกุล :"
        '
        'txtScuslname
        '
        Me.txtScuslname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScuslname.Location = New System.Drawing.Point(311, 14)
        Me.txtScuslname.Name = "txtScuslname"
        Me.txtScuslname.Size = New System.Drawing.Size(143, 27)
        Me.txtScuslname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(24, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ชื่อ :"
        '
        'txtScusname
        '
        Me.txtScusname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScusname.Location = New System.Drawing.Point(72, 14)
        Me.txtScusname.Name = "txtScusname"
        Me.txtScusname.Size = New System.Drawing.Size(143, 27)
        Me.txtScusname.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvShowcus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1357, 249)
        Me.Panel2.TabIndex = 90
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCusname)
        Me.Panel3.Controls.Add(Me.radFemale)
        Me.Panel3.Controls.Add(Me.txtCusid)
        Me.Panel3.Controls.Add(Me.radMale)
        Me.Panel3.Controls.Add(Me.txtCuslname)
        Me.Panel3.Controls.Add(Me.txtCusbirthday)
        Me.Panel3.Controls.Add(Me.txtCusaddress)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtCussubarea)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtCusarea)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtCusprovince)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtCuspostalcode)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCusphone)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1357, 254)
        Me.Panel3.TabIndex = 91
        '
        'frmCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1357, 659)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCus"
        Me.Text = "Customers"
        CType(Me.dgvShowcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvShowcus As DataGridView
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCusphone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCuspostalcode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCusprovince As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCusarea As TextBox
    Friend WithEvents txtCussubarea As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCusaddress As TextBox
    Friend WithEvents txtCusbirthday As TextBox
    Friend WithEvents txtCuslname As TextBox
    Friend WithEvents txtCusid As TextBox
    Friend WithEvents txtCusname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtScuslname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScusname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSeach As Button
    Friend WithEvents Button1 As Button
End Class
