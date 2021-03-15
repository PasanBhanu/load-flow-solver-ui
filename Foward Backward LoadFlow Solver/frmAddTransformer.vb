Public Class frmAddTransformer

    Private transformer As Transformer

    ' *** Custom Dialog ***
    Public Overloads Function ShowDialog(ByVal overloaded As Boolean, ByVal transformer As Transformer) As Transformer
        Me.transformer = transformer
        setupForm()
        Me.ShowDialog()
        Return transformer
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal transformer As Transformer) As Transformer
        Dim tmp As New frmAddTransformer
        Return tmp.ShowDialog(overloaded:=True, New Transformer)
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If validate() Then
            transformer.startNode = txtStartNode.Text
            transformer.endNode = txtEndNode.Text
            transformer.power = txtPower.Text
            transformer.primaryVoltage = txtPrimaryVoltage.Text
            transformer.secondaryVoltage = txtSecondaryVoltage.Text
            transformer.percentageImpedance = txtPercentageImpedance.Text
            transformer.phaseAngle = txtPhaseAngle.Text
            transformer.type = cmbType.Text
            transformer.xrRatio = txtXRRatio.Text
            Me.Close()
        End If

    End Sub

    Private Function setupForm()
        txtStartNode.Text = transformer.startNode
        txtEndNode.Text = transformer.endNode
        txtPower.Text = transformer.power
        txtPrimaryVoltage.Text = transformer.primaryVoltage
        txtSecondaryVoltage.Text = transformer.secondaryVoltage
        txtPercentageImpedance.Text = transformer.percentageImpedance
        txtPhaseAngle.Text = transformer.phaseAngle
        txtXRRatio.Text = transformer.xrRatio
        cmbType.Text = transformer.type
        transformer.isValid = False
    End Function

    Private Function validate()
        If txtStartNode.Text.Trim <> "" Then
            If txtEndNode.Text.Trim <> "" Then
                If txtPower.Text <> "" Then
                    If txtPrimaryVoltage.Text.Trim <> "" Then
                        If txtSecondaryVoltage.Text.Trim <> "" Then
                            If txtPercentageImpedance.Text.Trim <> "" Then
                                If txtPhaseAngle.Text.Trim <> "" Then
                                    If txtXRRatio.Text.Trim <> "" Then
                                        If cmbType.SelectedIndex >= 0 Then
                                            transformer.isValid = True
                                            Return True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        MsgBox("Please fill all the fields", MsgBoxStyle.Information, "Load Flow Calculator")
    End Function
End Class