Imports System.Data.OleDb
Module Conexion

    Public conexion_ As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Andrea.accdb")

End Module
