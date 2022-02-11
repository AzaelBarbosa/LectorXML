Imports System.Xml
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports ADODB
Module Module1
    'Declaro Variables Globales
    Public rutarchivos As String
    Public nombrearchivo As String
    Public nombrearchivoPDF As String
    Public folder As New FolderBrowserDialog
    Public ruta As String = ""
    Public SQLOracle As New ADODB.Connection
    Public ORACLEPasswordNOMBRE As String
    Public ORACLEUserNombre As String
    Public ORACLEDatabaseNombre As String
End Module
