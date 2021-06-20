<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Pink
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdmin.Location = New System.Drawing.Point(65, 77)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(203, 54)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "Connect As Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnCust
        '
        Me.btnCust.BackColor = System.Drawing.Color.Violet
        Me.btnCust.Location = New System.Drawing.Point(65, 192)
        Me.btnCust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(203, 56)
        Me.btnCust.TabIndex = 1
        Me.btnCust.Text = "Connect As Customer"
        Me.btnCust.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(348, 312)
        Me.Controls.Add(Me.btnCust)
        Me.Controls.Add(Me.btnAdmin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Clothing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnCust As Button
End Class
