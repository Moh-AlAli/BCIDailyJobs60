<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toloc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(toloc))
        Me.Butcan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGtloc = New System.Windows.Forms.DataGridView()
        Me.ButSel = New System.Windows.Forms.Button()
        Me.Txtloc = New System.Windows.Forms.TextBox()
        CType(Me.DGtloc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Butcan
        '
        Me.Butcan.Location = New System.Drawing.Point(296, 304)
        Me.Butcan.Name = "Butcan"
        Me.Butcan.Size = New System.Drawing.Size(75, 23)
        Me.Butcan.TabIndex = 118
        Me.Butcan.Text = "Cancel"
        Me.Butcan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Description"
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(111, 25)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(237, 20)
        Me.Txtname.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Location"
        '
        'DGtloc
        '
        Me.DGtloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtloc.Location = New System.Drawing.Point(0, 50)
        Me.DGtloc.Name = "DGtloc"
        Me.DGtloc.Size = New System.Drawing.Size(388, 244)
        Me.DGtloc.TabIndex = 116
        '
        'ButSel
        '
        Me.ButSel.Location = New System.Drawing.Point(24, 304)
        Me.ButSel.Name = "ButSel"
        Me.ButSel.Size = New System.Drawing.Size(75, 23)
        Me.ButSel.TabIndex = 117
        Me.ButSel.Text = "Select"
        Me.ButSel.UseVisualStyleBackColor = True
        '
        'Txtloc
        '
        Me.Txtloc.Location = New System.Drawing.Point(112, 2)
        Me.Txtloc.Name = "Txtloc"
        Me.Txtloc.Size = New System.Drawing.Size(237, 20)
        Me.Txtloc.TabIndex = 112
        '
        'toloc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 329)
        Me.Controls.Add(Me.Butcan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGtloc)
        Me.Controls.Add(Me.ButSel)
        Me.Controls.Add(Me.Txtloc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "toloc"
        Me.Text = "To Location "
        CType(Me.DGtloc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butcan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGtloc As System.Windows.Forms.DataGridView
    Friend WithEvents ButSel As System.Windows.Forms.Button
    Friend WithEvents Txtloc As System.Windows.Forms.TextBox
End Class
