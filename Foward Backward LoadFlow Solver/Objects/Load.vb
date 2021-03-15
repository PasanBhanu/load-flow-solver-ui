Imports System.Numerics

Public Class Load
    Inherits Node

    Public powerA As Complex
    Public powerB As Complex
    Public powerC As Complex
    Public cpq As Double
    Public cc As Double
    Public ci As Double

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
        Me.powerA = New Complex(voltage(0), voltage(1).Replace("j", 0))
        voltage = parameters(1).Split(New Char() {"+"c})
        Me.powerB = New Complex(voltage(0), voltage(1).Replace("j", 0))
        voltage = parameters(2).Split(New Char() {"+"c})
        Me.powerC = New Complex(voltage(0), voltage(1).Replace("j", 0))
        Me.cpq = parameters(3)
        Me.cc = parameters(4)
        Me.ci = parameters(5)
    End Sub

    Public Function getParameters() As String
        Dim parameters = powerA.Real.ToString + "+" + powerA.Imaginary.ToString + "j," + powerB.Real.ToString + "+" + powerB.Imaginary.ToString + "j," + powerC.Real.ToString + "+" + powerC.Imaginary.ToString + "j,"
        parameters += Me.cpq.ToString + "," + Me.cc.ToString + "," + Me.ci.ToString
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
