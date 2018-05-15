'Customer Support Technician - All In One Launchpad
'Coded by: Preston Belford
'Original Date :  03/09/2017
'Written for: Ringgold Telephone Company
'Protected By: Creative Commons License 4.0

Public Class CSTAIO
    Private Sub btnLongTemp_Click(sender As Object, e As EventArgs) Handles btnLongTemp.Click
        'launches another form to complete the template.
        My.Forms.LongTemp.Show()
    End Sub

    Private Sub btnShortTemp_Click(sender As Object, e As EventArgs) Handles btnShortTemp.Click
        'launches another form to complete the template.
        My.Forms.ShortTemp.Show()
    End Sub

    Private Sub btnHDTemp_Click(sender As Object, e As EventArgs) Handles btnHDTemp.Click
        'launches another form to complete the template.
        My.Forms.HDTemp.Show()
    End Sub

    Private Sub btnScripts_Click(sender As Object, e As EventArgs) Handles btnScripts.Click
        'Launches browser to Scripts page
        Process.Start("")
    End Sub

    Private Sub btnDispatchPricing_Click(sender As Object, e As EventArgs) Handles btnDispatchPricing.Click
        'launces browser to the dispatch pricing page.
        Process.Start("")
    End Sub

    Private Sub btnRedPricing_Click(sender As Object, e As EventArgs) Handles btnRedPricing.Click
        'Launched browser to red pricing manual
        Process.Start("")
    End Sub

    Private Sub btnCallCenterMan_Click(sender As Object, e As EventArgs) Handles btnCallCenterMan.Click
        'Launches browser to callcenter manual 
        Process.Start("")
    End Sub

    Private Sub btnCustOP_Click(sender As Object, e As EventArgs) Handles btnCustOP.Click
        'launches browser to Customers Operations folder.
        Process.Start("")
    End Sub

    Private Sub btnFCCRegulations_Click(sender As Object, e As EventArgs) Handles btnFCCRegulations.Click
        'Launches browser to security manuals folder
        Process.Start("")
    End Sub

    Private Sub btnMetaview_Click(sender As Object, e As EventArgs) Handles btnMetaview.Click
        'Launches browser to the MetaView connection internally.
        Process.Start("")
    End Sub

    Private Sub btnNovaSubscriber_Click(sender As Object, e As EventArgs) Handles btnNovaSubscriber.Click
        'Launches browser to Nova Subscriber login on the neonova site.
        Process.Start("https://admin.neonova.net/index.php")
    End Sub

    Private Sub btnNovaTicketing_Click(sender As Object, e As EventArgs) Handles btnNovaTicketing.Click
        'Launches browser to Nova ticketing login on the neonova site.
        Process.Start("https://support.neonova.net/login.php")
    End Sub

    Private Sub btnConsumerConnect_Click(sender As Object, e As EventArgs) Handles btnConsumerConnect.Click
        'Launches browser to Consumer Connect login on the Calix website.
        Process.Start("https://calix.force.com/idp/login?app=0sp70000000001i#")
    End Sub

    Private Sub btnSAS_Click(sender As Object, e As EventArgs) Handles btnSAS.Click
        'Launches browser to SAS login on the Local SAS server.
        Process.Start("")
    End Sub

    Private Sub btnCoWeb_Click(sender As Object, e As EventArgs) Handles btnCoWeb.Click
        'Launches browser to COWEB call logs.
        Process.Start("")
    End Sub

    Private Sub btnNeustar_Click(sender As Object, e As EventArgs) Handles btnNeustar.Click
        'Launches browser to Neustar Call Center Page with a link to login.
        Process.Start("")
    End Sub

    Private Sub btnBandwidth_Click(sender As Object, e As EventArgs) Handles btnBandwidth.Click
        'Launches browser to Toly Digital login on the Toly site.
        Process.Start("https://support.bandwidth.com/hc/en-us/restricted?return_to=https%3A%2F%2Fsupport.bandwidth.com%2Fhc%2Fen-us%2Frequests%2Fnew")
    End Sub

    Private Sub btnSpecialCircuits_Click(sender As Object, e As EventArgs) Handles btnSpecialCircuits.Click
        'Launches browser to Special Ciruits Ticketing login site.
        Process.Start("")
    End Sub

    Private Sub btnCalix_Click(sender As Object, e As EventArgs) Handles btnCalix.Click
        'Launches the local CMS application installed in the default directory.
        Process.Start("C:\Program Files (x86)\Calix\EMSGui.exe")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close form
        Me.Close()
    End Sub

    Private Sub ptcRTCLogo_Click(sender As Object, e As EventArgs) Handles ptcRTCLogo.Click
        Process.Start("https://www.rtctel.com/")
    End Sub

    Private Sub trkbOpacity_Scroll(sender As Object, e As EventArgs) Handles trkbOpacity.Scroll
        'Uses the slider to change form opacity
        If trkbOpacity.Value = trkbOpacity.Maximum Then
            lblOpacity.Text = "Opacity 20%"
        ElseIf trkbOpacity.Value = trkbOpacity.Minimum Then
            lblOpacity.Text = "Opacity 100%"
        Else
            lblOpacity.Text = "Opacity " & trkbOpacity.Maximum - trkbOpacity.Value + 20 & "%"
        End If
        Me.Opacity = Val(trkbOpacity.Maximum - trkbOpacity.Value + 21) / 100

    End Sub

    Private Sub ckbOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckbOnTop.CheckedChanged
        'checks and unchecks always on top or top most function.
        If ckbOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub lblCopyRight_Click(sender As Object, e As EventArgs) Handles lblCopyRight.Click

    End Sub
End Class
