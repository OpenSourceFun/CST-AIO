<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDTemp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDTemp))
        Me.grpUpsellOffer = New System.Windows.Forms.GroupBox()
        Me.rdbUpsellY = New System.Windows.Forms.RadioButton()
        Me.rdbUpsellN = New System.Windows.Forms.RadioButton()
        Me.rdbUpsellNA = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.rtxtSolution = New System.Windows.Forms.RichTextBox()
        Me.cmsEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClearBox = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtRelatedHist = New System.Windows.Forms.RichTextBox()
        Me.rtxtProblem = New System.Windows.Forms.RichTextBox()
        Me.lblRelatedHist = New System.Windows.Forms.Label()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUsersName = New System.Windows.Forms.TextBox()
        Me.txtCallBackNum = New System.Windows.Forms.TextBox()
        Me.lblCallBackNum = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDepartmentNum = New System.Windows.Forms.TextBox()
        Me.lblDepartmentNum = New System.Windows.Forms.Label()
        Me.txtAuthorizingManager = New System.Windows.Forms.TextBox()
        Me.lblAuthorizingManager = New System.Windows.Forms.Label()
        Me.ptcRTCLogo = New System.Windows.Forms.PictureBox()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.grpUpsellOffer.SuspendLayout()
        Me.cmsEdit.SuspendLayout()
        CType(Me.ptcRTCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUpsellOffer
        '
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellY)
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellN)
        Me.grpUpsellOffer.Controls.Add(Me.rdbUpsellNA)
        Me.grpUpsellOffer.Location = New System.Drawing.Point(149, 331)
        Me.grpUpsellOffer.Name = "grpUpsellOffer"
        Me.grpUpsellOffer.Size = New System.Drawing.Size(247, 46)
        Me.grpUpsellOffer.TabIndex = 8
        Me.grpUpsellOffer.TabStop = False
        Me.grpUpsellOffer.Text = "Upsell Offer"
        '
        'rdbUpsellY
        '
        Me.rdbUpsellY.AutoSize = True
        Me.rdbUpsellY.Location = New System.Drawing.Point(6, 19)
        Me.rdbUpsellY.Name = "rdbUpsellY"
        Me.rdbUpsellY.Size = New System.Drawing.Size(43, 17)
        Me.rdbUpsellY.TabIndex = 8
        Me.rdbUpsellY.Text = "Yes"
        Me.rdbUpsellY.UseVisualStyleBackColor = True
        '
        'rdbUpsellN
        '
        Me.rdbUpsellN.AutoSize = True
        Me.rdbUpsellN.Location = New System.Drawing.Point(102, 19)
        Me.rdbUpsellN.Name = "rdbUpsellN"
        Me.rdbUpsellN.Size = New System.Drawing.Size(39, 17)
        Me.rdbUpsellN.TabIndex = 9
        Me.rdbUpsellN.Text = "No"
        Me.rdbUpsellN.UseVisualStyleBackColor = True
        '
        'rdbUpsellNA
        '
        Me.rdbUpsellNA.AutoSize = True
        Me.rdbUpsellNA.Location = New System.Drawing.Point(198, 19)
        Me.rdbUpsellNA.Name = "rdbUpsellNA"
        Me.rdbUpsellNA.Size = New System.Drawing.Size(40, 17)
        Me.rdbUpsellNA.TabIndex = 10
        Me.rdbUpsellNA.Text = "NA"
        Me.rdbUpsellNA.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(391, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(310, 413)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(178, 413)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(126, 23)
        Me.btnGenerate.TabIndex = 12
        Me.btnGenerate.Text = "Generate to Clipboard"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Location = New System.Drawing.Point(12, 295)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(91, 13)
        Me.lblSolution.TabIndex = 0
        Me.lblSolution.Text = "Solution (optional)"
        '
        'rtxtSolution
        '
        Me.rtxtSolution.ContextMenuStrip = Me.cmsEdit
        Me.rtxtSolution.Location = New System.Drawing.Point(149, 277)
        Me.rtxtSolution.Name = "rtxtSolution"
        Me.rtxtSolution.Size = New System.Drawing.Size(497, 48)
        Me.rtxtSolution.TabIndex = 11
        Me.rtxtSolution.Text = ""
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
        Me.rtxtRelatedHist.Location = New System.Drawing.Point(149, 226)
        Me.rtxtRelatedHist.Name = "rtxtRelatedHist"
        Me.rtxtRelatedHist.Size = New System.Drawing.Size(497, 45)
        Me.rtxtRelatedHist.TabIndex = 7
        Me.rtxtRelatedHist.Text = ""
        '
        'rtxtProblem
        '
        Me.rtxtProblem.ContextMenuStrip = Me.cmsEdit
        Me.rtxtProblem.Location = New System.Drawing.Point(149, 145)
        Me.rtxtProblem.Name = "rtxtProblem"
        Me.rtxtProblem.Size = New System.Drawing.Size(497, 75)
        Me.rtxtProblem.TabIndex = 6
        Me.rtxtProblem.Text = ""
        '
        'lblRelatedHist
        '
        Me.lblRelatedHist.AutoSize = True
        Me.lblRelatedHist.Location = New System.Drawing.Point(12, 229)
        Me.lblRelatedHist.Name = "lblRelatedHist"
        Me.lblRelatedHist.Size = New System.Drawing.Size(107, 13)
        Me.lblRelatedHist.TabIndex = 0
        Me.lblRelatedHist.Text = "Related Trouble Hist."
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Location = New System.Drawing.Point(12, 148)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(48, 13)
        Me.lblProblem.TabIndex = 0
        Me.lblProblem.Text = "Problem:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(12, 18)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(87, 13)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Users Full Name:"
        '
        'txtUsersName
        '
        Me.txtUsersName.Location = New System.Drawing.Point(149, 15)
        Me.txtUsersName.Name = "txtUsersName"
        Me.txtUsersName.Size = New System.Drawing.Size(236, 20)
        Me.txtUsersName.TabIndex = 1
        '
        'txtCallBackNum
        '
        Me.txtCallBackNum.Location = New System.Drawing.Point(149, 41)
        Me.txtCallBackNum.Name = "txtCallBackNum"
        Me.txtCallBackNum.Size = New System.Drawing.Size(236, 20)
        Me.txtCallBackNum.TabIndex = 2
        '
        'lblCallBackNum
        '
        Me.lblCallBackNum.AutoSize = True
        Me.lblCallBackNum.Location = New System.Drawing.Point(12, 44)
        Me.lblCallBackNum.Name = "lblCallBackNum"
        Me.lblCallBackNum.Size = New System.Drawing.Size(95, 13)
        Me.lblCallBackNum.TabIndex = 0
        Me.lblCallBackNum.Text = "Call Back Number:"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(149, 67)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(236, 20)
        Me.txtDepartment.TabIndex = 3
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(12, 70)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Department:"
        '
        'txtDepartmentNum
        '
        Me.txtDepartmentNum.Location = New System.Drawing.Point(149, 93)
        Me.txtDepartmentNum.Name = "txtDepartmentNum"
        Me.txtDepartmentNum.Size = New System.Drawing.Size(236, 20)
        Me.txtDepartmentNum.TabIndex = 4
        '
        'lblDepartmentNum
        '
        Me.lblDepartmentNum.AutoSize = True
        Me.lblDepartmentNum.Location = New System.Drawing.Point(12, 96)
        Me.lblDepartmentNum.Name = "lblDepartmentNum"
        Me.lblDepartmentNum.Size = New System.Drawing.Size(131, 13)
        Me.lblDepartmentNum.TabIndex = 0
        Me.lblDepartmentNum.Text = "Department Main Number:"
        '
        'txtAuthorizingManager
        '
        Me.txtAuthorizingManager.Location = New System.Drawing.Point(149, 119)
        Me.txtAuthorizingManager.Name = "txtAuthorizingManager"
        Me.txtAuthorizingManager.Size = New System.Drawing.Size(236, 20)
        Me.txtAuthorizingManager.TabIndex = 5
        '
        'lblAuthorizingManager
        '
        Me.lblAuthorizingManager.AutoSize = True
        Me.lblAuthorizingManager.Location = New System.Drawing.Point(12, 122)
        Me.lblAuthorizingManager.Name = "lblAuthorizingManager"
        Me.lblAuthorizingManager.Size = New System.Drawing.Size(104, 13)
        Me.lblAuthorizingManager.TabIndex = 0
        Me.lblAuthorizingManager.Text = "Authorizing Manager"
        '
        'ptcRTCLogo
        '
        Me.ptcRTCLogo.Image = CType(resources.GetObject("ptcRTCLogo.Image"), System.Drawing.Image)
        Me.ptcRTCLogo.InitialImage = CType(resources.GetObject("ptcRTCLogo.InitialImage"), System.Drawing.Image)
        Me.ptcRTCLogo.Location = New System.Drawing.Point(298, 442)
        Me.ptcRTCLogo.Name = "ptcRTCLogo"
        Me.ptcRTCLogo.Size = New System.Drawing.Size(63, 50)
        Me.ptcRTCLogo.TabIndex = 58
        Me.ptcRTCLogo.TabStop = False
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.Location = New System.Drawing.Point(294, 495)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(70, 14)
        Me.lblCopyRight.TabIndex = 0
        Me.lblCopyRight.Text = "©RTC - 2018"
        '
        'HDTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(658, 513)
        Me.Controls.Add(Me.ptcRTCLogo)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.txtAuthorizingManager)
        Me.Controls.Add(Me.lblAuthorizingManager)
        Me.Controls.Add(Me.txtDepartmentNum)
        Me.Controls.Add(Me.lblDepartmentNum)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.txtCallBackNum)
        Me.Controls.Add(Me.lblCallBackNum)
        Me.Controls.Add(Me.txtUsersName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.grpUpsellOffer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblSolution)
        Me.Controls.Add(Me.rtxtSolution)
        Me.Controls.Add(Me.rtxtRelatedHist)
        Me.Controls.Add(Me.rtxtProblem)
        Me.Controls.Add(Me.lblRelatedHist)
        Me.Controls.Add(Me.lblProblem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HDTemp"
        Me.Text = "Help Desk Template"
        Me.grpUpsellOffer.ResumeLayout(False)
        Me.grpUpsellOffer.PerformLayout()
        Me.cmsEdit.ResumeLayout(False)
        CType(Me.ptcRTCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpUpsellOffer As GroupBox
    Friend WithEvents rdbUpsellY As RadioButton
    Friend WithEvents rdbUpsellN As RadioButton
    Friend WithEvents rdbUpsellNA As RadioButton
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblSolution As Label
    Friend WithEvents rtxtSolution As RichTextBox
    Friend WithEvents rtxtRelatedHist As RichTextBox
    Friend WithEvents rtxtProblem As RichTextBox
    Friend WithEvents lblRelatedHist As Label
    Friend WithEvents lblProblem As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUsersName As TextBox
    Friend WithEvents txtCallBackNum As TextBox
    Friend WithEvents lblCallBackNum As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtDepartmentNum As TextBox
    Friend WithEvents lblDepartmentNum As Label
    Friend WithEvents txtAuthorizingManager As TextBox
    Friend WithEvents lblAuthorizingManager As Label
    Friend WithEvents ptcRTCLogo As PictureBox
    Friend WithEvents lblCopyRight As Label
    Friend WithEvents cmsEdit As ContextMenuStrip
    Friend WithEvents tsmiUndo As ToolStripMenuItem
    Friend WithEvents tsmiCut As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiPaste As ToolStripMenuItem
    Friend WithEvents tsmiClearBox As ToolStripMenuItem
End Class
