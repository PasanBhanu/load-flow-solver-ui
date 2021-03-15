Imports System.Numerics

Public Class frmAddShuntCapacitor

    Private capacitor As ShuntCapacitor

    Public Overloads Function ShowDialog(ByVal overloaded As Boolean, ByVal capacitor As ShuntCapacitor) As ShuntCapacitor
        Me.capacitor = capacitor
        setupForm()
        Me.ShowDialog()
        Return capacitor
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal capacitor As ShuntCapacitor) As ShuntCapacitor
        Dim tmp As New frmAddShuntCapacitor
        Return tmp.ShowDialog(overloaded:=True, New ShuntCapacitor)
    End Function

    Private Function setupForm()
        txtNode.Text = capacitor.node
        txtPowerA_I.Text = capacitor.kvarA.Imaginary.ToString
        txtPowerA_R.Text = capacitor.kvarA.Real.ToString
        txtPowerB_I.Text = capacitor.kvarB.Imaginary.ToString
        txtPowerB_R.Text = capacitor.kvarB.Real.ToString
        txtPowerC_I.Text = capacitor.kvarC.Imaginary.ToString
        txtPowerC_R.Text = capacitor.kvarC.Real.ToString
        txtVoltageA_I.Text = capacitor.kvarA.Imaginary.ToString
        txtVoltageA_R.Text = capacitor.voltageA.Real.ToString
        txtVoltageB_I.Text = capacitor.voltageB.Imaginary.ToString
        txtVoltageB_R.Text = capacitor.voltageB.Real.ToString
        txtVoltageC_I.Text = capacitor.voltageC.Imaginary.ToString
        txtVoltageC_R.Text = capacitor.voltageC.Real.ToString
        cmbConnection.Text = capacitor.connection

        capacitor.isValid = False
    End Function

    Private Function validate()
        capacitor.isValid = True
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        validate()

        If capacitor.isValid Then
            capacitor.node = txtNode.Text
            capacitor.kvarA = New Complex(txtPowerA_R.Text, txtPowerA_I.Text)
            capacitor.kvarB = New Complex(txtPowerB_R.Text, txtPowerB_I.Text)
            capacitor.kvarC = New Complex(txtPowerC_R.Text, txtPowerC_I.Text)
            capacitor.voltageA = New Complex(txtVoltageA_R.Text, txtVoltageA_I.Text)
            capacitor.voltageB = New Complex(txtVoltageB_R.Text, txtVoltageB_I.Text)
            capacitor.voltageC = New Complex(txtVoltageC_R.Text, txtVoltageC_I.Text)
            capacitor.connection = cmbConnection.Text

            Me.Close()
        End If
    End Sub
End Class