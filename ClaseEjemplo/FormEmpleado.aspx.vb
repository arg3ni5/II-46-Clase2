Imports Microsoft.Ajax.Utilities

Public Class FormEmpleado
    Inherits System.Web.UI.Page
    Protected dbHelper As New DatabaseHelper()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim empleados As DataTable = dbHelper.CargarEmpleados()
        'GvEmpleados.DataSource = empleados
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDEmpreado.Value.IsNullOrWhiteSpace Then
            'CREAR
            If DdlPuestos.SelectedIndex = 0 Then
                LblMensaje.Text = "Debe Seleccionar un Puesto"
            Else
                Dim empleado As New ModelEmpleado() With {
                    .Nombre = TxtNombre.Text,
                    .Apellidos = TxtApellidos.Text,
                    .Sueldo = Decimal.Parse(TxtSueldo.Text),
                    .Puesto = DdlPuestos.SelectedValue
                }
                Dim resultado As String = dbHelper.CreateEmpleado(empleado)
                LblMensaje.Text = resultado
                LimpiarFormulario()
                GvEmpleados.DataBind()
            End If
        Else
            'ACTUALIZAR
            Dim empleado As New ModelEmpleado() With {
                .Nombre = TxtNombre.Text,
                .Apellidos = TxtApellidos.Text,
                .Sueldo = Decimal.Parse(TxtSueldo.Text),
                .Puesto = DdlPuestos.SelectedValue
            }
            Dim resultado As String = dbHelper.UpdateEmpleado(IDEmpreado.Value, empleado)
            LblMensaje.Text = resultado
            LimpiarFormulario()
            IDEmpreado.Value = ""
            GvEmpleados.DataBind()
        End If


    End Sub

    Protected Sub LimpiarFormulario()
        TxtNombre.Text = ""
        TxtApellidos.Text = ""
        TxtSueldo.Text = ""
        DdlPuestos.SelectedIndex = 0
    End Sub

    Protected Sub GvEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvEmpleados.SelectedIndex
        Dim IdEmpleado As Integer = Convert.ToInt32(GvEmpleados.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvEmpleados.Rows(index)
            Dim empleado As New ModelEmpleado With {
                .Nombre = row.Cells(2).Text,
                .Apellidos = row.Cells(3).Text,
                .Puesto = row.Cells(4).Text,
                .Sueldo = Double.Parse(row.Cells(5).Text).ToString
            }
            IDEmpreado.Value = row.Cells(1).Text

            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombre.Text = empleado.Nombre

            If row.Cells(3).Text.IsNullOrWhiteSpace Then
                TxtApellidos.Text = ""
            Else
                TxtApellidos.Text = empleado.Apellidos
            End If

            DdlPuestos.SelectedValue = empleado.Puesto
            TxtSueldo.Text = empleado.Sueldo
        End If
    End Sub

    Protected Sub GvEmpleados_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id As Integer = Convert.ToInt32(GvEmpleados.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbHelper.EliminarEmpleado(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvEmpleados.DataBind()
    End Sub
End Class