Imports System.Data.OleDb
Imports System.Windows.Markup

Public Class frmUsuariosAgregar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Usuario As String = txtUsuario.Text
        Dim Correo As String = txtCorreo.Text
        Dim Contrasena As String = txtContrasena.Text
        Dim ValidarContrasena As String = txtValidarContrasena.Text
        Dim Nombre As String = txtNombre.Text
        Dim ApellidoPaterno As String = txtPaterno.Text
        Dim ApellidoMaterno As String = txtMaterno.Text

        Dim query As String

        If Usuario = "" Or Correo = "" Or Contrasena = "" Then
            MsgBox("Favor de llenar el formulario", MsgBoxStyle.Critical, "Aviso")
        Else

            If Contrasena <> ValidarContrasena Then
                MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Aviso")
            Else

                Try
                    conexion_.Open()

                    query = "INSERT INTO usuarios (usuario, correo, contrasena, nombre, paterno, materno)
VALUES ('" & Usuario & "','" & Correo & "','" & Contrasena & "','" & Nombre & "','" & ApellidoPaterno & "','" & ApellidoMaterno & "')"

                    Dim COM As New OleDbCommand(query, conexion_)


                    COM.ExecuteNonQuery()
                    conexion_.Close()

                    MsgBox("Registro almacenado", MsgBoxStyle.Information, "Aviso")

                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conexion_.Close()
                End Try
            End If

        End If

    End Sub
End Class