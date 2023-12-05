Imports System.Data.OleDb
Public Class LoginForm2

    Private conexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.16.0;Data Source=" & Application.StartupPath & "\Andrea.accdb")
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String = txtUsuario.Text
        Dim password As String = txtContraseña.Text

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
