<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUNDP
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
        Me.lblAve = New System.Windows.Forms.Label()
        Me.txtAve = New System.Windows.Forms.TextBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(337, 267)
        Me.lblAve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(251, 17)
        Me.lblAve.TabIndex = 13
        Me.lblAve.Text = "Average Of Least Unemployed Areas :"
        '
        'txtAve
        '
        Me.txtAve.Location = New System.Drawing.Point(596, 239)
        Me.txtAve.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAve.Multiline = True
        Me.txtAve.Name = "txtAve"
        Me.txtAve.Size = New System.Drawing.Size(338, 103)
        Me.txtAve.TabIndex = 12
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(329, 29)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(891, 202)
        Me.txtDisplay.TabIndex = 11
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(30, 240)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(239, 44)
        Me.btnRead.TabIndex = 10
        Me.btnRead.Text = "Read from File"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(30, 165)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(239, 44)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(30, 97)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(239, 44)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create File"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(30, 29)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(239, 46)
        Me.btnInput.TabIndex = 7
        Me.btnInput.Text = "Input And Display Province Info"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'frmUNDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 347)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.txtAve)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "frmUNDP"
        Me.Text = "United Nations Development Programme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAve As Label
    Friend WithEvents txtAve As TextBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnInput As Button
End Class
