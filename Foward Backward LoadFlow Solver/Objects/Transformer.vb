Public Class Transformer
    Inherits Edge

    Public power As Double
    Public primaryVoltage As Double
    Public secondaryVoltage As Double
    Public percentageImpedance As Double
    Public phaseAngle As Double
    Public xrRatio As Double
    Public type As String
    Public Sub New()

    End Sub

    Public Sub New(startNode As String, endNode As String, parameterString As String)
        Me.startNode = startNode
        Me.endNode = endNode

        Dim parameters As String() = parameterString.Split(New Char() {","c})
        Me.power = parameters(0)
        Me.primaryVoltage = parameters(1)
        Me.secondaryVoltage = parameters(2)
        Me.percentageImpedance = parameters(3)
        Me.xrRatio = parameters(4)
        Me.type = parameters(5)
        Me.phaseAngle = parameters(6)
    End Sub

    Public Function getParameters() As String
        Dim parameters = power.ToString + "," + primaryVoltage.ToString + "," + secondaryVoltage.ToString + "," + percentageImpedance.ToString + "," + xrRatio.ToString + "," + type + "," + phaseAngle.ToString

        Return parameters
    End Function
End Class
