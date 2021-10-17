Imports System.Data
Imports System.Data.OleDb

Module ConexionBDViewModel
    Public conexion As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand


    Sub enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources/BASEDATOS.accdb"
        Catch ex As Exception

        End Try
    End Sub
End Module
