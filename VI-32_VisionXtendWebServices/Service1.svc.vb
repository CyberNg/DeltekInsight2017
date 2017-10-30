Imports System.Xml
Imports System.Data.SqlClient

' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    'Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
    '    Return String.Format("You entered: {0}", value)
    'End Function

    'Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
    '    If composite Is Nothing Then
    '        Throw New ArgumentNullException("composite")
    '    End If
    '    If composite.BoolValue Then
    '        composite.StringValue &= "Suffix"
    '    End If
    '    Return composite
    'End Function
    Public Function timesheetVal(ByVal inData As String) As String Implements IService1.timesheetVal
        test()

        timesheetVal = "<errors warning=""y""><error>This is my first timesheet error</error></errors>"
    End Function

    Public Sub test()
        Dim connectionString As String
        Dim sqlConnection As SqlConnection

        connectionString = ConfigurationManager.ConnectionStrings("Vision").ConnectionString
        sqlConnection = New SqlConnection(connectionString)

        sqlConnection.Open()
        sqlConnection.Close()

        connectionString = Nothing
        sqlConnection = Nothing
    End Sub

    Public Sub OpenVisionConnection()
        Dim connectionString As String
        Dim sqlConnection As SqlConnection

        connectionString = ConfigurationManager.ConnectionStrings("Vision").ConnectionString
        sqlConnection = New SqlConnection(connectionString)

        sqlConnection.Open()
    End Sub
End Class
