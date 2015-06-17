Module Module1
    Public Sub ExitApp()
        Dim Message As String 'T?o bi?n Message.

        'Gán B?ng thông báo cho bi?n Message.
        Message = MessageBox.Show( _
            "Bạn có muốn thoát?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hi?n thông báo xác nh?n thoát chuong trình.

        If (Message = Windows.Forms.DialogResult.Yes) Then
            'N?u ngu?i dùng ch?n Yes  thì thoát chuong trình.
            Application.Exit()
        End If 'Ðóng c?a s? ?ng d?ng.
    End Sub
End Module
