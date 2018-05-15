Public Class ShortTemp

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Performs Logic On the boxes and assembles the template
        'This template is then copied to the clipboard and announced
        'Declare Variables and perform logic
        Dim ShortTemplate(15) As String
        Dim TempString As String
        Dim UpsellOffer As String
        If (rdbUpsellY.Checked = True) Then
            UpsellOffer = "Yes"
        ElseIf (rdbUpsellN.Checked = True) Then
            UpsellOffer = "No"
        Else
            UpsellOffer = "NA"
        End If

        'Format and assemble the template into an array
        ShortTemplate(0) = ("Problem= " + rtxtProblem.Text)
        ShortTemplate(1) = " "
        ShortTemplate(2) = ("Related Trouble History= " + rtxtRelatedHist.Text)
        ShortTemplate(3) = ("Solution= " + rtxtSolution.Text)
        ShortTemplate(4) = ("Upsell Offer= " + UpsellOffer)

        'Write the formated template to a String Then copy to the clipbaord and message box.
        TempString = (ShortTemplate(0) + vbCrLf + ShortTemplate(1) + vbCrLf + ShortTemplate(2) _
                        + vbCrLf + ShortTemplate(3) + vbCrLf + ShortTemplate(4))
        My.Computer.Clipboard.SetText(TempString)
        MessageBox.Show("The Following Note was copied to the clipboard." + vbCrLf + vbCrLf + TempString)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear All Fields
        rdbUpsellY.Checked = False
        rdbUpsellN.Checked = False
        rdbUpsellNA.Checked = False
        rtxtProblem.Clear()
        rtxtRelatedHist.Clear()
        rtxtSolution.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close Form
        Me.Close()
    End Sub

    Private Sub ShortTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear All Fields on load.
        rdbUpsellY.Checked = False
        rdbUpsellN.Checked = False
        rdbUpsellNA.Checked = False
        rtxtProblem.Clear()
        rtxtRelatedHist.Clear()
        rtxtSolution.Clear()
    End Sub

    Private Sub ptcRTCLogo_Click(sender As Object, e As EventArgs) Handles ptcRTCLogo.Click
        Process.Start("https://www.rtctel.com/")
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click
        If rtxtProblem.SelectedText <> "" Then
            rtxtProblem.Cut()
        ElseIf rtxtRelatedHist.SelectedText <> "" Then
            rtxtRelatedHist.Cut()
        ElseIf rtxtSolution.SelectedText <> "" Then
            rtxtSolution.Cut()
        End If
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        If rtxtProblem.SelectedText <> "" Then
            rtxtProblem.Copy()
        ElseIf rtxtRelatedHist.SelectedText <> "" Then
            rtxtRelatedHist.Copy()
        ElseIf rtxtSolution.SelectedText <> "" Then
            rtxtSolution.Copy()
        End If
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Paste()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Paste()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Paste()
        End If
    End Sub

    Private Sub tsmiClearBox_Click(sender As Object, e As EventArgs) Handles tsmiClearBox.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Clear()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Clear()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Clear()
        End If
    End Sub

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Undo()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Undo()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Undo()
        End If
    End Sub
End Class