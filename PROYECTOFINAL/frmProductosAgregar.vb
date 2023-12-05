Imports System.Data.OleDb
Public Class frmProductosAgregar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Producto As String = txtProducto.Text
        Dim Cantidad As String = cbCantidad.Text
        Dim Descripcion As String = txtDescripcion.Text
        Dim Fecha_Venta As Date = dtpFecha.Value

        Dim query As String

        If Producto = "" Or Cantidad = "" Or Descripcion = "" Then
            MsgBox("Favor de llenar el formulario", MsgBoxStyle.Critical, "Aviso")
        Else

            Try
                conexion_.Open()

                query = "INSERT INTO productos (producto, cantidad, fecha_venta, descripcion)
VALUES ('" & Producto & "','" & Cantidad & "','" & Fecha_Venta & "','" & Descripcion & "')"

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

    End Sub
End Class