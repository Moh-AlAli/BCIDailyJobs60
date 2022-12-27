<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enteredby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enteredby))
        Me.Butcan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGfcus = New System.Windows.Forms.DataGridView()
        Me.ButSel = New System.Windows.Forms.Button()
        Me.Txtenter = New System.Windows.Forms.TextBox()
        CType(Me.DGfcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Butcan
        '
        Me.Butcan.Location = New System.Drawing.Point(296, 322)
        Me.Butcan.Name = "Butcan"
        Me.Butcan.Size = New System.Drawing.Size(75, 23)
        Me.Butcan.TabIndex = 125
        Me.Butcan.Text = "Cancel"
        Me.Butcan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Enter By"
        '
        'DGfcus
        '
        Me.DGfcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGfcus.Location = New System.Drawing.Point(0, 68)
        Me.DGfcus.Name = "DGfcus"
        Me.DGfcus.Size = New System.Drawing.Size(388, 244)
        Me.DGfcus.TabIndex = 123
        '
        'ButSel
        '
        Me.ButSel.Location = New System.Drawing.Point(24, 322)
        Me.ButSel.Name = "ButSel"
        Me.ButSel.Size = New System.Drawing.Size(75, 23)
        Me.ButSel.TabIndex = 124
        Me.ButSel.Text = "Select"
        Me.ButSel.UseVisualStyleBackColor = True
        '
        'Txtenter
        '
        Me.Txtenter.Location = New System.Drawing.Point(112, 23)
        Me.Txtenter.Name = "Txtenter"
        Me.Txtenter.Size = New System.Drawing.Size(237, 20)
        Me.Txtenter.TabIndex = 119
        '
        'Enteredby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 355)
        Me.Controls.Add(Me.Butcan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGfcus)
        Me.Controls.Add(Me.ButSel)
        Me.Controls.Add(Me.Txtenter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Enteredby"
        Me.Text = "Entered by"
        CType(Me.DGfcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butcan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGfcus As System.Windows.Forms.DataGridView
    Friend WithEvents ButSel As System.Windows.Forms.Button
    Friend WithEvents Txtenter As System.Windows.Forms.TextBox
End Class
