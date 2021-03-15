Imports System.Numerics

Public Class Line
    Inherits Edge

    Public type As String = "Overhead"
    Public resistance As Double
    Public gmr As Double
    Public phases As Integer = 3
    Public length As Double = 1
    Public isNeutralAvailable As Boolean = True
    Public frequency As Integer = 50
    Public soilResistivity As Double = 100

    Public L_12 As Double = 0
    Public L_13 As Double = 0
    Public L_23 As Double = 0
    Public L_1N As Double = 0
    Public L_2N As Double = 0
    Public L_3N As Double = 0

    Public Sub New()

    End Sub

    Public Sub New(startNode As String, endNode As String, parameterString As String)
        Me.startNode = startNode
        Me.endNode = endNode

        Dim parameters As String() = parameterString.Split(New Char() {","c})
        Me.resistance = parameters(0)
        Me.gmr = parameters(1)
        Me.phases = parameters(2)
        Me.length = parameters(3)
        Me.isNeutralAvailable = parameters(4)
        Me.frequency = parameters(5)
        Me.soilResistivity = parameters(6)
        Me.type = parameters(7)
        Me.L_12 = parameters(8)
        Me.L_13 = parameters(9)
        Me.L_23 = parameters(10)
        Me.L_1N = parameters(11)
        Me.L_2N = parameters(12)
        Me.L_3N = parameters(13)

        If type = "O" Then
            Me.type = "Overhead"
        Else
            Me.type = "Underground"
        End If

    End Sub

    Public Function getParameters() As String
        Dim parameters = resistance.ToString + "," + gmr.ToString + "," + phases.ToString + "," + length.ToString + "," + isNeutralAvailable.ToString + "," + frequency.ToString + "," + soilResistivity.ToString + ","
        If type = "Overhead" Then
            parameters += "O,"
        Else
            parameters += "U,"
        End If
        parameters += L_12.ToString + "," + L_13.ToString + "," + L_23.ToString + "," + L_1N.ToString + "," + L_2N.ToString + "," + L_3N.ToString
        Return parameters
    End Function

    ' ----- Depricated -----
    Public Function calculateResistance()
        Dim R_11 = New Complex(0, 0)
        Dim R_22 = New Complex(0, 0)
        Dim R_33 = New Complex(0, 0)
        Dim R_NN = New Complex(0, 0)

        Dim R_12 = New Complex(0, 0)
        Dim R_13 = New Complex(0, 0)
        Dim R_1N = New Complex(0, 0)

        Dim R_23 = New Complex(0, 0)
        Dim R_2N = New Complex(0, 0)

        Dim R_3N = New Complex(0, 0)

        ' Carson Equations
        Dim R_ii = New Complex(resistance + 0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / gmr) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))

        If phases = 3 Then
            R_12 = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_12) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
            R_13 = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_13) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
            R_23 = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_23) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
        ElseIf phases = 2 Then
            R_12 = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_12) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
        End If

        If isNeutralAvailable Then
            If phases = 3 Then
                R_1N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
                R_2N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
                R_3N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
            ElseIf phases = 2 Then
                R_1N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
                R_2N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
            Else
                R_1N = New Complex(0.00158836 * frequency, 0.00202237 * frequency * (Math.Log(1 / L_1N) + 7.6786 + 0.5 * Math.Log(soilResistivity / frequency)))
            End If
        End If


        Dim zMatrix = R_ii.Real.ToString + "+" + R_ii.Imaginary.ToString + "j," + R_12.Real.ToString + "+" + R_12.Imaginary.ToString + "j," + R_13.Real.ToString + "+" + R_13.Imaginary.ToString + "j,"
        zMatrix = zMatrix + R_12.Real.ToString + "+" + R_12.Imaginary.ToString + "j," + R_ii.Real.ToString + "+" + R_ii.Imaginary.ToString + "j," + R_23.Real.ToString + "+" + R_23.Imaginary.ToString + "j,"
        zMatrix = zMatrix + R_13.Real.ToString + "+" + R_13.Imaginary.ToString + "j," + R_23.Real.ToString + "+" + R_23.Imaginary.ToString + "j," + R_ii.Real.ToString + "+" + R_ii.Imaginary.ToString + "j"

        Return zMatrix
    End Function
End Class
