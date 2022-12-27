<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyJobs))
        Me.Butexit = New System.Windows.Forms.Button()
        Me.Butprint = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btdloc = New System.Windows.Forms.Button()
        Me.Txttoloc = New System.Windows.Forms.TextBox()
        Me.Bfdloc = New System.Windows.Forms.Button()
        Me.Txtfrmloc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Butentby = New System.Windows.Forms.Button()
        Me.txtenteredby = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Butexit
        '
        Me.Butexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butexit.Location = New System.Drawing.Point(303, 307)
        Me.Butexit.Name = "Butexit"
        Me.Butexit.Size = New System.Drawing.Size(80, 38)
        Me.Butexit.TabIndex = 80
        Me.Butexit.Text = "Exit"
        Me.Butexit.UseVisualStyleBackColor = True
        '
        'Butprint
        '
        Me.Butprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butprint.Location = New System.Drawing.Point(52, 308)
        Me.Butprint.Name = "Butprint"
        Me.Butprint.Size = New System.Drawing.Size(83, 38)
        Me.Butprint.TabIndex = 78
        Me.Butprint.Text = "Print"
        Me.Butprint.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btdloc)
        Me.GroupBox4.Controls.Add(Me.Txttoloc)
        Me.GroupBox4.Controls.Add(Me.Bfdloc)
        Me.GroupBox4.Controls.Add(Me.Txtfrmloc)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(27, 125)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 75)
        Me.GroupBox4.TabIndex = 79
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Location"
        '
        'Btdloc
        '
        Me.Btdloc.BackColor = System.Drawing.SystemColors.Control
        Me.Btdloc.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btdloc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btdloc.Image = CType(resources.GetObject("Btdloc.Image"), System.Drawing.Image)
        Me.Btdloc.Location = New System.Drawing.Point(348, 42)
        Me.Btdloc.Name = "Btdloc"
        Me.Btdloc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btdloc.Size = New System.Drawing.Size(25, 24)
        Me.Btdloc.TabIndex = 31
        Me.Btdloc.TabStop = False
        Me.Btdloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btdloc.UseVisualStyleBackColor = False
        '
        'Txttoloc
        '
        Me.Txttoloc.Location = New System.Drawing.Point(100, 44)
        Me.Txttoloc.Name = "Txttoloc"
        Me.Txttoloc.Size = New System.Drawing.Size(250, 20)
        Me.Txttoloc.TabIndex = 3
        '
        'Bfdloc
        '
        Me.Bfdloc.BackColor = System.Drawing.SystemColors.Control
        Me.Bfdloc.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bfdloc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bfdloc.Image = CType(resources.GetObject("Bfdloc.Image"), System.Drawing.Image)
        Me.Bfdloc.Location = New System.Drawing.Point(348, 17)
        Me.Bfdloc.Name = "Bfdloc"
        Me.Bfdloc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bfdloc.Size = New System.Drawing.Size(24, 22)
        Me.Bfdloc.TabIndex = 30
        Me.Bfdloc.TabStop = False
        Me.Bfdloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bfdloc.UseVisualStyleBackColor = False
        '
        'Txtfrmloc
        '
        Me.Txtfrmloc.Location = New System.Drawing.Point(100, 19)
        Me.Txtfrmloc.Name = "Txtfrmloc"
        Me.Txtfrmloc.Size = New System.Drawing.Size(250, 20)
        Me.Txtfrmloc.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "From "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 83)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(100, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(272, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(5, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Butentby)
        Me.GroupBox2.Controls.Add(Me.txtenteredby)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 58)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter By"
        '
        'Butentby
        '
        Me.Butentby.BackColor = System.Drawing.SystemColors.Control
        Me.Butentby.Cursor = System.Windows.Forms.Cursors.Default
        Me.Butentby.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butentby.Image = CType(resources.GetObject("Butentby.Image"), System.Drawing.Image)
        Me.Butentby.Location = New System.Drawing.Point(348, 17)
        Me.Butentby.Name = "Butentby"
        Me.Butentby.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Butentby.Size = New System.Drawing.Size(24, 22)
        Me.Butentby.TabIndex = 30
        Me.Butentby.TabStop = False
        Me.Butentby.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Butentby.UseVisualStyleBackColor = False
        '
        'txtenteredby
        '
        Me.txtenteredby.Location = New System.Drawing.Point(100, 19)
        Me.txtenteredby.Name = "txtenteredby"
        Me.txtenteredby.Size = New System.Drawing.Size(250, 20)
        Me.txtenteredby.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter By"
        '
        'DailyJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 355)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Butexit)
        Me.Controls.Add(Me.Butprint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DailyJobs"
        Me.Text = "Daily Jobs"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Butexit As System.Windows.Forms.Button
    Friend WithEvents Butprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents Btdloc As System.Windows.Forms.Button
    Friend WithEvents Txttoloc As System.Windows.Forms.TextBox
    Public WithEvents Bfdloc As System.Windows.Forms.Button
    Friend WithEvents Txtfrmloc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents Butentby As System.Windows.Forms.Button
    Friend WithEvents txtenteredby As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
