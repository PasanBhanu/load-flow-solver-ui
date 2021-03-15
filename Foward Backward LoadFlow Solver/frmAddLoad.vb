Imports System.Numerics

Public Class frmAddLoad

    Private load As Load

    ' *** Custom Dialog ***
    Public Overloads Function ShowDialog(ByVal overloaded As Boolean, ByVal load As Load) As Load
        Me.load = load
        setupForm()
        Me.ShowDialog()
        Return load
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal load As Load) As Load
        Dim tmp As New frmAddLoad
        Return tmp.ShowDialog(overloaded:=True, New Load)
    End Function

    Private Function setupForm()
        txtNode.Text = load.node
        txtPowerA_I.Text = load.powerA.Imaginary.ToString
        txtPowerA_R.Text = load.powerA.Real.ToString
        txtPowerB_I.Text = load.powerB.Imaginary.ToString
        txtPowerB_R.Text = load.powerB.Real.ToString
        txtPowerC_I.Text = load.powerC.Imaginary.ToString
        txtPowerC_R.Text = load.powerC.Real.ToString
        txtCP.Text = load.cpq
        txtCC.Text = load.cc
        txtCI.Text = load.ci
        cmbConnection.Text = load.connection

        load.isValid = False
    End Function

    Private Function validate()
        If txtCP.Text.Trim <> "" Then
            If txtCC.Text.Trim <> "" Then
                If txtCI.Text <> "" Then
                    If cmbConnection.SelectedIndex >= 0 Then
                        load.isValid = True
                    End If
                End If
            End If
        End If
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        validate()

        If load.isValid Then
            load.node = txtNode.Text
            load.powerA = New Complex(txtPowerA_R.Text, txtPowerA_I.Text)
            load.powerB = New Complex(txtPowerB_R.Text, txtPowerB_I.Text)
            load.powerC = New Complex(txtPowerC_R.Text, txtPowerC_I.Text)
            load.cpq = txtCP.Text
            load.cc = txtCC.Text
            load.ci = txtCI.Text
            load.connection = cmbConnection.Text

            Me.Close()
        End If
    End Sub
End Class