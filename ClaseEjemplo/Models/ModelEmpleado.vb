Public Class ModelEmpleado
    Inherits Persona

    ' Atributos
    Private _puesto As String
    Private _fechaIngreso As DateTime
    Private _sueldo As Decimal
    Private _activo As Boolean

    ' Constructor
    Public Sub New()
        ' Llamar al constructor de la clase base
        MyBase.New()
        ' Inicializar valores por defecto
        _puesto = String.Empty
        _fechaIngreso = DateTime.Now
        _sueldo = 0D
        _activo = True
    End Sub

    ' Propiedades
    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property

    Public Property FechaIngreso As Date
        Get
            Return _fechaIngreso
        End Get
        Set(value As Date)
            _fechaIngreso = value
        End Set
    End Property

    Public Property Sueldo As Decimal
        Get
            Return _sueldo
        End Get
        Set(value As Decimal)
            _sueldo = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property
End Class
