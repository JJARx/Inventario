Imports System.Data
Imports System.Data.OleDb

Module ConexionBDViewModel
    Public conexion As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand


    Sub enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\BASE DE DATOS\BASEDATOS.accdb"
            conexion.Open()
            estado = "conectado"
        Catch ex As Exception
            estado = "desconectado"
        End Try
    End Sub
End Module
