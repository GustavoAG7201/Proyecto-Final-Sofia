Imports System.Data.OleDb
Public Class frmVentasAgregar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Cantidad As String = txtCantidad.Text
        Dim Descripcion As String = txtDescripcion.Text
        Dim Precio As String = txtPrecio.Text
        Dim Fecha_Venta As Date = dtpFechaVenta.Value
        Dim ID_Producto As String = cbID.Text

        Dim query As String

        If Cantidad = "" Or Descripcion = "" Or Precio = "" Then
            MsgBox("Favor de llenar el formulario", MsgBoxStyle.Critical, "Aviso")
        Else

            Try

                conexion_.Open()

                query = "INSERT INTO ventas (cantidad, id_producto, fecha_venta, descripcion, precio) 
VALUES ('" & Cantidad & "','" & ID_Producto & "','" & Fecha_Venta & "','" & Descripcion & "','" & Precio & "')"

                Dim COM As New OleDbCommand(query, conexion_)

                COM.ExecuteNonQuery()
                conexion_.Close()
                MsgBox("Registro Almacenado", MsgBoxStyle.Information, "Aviso")

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion_.Close()

            End Try
        End If
    End Sub

    Private Sub frmVentasAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class