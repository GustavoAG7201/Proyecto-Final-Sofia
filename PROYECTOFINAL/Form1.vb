Public Class Form1
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim AboutBox1 As New AboutBox1
        AboutBox1.MdiParent = Me
        AboutBox1.Show()

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Dim frmUsuariosAgregar As New frmUsuariosAgregar
        frmUsuariosAgregar.MdiParent = Me
        frmUsuariosAgregar.Show()
    End Sub

    Private Sub ListadpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadpToolStripMenuItem.Click
        Dim frmUsuariosListado As New frmUsuariosListado
        frmUsuariosListado.MdiParent = Me
        frmUsuariosListado.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Dim frmProductosAgregar As New frmProductosAgregar
        frmProductosAgregar.MdiParent = Me
        frmProductosAgregar.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim frmProductosListado As New frmProductosListado
        frmProductosListado.MdiParent = Me
        frmProductosListado.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem3.Click
        Dim frmVentasAgregar As New frmVentasAgregar
        frmVentasAgregar.MdiParent = Me
        frmVentasAgregar.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem2.Click

    End Sub
End Class
