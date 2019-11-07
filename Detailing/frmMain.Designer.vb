<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.mskZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDisplayCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCalculate = New System.Windows.Forms.ToolStripButton()
        Me.btnClearAll = New System.Windows.Forms.ToolStripButton()
        Me.btnClearOrder = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.chkFluids = New System.Windows.Forms.CheckBox()
        Me.chkPasteWax = New System.Windows.Forms.CheckBox()
        Me.chkWhiteWalls = New System.Windows.Forms.CheckBox()
        Me.chkTireDressing = New System.Windows.Forms.CheckBox()
        Me.chkUpholstery = New System.Windows.Forms.CheckBox()
        Me.chkCarpets = New System.Windows.Forms.CheckBox()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpSalesTotals = New System.Windows.Forms.GroupBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.picCarWash = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.grpSalesTotals.SuspendLayout()
        CType(Me.picCarWash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 32)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Order Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Name:"
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Location = New System.Drawing.Point(20, 162)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(260, 26)
        Me.txtName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtName, "Enter Alphabetic Characters Only. Space OK between First and Last")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(302, 162)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(260, 26)
        Me.txtAddress.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAddress, "Numeric and Alphabetic characters only")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&City:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(20, 234)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(260, 26)
        Me.txtCity.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtCity, "Alphabetic Characters only")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "&Zip Code:"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "Select State:", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"})
        Me.cboState.Location = New System.Drawing.Point(302, 234)
        Me.cboState.MaxLength = 2
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(130, 28)
        Me.cboState.Sorted = True
        Me.cboState.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cboState, "Choose a State")
        '
        'mskZipCode
        '
        Me.mskZipCode.Location = New System.Drawing.Point(448, 235)
        Me.mskZipCode.Mask = "00000"
        Me.mskZipCode.Name = "mskZipCode"
        Me.mskZipCode.Size = New System.Drawing.Size(115, 26)
        Me.mskZipCode.TabIndex = 9
        Me.mskZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.mskZipCode, "Five Digit Zip Code, Numbers Only")
        Me.mskZipCode.ValidatingType = GetType(Integer)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp, Me.mnuClear, Me.mnuView})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(615, 35)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit, Me.mnuFileSave})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "File"
        Me.mnuFile.ToolTipText = "Exit"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(133, 30)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(133, 30)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(61, 29)
        Me.mnuHelp.Text = "Help"
        Me.mnuHelp.ToolTipText = "About"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(146, 30)
        Me.mnuHelpAbout.Text = "About"
        '
        'mnuClear
        '
        Me.mnuClear.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClearOrder, Me.mnuClearAll})
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(63, 29)
        Me.mnuClear.Text = "Clear"
        '
        'mnuClearOrder
        '
        Me.mnuClearOrder.Name = "mnuClearOrder"
        Me.mnuClearOrder.Size = New System.Drawing.Size(186, 30)
        Me.mnuClearOrder.Text = "Clear Order"
        '
        'mnuClearAll
        '
        Me.mnuClearAll.Name = "mnuClearAll"
        Me.mnuClearAll.Size = New System.Drawing.Size(186, 30)
        Me.mnuClearAll.Text = "Clear All"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewDisplayCustomers})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(61, 29)
        Me.mnuView.Text = "View"
        '
        'mnuViewDisplayCustomers
        '
        Me.mnuViewDisplayCustomers.Name = "mnuViewDisplayCustomers"
        Me.mnuViewDisplayCustomers.Size = New System.Drawing.Size(244, 30)
        Me.mnuViewDisplayCustomers.Text = "Display Customers"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCalculate, Me.btnClearAll, Me.btnClearOrder, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 715)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(615, 30)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCalculate
        '
        Me.btnCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), System.Drawing.Image)
        Me.btnCalculate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 27)
        Me.btnCalculate.Text = "Calculate"
        '
        'btnClearAll
        '
        Me.btnClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClearAll.Image = CType(resources.GetObject("btnClearAll.Image"), System.Drawing.Image)
        Me.btnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(89, 27)
        Me.btnClearAll.Text = "Clear All"
        '
        'btnClearOrder
        '
        Me.btnClearOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClearOrder.Image = CType(resources.GetObject("btnClearOrder.Image"), System.Drawing.Image)
        Me.btnClearOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.Size = New System.Drawing.Size(114, 27)
        Me.btnClearOrder.Text = "Clear Order"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(49, 27)
        Me.btnExit.Text = "Exit"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(298, 323)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDate.MinDate = New Date(2018, 7, 18, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(298, 26)
        Me.dtpDate.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.dtpDate, "Scheduled Completion Date")
        Me.dtpDate.Value = New Date(2018, 7, 18, 0, 0, 0, 0)
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(20, 323)
        Me.mskPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskPhone.Mask = "(000) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(118, 26)
        Me.mskPhone.TabIndex = 11
        Me.mskPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.ToolTip1.SetToolTip(Me.mskPhone, "Enter 10 Digit phone number")
        '
        'chkFluids
        '
        Me.chkFluids.AutoSize = True
        Me.chkFluids.Location = New System.Drawing.Point(21, 639)
        Me.chkFluids.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkFluids.Name = "chkFluids"
        Me.chkFluids.Size = New System.Drawing.Size(77, 24)
        Me.chkFluids.TabIndex = 47
        Me.chkFluids.Text = "Fluids"
        Me.ToolTip1.SetToolTip(Me.chkFluids, "Price: $10.99")
        Me.chkFluids.UseVisualStyleBackColor = True
        '
        'chkPasteWax
        '
        Me.chkPasteWax.AutoSize = True
        Me.chkPasteWax.Location = New System.Drawing.Point(21, 536)
        Me.chkPasteWax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPasteWax.Name = "chkPasteWax"
        Me.chkPasteWax.Size = New System.Drawing.Size(111, 24)
        Me.chkPasteWax.TabIndex = 46
        Me.chkPasteWax.Text = "Paste Wax"
        Me.ToolTip1.SetToolTip(Me.chkPasteWax, "Price: $14.99")
        Me.chkPasteWax.UseVisualStyleBackColor = True
        '
        'chkWhiteWalls
        '
        Me.chkWhiteWalls.AutoSize = True
        Me.chkWhiteWalls.Location = New System.Drawing.Point(21, 602)
        Me.chkWhiteWalls.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkWhiteWalls.Name = "chkWhiteWalls"
        Me.chkWhiteWalls.Size = New System.Drawing.Size(118, 24)
        Me.chkWhiteWalls.TabIndex = 45
        Me.chkWhiteWalls.Text = "White Walls"
        Me.ToolTip1.SetToolTip(Me.chkWhiteWalls, "Price: $8.99")
        Me.chkWhiteWalls.UseVisualStyleBackColor = True
        '
        'chkTireDressing
        '
        Me.chkTireDressing.AutoSize = True
        Me.chkTireDressing.Location = New System.Drawing.Point(21, 499)
        Me.chkTireDressing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkTireDressing.Name = "chkTireDressing"
        Me.chkTireDressing.Size = New System.Drawing.Size(128, 24)
        Me.chkTireDressing.TabIndex = 44
        Me.chkTireDressing.Text = "Tire Dressing"
        Me.ToolTip1.SetToolTip(Me.chkTireDressing, "Price: $7.99")
        Me.chkTireDressing.UseVisualStyleBackColor = True
        '
        'chkUpholstery
        '
        Me.chkUpholstery.AutoSize = True
        Me.chkUpholstery.Location = New System.Drawing.Point(21, 568)
        Me.chkUpholstery.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkUpholstery.Name = "chkUpholstery"
        Me.chkUpholstery.Size = New System.Drawing.Size(111, 24)
        Me.chkUpholstery.TabIndex = 43
        Me.chkUpholstery.Text = "Upholstery"
        Me.ToolTip1.SetToolTip(Me.chkUpholstery, "Price: $24.99")
        Me.chkUpholstery.UseVisualStyleBackColor = True
        '
        'chkCarpets
        '
        Me.chkCarpets.AutoSize = True
        Me.chkCarpets.Location = New System.Drawing.Point(21, 465)
        Me.chkCarpets.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkCarpets.Name = "chkCarpets"
        Me.chkCarpets.Size = New System.Drawing.Size(91, 24)
        Me.chkCarpets.TabIndex = 42
        Me.chkCarpets.Text = "Carpets"
        Me.ToolTip1.SetToolTip(Me.chkCarpets, "Price: $19.99")
        Me.chkCarpets.UseVisualStyleBackColor = True
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Location = New System.Drawing.Point(129, 410)
        Me.radDeluxe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(83, 24)
        Me.radDeluxe.TabIndex = 41
        Me.radDeluxe.Text = "&Deluxe"
        Me.ToolTip1.SetToolTip(Me.radDeluxe, "Price: $129.99 includes ALL options below")
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Location = New System.Drawing.Point(19, 410)
        Me.radBasic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(73, 24)
        Me.radBasic.TabIndex = 40
        Me.radBasic.Text = "&Basic"
        Me.ToolTip1.SetToolTip(Me.radBasic, "Price: $79.99 with Extras below")
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "&Customer Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(288, 25)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sc&heduled Completion Date:"
        '
        'grpSalesTotals
        '
        Me.grpSalesTotals.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpSalesTotals.Controls.Add(Me.lblGrandTotal)
        Me.grpSalesTotals.Controls.Add(Me.lblSalesTax)
        Me.grpSalesTotals.Controls.Add(Me.lblTotalSale)
        Me.grpSalesTotals.Controls.Add(Me.lblTotal)
        Me.grpSalesTotals.Controls.Add(Me.Label9)
        Me.grpSalesTotals.Controls.Add(Me.Label8)
        Me.grpSalesTotals.Location = New System.Drawing.Point(360, 357)
        Me.grpSalesTotals.Name = "grpSalesTotals"
        Me.grpSalesTotals.Size = New System.Drawing.Size(246, 272)
        Me.grpSalesTotals.TabIndex = 32
        Me.grpSalesTotals.TabStop = False
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotal.Location = New System.Drawing.Point(64, 202)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(144, 45)
        Me.lblGrandTotal.TabIndex = 35
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalesTax
        '
        Me.lblSalesTax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesTax.Location = New System.Drawing.Point(64, 125)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(146, 40)
        Me.lblSalesTax.TabIndex = 33
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSale
        '
        Me.lblTotalSale.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSale.Location = New System.Drawing.Point(68, 49)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(144, 40)
        Me.lblTotalSale.TabIndex = 31
        Me.lblTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(63, 175)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 25)
        Me.lblTotal.TabIndex = 34
        Me.lblTotal.Text = "Grand Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Sales Tax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Sale:"
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblServiceType.Location = New System.Drawing.Point(19, 382)
        Me.lblServiceType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(103, 20)
        Me.lblServiceType.TabIndex = 39
        Me.lblServiceType.Text = "Service Type:"
        '
        'picCarWash
        '
        Me.picCarWash.BackgroundImage = CType(resources.GetObject("picCarWash.BackgroundImage"), System.Drawing.Image)
        Me.picCarWash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCarWash.Location = New System.Drawing.Point(156, 455)
        Me.picCarWash.Name = "picCarWash"
        Me.picCarWash.Size = New System.Drawing.Size(209, 199)
        Me.picCarWash.TabIndex = 48
        Me.picCarWash.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(615, 745)
        Me.Controls.Add(Me.picCarWash)
        Me.Controls.Add(Me.lblServiceType)
        Me.Controls.Add(Me.chkFluids)
        Me.Controls.Add(Me.chkPasteWax)
        Me.Controls.Add(Me.chkWhiteWalls)
        Me.Controls.Add(Me.chkTireDressing)
        Me.Controls.Add(Me.chkUpholstery)
        Me.Controls.Add(Me.chkCarpets)
        Me.Controls.Add(Me.radDeluxe)
        Me.Controls.Add(Me.radBasic)
        Me.Controls.Add(Me.grpSalesTotals)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskPhone)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mskZipCode)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dot's Detailing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpSalesTotals.ResumeLayout(False)
        Me.grpSalesTotals.PerformLayout()
        CType(Me.picCarWash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents mskZipCode As MaskedTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnCalculate As ToolStripButton
    Friend WithEvents btnClearAll As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents grpSalesTotals As GroupBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents chkFluids As CheckBox
    Friend WithEvents chkPasteWax As CheckBox
    Friend WithEvents chkWhiteWalls As CheckBox
    Friend WithEvents chkTireDressing As CheckBox
    Friend WithEvents chkUpholstery As CheckBox
    Friend WithEvents chkCarpets As CheckBox
    Friend WithEvents radDeluxe As RadioButton
    Friend WithEvents radBasic As RadioButton
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuClearOrder As ToolStripMenuItem
    Friend WithEvents mnuClearAll As ToolStripMenuItem
    Friend WithEvents btnClearOrder As ToolStripButton
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuViewDisplayCustomers As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents picCarWash As PictureBox
End Class
