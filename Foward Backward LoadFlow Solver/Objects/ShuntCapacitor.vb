Imports System.Numerics

Public Class ShuntCapacitor
    Inherits Node

    Public voltageA As Complex
    Public voltageB As Complex
    Public voltageC As Complex
    Public kvarA As Complex
    Public kvarB As Complex
    Public kvarC As Complex

    Public Sub New()

    End Sub

    Public Sub New(node As String, connection As String, parameterString As String)
        Me.node = node
        If connection = "S" Then
            Me.connection = "Star"
        Else
            Me.connection = "Delta"
        End If

        Dim parameters As String() = parameterString.Split(New Char() {","c})
        Dim voltage As String()
        voltage = parameters(0).Split(New Char() {"+"c})
        Me.voltageA = New Complex(voltage(0), voltage(1).Replace("j", 0))
        voltage = parameters(1).Split(New Char() {"+"c})
        Me.voltageB = New Complex(voltage(0), voltage(1).Replace("j", 0))
        voltage = parameters(2).Split(New Char() {"+"c})
        Me.voltageC = New Complex(voltage(0), voltage(1).Replace("j", 0))
        Dim power As String()
        power = parameters(3).Split(New Char() {"+"c})
        Me.kvarA = New Complex(power(0), power(1).Replace("j", 0))
        power = parameters(4).Split(New Char() {"+"c})
        Me.kvarB = New Complex(power(0), power(1).Replace("j", 0))
        power = parameters(5).Split(New Char() {"+"c})
        Me.kvarC = New Complex(power(0), power(1).Replace("j", 0))
    End Sub

    Public Function getParameters() As String
        Dim parameters = voltageA.Real.ToString + "+" + voltageA.Imaginary.ToString + "j," + voltageB.Real.ToString + "+" + voltageB.Imaginary.ToString + "j," + voltageC.Real.ToString + "+" + voltageC.Imaginary.ToString + "j,"
        parameters += kvarA.Real.ToString + "+" + kvarA.Imaginary.ToString + "j," + kvarB.Real.ToString + "+" + kvarB.Imaginary.ToString + "j," + kvarC.Real.ToString + "+" + kvarC.Imaginary.ToString + "j,"
        Return parameters
    End Function

    Public Function getConnection() As String
        If Me.connection = "Star" Then
            Return "S"
        Else
            Return "D"
        End If
    End Function
End Class
