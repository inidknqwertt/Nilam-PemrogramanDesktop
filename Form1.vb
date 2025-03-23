Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan item ke dalam ComboBox Jurusan
        cmbJurusan.Items.Add("Matematika")
        cmbJurusan.Items.Add("Kimia")
        cmbJurusan.Items.Add("Biologi")
        cmbJurusan.Items.Add("Fisika")
        cmbJurusan.Items.Add("Ilmu Komputer")

        ' Menambahkan item ke dalam ComboBox Mata Kuliah
        cmbMataKuliah.Items.Add("Kalkulus")
        cmbMataKuliah.Items.Add("Kimia Dasar")
        cmbMataKuliah.Items.Add("Biologi Umum")
        cmbMataKuliah.Items.Add("Fisika Dasar")
        cmbMataKuliah.Items.Add("Pemrograman Dasar")
    End Sub

    ' Validasi agar NIP hanya berisi angka
    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Mencegah input selain angka
        End If
    End Sub

    ' Tombol New: Membersihkan semua field dan mengaktifkan NIP
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNIP.Enabled = True
        txtNIP.Clear()
        txtNama.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        txtGRADE.Clear()
        cmbJurusan.SelectedIndex = -1
        cmbMataKuliah.SelectedIndex = -1
        rdoLaki.Checked = False
        rdoPr.Checked = False
        txtNIP.Focus()
    End Sub

    ' Tombol Save: Menyimpan atau memperbarui data di DataGridView1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validasi input
        If txtNIP.Text.Trim() = "" Or txtNama.Text.Trim() = "" Or txtTugas.Text.Trim() = "" Or txtUTS.Text.Trim() = "" Or txtUAS.Text.Trim() = "" Or cmbJurusan.SelectedIndex = -1 Or cmbMataKuliah.SelectedIndex = -1 Then
            MessageBox.Show("Harap isi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Mengambil data dari inputan
        Dim gender As String = If(rdoLaki.Checked, "Laki-Laki", "Perempuan")
        Dim tugas As Double = Convert.ToDouble(txtTugas.Text)
        Dim uts As Double = Convert.ToDouble(txtUTS.Text)
        Dim uas As Double = Convert.ToDouble(txtUAS.Text)
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)
        Dim grade As String = GetGrade(nilaiAkhir) ' Menentukan grade berdasarkan nilai
        txtGRADE.Text = grade

        ' Jika NIP baru, tambahkan data ke DataGridView1
        If txtNIP.Enabled Then
            DataGridView1.Rows.Add(txtNIP.Text, txtNama.Text, gender, cmbJurusan.Text, cmbMataKuliah.Text, grade)
        Else ' Jika NIP sudah ada, update data yang dipilih
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            row.SetValues(txtNIP.Text, txtNama.Text, gender, cmbJurusan.Text, cmbMataKuliah.Text, grade)
        End If

        btnNew_Click(sender, e) ' Bersihkan field setelah menyimpan
    End Sub

    ' Fungsi untuk menentukan grade berdasarkan nilai
    Private Function GetGrade(nilai As Double) As String
        If nilai >= 78 Then Return "A"
        If nilai >= 65 Then Return "B"
        If nilai >= 50 Then Return "C"
        If nilai >= 40 Then Return "D"
        Return "E"
    End Function

    ' Tombol Delete: Menghapus data yang dipilih dengan konfirmasi
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Pastikan DataGridView memiliki data dan ada baris yang dipilih
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data yang dapat dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Menampilkan pesan konfirmasi sebelum menghapus
        Dim result As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna menekan "Yes", hapus data
        If result = DialogResult.Yes Then
            ' Hapus baris yang dipilih
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            btnNew_Click(sender, e) ' Bersihkan field setelah menghapus
        End If
    End Sub


    ' Event untuk memilih data dari DataGridView1
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Jika baris yang diklik valid
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtNIP.Text = row.Cells(0).Value.ToString()
            txtNama.Text = row.Cells(1).Value.ToString()
            If row.Cells(2).Value.ToString() = "Laki-Laki" Then
                rdoLaki.Checked = True
            Else
                rdoPr.Checked = True
            End If
            cmbJurusan.Text = row.Cells(3).Value.ToString()
            cmbMataKuliah.Text = row.Cells(4).Value.ToString()
            txtGRADE.Text = row.Cells(5).Value.ToString()
            txtNIP.Enabled = False ' NIP tidak bisa diubah setelah dipilih
        End If
    End Sub

    ' Tombol Close: Menutup program
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
