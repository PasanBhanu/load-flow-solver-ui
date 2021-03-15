Public Class frmAddLine

    Private line As Line

    ' *** Custom Dialog ***
    Public Overloads Function ShowDialog(ByVal overloaded As Boolean, ByVal line As Line) As Line
        Me.line = line
        setupForm()
        Me.ShowDialog()
        Return line
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal line As Line) As Line
        Dim tmp As New frmAddLine
        Return tmp.ShowDialog(overloaded:=True, New Line)
    End Function

    Private Function setupForm()
        txtStartNode.Text = line.startNode
        txtEndNode.Text = line.endNode
        txtResistance.Text = line.resistance
        txtGmr.Text = line.gmr
        txtLength.Text = line.length
        txtFrequency.Text = line.frequency
        txtSoilResistivity.Text = line.soilResistivity
        cmbType.Text = line.type
        cmbPhases.Text = line.phases
        chkNeutral.Checked = line.isNeutralAvailable
        txt12.Text = line.L_12
        txt13.Text = line.L_13
        txt23.Text = line.L_23
        txt1n.Text = line.L_1N
        txt2n.Text = line.L_2N
        txt3n.Text = line.L_3N
        line.isValid = False
    End Function

    Private Function validate()
        If txtStartNode.Text.Trim <> "" Then
            If txtEndNode.Text.Trim <> "" Then
                If txtResistance.Text <> "" Then
                    If txtGmr.Text.Trim <> "" Then
                        If txtLength.Text.Trim <> "" Then
                            If txtFrequency.Text.Trim <> "" Then
                                If txtSoilResistivity.Text.Trim <> "" Then
                                    If cmbPhases.SelectedIndex >= 0 Then
                                        If cmbType.SelectedIndex >= 0 Then
                                            line.isValid = True
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validate() Then
            line.startNode = txtStartNode.Text
            line.endNode = txtEndNode.Text
            line.resistance = txtResistance.Text
            line.gmr = txtGmr.Text
            line.length = txtLength.Text
            line.frequency = txtFrequency.Text
            line.soilResistivity = txtSoilResistivity.Text
            line.type = cmbType.Text
            line.phases = cmbPhases.Text
            line.isNeutralAvailable = chkNeutral.Checked
            line.L_12 = txt12.Text
            line.L_23 = txt23.Text
            line.L_13 = txt13.Text
            line.L_1N = txt1n.Text
            line.L_2N = txt2n.Text
            line.L_3N = txt3n.Text
            Me.Close()
        End If
    End Sub

    Private Sub chkNeutral_CheckedChanged(sender As Object, e As EventArgs) Handles chkNeutral.CheckedChanged
        If chkNeutral.CheckState = CheckState.Checked Then
            If cmbPhases.Text = 3 Then
                txt1n.Enabled = True
                txt2n.Enabled = True
                txt3n.Enabled = True
            ElseIf cmbPhases.Text = 2 Then
                txt1n.Enabled = True
                txt2n.Enabled = True
            Else
                txt1n.Enabled = True
            End If
        Else
            txt1n.Enabled = False
            txt2n.Enabled = False
            txt3n.Enabled = False
        End If
    End Sub

    Private Sub cmbPhases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhases.SelectedIndexChanged
        If cmbPhases.Text = 3 Then
            txt12.Enabled = True
            txt13.Enabled = True
            txt23.Enabled = True
        ElseIf cmbPhases.Text = 2 Then
            txt12.Enabled = True
            txt13.Enabled = False
            txt23.Enabled = False
        Else
            txt12.Enabled = False
            txt13.Enabled = False
            txt23.Enabled = False
        End If

        If chkNeutral.CheckState = CheckState.Checked Then
            If cmbPhases.Text = 3 Then
                txt1n.Enabled = True
                txt2n.Enabled = True
                txt3n.Enabled = True
            ElseIf cmbPhases.Text = 2 Then
                txt1n.Enabled = True
                txt2n.Enabled = True
            Else
                txt1n.Enabled = True
            End If
        Else
            txt1n.Enabled = False
            txt2n.Enabled = False
            txt3n.Enabled = False
        End If
    End Sub
End Class