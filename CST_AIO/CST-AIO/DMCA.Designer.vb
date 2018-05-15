<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DMCA))
        Me.btnDMCADocs = New System.Windows.Forms.Button()
        Me.btnDMCAsFolder = New System.Windows.Forms.Button()
        Me.cmbSelectForm = New System.Windows.Forms.ComboBox()
        Me.lblSelectForm = New System.Windows.Forms.Label()
        Me.txtCustLast = New System.Windows.Forms.TextBox()
        Me.txtYourName = New System.Windows.Forms.TextBox()
        Me.txtYourTitle = New System.Windows.Forms.TextBox()
        Me.rtxtDMCAEmail = New System.Windows.Forms.RichTextBox()
        Me.lblCustFirst = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.lblManagerName = New System.Windows.Forms.Label()
        Me.lblManagerTitle = New System.Windows.Forms.Label()
        Me.lblDMCACompany = New System.Windows.Forms.Label()
        Me.rtxtCustAddress = New System.Windows.Forms.RichTextBox()
        Me.txtDMCACompany = New System.Windows.Forms.TextBox()
        Me.lblCopyrightHolder = New System.Windows.Forms.Label()
        Me.lblDMCAEmail = New System.Windows.Forms.Label()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtCustFirst = New System.Windows.Forms.TextBox()
        Me.txtInfringmentID = New System.Windows.Forms.TextBox()
        Me.lblCustLast = New System.Windows.Forms.Label()
        Me.lblInfringmentID = New System.Windows.Forms.Label()
        Me.cmbCopyrightHolder = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnDMCADocs
        '
        Me.btnDMCADocs.Location = New System.Drawing.Point(117, 12)
        Me.btnDMCADocs.Name = "btnDMCADocs"
        Me.btnDMCADocs.Size = New System.Drawing.Size(142, 23)
        Me.btnDMCADocs.TabIndex = 1
        Me.btnDMCADocs.Text = "DMCA Docs Folder"
        Me.btnDMCADocs.UseVisualStyleBackColor = True
        '
        'btnDMCAsFolder
        '
        Me.btnDMCAsFolder.Location = New System.Drawing.Point(265, 12)
        Me.btnDMCAsFolder.Name = "btnDMCAsFolder"
        Me.btnDMCAsFolder.Size = New System.Drawing.Size(116, 23)
        Me.btnDMCAsFolder.TabIndex = 2
        Me.btnDMCAsFolder.Text = "DMCAs Folder"
        Me.btnDMCAsFolder.UseVisualStyleBackColor = True
        '
        'cmbSelectForm
        '
        Me.cmbSelectForm.AllowDrop = True
        Me.cmbSelectForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectForm.FormattingEnabled = True
        Me.cmbSelectForm.Items.AddRange(New Object() {"DMCA (able to contact customer)", "DMCA (No contact with customer)", "2nd Offense (able to contact customer)", "2nd Offense (No contact with customer)", "3rd Offense (able to contact customer)", "3rd Offense (No contact with customer)", "CEGTEK"})
        Me.cmbSelectForm.Location = New System.Drawing.Point(153, 42)
        Me.cmbSelectForm.Name = "cmbSelectForm"
        Me.cmbSelectForm.Size = New System.Drawing.Size(333, 21)
        Me.cmbSelectForm.TabIndex = 3
        '
        'lblSelectForm
        '
        Me.lblSelectForm.AutoSize = True
        Me.lblSelectForm.Location = New System.Drawing.Point(12, 45)
        Me.lblSelectForm.Name = "lblSelectForm"
        Me.lblSelectForm.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectForm.TabIndex = 0
        Me.lblSelectForm.Text = "Select a Document"
        '
        'txtCustLast
        '
        Me.txtCustLast.Location = New System.Drawing.Point(153, 95)
        Me.txtCustLast.Name = "txtCustLast"
        Me.txtCustLast.Size = New System.Drawing.Size(333, 20)
        Me.txtCustLast.TabIndex = 5
        '
        'txtYourName
        '
        Me.txtYourName.Location = New System.Drawing.Point(153, 176)
        Me.txtYourName.Name = "txtYourName"
        Me.txtYourName.Size = New System.Drawing.Size(333, 20)
        Me.txtYourName.TabIndex = 7
        Me.txtYourName.Text = "Irene Garcia"
        '
        'txtYourTitle
        '
        Me.txtYourTitle.Location = New System.Drawing.Point(153, 202)
        Me.txtYourTitle.Name = "txtYourTitle"
        Me.txtYourTitle.Size = New System.Drawing.Size(333, 20)
        Me.txtYourTitle.TabIndex = 8
        Me.txtYourTitle.Text = "Customer Operations Manager"
        '
        'rtxtDMCAEmail
        '
        Me.rtxtDMCAEmail.Location = New System.Drawing.Point(15, 326)
        Me.rtxtDMCAEmail.Name = "rtxtDMCAEmail"
        Me.rtxtDMCAEmail.Size = New System.Drawing.Size(471, 179)
        Me.rtxtDMCAEmail.TabIndex = 12
        Me.rtxtDMCAEmail.Text = " "
        '
        'lblCustFirst
        '
        Me.lblCustFirst.AutoSize = True
        Me.lblCustFirst.Location = New System.Drawing.Point(12, 72)
        Me.lblCustFirst.Name = "lblCustFirst"
        Me.lblCustFirst.Size = New System.Drawing.Size(111, 13)
        Me.lblCustFirst.TabIndex = 0
        Me.lblCustFirst.Text = "Customer's First Name"
        '
        'lblCustAddress
        '
        Me.lblCustAddress.AutoSize = True
        Me.lblCustAddress.Location = New System.Drawing.Point(12, 124)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.Size = New System.Drawing.Size(135, 13)
        Me.lblCustAddress.TabIndex = 0
        Me.lblCustAddress.Text = "Customer's Mailing Address"
        '
        'lblManagerName
        '
        Me.lblManagerName.AutoSize = True
        Me.lblManagerName.Location = New System.Drawing.Point(12, 179)
        Me.lblManagerName.Name = "lblManagerName"
        Me.lblManagerName.Size = New System.Drawing.Size(87, 13)
        Me.lblManagerName.TabIndex = 0
        Me.lblManagerName.Text = "Manager's Name"
        '
        'lblManagerTitle
        '
        Me.lblManagerTitle.AutoSize = True
        Me.lblManagerTitle.Location = New System.Drawing.Point(12, 205)
        Me.lblManagerTitle.Name = "lblManagerTitle"
        Me.lblManagerTitle.Size = New System.Drawing.Size(79, 13)
        Me.lblManagerTitle.TabIndex = 0
        Me.lblManagerTitle.Text = "Manager's Title"
        '
        'lblDMCACompany
        '
        Me.lblDMCACompany.AutoSize = True
        Me.lblDMCACompany.Location = New System.Drawing.Point(12, 257)
        Me.lblDMCACompany.Name = "lblDMCACompany"
        Me.lblDMCACompany.Size = New System.Drawing.Size(85, 13)
        Me.lblDMCACompany.TabIndex = 0
        Me.lblDMCACompany.Text = "DMCA Company"
        '
        'rtxtCustAddress
        '
        Me.rtxtCustAddress.Location = New System.Drawing.Point(153, 121)
        Me.rtxtCustAddress.Name = "rtxtCustAddress"
        Me.rtxtCustAddress.Size = New System.Drawing.Size(333, 49)
        Me.rtxtCustAddress.TabIndex = 6
        Me.rtxtCustAddress.Text = ""
        '
        'txtDMCACompany
        '
        Me.txtDMCACompany.Location = New System.Drawing.Point(153, 254)
        Me.txtDMCACompany.Name = "txtDMCACompany"
        Me.txtDMCACompany.Size = New System.Drawing.Size(333, 20)
        Me.txtDMCACompany.TabIndex = 10
        Me.txtDMCACompany.Text = "Irdeto"
        '
        'lblCopyrightHolder
        '
        Me.lblCopyrightHolder.AutoSize = True
        Me.lblCopyrightHolder.Location = New System.Drawing.Point(12, 283)
        Me.lblCopyrightHolder.Name = "lblCopyrightHolder"
        Me.lblCopyrightHolder.Size = New System.Drawing.Size(85, 13)
        Me.lblCopyrightHolder.TabIndex = 0
        Me.lblCopyrightHolder.Text = "Copyright Holder"
        '
        'lblDMCAEmail
        '
        Me.lblDMCAEmail.AutoSize = True
        Me.lblDMCAEmail.Location = New System.Drawing.Point(12, 310)
        Me.lblDMCAEmail.Name = "lblDMCAEmail"
        Me.lblDMCAEmail.Size = New System.Drawing.Size(111, 13)
        Me.lblDMCAEmail.TabIndex = 0
        Me.lblDMCAEmail.Text = "DMCA Email Contents"
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Location = New System.Drawing.Point(117, 511)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(142, 23)
        Me.btnSavePrint.TabIndex = 13
        Me.btnSavePrint.Text = "Save and Print"
        Me.btnSavePrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(265, 511)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtCustFirst
        '
        Me.txtCustFirst.Location = New System.Drawing.Point(153, 69)
        Me.txtCustFirst.Name = "txtCustFirst"
        Me.txtCustFirst.Size = New System.Drawing.Size(333, 20)
        Me.txtCustFirst.TabIndex = 4
        '
        'txtInfringmentID
        '
        Me.txtInfringmentID.Location = New System.Drawing.Point(153, 228)
        Me.txtInfringmentID.Name = "txtInfringmentID"
        Me.txtInfringmentID.Size = New System.Drawing.Size(333, 20)
        Me.txtInfringmentID.TabIndex = 9
        '
        'lblCustLast
        '
        Me.lblCustLast.AutoSize = True
        Me.lblCustLast.Location = New System.Drawing.Point(12, 98)
        Me.lblCustLast.Name = "lblCustLast"
        Me.lblCustLast.Size = New System.Drawing.Size(112, 13)
        Me.lblCustLast.TabIndex = 0
        Me.lblCustLast.Text = "Customer's Last Name"
        '
        'lblInfringmentID
        '
        Me.lblInfringmentID.AutoSize = True
        Me.lblInfringmentID.Location = New System.Drawing.Point(12, 231)
        Me.lblInfringmentID.Name = "lblInfringmentID"
        Me.lblInfringmentID.Size = New System.Drawing.Size(73, 13)
        Me.lblInfringmentID.TabIndex = 0
        Me.lblInfringmentID.Text = "Infringment ID"
        '
        'cmbCopyrightHolder
        '
        Me.cmbCopyrightHolder.FormattingEnabled = True
        Me.cmbCopyrightHolder.Items.AddRange(New Object() {"Disney Enterprises", "Twentieth Century Fox"})
        Me.cmbCopyrightHolder.Location = New System.Drawing.Point(153, 281)
        Me.cmbCopyrightHolder.Name = "cmbCopyrightHolder"
        Me.cmbCopyrightHolder.Size = New System.Drawing.Size(333, 21)
        Me.cmbCopyrightHolder.TabIndex = 11
        '
        'DMCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(498, 543)
        Me.Controls.Add(Me.cmbCopyrightHolder)
        Me.Controls.Add(Me.lblInfringmentID)
        Me.Controls.Add(Me.lblCustLast)
        Me.Controls.Add(Me.txtInfringmentID)
        Me.Controls.Add(Me.txtCustFirst)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.lblDMCAEmail)
        Me.Controls.Add(Me.lblCopyrightHolder)
        Me.Controls.Add(Me.txtDMCACompany)
        Me.Controls.Add(Me.rtxtCustAddress)
        Me.Controls.Add(Me.lblDMCACompany)
        Me.Controls.Add(Me.lblManagerTitle)
        Me.Controls.Add(Me.lblManagerName)
        Me.Controls.Add(Me.lblCustAddress)
        Me.Controls.Add(Me.lblCustFirst)
        Me.Controls.Add(Me.rtxtDMCAEmail)
        Me.Controls.Add(Me.txtYourTitle)
        Me.Controls.Add(Me.txtYourName)
        Me.Controls.Add(Me.txtCustLast)
        Me.Controls.Add(Me.lblSelectForm)
        Me.Controls.Add(Me.cmbSelectForm)
        Me.Controls.Add(Me.btnDMCAsFolder)
        Me.Controls.Add(Me.btnDMCADocs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DMCA"
        Me.Text = "DMCA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDMCADocs As Button
    Friend WithEvents btnDMCAsFolder As Button
    Friend WithEvents cmbSelectForm As ComboBox
    Friend WithEvents lblSelectForm As Label
    Friend WithEvents txtCustLast As TextBox
    Friend WithEvents txtYourName As TextBox
    Friend WithEvents txtYourTitle As TextBox
    Friend WithEvents rtxtDMCAEmail As RichTextBox
    Friend WithEvents lblCustFirst As Label
    Friend WithEvents lblCustAddress As Label
    Friend WithEvents lblManagerName As Label
    Friend WithEvents lblManagerTitle As Label
    Friend WithEvents lblDMCACompany As Label
    Friend WithEvents rtxtCustAddress As RichTextBox
    Friend WithEvents txtDMCACompany As TextBox
    Friend WithEvents lblCopyrightHolder As Label
    Friend WithEvents lblDMCAEmail As Label
    Friend WithEvents btnSavePrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtCustFirst As TextBox
    Friend WithEvents txtInfringmentID As TextBox
    Friend WithEvents lblCustLast As Label
    Friend WithEvents lblInfringmentID As Label
    Friend WithEvents cmbCopyrightHolder As ComboBox
End Class
