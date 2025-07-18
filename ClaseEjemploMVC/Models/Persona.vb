﻿Imports System.ComponentModel.DataAnnotations

Public Class Persona
    Private _nombre As String
    Private _apellido As String
    Private _edad As Integer
    Private _direccion As String
    Private _telefono As String
    Private _email As String

    ' Constructor por defecto


    ' Constructor basico
    Public Sub New(nombre As String, apellido As String, email As String)
        _nombre = nombre
        _apellido = apellido
        _email = email
    End Sub

    ' Constructor completo
    Public Sub New(nombre As String, apellido As String, edad As Integer, direccion As String, telefono As String, email As String)
        _nombre = nombre
        _apellido = apellido
        _edad = edad
        _direccion = direccion
        _telefono = telefono
        _email = email
    End Sub

    Public Sub New(nombre As String, apellido As String)
        _nombre = nombre
        _apellido = apellido
    End Sub

    Public Sub New()
        _edad = 0
        _direccion = String.Empty
        _telefono = String.Empty
        _email = String.Empty
        _nombre = String.Empty
        _apellido = String.Empty
    End Sub

    Public Function NombreCompleto() As String
        Return $"{_nombre} {_apellido}"
    End Function

    ' Propiedades para acceder a los campos privados
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    <Required(ErrorMessage:="El apellido es necesario")>
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    <Required(ErrorMessage:="El correo es obligatorio")>
    <EmailAddress(ErrorMessage:="Correo invalido")>
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

End Class
