Imports MySql.Data.MySqlClient

Public Class Mysqlconnection1
    'Private connection As New MySqlConnection("Server=database123.mysql.database.azure.com;;username=root;password=;database=test2;SslMode=none;")
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    Sub Openconnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub Closeconnection()
        If connection.State = ConnectionState.Closed Then
            connection.Close()
        End If
    End Sub

    Public Function getdata(ByVal query As String, ByVal parameters() As MySqlParameter) As DataTable

        Dim command As New MySqlCommand(query, connection)
        If parameters Is Nothing Then
            command.Parameters.AddRange(parameters)
        End If

        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function

    Public Function setdata(ByVal query As String, ByVal parameters() As MySqlParameter) As Integer

        Dim command As New MySqlCommand(query, connection)
        If parameters Is Nothing Then
            command.Parameters.AddRange(parameters)
        End If

        Openconnection()
        Dim commandstate As Integer = command.ExecuteNonQuery
        Closeconnection()
        Return commandstate


    End Function


End Class
