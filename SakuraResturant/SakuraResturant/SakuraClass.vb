Imports System.Data
Imports System.Data.Odbc
Public Class SakuraClass

    'Connection String
    Private ConnectionString As String = "Driver={MySQL ODBC 5.3 ANSI Driver}; server=141.209.241.47; database=bis635c1g3; user=bis635c1g3; password=initpass"
    'DB Connection Object - To access the database
    Private DBConnection As New OdbcConnection(ConnectionString)
    'DB (SQL) Commands
    Private DBCommand As OdbcCommand

    'Data Adapter - To execute the SQL commands
    Public DBDataAdapter As OdbcDataAdapter
    'Data Table
    Public DBDataTable As DataTable
    'Parameters
    Public Params As New List(Of OdbcParameter)
    'Record Count
    Public RecordCountInteger As Integer
    'Exception
    Public ExceptionString As String

    'To know which form is calling the next form
    Public CallingFormString, ReservationString, ChangePasswordString, OrderButtonString As String

    'Procedure to execute the query
    Public Sub ExecuteQuery(QueryString As String)
        RecordCountInteger = 0
        ExceptionString = String.Empty

        Try
            DBConnection.Open() 'Open the DB
            DBCommand = New OdbcCommand(QueryString, DBConnection) 'Execute the SQL command

            'Adds the required parameters to the SQL query
            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear() 'Clear the params

            'Get the datatable
            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCountInteger = DBDataAdapter.Fill(DBDataTable)

        Catch ex As Exception
            ExceptionString = ex.Message
        End Try

        'Close the DB connection
        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    'To add the parameters to query
    Public Sub AddParam(Name As String, Value As Object)

        Dim NewParam As New OdbcParameter(Name, Value)

        'Add the params into the parameters list
        Params.Add(NewParam)
    End Sub

End Class
