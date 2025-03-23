<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNIP = New TextBox()
        txtNama = New TextBox()
        rdoLaki = New RadioButton()
        rdoPr = New RadioButton()
        cmbJurusan = New ComboBox()
        cmbMataKuliah = New ComboBox()
        txtTugas = New TextBox()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        txtGRADE = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnNew = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        DataGridView1 = New DataGridView()
        nip = New DataGridViewTextBoxColumn()
        nama = New DataGridViewTextBoxColumn()
        jeniskelamin = New DataGridViewTextBoxColumn()
        jurusan = New DataGridViewTextBoxColumn()
        matakuliah = New DataGridViewTextBoxColumn()
        grade = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 3
        Label4.Text = "Jurusan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 4
        Label5.Text = "Mata Kuliah"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 5
        Label6.Text = "Nilai"
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(177, 11)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(219, 27)
        txtNIP.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(177, 57)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(345, 27)
        txtNama.TabIndex = 7
        ' 
        ' rdoLaki
        ' 
        rdoLaki.AutoSize = True
        rdoLaki.Location = New Point(181, 107)
        rdoLaki.Name = "rdoLaki"
        rdoLaki.Size = New Size(88, 24)
        rdoLaki.TabIndex = 8
        rdoLaki.TabStop = True
        rdoLaki.Text = "Laki-Laki"
        rdoLaki.UseVisualStyleBackColor = True
        ' 
        ' rdoPr
        ' 
        rdoPr.AutoSize = True
        rdoPr.Location = New Point(318, 107)
        rdoPr.Name = "rdoPr"
        rdoPr.Size = New Size(104, 24)
        rdoPr.TabIndex = 9
        rdoPr.TabStop = True
        rdoPr.Text = "Perempuan"
        rdoPr.UseVisualStyleBackColor = True
        ' 
        ' cmbJurusan
        ' 
        cmbJurusan.FormattingEnabled = True
        cmbJurusan.Location = New Point(177, 151)
        cmbJurusan.Name = "cmbJurusan"
        cmbJurusan.Size = New Size(263, 28)
        cmbJurusan.TabIndex = 10
        ' 
        ' cmbMataKuliah
        ' 
        cmbMataKuliah.FormattingEnabled = True
        cmbMataKuliah.Location = New Point(177, 201)
        cmbMataKuliah.Name = "cmbMataKuliah"
        cmbMataKuliah.Size = New Size(329, 28)
        cmbMataKuliah.TabIndex = 11
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(231, 249)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(87, 27)
        txtTugas.TabIndex = 12
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(402, 249)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(85, 27)
        txtUTS.TabIndex = 13
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(565, 249)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(78, 27)
        txtUAS.TabIndex = 14
        ' 
        ' txtGRADE
        ' 
        txtGRADE.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGRADE.Location = New Point(721, 250)
        txtGRADE.Name = "txtGRADE"
        txtGRADE.Size = New Size(91, 27)
        txtGRADE.TabIndex = 15
        txtGRADE.Text = "-GRADE-"
        txtGRADE.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(177, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 20)
        Label7.TabIndex = 16
        Label7.Text = "Tugas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(361, 253)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 20)
        Label8.TabIndex = 17
        Label8.Text = "UTS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(522, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 20)
        Label9.TabIndex = 18
        Label9.Text = "UAS"
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(39, 302)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(94, 29)
        btnNew.TabIndex = 19
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(177, 302)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 20
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(328, 302)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(178, 29)
        btnDelete.TabIndex = 21
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(565, 302)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(292, 29)
        btnClose.TabIndex = 22
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nip, nama, jeniskelamin, jurusan, matakuliah, grade})
        DataGridView1.Location = New Point(39, 379)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1102, 188)
        DataGridView1.TabIndex = 23
        ' 
        ' nip
        ' 
        nip.HeaderText = "Nip"
        nip.MinimumWidth = 6
        nip.Name = "nip"
        nip.Width = 125
        ' 
        ' nama
        ' 
        nama.HeaderText = "Nama"
        nama.MinimumWidth = 6
        nama.Name = "nama"
        nama.Width = 300
        ' 
        ' jeniskelamin
        ' 
        jeniskelamin.HeaderText = "Jenis Kelamin"
        jeniskelamin.MinimumWidth = 6
        jeniskelamin.Name = "jeniskelamin"
        jeniskelamin.Width = 150
        ' 
        ' jurusan
        ' 
        jurusan.HeaderText = "Jurusan"
        jurusan.MinimumWidth = 6
        jurusan.Name = "jurusan"
        jurusan.Width = 150
        ' 
        ' matakuliah
        ' 
        matakuliah.HeaderText = "Mata Kuliah"
        matakuliah.MinimumWidth = 6
        matakuliah.Name = "matakuliah"
        matakuliah.Width = 200
        ' 
        ' grade
        ' 
        grade.HeaderText = "GRADE"
        grade.MinimumWidth = 6
        grade.Name = "grade"
        grade.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1201, 627)
        Controls.Add(DataGridView1)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtGRADE)
        Controls.Add(txtUAS)
        Controls.Add(txtUTS)
        Controls.Add(txtTugas)
        Controls.Add(cmbMataKuliah)
        Controls.Add(cmbJurusan)
        Controls.Add(rdoPr)
        Controls.Add(rdoLaki)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents rdoLaki As RadioButton
    Friend WithEvents rdoPr As RadioButton
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtGRADE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nip As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jeniskelamin As DataGridViewTextBoxColumn
    Friend WithEvents jurusan As DataGridViewTextBoxColumn
    Friend WithEvents matakuliah As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn

End Class
