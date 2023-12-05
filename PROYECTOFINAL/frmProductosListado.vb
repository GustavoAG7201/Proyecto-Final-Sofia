﻿Imports System.Data.OleDb

Public Class frmProductosListado
    Private Sub frmProductosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListProductos()
    End Sub

    Private Sub ListProductos()
        Try

            conexion_.Open()

            Dim query As String = "SELECT id, producto, cantidad, fecha_venta, descripcion FROM productos"
            Dim COM As New OleDbCommand(query, conexion_)
            Dim LEC As OleDbDataReader = COM.ExecuteReader()
            Dim TABLA As New DataTable
            TABLA.Load(LEC)
            dgvListado.DataSource = TABLA
            conexion_.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion_.Close()
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Selected_row As Integer = dgvListado.CurrentRow.Cells(0).Value
        Dim response As Byte
        response = MsgBox("¿Está seguro de que desea eliminar este registro?", MsgBoxStyle.YesNo, "Eliminar")
        If response = 6 Then
            Try
                conexion_.Open()
                Dim query As String = "DELETE FROM productos WHERE id = " & Selected_row & ""

                Dim COM As New OleDbCommand(query, conexion_)
                COM.ExecuteNonQuery()
                conexion_.Close()

                MsgBox("Registro eliminado", MsgBoxStyle.Information, "eliminado")

                ListProductos()
                Me.dgvListado.CurrentRow.Selected = False
            Catch ex As Exception
                conexion_.Close()
                MsgBox("Error al eliminar el registro.", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub
End Class