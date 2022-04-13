<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.btn_Click = New System.Windows.Forms.Button()
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Click
        '
        Me.btn_Click.Location = New System.Drawing.Point(37, 63)
        Me.btn_Click.Name = "btn_Click"
        Me.btn_Click.Size = New System.Drawing.Size(75, 23)
        Me.btn_Click.TabIndex = 0
        Me.btn_Click.Text = "Click aqui"
        Me.btn_Click.UseVisualStyleBackColor = True
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(14, 18)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(53, 15)
        Me.lbl_Principal.TabIndex = 1
        Me.lbl_Principal.Text = "Principal"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Controls.Add(Me.btn_Click)
        Me.Name = "frm_Principal"
        Me.Text = "frm_Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Click As Button
    Friend WithEvents lbl_Principal As Label
End Class
