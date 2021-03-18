Public Class frmAddLine

    Private line As Line


    ' *** Custom Dialog ***
    Public Overloads Function ShowDialog(ByVal isEditor As Boolean, ByVal line As Line) As Line
        Me.line = line
        setupForm()
        If isEditor Then
            txtTitle.Text = "Transmission Line"
            txtDescription.Text = "Model Tx Line with Exact Line Model"
            txtTitle.ReadOnly = True
            txtDescription.ReadOnly = True
            txtStartNode.Enabled = True
            txtEndNode.Enabled = True
            btnLibrary.Visible = True
        Else
            txtStartNode.Text = 0
            txtEndNode.Text = 0
            txtStartNode.Enabled = False
            txtEndNode.Enabled = False
            btnLibrary.Visible = False
            txtTitle.ReadOnly = False
            txtDescription.ReadOnly = False
        End If
        Me.ShowDialog()
        Return line
    End Function

    Public Overloads Shared Function Show(ByVal overloaded As Boolean, ByVal line As Line) As Line
        Dim tmp As New frmAddLine
        Return tmp.ShowDialog(isEditor:=True, New Line)
    End Function

    Private Function setupForm()
        txtTitle.Text = line.title
        txtDescription.Text = line.description
        txtStartNode.Text = line.startNode
        txtEndNode.Text = line.endNode
        txtResistance_P.Text = line.resistance_p
        txtGmr_P.Text = line.gmr_p
        txtResistance_N.Text = line.resistance_n
        txtGmr_N.Text = line.gmr_n
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
        line.isValid = True
        Return True
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validate() Then
            line.title = txtTitle.Text
            line.description = txtDescription.Text
            line.startNode = txtStartNode.Text
            line.endNode = txtEndNode.Text
            line.resistance_p = txtResistance_P.Text
            line.gmr_p = txtGmr_P.Text
            line.resistance_n = txtResistance_N.Text
            line.gmr_n = txtGmr_N.Text
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
            txtGmr_N.Text = 0
            txtResistance_N.Text = 0
            txtGmr_N.Enabled = True
            txtResistance_N.Enabled = True
        Else
            txt1n.Enabled = False
            txt2n.Enabled = False
            txt3n.Enabled = False
            txtGmr_N.Text = 0
            txtResistance_N.Text = 0
            txtGmr_N.Enabled = False
            txtResistance_N.Enabled = False
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