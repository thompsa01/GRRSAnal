<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Graph))
        Me.ComboBoxEditReports = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditNumRows = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControlYWP = New DevExpress.XtraEditors.LabelControl()
        Me.RadioGroupTopBottom = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.ComboBoxEditReports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNumRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.RadioGroupTopBottom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxEditReports
        '
        Me.ComboBoxEditReports.Location = New System.Drawing.Point(77, 16)
        Me.ComboBoxEditReports.Name = "ComboBoxEditReports"
        Me.ComboBoxEditReports.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditReports.Properties.Items.AddRange(New Object() {"Income by Customer Grouping", "Income by Drop Point", "Income by Fleet Type", "Income by Home Depot", "Income by Unit", "Income by Driver", "Income by Zone", "Income by Account", "Income by Vendor Managed Grouping", "Profit by Customer Grouping", "Profit by Customer Grouping", "Profit by Drop Point", "Profit by Fleet Type", "Profit by Home Depot", "Profit Income by Driver", "Profit by Zone", "Profit by Account", "Profit by Vendor Managed Grouping"})
        Me.ComboBoxEditReports.Size = New System.Drawing.Size(145, 20)
        Me.ComboBoxEditReports.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Select Report"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(228, 22)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "number of items"
        '
        'TextEditNumRows
        '
        Me.TextEditNumRows.EditValue = ""
        Me.TextEditNumRows.Location = New System.Drawing.Point(311, 19)
        Me.TextEditNumRows.Name = "TextEditNumRows"
        Me.TextEditNumRows.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TextEditNumRows.Properties.DisplayFormat.FormatString = "###0"
        Me.TextEditNumRows.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditNumRows.Properties.EditFormat.FormatString = "###0"
        Me.TextEditNumRows.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditNumRows.Properties.EditValueChangedDelay = 2
        Me.TextEditNumRows.Properties.Mask.EditMask = "n0"
        Me.TextEditNumRows.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEditNumRows.Properties.MaxLength = 3
        Me.TextEditNumRows.Properties.NullText = "10"
        Me.TextEditNumRows.Properties.NullValuePrompt = "0"
        Me.TextEditNumRows.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEditNumRows.Size = New System.Drawing.Size(44, 20)
        Me.TextEditNumRows.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.RadioGroupTopBottom)
        Me.PanelControl1.Controls.Add(Me.ComboBoxEditReports)
        Me.PanelControl1.Controls.Add(Me.TextEditNumRows)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(106, 32)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(881, 41)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControlYWP
        '
        Me.LabelControlYWP.Location = New System.Drawing.Point(24, 12)
        Me.LabelControlYWP.Name = "LabelControlYWP"
        Me.LabelControlYWP.Size = New System.Drawing.Size(84, 13)
        Me.LabelControlYWP.TabIndex = 5
        Me.LabelControlYWP.Text = "year/week period"
        '
        'RadioGroupTopBottom
        '
        Me.RadioGroupTopBottom.Location = New System.Drawing.Point(387, 5)
        Me.RadioGroupTopBottom.Name = "RadioGroupTopBottom"
        Me.RadioGroupTopBottom.Properties.Columns = 1
        Me.RadioGroupTopBottom.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "from the top"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "from the bottom")})
        Me.RadioGroupTopBottom.Size = New System.Drawing.Size(117, 36)
        Me.RadioGroupTopBottom.TabIndex = 4
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 447)
        Me.Controls.Add(Me.LabelControlYWP)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Graph"
        Me.Text = "Graph"
        CType(Me.ComboBoxEditReports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNumRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.RadioGroupTopBottom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxEditReports As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditNumRows As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControlYWP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroupTopBottom As DevExpress.XtraEditors.RadioGroup
End Class
