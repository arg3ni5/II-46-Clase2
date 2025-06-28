Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("conexionDB").ConnectionString
    Public Function CreateEmpleado(Empleado As ModelEmpleado) As String
        Try
            Dim fechaDate As Date = Date.Now

            Dim query As String = "INSERT INTO Empleados (Nombre, Apellidos, Cargo, Salario) 
            VALUES (@Nombre, @Apellidos, @Cargo, @Salario)"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", Empleado.Nombre),
                New SqlParameter("@Apellidos", Empleado.Apellidos),
                New SqlParameter("@Cargo", Empleado.Puesto),
                New SqlParameter("@Salario", Empleado.Sueldo)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Persona creada exitosamente."
        Catch ex As FormatException
            Return "Formato de fecha inválido. Por favor, use el formato 'dd/MM/yyyy'."
        Catch ex As Exception
            Return "Error al crear el empleado: " & ex.Message
        End Try
    End Function

    Public Function EliminarEmpleado(id As Integer) As String

        Try
            Dim query As String = "DELETE FROM Empleados WHERE EmpleadoID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return "No se encontró el empleado con el ID especificado."
                    End If
                End Using
            End Using
            Return "Persona eliminada exitosamente."
        Catch ex As Exception
            Return "Error al eliminar el empleado: " & ex.Message
        End Try
    End Function

    Friend Function UpdateEmpleado(id As String, empleado As ModelEmpleado) As String
        Try
            Dim query As String = "UPDATE Empleados SET Nombre = @Nombre,
Apellidos = @Apellidos, Cargo = @Cargo, Salario = @Salario WHERE EmpleadoID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id),
                New SqlParameter("@Nombre", empleado.Nombre),
                New SqlParameter("@Apellidos", empleado.Apellidos),
                New SqlParameter("@Cargo", empleado.Puesto),
                New SqlParameter("@Salario", empleado.Sueldo)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Empleado actualizado exitosamente."
        Catch ex As Exception
            Return "Error al actualizar el empleado: " & ex.Message
        End Try
    End Function
End Class
