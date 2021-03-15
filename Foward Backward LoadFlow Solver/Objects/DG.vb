Imports System.Numerics

Public Class DG
    Inherits Node

    Public powerA As Complex
    Public powerB As Complex
    Public powerC As Complex
    Public pfA As Double
    Public pfB As Double
    Public pfC As Double

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
        Dim power As String()
        power = parameters(0).Split(New Char() {"+"c})
        Me.powerA = New Complex(power(0), power(1).Replace("j", 0))
        power = parameters(1).Split(New Char() {"+"c})
        Me.powerB = New Complex(power(0), power(1).Replace("j", 0))
        power = parameters(2).Split(New Char() {"+"c})
        Me.powerC = New Complex(power(0), power(1).Replace("j", 0))
        Me.pfA = parameters(3)
        Me.pfB = parameters(4)
        Me.pfC = parameters(5)
    End Sub

    Public Function getParameters() As String
        Dim parameters = powerA.Real.ToString + "+" + powerA.Imaginary.ToString + "j," + powerB.Real.ToString + "+" + powerB.Imaginary.ToString + "j," + powerC.Real.ToString + "+" + powerC.Imaginary.ToString + "j,"
        parameters += Me.pfA.ToString + "," + Me.pfB.ToString + "," + Me.pfC.ToString
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
