Imports System.Numerics

Public Class frmAddDG
    Private generator As DG

    Public Overloads Function ShowDialog(ByVal overloaded As Boolean, ByVal generator As DG) As DG
        Me.generator = generator
        setupForm()
        Me.ShowDialog()
        Return generator
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal generator As DG) As DG
        Dim tmp As New frmAddDG
        Return tmp.ShowDialog(overloaded:=True, New DG)
    End Function

    Private Function setupForm()
        txtNode.Text = generator.node
        txtPowerA_I.Text = generator.powerA.Imaginary.ToString
        txtPowerA_R.Text = generator.powerA.Real.ToString
        txtPowerB_I.Text = generator.powerB.Imaginary.ToString
        txtPowerB_R.Text = generator.powerB.Real.ToString
        txtPowerC_I.Text = generator.powerC.Imaginary.ToString
        txtPowerC_R.Text = generator.powerC.Real.ToString
        txtPfA.Text = generator.pfA
        txtPfB.Text = generator.pfB
        txtPfC.Text = generator.pfC
        cmbConnection.Text = generator.connection

        generator.isValid = False
    End Function

    Private Function validate()
        generator.isValid = True
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        validate()

        If generator.isValid Then
            generator.node = txtNode.Text
            generator.powerA = New Complex(txtPowerA_R.Text, txtPowerA_I.Text)
            generator.powerB = New Complex(txtPowerB_R.Text, txtPowerB_I.Text)
            generator.powerC = New Complex(txtPowerC_R.Text, txtPowerC_I.Text)
            generator.pfA = txtPfA.Text
            generator.pfB = txtPfB.Text
            generator.pfC = txtPfC.Text
            generator.connection = cmbConnection.Text

            Me.Close()
        End If
    End Sub
End Class