Imports System.Data.SqlClient

'***************************************************************************************
'Author: Triệu Quốc Duy.
'Description: Form Login của chương trình.
'***************************************************************************************

Public Class frmlogin

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        ExitApp()
    End Sub

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim chuoiketnoi As String = "workstation id=Duytqps02004.mssql.somee.com;packet size=4096;user id=ps02004;pwd=123456789;data source=Duytqps02004.mssql.somee.com;persist security info=False;initial catalog=Duytqps02004"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien='" & txtuser.Text & "' and Password='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                frmmain.Show()
                Me.Close()
            Else
                MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu, Xin bạn nhập lại")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
