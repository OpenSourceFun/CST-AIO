<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LongTemp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LongTemp))
        Me.cmbHSIProvSpeed = New System.Windows.Forms.ComboBox()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.ckbLeasedModem = New System.Windows.Forms.CheckBox()
        Me.ckbLeasedRouter = New System.Windows.Forms.CheckBox()
        Me.lblHSIProvSpeed = New System.Windows.Forms.Label()
        Me.ckbLeasedWifiExt = New System.Windows.Forms.CheckBox()
        Me.lblSyncSpeed = New System.Windows.Forms.Label()
        Me.lblFootage = New System.Windows.Forms.Label()
        Me.lblStaticIP = New System.Windows.Forms.Label()
        Me.txtStaticIP = New System.Windows.Forms.TextBox()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.lblRelatedHist = New System.Windows.Forms.Label()
        Me.rdbUpsellY = New System.Windows.Forms.RadioButton()
        Me.rdbUpsellN = New System.Windows.Forms.RadioButton()
        Me.rdbUpsellNA = New System.Windows.Forms.RadioButton()
        Me.rtxtProblem = New System.Windows.Forms.RichTextBox()
        Me.cmsEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClearBox = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtRelatedHist = New System.Windows.Forms.RichTextBox()
        Me.rdbIWMN = New System.Windows.Forms.RadioButton()
        Me.rdbIWMY = New System.Windows.Forms.RadioButton()
        Me.rtxtMetallicResults = New System.Windows.Forms.RichTextBox()
        Me.lblMetallicResults = New System.Windows.Forms.Label()
        Me.lblHSITestingResults = New System.Windows.Forms.Label()
        Me.rtxtHSITestingResults = New System.Windows.Forms.RichTextBox()
        Me.rdbCamMaintN = New System.Windows.Forms.RadioButton()
        Me.rdbCamMaintY = New System.Windows.Forms.RadioButton()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.rtxtSolution = New System.Windows.Forms.RichTextBox()
        Me.grpIWM = New System.Windows.Forms.GroupBox()
        Me.grpCamMaint = New System.Windows.Forms.GroupBox()
        Me.txtSyncSpeed = New System.Windows.Forms.TextBox()
        Me.grpLeasedEquip = New System.Windows.Forms.GroupBox()
        Me.grpUpsellOffer = New System.Windows.Forms.GroupBox()
        Me.grpMetallicTest = New System.Windows.Forms.GroupBox()
        Me.rdbMetallicPass = New System.Windows.Forms.RadioButton()
        Me.rdbMetallicFail = New System.Windows.Forms.RadioButton()
        Me.rdbMetallicNA = New System.Windows.Forms.RadioButton()
        Me.grpHSITesting = New System.Windows.Forms.GroupBox()
        Me.rdbHSITestPass = New System.Windows.Forms.RadioButton()
        Me.rdbHSITestFail = New System.Windows.Forms.RadioButton()
        Me.rdbHSITestNA = New System.Windows.Forms.RadioButton()
        Me.grpMetallicAtClose = New System.Windows.Forms.GroupBox()
        Me.rdbMetallicAtClosePass = New System.Windows.Forms.RadioButton()
        Me.rdbMetallicAtCloseFail = New System.Windows.Forms.RadioButton()
        Me.rdbMetallicAtCloseNA = New System.Windows.Forms.RadioButton()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ptcRTCLogo = New System.Windows.Forms.PictureBox()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.cmsEdit.SuspendLayout()
        Me.grpIWM.SuspendLayout()
        Me.grpCamMaint.SuspendLayout()
        Me.grpLeasedEquip.SuspendLayout()
        Me.grpUpsellOffer.SuspendLayout()
        Me.grpMetallicTest.SuspendLayout()
        Me.grpHSITesting.SuspendLayout()
        Me.grpMetallicAtClose.SuspendLayout()
        CType(Me.ptcRTCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbHSIProvSpeed
        '
        Me.cmbHSIProvSpeed.FormattingEnabled = True
        Me.cmbHSIProvSpeed.Items.AddRange(New Object() {"1.5Mbps ADSL", "6Long Loop ADSL", "6Mbps (res) ADSL", "6Mbps (biz) ADSL", "12Mbps ADSL", "12Mbps ADSL Bonded", "25Mbps ADSL Bonded", "25/5Mbps VDSL", "50/10Mbps VDSL", "50/10Mbps VDSL Bonded", "100/20Mbps VDSL", "100/20Mbps VDSL Bonded", "50/50Mbps FTTH", "100/100Mbps FTTH", "250/250Mbps FTTH", "1/1Gbps FTTH"})
        Me.cmbHSIProvSpeed.Location = New System.Drawing.Point(139, 65)
        Me.cmbHSIProvSpeed.Name = "cmbHSIProvSpeed"
        Me.cmbHSIProvSpeed.Size = New System.Drawing.Size(251, 21)
        Me.cmbHSIProvSpeed.TabIndex = 5
        '
        'txtFootage
        '
        Me.txtFootage.Location = New System.Drawing.Point(139, 118)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(251, 20)
        Me.txtFootage.TabIndex = 7
        '
        'ckbLeasedModem
        '
        Me.ckbLeasedModem.AutoSize = True
        Me.ckbLeasedModem.Location = New System.Drawing.Point(6, 17)
        Me.ckbLeasedModem.Name = "ckbLeasedModem"
        Me.ckbLeasedModem.Size = New System.Drawing.Size(61, 17)
        Me.ckbLeasedModem.TabIndex = 8
        Me.ckbLeasedModem.Text = "Modem"
        Me.ckbLeasedModem.UseVisualStyleBackColor = True
        '
        'ckbLeasedRouter
        '
        Me.ckbLeasedRouter.AutoSize = True
        Me.ckbLeasedRouter.Location = New System.Drawing.Point(93, 17)
        Me.ckbLeasedRouter.Name = "ckbLeasedRouter"
        Me.ckbLeasedRouter.Size = New System.Drawing.Size(58, 17)
        Me.ckbLeasedRouter.TabIndex = 9
        Me.ckbLeasedRouter.Text = "Router"
        Me.ckbLeasedRouter.UseVisualStyleBackColor = True
        '
        'lblHSIProvSpeed
        '
        Me.lblHSIProvSpeed.AutoSize = True
        Me.lblHSIProvSpeed.Location = New System.Drawing.Point(12, 68)
        Me.lblHSIProvSpeed.Name = "lblHSIProvSpeed"
        Me.lblHSIProvSpeed.Size = New System.Drawing.Size(105, 13)
        Me.lblHSIProvSpeed.TabIndex = 0
        Me.lblHSIProvSpeed.Text = "HSI Provision Speed"
        '
        'ckbLeasedWifiExt
        '
        Me.ckbLeasedWifiExt.AutoSize = True
        Me.ckbLeasedWifiExt.Location = New System.Drawing.Point(182, 161)
        Me.ckbLeasedWifiExt.Name = "ckbLeasedWifiExt"
        Me.ckbLeasedWifiExt.Size = New System.Drawing.Size(65, 17)
        Me.ckbLeasedWifiExt.TabIndex = 10
        Me.ckbLeasedWifiExt.Text = "WiFi Ext"
        Me.ckbLeasedWifiExt.UseVisualStyleBackColor = True
        '
        'lblSyncSpeed
        '
        Me.lblSyncSpeed.AutoSize = True
        Me.lblSyncSpeed.Location = New System.Drawing.Point(12, 95)
        Me.lblSyncSpeed.Name = "lblSyncSpeed"
        Me.lblSyncSpeed.Size = New System.Drawing.Size(90, 13)
        Me.lblSyncSpeed.TabIndex = 0
        Me.lblSyncSpeed.Text = "Sync/Link Speed"
        '
        'lblFootage
        '
        Me.lblFootage.AutoSize = True
        Me.lblFootage.Location = New System.Drawing.Point(12, 121)
        Me.lblFootage.Name = "lblFootage"
        Me.lblFootage.Size = New System.Drawing.Size(46, 13)
        Me.lblFootage.TabIndex = 0
        Me.lblFootage.Text = "Footage"
        '
        'lblStaticIP
        '
        Me.lblStaticIP.AutoSize = True
        Me.lblStaticIP.Location = New System.Drawing.Point(12, 193)
        Me.lblStaticIP.Name = "lblStaticIP"
        Me.lblStaticIP.Size = New System.Drawing.Size(47, 13)
        Me.lblStaticIP.TabIndex = 0
        Me.lblStaticIP.Text = "Static IP"
        '
        'txtStaticIP
        '
        Me.txtStaticIP.Location = New System.Drawing.Point(139, 190)
        Me.txtStaticIP.Name = "txtStaticIP"
        Me.txtStaticIP.Size = New System.Drawing.Size(251, 20)
        Me.txtStaticIP.TabIndex = 11
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Location = New System.Drawing.Point(12, 247)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(48, 13)
        Me.lblProblem.TabIndex = 0
        Me.lblProblem.Text = "Problem:"
        '
        'lblRelatedHist
        '
        Me.lblRelatedHist.AutoSize = True
        Me.lblRelatedHist.Location = New System.Drawing.Point(12, 315)
        Me.lblRelatedHist.Name = "lblRelatedHist"
        Me.lblRelatedHist.Size = New System.Drawing.Size(107, 13)
        Me.lblRelatedHist.TabIndex = 0
        Me.lblRelatedHist.Text = "Related Trouble Hist."
        '
        'rdbUpsellY
        '
        Me.rdbUpsellY.AutoSize = True
        Me.rdbUpsellY.Location = New System.Drawing.Point(6, 19)
        Me.rdbUpsellY.Name = "rdbUpsellY"
        Me.rdbUpsellY.Size = New System.Drawing.Size(43, 17)
        Me.rdbUpsellY.TabIndex = 14
        Me.rdbUpsellY.Text = "Yes"
        Me.rdbUpsellY.UseVisualStyleBackColor = True
        '
        'rdbUpsellN
        '
        Me.rdbUpsellN.AutoSize = True
        Me.rdbUpsellN.Location = New System.Drawing.Point(102, 19)
        Me.rdbUpsellN.Name = "rdbUpsellN"
        Me.rdbUpsellN.Size = New System.Drawing.Size(39, 17)
        Me.rdbUpsellN.TabIndex = 15
        Me.rdbUpsellN.Text = "No"
        Me.rdbUpsellN.UseVisualStyleBackColor = True
        '
        'rdbUpsellNA
        '
        Me.rdbUpsellNA.AutoSize = True
        Me.rdbUpsellNA.Location = New System.Drawing.Point(198, 19)
        Me.rdbUpsellNA.Name = "rdbUpsellNA"
        Me.rdbUpsellNA.Size = New System.Drawing.Size(40, 17)
        Me.rdbUpsellNA.TabIndex = 16
        Me.rdbUpsellNA.Text = "NA"
        Me.rdbUpsellNA.UseVisualStyleBackColor = True
        '
        'rtxtProblem
        '
        Me.rtxtProblem.ContextMenuStrip = Me.cmsEdit
        Me.rtxtProblem.Location = New System.Drawing.Point(139, 216)
        Me.rtxtProblem.Name = "rtxtProblem"
        Me.rtxtProblem.Size = New System.Drawing.Size(497, 75)
        Me.rtxtProblem.TabIndex = 12
        Me.rtxtProblem.Text = ""
        '
        'cmsEdit
        '
        Me.cmsEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUndo, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, Me.tsmiClearBox})
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(124, 114)
        '
        'tsmiUndo
        '
        Me.tsmiUndo.Name = "tsmiUndo"
        Me.tsmiUndo.Size = New System.Drawing.Size(123, 22)
        Me.tsmiUndo.Text = "Undo"
        '
        'tsmiCut
        '
        Me.tsmiCut.Name = "tsmiCut"
        Me.tsmiCut.Size = New System.Drawing.Size(123, 22)
        Me.tsmiCut.Text = "Cut"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.Size = New System.Drawing.Size(123, 22)
        Me.tsmiCopy.Text = "Copy"
        '
        'tsmiPaste
        '
        Me.tsmiPaste.Name = "tsmiPaste"
        Me.tsmiPaste.Size = New System.Drawing.Size(123, 22)
        Me.tsmiPaste.Text = "Paste"
        '
        'tsmiClearBox
        '
        Me.tsmiClearBox.Name = "tsmiClearBox"
        Me.tsmiClearBox.Size = New System.Drawing.Size(123, 22)
        Me.tsmiClearBox.Text = "Clear Box"
        '
        'rtxtRelatedHist
        '
        Me.rtxtRelatedHist.ContextMenuStrip = Me.cmsEdit
        Me.rtxtRelatedHist.Location = New System.Drawing.Point(139, 297)
        Me.rtxtRelatedHist.Name = "rtxtRelatedHist"
        Me.rtxtRelatedHist.Size = New System.Drawing.Size(497, 45)
        Me.rtxtRelatedHist.TabIndex = 13
        Me.rtxtRelatedHist.Text = ""
        '
        'rdbIWMN
        '
        Me.rdbIWMN.AutoSize = True
        Me.rdbIWMN.Location = New System.Drawing.Point(75, 18)
        Me.rdbIWMN.Name = "rdbIWMN"
        Me.rdbIWMN.Size = New System.Drawing.Size(39, 17)
        Me.rdbIWMN.TabIndex = 2
        Me.rdbIWMN.Text = "No"
        Me.rdbIWMN.UseVisualStyleBackColor = True
        '
        'rdbIWMY
        '
        Me.rdbIWMY.AutoSize = True
        Me.rdbIWMY.Location = New System.Drawing.Point(6, 18)
        Me.rdbIWMY.Name = "rdbIWMY"
        Me.rdbIWMY.Size = New System.Drawing.Size(43, 17)
        Me.rdbIWMY.TabIndex = 1
        Me.rdbIWMY.Text = "Yes"
        Me.rdbIWMY.UseVisualStyleBackColor = True
        '
        'rtxtMetallicResults
        '
        Me.rtxtMetallicResults.ContextMenuStrip = Me.cmsEdit
        Me.rtxtMetallicResults.Location = New System.Drawing.Point(139, 400)
        Me.rtxtMetallicResults.Name = "rtxtMetallicResults"
        Me.rtxtMetallicResults.Size = New System.Drawing.Size(497, 48)
        Me.rtxtMetallicResults.TabIndex = 20
        Me.rtxtMetallicResults.Text = ""
        '
        'lblMetallicResults
        '
        Me.lblMetallicResults.AutoSize = True
        Me.lblMetallicResults.Location = New System.Drawing.Point(12, 418)
        Me.lblMetallicResults.Name = "lblMetallicResults"
        Me.lblMetallicResults.Size = New System.Drawing.Size(105, 13)
        Me.lblMetallicResults.TabIndex = 0
        Me.lblMetallicResults.Text = "Metallic Test Results"
        '
        'lblHSITestingResults
        '
        Me.lblHSITestingResults.AutoSize = True
        Me.lblHSITestingResults.Location = New System.Drawing.Point(9, 527)
        Me.lblHSITestingResults.Name = "lblHSITestingResults"
        Me.lblHSITestingResults.Size = New System.Drawing.Size(87, 13)
        Me.lblHSITestingResults.TabIndex = 0
        Me.lblHSITestingResults.Text = "HSI Test Results"
        '
        'rtxtHSITestingResults
        '
        Me.rtxtHSITestingResults.ContextMenuStrip = Me.cmsEdit
        Me.rtxtHSITestingResults.Location = New System.Drawing.Point(139, 506)
        Me.rtxtHSITestingResults.Name = "rtxtHSITestingResults"
        Me.rtxtHSITestingResults.Size = New System.Drawing.Size(497, 48)
        Me.rtxtHSITestingResults.TabIndex = 24
        Me.rtxtHSITestingResults.Text = ""
        '
        'rdbCamMaintN
        '
        Me.rdbCamMaintN.AutoSize = True
        Me.rdbCamMaintN.Location = New System.Drawing.Point(75, 17)
        Me.rdbCamMaintN.Name = "rdbCamMaintN"
        Me.rdbCamMaintN.Size = New System.Drawing.Size(39, 17)
        Me.rdbCamMaintN.TabIndex = 4
        Me.rdbCamMaintN.Text = "No"
        Me.rdbCamMaintN.UseVisualStyleBackColor = True
        '
        'rdbCamMaintY
        '
        Me.rdbCamMaintY.AutoSize = True
        Me.rdbCamMaintY.Location = New System.Drawing.Point(6, 18)
        Me.rdbCamMaintY.Name = "rdbCamMaintY"
        Me.rdbCamMaintY.Size = New System.Drawing.Size(43, 17)
        Me.rdbCamMaintY.TabIndex = 3
        Me.rdbCamMaintY.Text = "Yes"
        Me.rdbCamMaintY.UseVisualStyleBackColor = True
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Location = New System.Drawing.Point(9, 581)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(91, 13)
        Me.lblSolution.TabIndex = 0
        Me.lblSolution.Text = "Solution (optional)"
        '
        'rtxtSolution
        '
        Me.rtxtSolution.ContextMenuStrip = Me.cmsEdit
        Me.rtxtSolution.Location = New System.Drawing.Point(139, 560)
        Me.rtxtSolution.Name = "rtxtSolution"
        Me.rtxtSolution.Size = New System.Drawing.Size(497, 48)
        Me.rtxtSolution.TabIndex = 25
        Me.rtxtSolution.Text = ""
        '
        'grpIWM
        '
        Me.grpIWM.Controls.Add(Me.rdbIWMN)
        Me.grpIWM.Controls.Add(Me.rdbIWMY)
        Me.grpIWM.Location = New System.Drawing.Point(12, 12)
        Me.grpIWM.Name = "grpIWM"
        Me.grpIWM.Size = New System.Drawing.Size(120, 41)
        Me.grpIWM.TabIndex = 1
        Me.grpIWM.TabStop = False
        Me.grpIWM.Text = "Inside Wire Maint."
        '
        'grpCamMaint
        '
        Me.grpCamMaint.Controls.Add(Me.rdbCamMaintN)
        Me.grpCamMaint.Controls.Add(Me.rdbCamMaintY)
        Me.grpCamMaint.Location = New System.Drawing.Point(139, 12)
        Me.grpCamMaint.Name = "grpCamMaint"
        Me.grpCamMaint.Size = New System.Drawing.Size(120, 41)
        Me.grpCamMaint.TabIndex = 3
        Me.grpCamMaint.TabStop = False
        Me.grpCamMaint.Text = "Camera Maint."
        '
        'txtSyncSpeed
        '
        Me.txtSyncSpeed.Location = New System.Drawing.Point(139, 92)
        Me.txtSyncSpeed.Name = "txtSyncSpeed"
        Me.txtSyncSpeed.Size = New System.Drawing.Size(251, 20)
        Me.txtSyncSpeed.TabIndex = 6
        '
        'grpLeasedEquip
        '
        Me.grpLeasedEquip.Controls.Add(Me.ckbLeasedModem)
        Me.grpLeasedEquip.Controls.Add(Me.ckbLeasedRouter)
        Me.grpLeasedEquip.Location = New System.Drawing.Point(12, 144)
        Me.grpLeasedEquip.Name = "grpLeasedEquip"
        Me.grpLeasedEquip.Size = New System.Drawing.Size(241, 40)
        Me.grpLeasedEquip.TabIndex = 8
        Me.grpLeasedEquip.TabStop = False
        Me.grpLeasedEquip.Text = "Leased Equipment"
        '
        'grpUpsellOffer
        '
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellY)
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellN)
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellNA)
        Me.grpUpsellOffer.Location = New System.Drawing.Point(12, 666)
        Me.grpUpsellOffer.Name = "grpUpsellOffer"
        Me.grpUpsellOffer.Size = New System.Drawing.Size(247, 46)
        Me.grpUpsellOffer.TabIndex = 14
        Me.grpUpsellOffer.TabStop = False
        Me.grpUpsellOffer.Text = "Upsell Offer"
        '
        'grpMetallicTest
        '
        Me.grpMetallicTest.Controls.Add(Me.rdbMetallicPass)
        Me.grpMetallicTest.Controls.Add(Me.rdbMetallicFail)
        Me.grpMetallicTest.Controls.Add(Me.rdbMetallicNA)
        Me.grpMetallicTest.Location = New System.Drawing.Point(12, 348)
        Me.grpMetallicTest.Name = "grpMetallicTest"
        Me.grpMetallicTest.Size = New System.Drawing.Size(247, 46)
        Me.grpMetallicTest.TabIndex = 17
        Me.grpMetallicTest.TabStop = False
        Me.grpMetallicTest.Text = "Metallic Test"
        '
        'rdbMetallicPass
        '
        Me.rdbMetallicPass.AutoSize = True
        Me.rdbMetallicPass.Location = New System.Drawing.Point(6, 19)
        Me.rdbMetallicPass.Name = "rdbMetallicPass"
        Me.rdbMetallicPass.Size = New System.Drawing.Size(48, 17)
        Me.rdbMetallicPass.TabIndex = 17
        Me.rdbMetallicPass.Text = "Pass"
        Me.rdbMetallicPass.UseVisualStyleBackColor = True
        '
        'rdbMetallicFail
        '
        Me.rdbMetallicFail.AutoSize = True
        Me.rdbMetallicFail.Location = New System.Drawing.Point(102, 19)
        Me.rdbMetallicFail.Name = "rdbMetallicFail"
        Me.rdbMetallicFail.Size = New System.Drawing.Size(41, 17)
        Me.rdbMetallicFail.TabIndex = 18
        Me.rdbMetallicFail.Text = "Fail"
        Me.rdbMetallicFail.UseVisualStyleBackColor = True
        '
        'rdbMetallicNA
        '
        Me.rdbMetallicNA.AutoSize = True
        Me.rdbMetallicNA.Location = New System.Drawing.Point(198, 19)
        Me.rdbMetallicNA.Name = "rdbMetallicNA"
        Me.rdbMetallicNA.Size = New System.Drawing.Size(40, 17)
        Me.rdbMetallicNA.TabIndex = 19
        Me.rdbMetallicNA.Text = "NA"
        Me.rdbMetallicNA.UseVisualStyleBackColor = True
        '
        'grpHSITesting
        '
        Me.grpHSITesting.Controls.Add(Me.rdbHSITestPass)
        Me.grpHSITesting.Controls.Add(Me.rdbHSITestFail)
        Me.grpHSITesting.Controls.Add(Me.rdbHSITestNA)
        Me.grpHSITesting.Location = New System.Drawing.Point(15, 454)
        Me.grpHSITesting.Name = "grpHSITesting"
        Me.grpHSITesting.Size = New System.Drawing.Size(247, 46)
        Me.grpHSITesting.TabIndex = 21
        Me.grpHSITesting.TabStop = False
        Me.grpHSITesting.Text = "HSI Testing"
        '
        'rdbHSITestPass
        '
        Me.rdbHSITestPass.AutoSize = True
        Me.rdbHSITestPass.Location = New System.Drawing.Point(6, 19)
        Me.rdbHSITestPass.Name = "rdbHSITestPass"
        Me.rdbHSITestPass.Size = New System.Drawing.Size(48, 17)
        Me.rdbHSITestPass.TabIndex = 21
        Me.rdbHSITestPass.Text = "Pass"
        Me.rdbHSITestPass.UseVisualStyleBackColor = True
        '
        'rdbHSITestFail
        '
        Me.rdbHSITestFail.AutoSize = True
        Me.rdbHSITestFail.Location = New System.Drawing.Point(102, 19)
        Me.rdbHSITestFail.Name = "rdbHSITestFail"
        Me.rdbHSITestFail.Size = New System.Drawing.Size(41, 17)
        Me.rdbHSITestFail.TabIndex = 22
        Me.rdbHSITestFail.Text = "Fail"
        Me.rdbHSITestFail.UseVisualStyleBackColor = True
        '
        'rdbHSITestNA
        '
        Me.rdbHSITestNA.AutoSize = True
        Me.rdbHSITestNA.Location = New System.Drawing.Point(198, 19)
        Me.rdbHSITestNA.Name = "rdbHSITestNA"
        Me.rdbHSITestNA.Size = New System.Drawing.Size(40, 17)
        Me.rdbHSITestNA.TabIndex = 23
        Me.rdbHSITestNA.Text = "NA"
        Me.rdbHSITestNA.UseVisualStyleBackColor = True
        '
        'grpMetallicAtClose
        '
        Me.grpMetallicAtClose.Controls.Add(Me.rdbMetallicAtClosePass)
        Me.grpMetallicAtClose.Controls.Add(Me.rdbMetallicAtCloseFail)
        Me.grpMetallicAtClose.Controls.Add(Me.rdbMetallicAtCloseNA)
        Me.grpMetallicAtClose.Location = New System.Drawing.Point(12, 614)
        Me.grpMetallicAtClose.Name = "grpMetallicAtClose"
        Me.grpMetallicAtClose.Size = New System.Drawing.Size(247, 46)
        Me.grpMetallicAtClose.TabIndex = 26
        Me.grpMetallicAtClose.TabStop = False
        Me.grpMetallicAtClose.Text = "Metallic Test at Closing (optional)"
        '
        'rdbMetallicAtClosePass
        '
        Me.rdbMetallicAtClosePass.AutoSize = True
        Me.rdbMetallicAtClosePass.Location = New System.Drawing.Point(6, 19)
        Me.rdbMetallicAtClosePass.Name = "rdbMetallicAtClosePass"
        Me.rdbMetallicAtClosePass.Size = New System.Drawing.Size(48, 17)
        Me.rdbMetallicAtClosePass.TabIndex = 26
        Me.rdbMetallicAtClosePass.Text = "Pass"
        Me.rdbMetallicAtClosePass.UseVisualStyleBackColor = True
        '
        'rdbMetallicAtCloseFail
        '
        Me.rdbMetallicAtCloseFail.AutoSize = True
        Me.rdbMetallicAtCloseFail.Location = New System.Drawing.Point(102, 19)
        Me.rdbMetallicAtCloseFail.Name = "rdbMetallicAtCloseFail"
        Me.rdbMetallicAtCloseFail.Size = New System.Drawing.Size(41, 17)
        Me.rdbMetallicAtCloseFail.TabIndex = 27
        Me.rdbMetallicAtCloseFail.Text = "Fail"
        Me.rdbMetallicAtCloseFail.UseVisualStyleBackColor = True
        '
        'rdbMetallicAtCloseNA
        '
        Me.rdbMetallicAtCloseNA.AutoSize = True
        Me.rdbMetallicAtCloseNA.Location = New System.Drawing.Point(198, 19)
        Me.rdbMetallicAtCloseNA.Name = "rdbMetallicAtCloseNA"
        Me.rdbMetallicAtCloseNA.Size = New System.Drawing.Size(40, 17)
        Me.rdbMetallicAtCloseNA.TabIndex = 28
        Me.rdbMetallicAtCloseNA.Text = "NA"
        Me.rdbMetallicAtCloseNA.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(183, 744)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(126, 23)
        Me.btnGenerate.TabIndex = 29
        Me.btnGenerate.Text = "Generate to Clipboard"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(315, 744)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(396, 744)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ptcRTCLogo
        '
        Me.ptcRTCLogo.Image = CType(resources.GetObject("ptcRTCLogo.Image"), System.Drawing.Image)
        Me.ptcRTCLogo.InitialImage = CType(resources.GetObject("ptcRTCLogo.InitialImage"), System.Drawing.Image)
        Me.ptcRTCLogo.Location = New System.Drawing.Point(296, 773)
        Me.ptcRTCLogo.Name = "ptcRTCLogo"
        Me.ptcRTCLogo.Size = New System.Drawing.Size(63, 50)
        Me.ptcRTCLogo.TabIndex = 32
        Me.ptcRTCLogo.TabStop = False
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.Location = New System.Drawing.Point(292, 826)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(70, 14)
        Me.lblCopyRight.TabIndex = 31
        Me.lblCopyRight.Text = "©RTC - 2018"
        '
        'LongTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(654, 844)
        Me.Controls.Add(Me.ptcRTCLogo)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.grpMetallicAtClose)
        Me.Controls.Add(Me.grpHSITesting)
        Me.Controls.Add(Me.ckbLeasedWifiExt)
        Me.Controls.Add(Me.grpMetallicTest)
        Me.Controls.Add(Me.grpUpsellOffer)
        Me.Controls.Add(Me.grpLeasedEquip)
        Me.Controls.Add(Me.txtSyncSpeed)
        Me.Controls.Add(Me.grpCamMaint)
        Me.Controls.Add(Me.grpIWM)
        Me.Controls.Add(Me.lblSolution)
        Me.Controls.Add(Me.rtxtSolution)
        Me.Controls.Add(Me.lblHSITestingResults)
        Me.Controls.Add(Me.rtxtHSITestingResults)
        Me.Controls.Add(Me.lblMetallicResults)
        Me.Controls.Add(Me.rtxtMetallicResults)
        Me.Controls.Add(Me.rtxtRelatedHist)
        Me.Controls.Add(Me.rtxtProblem)
        Me.Controls.Add(Me.lblRelatedHist)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.txtStaticIP)
        Me.Controls.Add(Me.lblStaticIP)
        Me.Controls.Add(Me.lblFootage)
        Me.Controls.Add(Me.lblSyncSpeed)
        Me.Controls.Add(Me.lblHSIProvSpeed)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.cmbHSIProvSpeed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LongTemp"
        Me.Text = "Long Template"
        Me.cmsEdit.ResumeLayout(False)
        Me.grpIWM.ResumeLayout(False)
        Me.grpIWM.PerformLayout()
        Me.grpCamMaint.ResumeLayout(False)
        Me.grpCamMaint.PerformLayout()
        Me.grpLeasedEquip.ResumeLayout(False)
        Me.grpLeasedEquip.PerformLayout()
        Me.grpUpsellOffer.ResumeLayout(False)
        Me.grpUpsellOffer.PerformLayout()
        Me.grpMetallicTest.ResumeLayout(False)
        Me.grpMetallicTest.PerformLayout()
        Me.grpHSITesting.ResumeLayout(False)
        Me.grpHSITesting.PerformLayout()
        Me.grpMetallicAtClose.ResumeLayout(False)
        Me.grpMetallicAtClose.PerformLayout()
        CType(Me.ptcRTCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbHSIProvSpeed As ComboBox
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents ckbLeasedModem As CheckBox
    Friend WithEvents ckbLeasedRouter As CheckBox
    Friend WithEvents lblHSIProvSpeed As Label
    Friend WithEvents ckbLeasedWifiExt As CheckBox
    Friend WithEvents lblSyncSpeed As Label
    Friend WithEvents lblFootage As Label
    Friend WithEvents lblStaticIP As Label
    Friend WithEvents txtStaticIP As TextBox
    Friend WithEvents lblProblem As Label
    Friend WithEvents lblRelatedHist As Label
    Friend WithEvents rdbUpsellY As RadioButton
    Friend WithEvents rdbUpsellN As RadioButton
    Friend WithEvents rdbUpsellNA As RadioButton
    Friend WithEvents rtxtProblem As RichTextBox
    Friend WithEvents rtxtRelatedHist As RichTextBox
    Friend WithEvents rdbIWMN As RadioButton
    Friend WithEvents rdbIWMY As RadioButton
    Friend WithEvents rtxtMetallicResults As RichTextBox
    Friend WithEvents lblMetallicResults As Label
    Friend WithEvents lblHSITestingResults As Label
    Friend WithEvents rtxtHSITestingResults As RichTextBox
    Friend WithEvents rdbCamMaintN As RadioButton
    Friend WithEvents rdbCamMaintY As RadioButton
    Friend WithEvents lblSolution As Label
    Friend WithEvents rtxtSolution As RichTextBox
    Friend WithEvents grpIWM As GroupBox
    Friend WithEvents grpCamMaint As GroupBox
    Friend WithEvents txtSyncSpeed As TextBox
    Friend WithEvents grpLeasedEquip As GroupBox
    Friend WithEvents grpUpsellOffer As GroupBox
    Friend WithEvents grpMetallicTest As GroupBox
    Friend WithEvents rdbMetallicPass As RadioButton
    Friend WithEvents rdbMetallicFail As RadioButton
    Friend WithEvents rdbMetallicNA As RadioButton
    Friend WithEvents grpHSITesting As GroupBox
    Friend WithEvents rdbHSITestPass As RadioButton
    Friend WithEvents rdbHSITestFail As RadioButton
    Friend WithEvents rdbHSITestNA As RadioButton
    Friend WithEvents grpMetallicAtClose As GroupBox
    Friend WithEvents rdbMetallicAtClosePass As RadioButton
    Friend WithEvents rdbMetallicAtCloseFail As RadioButton
    Friend WithEvents rdbMetallicAtCloseNA As RadioButton
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ptcRTCLogo As PictureBox
    Friend WithEvents lblCopyRight As Label
    Friend WithEvents cmsEdit As ContextMenuStrip
    Friend WithEvents tsmiCut As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiPaste As ToolStripMenuItem
    Friend WithEvents tsmiClearBox As ToolStripMenuItem
    Friend WithEvents tsmiUndo As ToolStripMenuItem
End Class
