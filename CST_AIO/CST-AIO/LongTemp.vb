Public Class LongTemp

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Performs Logic On the boxes and assembles the template
        'This template is then copied to the clipboard and announced
        'Declare Variables
        Dim LongTemplate(15) As String
        Dim TempString As String
        Dim IWMCheck As String
        Dim CamMainCheck As String
        Dim LeasedModem As String
        Dim LeasedRouter As String
        Dim LeasedWifiExt As String
        Dim UpsellOffer As String
        Dim MetallicTest As String
        Dim HSITest As String
        Dim MetallicTestAtClose As String

        'Perform Logic on Radio Buttons and Check Boxes
        If (rdbIWMY.Checked = True) Then
            IWMCheck = "Yes"
        Else
            IWMCheck = "No"
        End If
        If (rdbCamMaintY.Checked = True) Then
            CamMainCheck = "Yes"
        Else
            CamMainCheck = "No"
        End If
        If (ckbLeasedModem.Checked = True) Then
            LeasedModem = "Modem"
        End If
        If (ckbLeasedRouter.Checked = True) Then
            LeasedRouter = "Router"
        End If
        If (ckbLeasedWifiExt.Checked = True) Then
            LeasedWifiExt = "WiFi Ext"
        End If
        If (rdbUpsellY.Checked = True) Then
            UpsellOffer = "Yes"
        ElseIf (rdbUpsellN.Checked = True) Then
            UpsellOffer = "No"
        Else
            UpsellOffer = "NA"
        End If
        If (rdbMetallicPass.Checked = True) Then
            MetallicTest = "Pass"
        ElseIf (rdbMetallicFail.Checked = True) Then
            MetallicTest = "Fail"
        Else
            MetallicTest = "NA"
        End If
        If (rdbHSITestPass.Checked = True) Then
            HSITest = "Pass"
        ElseIf (rdbHSITestFail.Checked = True) Then
            HSITest = "Fail"
        Else
            HSITest = "NA"
        End If
        If (rdbMetallicAtClosePass.Checked = True) Then
            MetallicTestAtClose = "Pass"
        ElseIf (rdbMetallicAtCloseFail.Checked = True) Then
            MetallicTestAtClose = "Fail"
        Else
            MetallicTestAtClose = "NA"
        End If

        'Format and assemble the template into an array
        LongTemplate(0) = ("IWM= " + IWMCheck + ", Camera Maint.= " + CamMainCheck + ", HSI Provision Speed= " _
            + cmbHSIProvSpeed.Text + ", Sync Speed= " + txtSyncSpeed.Text + ", Footage= " + txtFootage.Text)
        LongTemplate(1) = ("Leased Equip= (" + LeasedModem + ", " + LeasedRouter + ", " _
            + LeasedWifiExt + "), Static IP= " + txtStaticIP.Text)
        LongTemplate(2) = ("Problem= " + rtxtProblem.Text)
        LongTemplate(3) = " "
        LongTemplate(4) = ("Related Trouble History= " + rtxtRelatedHist.Text)
        LongTemplate(5) = ("Metallic Testing= " + MetallicTest)
        LongTemplate(6) = rtxtMetallicResults.Text
        LongTemplate(7) = " "
        LongTemplate(8) = ("HSI Testing= " + HSITest)
        LongTemplate(9) = rtxtHSITestingResults.Text
        LongTemplate(10) = " "
        LongTemplate(11) = ("Solution= " + rtxtSolution.Text)
        LongTemplate(12) = ("Metallic Tests Pass At Close= " + MetallicTestAtClose)
        LongTemplate(13) = ("Upsell Offer= " + UpsellOffer)

        'Write the formated template to a String Then copy to the clipbaord and message box.
        TempString = (LongTemplate(0) + vbCrLf + LongTemplate(1) + vbCrLf + LongTemplate(2) _
                        + vbCrLf + LongTemplate(3) + vbCrLf + LongTemplate(4) + vbCrLf + LongTemplate(5) _
                        + vbCrLf + LongTemplate(6) + vbCrLf + LongTemplate(7) + vbCrLf + LongTemplate(8) _
                        + vbCrLf + LongTemplate(9) + vbCrLf + LongTemplate(10) + vbCrLf + LongTemplate(11) _
                        + vbCrLf + LongTemplate(12) + vbCrLf + LongTemplate(13))
        My.Computer.Clipboard.SetText(TempString)
        MessageBox.Show("The Following Note was copied to the clipboard." + vbCrLf + vbCrLf + TempString)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all radio buttons, checkboxes, and textboxes
        rdbIWMY.Checked = False
        rdbIWMN.Checked = False
        rdbCamMaintY.Checked = False
        rdbCamMaintN.Checked = False
        ckbLeasedModem.Checked = False
        ckbLeasedRouter.Checked = False
        ckbLeasedWifiExt.Checked = False
        rdbUpsellY.Checked = False
        rdbUpsellN.Checked = False
        rdbUpsellNA.Checked = False
        rdbMetallicPass.Checked = False
        rdbMetallicFail.Checked = False
        rdbMetallicNA.Checked = False
        rdbHSITestPass.Checked = False
        rdbHSITestFail.Checked = False
        rdbHSITestNA.Checked = False
        rdbMetallicAtClosePass.Checked = False
        rdbMetallicAtCloseFail.Checked = False
        rdbMetallicAtCloseNA.Checked = False
        cmbHSIProvSpeed.ResetText()
        txtSyncSpeed.Clear()
        txtFootage.Clear()
        txtStaticIP.Clear()
        rtxtProblem.Clear()
        rtxtRelatedHist.Clear()
        rtxtMetallicResults.Clear()
        rtxtHSITestingResults.Clear()
        rtxtSolution.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close Form
        Me.Close()
    End Sub

    Private Sub LongTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear all radio buttons, checkboxes, and textboxes on load
        rdbIWMY.Checked = False
        rdbIWMN.Checked = False
        rdbCamMaintY.Checked = False
        rdbCamMaintN.Checked = False
        ckbLeasedModem.Checked = False
        ckbLeasedRouter.Checked = False
        ckbLeasedWifiExt.Checked = False
        rdbUpsellY.Checked = False
        rdbUpsellN.Checked = False
        rdbUpsellNA.Checked = False
        rdbMetallicPass.Checked = False
        rdbMetallicFail.Checked = False
        rdbMetallicNA.Checked = False
        rdbHSITestPass.Checked = False
        rdbHSITestFail.Checked = False
        rdbHSITestNA.Checked = False
        rdbMetallicAtClosePass.Checked = False
        rdbMetallicAtCloseFail.Checked = False
        rdbMetallicAtCloseNA.Checked = False
        cmbHSIProvSpeed.ResetText()
        txtSyncSpeed.Clear()
        txtFootage.Clear()
        txtStaticIP.Clear()
        rtxtProblem.Clear()
        rtxtRelatedHist.Clear()
        rtxtMetallicResults.Clear()
        rtxtHSITestingResults.Clear()
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
        ElseIf rtxtMetallicResults.SelectedText <> "" Then
            rtxtMetallicResults.Cut()
        ElseIf rtxtHSITestingResults.SelectedText <> "" Then
            rtxtHSITestingResults.Cut()
        ElseIf rtxtSolution.SelectedText <> "" Then
            rtxtSolution.Cut()
        End If
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        If rtxtProblem.SelectedText <> "" Then
            rtxtProblem.Copy()
        ElseIf rtxtRelatedHist.SelectedText <> "" Then
            rtxtRelatedHist.Copy()
        ElseIf rtxtMetallicResults.SelectedText <> "" Then
            rtxtMetallicResults.Copy()
        ElseIf rtxtHSITestingResults.SelectedText <> "" Then
            rtxtHSITestingResults.Copy()
        ElseIf rtxtSolution.SelectedText <> "" Then
            rtxtSolution.Copy()
        End If
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Paste()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Paste()
        ElseIf rtxtMetallicResults.Focused() = True Then
            rtxtMetallicResults.Paste()
        ElseIf rtxtHSITestingResults.Focused() = True Then
            rtxtHSITestingResults.Paste()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Paste()
        End If
    End Sub

    Private Sub tsmiClearBox_Click(sender As Object, e As EventArgs) Handles tsmiClearBox.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Clear()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Clear()
        ElseIf rtxtMetallicResults.Focused() = True Then
            rtxtMetallicResults.Clear()
        ElseIf rtxtHSITestingResults.Focused() = True Then
            rtxtHSITestingResults.Clear()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Clear()
        End If
    End Sub

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click
        If rtxtProblem.Focused() = True Then
            rtxtProblem.Undo()
        ElseIf rtxtRelatedHist.Focused() = True Then
            rtxtRelatedHist.Undo()
        ElseIf rtxtMetallicResults.Focused() = True Then
            rtxtMetallicResults.Undo()
        ElseIf rtxtHSITestingResults.Focused() = True Then
            rtxtHSITestingResults.Undo()
        ElseIf rtxtSolution.Focused() = True Then
            rtxtSolution.Undo()
        End If
    End Sub
End Class