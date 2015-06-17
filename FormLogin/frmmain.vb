Public Class frmmain

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmlogin.ShowDialog()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HệThốngToolStripMenuItem.Click

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmquanlihoadon.ShowDialog()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmquanlisanpham.ShowDialog()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmquanlikhachhang.ShowDialog()
    End Sub

    Private Sub TàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TàiKhoảnToolStripMenuItem.Click
        frmquanlynhanvien.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class